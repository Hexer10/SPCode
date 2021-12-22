﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCode.Utils
{
    public class DefaultTranslations
    {
        public static Dictionary<string, string> DefaultLangDict = new()
        {
            { "File", "File" },
            { "Language", "English" },
            { "ServerRunning", "Server running" },
            { "Saving", "Saving" },
            { "SavingUFiles", "Save all unsaved files?" },
            { "CompileAll", "Compile all" },
            { "CompileCurrent", "Compile current" },
            { "Copy", "Copy" },
            { "UploadFTP", "FTP Upload" },
            { "StartServer", "Start server" },
            { "Replace", "Replace" },
            { "ReplaceAll", "Replace all" },
            { "OpenNewFile", "Open new file" },
            { "NoFileOpened", "No files opened" },
            { "NoFileOpenedCap", "None of the selected files could be opened." },
            { "SaveFileAs", "Save file as" },
            { "SaveFollow", "Save following files" },
            { "ChDecomp", "Select plugin to decompile" },
            { "Decompiling", "Decompiling" },
            { "EditConfig", "Edit Configurations" },
            { "FoundInOff", "Found in offset {0} with length {1}" },
            { "FoundNothing", "Found nothing" },
            { "ReplacedOff", "Replaced in offset {0}" },
            { "ReplacedOcc", "Replaced {0} occurrences in {1} documents" },
            { "OccFound", "occurrences found" },
            { "EmptyPatt", "Empty search pattern" },
            { "NoValidRegex", "No valid regex pattern" },
            { "FailedCheck", "Failed to check" },
            { "ErrorUpdate", "Error while checking for updates." },
            { "VersUpToDate", "Version up to date" },
            { "VersionYour", "Your program version {0} is up to date." },
            { "VersionYourBeta", "Your beta program version {0} is up to date." },
            { "Details", "Details" },
            { "Compiling", "Compiling" },
            { "Error", "Error" },
            { "SPCompNotStarted", "The spcomp.exe compiler did not start correctly." },
            { "SPCompNotFound", "The spcomp.exe compiler could not be found." },
            { "Copied", "Copied" },
            { "Deleted", "Deleted" },
            { "FailCopy", "Failed to copy" },
            { "NoFilesCopy", "No files copied" },
            { "Uploaded", "Uploaded" },
            { "ErrorUploadFile", "Error while uploading file: {0} to {1}" },
            { "ErrorUpload", "Error while uploading files" },
            { "Done", "Done" },
            { "FileStr", "File" },
            { "New", "New" },
            { "NewTemplate", "New from Template" },
            { "Open", "Open" },
            { "Save", "Save" },
            { "SaveAll", "Save all" },
            { "SaveAs", "Save as" },
            { "Close", "Close" },
            { "CloseAll", "Close all" },
            { "Build", "Build" },
            { "CopyPlugins", "Copy Plugins" },
            { "SendRCON", "Send RCON Commands" },
            { "Config", "Configuration" },
            { "Edit", "Edit" },
            { "Undo", "Undo" },
            { "Redo", "Redo" },
            { "Cut", "Cut" },
            { "Paste", "Paste" },
            { "Folding", "Foldings" },
            { "FoldingsExpand", "Expand all" },
            { "FoldingsCollapse", "Collapse all" },
            { "CommentLine", "Comment selection" },
            { "UncommentLine", "Uncomment selection" },
            { "SelectAll", "Select all" },
            { "SearchReplace", "Find & Replace" },
            { "Tools", "Tools" },
            { "Options", "Options" },
            { "SearchDefinition", "Parsed from include directory" },
            { "NewAPIWeb", "API Reference" },
            { "BetaAPIWeb", "(BETA) API Reference" },
            { "Reformatter", "Syntax reformatter" },
            { "ReformatCurrent", "Reformat current" },
            { "ReformatAll", "Reformat all" },
            { "Decompile", "Decompile" },
            { "ReportBugGit", "Report bug on GitHub" },
            { "CheckUpdates", "Check for updates" },
            { "About", "About" },
            { "FileName", "File Name" },
            { "Line", "Line" },
            { "TypeStr", "Type" },
            { "NormalSearch", "Normal search" },
            { "MatchWholeWords", "Match whole words" },
            { "AdvancSearch", "Advanced search" },
            { "RegexSearch", "Regex search" },
            { "CurrDoc", "Current document" },
            { "AllDoc", "All open documents" },
            { "Find", "Find" },
            { "Count", "Count" },
            { "CaseSen", "Case sensitive" },
            { "MultilineRegex", "Multiline Regex" },
            { "ErrorFileLoadProc", "Error while loading and processing the file." },
            { "NotDissMethod", "Could not disassemble method {0}: {1}" },
            { "DFileChanged", "{0} has changed." },
            { "FileChanged", "File changed" },
            { "FileTryReload", "Try reloading file?" },
            { "DSaveError", "An error occured while saving." },
            { "SaveError", "Save error" },
            { "SavingFile", "Saving file" },
            { "PtAbb", "pt" },
            { "ColAbb", "Col" },
            { "LnAbb", "Ln" },
            { "LenAbb", "Len" },
            { "SPEditCap", "a lightweight SourcePawn editor" },
            { "WrittenBy", "written by: {0}" },
            { "License", "License" },
            { "PeopleInv", "People involved" },
            { "Preview", "Preview" },
            { "ConfigWrongPars", "The config was not able to parse a sourcepawn definition." },
            { "NoName", "no name" },
            { "PosLen", "(pos: {0} - len: {1})" },
            { "InheritedFrom", "inherited from" },
            { "MethodFrom", "Method from" },
            { "PropertyFrom", "Property from" },
            { "Search", "Search" },
            { "Delete", "Delete" },
            { "Name", "Name" },
            { "ScriptDir", "Scripting directories" },
            { "DelimiedWi", "delimit with" },
            { "CopyDir", "Copy directory" },
            { "ServerExe", "Server executable" },
            { "serverStartArgs", "Server-start arguments" },
            { "PreBuildCom", "Pre-Build commandline" },
            { "PostBuildCom", "Post-Build commandline" },
            { "OptimizeLvl", "Optimization level" },
            { "VerboseLvl", "Verbose level" },
            { "AutoCopy", "Auto copy after compile" },
            { "AutoUpload", "Auto upload .smx after Compile" },
            { "AutoRCON", "Send RCON Commands after Compile" },
            { "DeleteOldSMX", "Delete old .smx after copy" },
            { "FTPHost", "FTP host" },
            { "FTPUser", "FTP user" },
            { "FTPPw", "FTP password" },
            { "FTPDir", "FTP directory" },
            { "ComEditorDir", "Directory of the SPEdit binary" },
            { "ComScriptDir", "Directory of the Compiling script" },
            { "ComCopyDir", "Directory where the smx should be copied" },
            { "ComScriptFile", "Full Directory and Name of the script" },
            { "ComScriptName", "File Name of the script" },
            { "ComPluginFile", "Full Directory and Name of the compiled script" },
            { "ComPluginName", "File Name of the compiled script" },
            { "RConEngine", "RCon server engine" },
            { "RConIP", "RCon server IP" },
            { "RconPort", "RCon server port" },
            { "RconPw", "RCon server password" },
            { "RconCom", "RCon Server commands" },
            { "ComPluginsReload", "Reloads all compiled plugins" },
            { "ComPluginsLoad", "Loads all compiled plugins" },
            { "ComPluginsUnload", "Unloads all compiled plugins" },
            { "NewConfig", "New config" },
            { "CannotDelConf", "Cannot delete config" },
            { "YCannotDelConf", "You cannot delete the default config." },
            { "SelectExe", "Select executable" },
            { "CMDLineCom", "Commandline variables" },
            { "RConCMDLineCom", "Rcon commandline variables" },
            { "ResetOptions", "Reset options" },
            { "ResetOptQues", "Are you sure, you want to reset the options?" },
            { "RestartEditor", "Restart Editor" },
            { "YRestartEditor", "You have to restart the editor for the changes to have effect." },
            { "RestartEdiFullEff", "Restart editor to take full effect..." },
            { "RestartEdiEff", "Restart editor to take effect..." },
            { "Program", "Program" },
            { "HardwareAcc", "Use hardware acceleration (if available)" },
            { "UIAnim", "UI animations" },
            { "OpenInc", "Auto open includes" },
            { "OpenIncRec", "Open Includes Recursively" },
            { "AutoUpdate", "Search automatically for updates" },
            { "ShowToolbar", "Show toolbar" },
            { "DynamicISAC", "Dynamic Autocomplete/Intellisense" },
            { "DarkTheme", "Dark theme" },
            { "ThemeColor", "Theme Color" },
            { "LanguageStr", "Language" },
            { "Editor", "Editor" },
            { "FontSize", "Font size" },
            { "ScrollSpeed", "Scroll speed" },
            { "WordWrap", "Word wrap" },
            { "AggIndentation", "Aggressive Indentation" },
            { "ReformatAfterSem", "Reformatting line after semicolon" },
            { "TabsToSpace", "Replace tabs with spaces" },
            { "AutoCloseBrack", "Auto close brackets" },
            { "AutoCloseStrChr", "Auto close Strings, Chars" },
            { "ShowSpaces", "Show spaces" },
            { "ShowTabs", "Show tabs" },
            { "IndentationSize", "Indentation size" },
            { "FontFamily", "Font" },
            { "SyntaxHigh", "Syntax Highlighting" },
            { "HighDeprecat", "Highlight deprecated (<1.7) syntax - NOT SUPPORTED" },
            { "Compile", "Compile" },
            { "AutoSaveMin", "Auto save (min)" },
            { "OBTextFile", "File Directory" },
            { "OBTextConfig", "Config Directory" },
            { "CopyingFiles", "Copying files" },
            { "FTPUploading", "Uploading files" },
            { "RCONCommand", "Sending RCON Commands" },
            { "JavaInstallCheck", "Checking for Java installation" },
            { "JavaNotFoundTitle", "Java was not found" },
            {
                "JavaNotFoundMessage",
                "SPCode needs Java to decompile plugins, but it couldn't get it to work properly - " +
                "perhaps due to an absent or incorrect Java installation. " +
                "Do you wish to download and install it now?"
            },
            { "JavaOutdatedTitle", "Java version found is outdated" },
            {
                "JavaOutdatedMessage",
                "SPCode requires Java 11 SDK or later to decompile plugins. " +
                "We found an outdated version in your system. " +
                "Do you wish to download and upgrade it now?"
            },
            { "FailedToDecompile", "failed to decompile" },
            { "DownloadingJava", "Downloading Java" },
            { "FetchingJava", "Fetching installation file from https://adoptopenjdk.net..." },
            { "AmountCompleted", "completed" },
            { "AmountDownloaded", "downloaded" },
            { "JavaOpened", "Java installation file opened" },
            { "JavaSuggestRestart", "After installing Java, it is highly recommended to restart SPCode." },
            { "JavaDownErrorTitle", "Java download error" },
            { "JavaDownErrorMessage", "SPCode could not download Java by itself. Would you like to download it manually?" },
            { "JavaOpenedBrowser", "Java download link opened in browser" },
            { "ErrorSavingConfigs", "Could not save the current configs state" },
            { "DuplicateConfigNames", "You cannot have 2 configs or more with the same name." },
            { "EmptyConfigNames", "You cannot have configs with an empty name." },
            { "DefaultValues", "Default values" },
            { "WantToUpdate", "Do you want to update?" },
            { "VersionAvailable", "Version {0} is available for download!" },
            { "Yes", "Yes" },
            { "No", "No" },
            { "ViewGithub", "View on GitHub" },
            { "UpdatingTo", "Updating to {0}" },
            { "DownloadingUpdater", "Downloading updater..." },
            { "StartingUpdater", "Starting updater..." },
            { "Add", "Add" },
            { "Remove", "Remove" },
            { "HardwareEncryption", "Hardware encryption" },
            { "CheckingUpdates", "Checking for updates" },
            { "GoToLine", "Go to line" },
            { "GoToOffset", "Go to offset" },
            { "Go", "Go" },
            { "Hotkey", "Hotkey" },
            { "Command", "Command" },
            { "DeleteLine", "Delete line" },
            { "MoveLineDown", "Move line down" },
            { "MoveLineUp", "Move line up" },
            { "DupeLineDown", "Duplicate line down" },
            { "DupeLineUp", "Duplicate line up" },
            { "InUse", "In use!" },
            { "Reserved", "Reserved!" },
            { "TransformUppercase", "Transform to uppercase" },
            { "TransformLowercase", "Transform to lowercase" },
            { "OpenFileLocation", "Open file location" },
            { "OpenDirLocation", "Open directory location" },
            { "Rename", "Rename" },
            { "Accept", "Accept" },
            { "Cancel", "Cancel" },
            { "EmptyName", "Empty name!" },
            { "NameAlreadyExists", "File name taken!" },
            { "Empty", "Empty" },
            { "SearchFiles", "Search files" },
            { "SearchResults", "Search results" },
            { "NoResultsThisDir", "No results on this directory!" },
            { "FileNotSupported", "File not supported!" },
            { "FileWillBeExcluded", "The file will be excluded from the file browser once renamed." },
            { "ExpandAllDirs", "Expand all directories" },
            { "CollapseAllDirs", "Collapse all directories" },
            { "RefreshOB", "Reload current directory" },
            { "EnableRPC", "Enable Discord Rich Presence" },
            { "EnableRPCTime", "Show elapsed time" },
            { "EnableRPCFile", "Show current file" },
            { "TemplateExists", "Template name already exists" },
            { "IllegalCharacters", "Illegal characters" },
            { "ReopenLastClosedTab", "Reopen the last closed tab" },
            { "DefaultTaken", "Default taken!" },
        };
    }
}