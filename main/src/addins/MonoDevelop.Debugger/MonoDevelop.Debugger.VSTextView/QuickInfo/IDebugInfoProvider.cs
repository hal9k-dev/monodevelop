using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text;

namespace MonoDevelop.Debugger.VSTextView.QuickInfo
{
	public interface IDebugInfoProvider
	{
		Task<DataTipInfo> GetDebugInfoAsync (SnapshotPoint snapshotPoint);
	}

	public class DataTipInfo
	{
		public readonly ITrackingSpan Span;
		public readonly string Text;

		public DataTipInfo (ITrackingSpan span, string text)
		{
			this.Span = span;
			this.Text = text;
		}

		public bool IsDefault {
			get { return Span == null && Text == null; }
		}

		public override string ToString () => $"{Span} {Text}";
	}
}
