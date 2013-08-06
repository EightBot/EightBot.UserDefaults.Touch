using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EightBot.UserDefaults.Touch
{
	public partial class EightBot_UserDefaults_TouchViewController : UIViewController
	{

		private const String TEST_STRING = "TEST_STRING";


		public EightBot_UserDefaults_TouchViewController () : base ("EightBot_UserDefaults_TouchViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			btnLoadDefaults.TouchUpInside += (sender, e) => {
				var settingsDictionary = new NSDictionary(NSBundle.MainBundle.PathForResource("Settings.bundle/Root.plist", null));
				var preferenceItemArray = settingsDictionary[(NSString)"PreferenceSpecifiers"] as NSArray;

				foreach (var preferenceItem in NSArray.FromArray<NSDictionary>(preferenceItemArray)) {
					var currentKey = preferenceItem[(NSString)"Key"] as NSString;
					var currentDefaultValue = preferenceItem[(NSString)"DefaultValue"] as NSString;

					if(currentKey == null)
						continue;

					if(currentKey.ToString().Equals(TEST_STRING, StringComparison.OrdinalIgnoreCase))
						lblValueLoaded.Text = currentDefaultValue.ToString();
				}
			};

			btnLoad.TouchUpInside += (sender, e) => {
				var testString = NSUserDefaults.StandardUserDefaults.StringForKey (TEST_STRING);
				lblValueLoaded.Text = testString;

				if(String.IsNullOrEmpty(txtValueToSave.Text))
					txtValueToSave.Text = testString;
			};

			btnSave.TouchUpInside += (sender, e) => {
				NSUserDefaults.StandardUserDefaults.SetValueForKey(new NSString(txtValueToSave.Text), new NSString(TEST_STRING));

				this.View.EndEditing(true);
			};


		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

