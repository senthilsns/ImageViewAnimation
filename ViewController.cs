using Foundation;
using System;
using UIKit;

namespace Loader
{
    public partial class ViewController : UIViewController
    {

        UIImageView ProgressImageView;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            CircularAnimatingImages(true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }



        #region Progressbar animation

        private void CircularAnimatingImages(bool status)
        {

            if (status == true)
            {

                // Progress ImageView
                ProgressImageView = new UIImageView();
                ProgressImageView.Frame = new CoreGraphics.CGRect(this.View.Frame.Width / 2 - 40, 200, 40, 30);

              //  this.View.Add(ProgressImageView);

                var barButtonItem = new UIBarButtonItem(ProgressImageView);
                NavigationItem.RightBarButtonItem = barButtonItem;

                ProgressImageView.AnimationImages = new UIImage[] {
                UIImage.FromBundle ("11"),
                UIImage.FromBundle ("22"),
                UIImage.FromBundle ("33"),
                UIImage.FromBundle ("44"),
                UIImage.FromBundle ("55"),
                UIImage.FromBundle ("66"),
                UIImage.FromBundle ("77"),
                UIImage.FromBundle ("88"),
                UIImage.FromBundle ("99"),
            };

                ProgressImageView.AnimationRepeatCount = 0;
                ProgressImageView.AnimationDuration = .7;
                ProgressImageView.StartAnimating();
            }
            else
            {
                if (ProgressImageView != null)
                    ProgressImageView.RemoveFromSuperview();

            }


        }
        #endregion

    }
}