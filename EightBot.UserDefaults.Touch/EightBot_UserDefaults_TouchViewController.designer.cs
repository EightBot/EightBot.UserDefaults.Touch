// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace EightBot.UserDefaults.Touch
{
	[Register ("EightBot_UserDefaults_TouchViewController")]
	partial class EightBot_UserDefaults_TouchViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnLoad { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnLoadDefaults { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblValueLoaded { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtValueToSave { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}

			if (btnLoad != null) {
				btnLoad.Dispose ();
				btnLoad = null;
			}

			if (btnLoadDefaults != null) {
				btnLoadDefaults.Dispose ();
				btnLoadDefaults = null;
			}

			if (txtValueToSave != null) {
				txtValueToSave.Dispose ();
				txtValueToSave = null;
			}

			if (lblValueLoaded != null) {
				lblValueLoaded.Dispose ();
				lblValueLoaded = null;
			}
		}
	}
}
