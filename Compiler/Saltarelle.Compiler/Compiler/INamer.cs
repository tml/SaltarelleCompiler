﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.NRefactory.TypeSystem;

namespace Saltarelle.Compiler.Compiler
{
	public interface INamer {
		string GetTypeParameterName(ITypeParameter typeParameter);
		string GetVariableName(string desiredName, ISet<string> usedNames);
		string GetStateMachineLoopLabel(ISet<string> usedNames);
		string ThisAlias { get; }
		string FinallyHandlerDesiredName { get; }
		string StateVariableDesiredName { get; }
		string YieldResultVariableDesiredName { get; }
	}
}
