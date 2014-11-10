using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using first;
using first.Droid.Renderers;
using Android.Graphics.Drawables;
using Xamarin.Forms.Labs.Droid.Controls.ImageButton;

[assembly: ExportRenderer(typeof(SearchTextBox), typeof(SearchTextBoxRenderer))]
[assembly: ExportRenderer(typeof(LocationButton), typeof(LocationButtonRenderer))]
[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
[assembly: ExportRenderer(typeof(FindCafeCell), typeof(CustomViewCellRenderer))]

namespace first.Droid.Renderers
{
    public class SearchTextBoxRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            var editText = Control as EditText;
            editText.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.roundedCorners));
            editText.SetPadding(10, 5, 10, 5);
        }
    }

    public class LocationButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.smallRoundedCorners));
        }
    }

    public class CustomImageRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            var img = Control as ImageView;
            img.SetScaleType(Android.Widget.ImageView.ScaleType.Center);
        }
    }

    public class CustomViewCellRenderer : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            //Get Android's ListView 
            var thisCellsListView = (Android.Widget.ListView)parent;

            //This CustomListView is a Xamarin.Forms.ListView that has a Custom ListView Renderer in my IOS version
            var tableParent = (CafeListView)base.ParentView;

            thisCellsListView.Divider = new ColorDrawable(Xamarin.Forms.Color.FromHex("C8C7CC").ToAndroid());
            thisCellsListView.DividerHeight = 1;

            var cell = base.GetCellCore(item, convertView, parent, context);
            return cell;
        }
    }

}