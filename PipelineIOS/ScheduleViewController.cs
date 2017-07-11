using Foundation;
using System;
using UIKit;

namespace PipelineIOS
{
    public partial class ScheduleViewController : UIViewController
    {
        public ScheduleViewController (IntPtr handle) : base (handle)
        {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that n't in use.
		}
    }
}