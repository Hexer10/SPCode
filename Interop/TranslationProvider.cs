﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows;
using System.Xml;
using Octokit;
using SPCode.Utils;

namespace SPCode.Interop
{
    public class TranslationProvider
    {
        public List<string> AvailableLanguageIDs = new();
        public List<string> AvailableLanguages = new();
        private readonly string _tempDir = Paths.GetTempDirectory();
        private readonly string _translationsDir = Paths.GetTranslationsDirectory();

        public bool IsDefault = true;

        private static readonly Dictionary<string, string> LangDict = new(StringComparer.OrdinalIgnoreCase);

        public TranslationProvider()
        {
            // Make sure translations dir exists
            if (!Directory.Exists(_translationsDir))
            {
                Directory.CreateDirectory(_translationsDir);
            }

            if (IsUpdateAvailable(out var latestVersion))
            {
                UpdateTranslations(latestVersion);
            }

            ParseTranslationFiles();
        }

        /// <summary>
        /// Gets the translation of the specified phrase.
        /// </summary>
        /// <param name="phrase">The phrase to return translated</param>
        /// <returns></returns>
        public static string Translate(string phrase)
        {
            return LangDict.ContainsKey(phrase) ? LangDict[phrase] : "<empty>";
        }

        /// <summary>
        /// Loads the specified language.
        /// </summary>
        /// <param name="lang">The language to load</param>
        /// <param name="initial"></param>
        public void LoadLanguage(string lang, bool initial = false)
        {
            // This is probably the first boot ever
            if (lang == string.Empty)
            {
                lang = Constants.DefaultLanguageID;
                Program.OptionsObject.Language = lang;
            }
            lang = lang.Trim().ToLowerInvariant();
            IsDefault = (string.IsNullOrEmpty(lang) || lang.ToLowerInvariant() == Constants.DefaultLanguageID) && initial;
            var doc = new XmlDocument();

            try
            {
                // Fill with defaults first
                if (initial)
                {
                    doc.Load(Path.Combine(_translationsDir, Constants.DefaultTranslationsFile));
                    foreach (XmlNode node in doc.ChildNodes[0].ChildNodes)
                    {
                        LangDict.Add(node.Name, node.InnerText);
                    }

                    // Return if the attempted language to load is the default one
                    if (lang == Constants.DefaultLanguageID)
                    {
                        return;
                    }
                }

                var file = Path.Combine(_translationsDir, $"{lang}.xml");
                doc.Load(file);

                // Replace existing keys with the ones available in this file
                foreach (XmlNode node in doc.ChildNodes[0].ChildNodes)
                {
                    LangDict[node.Name] = node.InnerText;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ParseTranslationFiles()
        {
            try
            {
                var filesDir = Directory.GetFiles(_translationsDir).Where(x => x.EndsWith(".xml"));
                foreach (var file in filesDir)
                {
                    // Create wrapper
                    var fInfo = new FileInfo(file);

                    // Parse content in an XML object
                    var doc = new XmlDocument();
                    doc.LoadXml(File.ReadAllText(fInfo.FullName));

                    // Get language name and ID
                    var langName = doc.ChildNodes[0].ChildNodes
                        .Cast<XmlNode>()
                        .Single(x => x.Name == "language")
                        .InnerText;
                    var langID = fInfo.Name.Substring(0, fInfo.Name.IndexOf('.'));

                    // Add file to the available languages lists
                    AvailableLanguages.Add(langName);
                    AvailableLanguageIDs.Add(langID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem while updating the translations file.\n" +
                    $"Details: {ex.Message}");
            }
        }

        public void UpdateTranslations(Release latestVersion)
        {
            // Clear temp folder before beggining
            DirUtils.ClearTempFolder();

            // Download latest release zip file
            var wc = new WebClient();
            var downloadedFile = Path.Combine(_tempDir, "langs.zip");
            wc.Headers.Add(HttpRequestHeader.UserAgent, Constants.ProductHeaderValueName);
            wc.DownloadFile(latestVersion.ZipballUrl, downloadedFile);

            // Decompress and replace all of its files
            ZipFile.ExtractToDirectory(downloadedFile, _tempDir);
            var filesDir = Directory.GetFiles(Directory.GetDirectories(_tempDir)[0]).Where(x => x.EndsWith(".xml"));
            foreach (var file in filesDir)
            {
                // Create wrapper
                var fInfo = new FileInfo(file);

                // Replace current file with this one
                var destination = Path.Combine(_translationsDir, fInfo.Name);
                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }
                File.Move(fInfo.FullName, destination);
            }

            // Delete all temp folder contents
            DirUtils.ClearTempFolder();

            // Update version to options object
            Program.OptionsObject.TranslationsVersion = int.Parse(latestVersion.Name);
        }

        public bool IsUpdateAvailable(out Release latestVersion)
        {
            var client = new GitHubClient(new ProductHeaderValue(Constants.ProductHeaderValueName));

            // Check if translations need update by comparing stored version with latest release name from repository
            var versionStored = Program.OptionsObject.TranslationsVersion;

            latestVersion = client.Repository.Release.GetAll(Constants.OrgName,
                Constants.TranslationsRepoName).Result[0];

            return versionStored < int.Parse(latestVersion.Name);
        }
    }
}