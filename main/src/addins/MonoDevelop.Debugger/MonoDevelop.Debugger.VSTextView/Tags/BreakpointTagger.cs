﻿using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;

namespace MonoDevelop.Debugger
{
	internal class BreakpointTagger : AbstractBreakpointTagger<TextMarkerTag>
	{
		public BreakpointTagger (ITextView textView)
			: base (BreakpointTag.Instance, BreakpointDisabledTag.Instance, BreakpointInvalidTag.Instance, textView)
		{
		}
	}
}
