using Foundation;
using System;
using UIKit;

namespace PipelineIOS
{
	public partial class SettingViewController : UIViewController
	{
		public SettingViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc thaten't in use.

		}
	}
}