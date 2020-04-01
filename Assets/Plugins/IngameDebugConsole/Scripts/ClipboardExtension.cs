using UnityEngine;

namespace IngameDebugConsole
{
	public static class ClipboardExtension
	{
		/// <summary>
		/// Puts the string into the Clipboard.
		/// </summary>
		/// <param name="str"></param>
		public static void CopyToClipboard( this string str )
		{
			var textEditor = new TextEditor();
			textEditor.text = str;
			textEditor.SelectAll();
			textEditor.Copy();
		}
	}
}