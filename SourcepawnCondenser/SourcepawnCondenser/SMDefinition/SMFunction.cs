﻿using System.Collections.Generic;

namespace SourcepawnCondenser.SourcemodDefinition
{
	public class SMFunction
	{
		public int Index = -1;
		public int Length = 0;
		public int EndPos = -1;
		public string File = string.Empty;

		public string Name = string.Empty;
		public string FullName = string.Empty;
		public string ReturnType = string.Empty;
		public string CommentString = string.Empty;
		public string[] Parameters = new string[0];
		public SMFunctionKind FunctionKind = SMFunctionKind.Unknown;
		public List<SMVariable> FuncVariables = new List<SMVariable>();
	}

	public enum SMFunctionKind
	{
		Stock,
		StockStatic,
		Native,
		Forward,
		Public,
		PublicNative,
		Static,
		Normal,
		Unknown
	}
}
