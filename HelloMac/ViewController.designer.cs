// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HelloMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField inputText { get; set; }

		[Outlet]
		AppKit.NSTextField labelInfo { get; set; }

		[Outlet]
		AppKit.NSTextField outputText { get; set; }

		[Action ("Build:")]
		partial void Build (Foundation.NSObject sender);

		[Action ("Higher:")]
		partial void Higher (Foundation.NSObject sender);

		[Action ("Lower:")]
		partial void Lower (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (labelInfo != null) {
				labelInfo.Dispose ();
				labelInfo = null;
			}

			if (inputText != null) {
				inputText.Dispose ();
				inputText = null;
			}

			if (outputText != null) {
				outputText.Dispose ();
				outputText = null;
			}
		}
	}
}
