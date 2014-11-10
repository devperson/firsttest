using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using first;
using Xamarin.Forms;
using first.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;



[assembly: ExportRenderer(typeof(LocationButton), typeof(LocationImageRenderer))]
namespace first.iOS.Renderers
{
   
    public class LocationImageRenderer : Xamarin.Forms.Labs.iOS.Controls.ImageButton.ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            var buttonLocation = Control;
            
            buttonLocation.Layer.BorderColor = UIColor.FromRGB(194, 194, 194).CGColor;
            buttonLocation.Layer.BorderWidth = 1;
            buttonLocation.Layer.CornerRadius = 5;
            buttonLocation.Layer.MasksToBounds = true;     
        }
    }

}