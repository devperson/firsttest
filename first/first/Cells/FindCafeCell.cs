using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Controls;

namespace first
{
    public class FindCafeCell : ViewCell
    {
        public FindCafeCell() : base()
        {
            var mainStackLayout = new StackLayout() { Orientation = StackOrientation.Horizontal, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.White };
            var stackLayout1 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(8, 8, 5, 8)
            };

            var imgCafe = new Image() { VerticalOptions = LayoutOptions.Start, HeightRequest = 43, WidthRequest = 43};
            imgCafe.SetBinding(Image.SourceProperty, new Binding("ImageSrc"));

            var lblTitle = new Label() { TextColor = Color.Black, HorizontalOptions = LayoutOptions.FillAndExpand, Font = Font.SystemFontOfSize(13) };
            lblTitle.SetBinding(Label.TextProperty, new Binding("Name"));

            var lblMile = new Label() { YAlign = TextAlignment.Center, Font = Font.SystemFontOfSize(9), TextColor = Color.FromHex("bbbbbb") };
            lblMile.SetBinding(Label.TextProperty, new Binding("MilesTo"));

            var imgArrow = new CustomImage() { Source = ImageSource.FromFile(Device.OnPlatform("arrow_gray.png","arrow_gray.png","Images/arrow_gray.png")) };

            var stackLayout3 = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(0, 0, 0, 0),
                Spacing = 2,
                Children = { lblTitle, lblMile, imgArrow }
            };


            
            var lblAddres = new Label() 
            {   
                YAlign = TextAlignment.Start,
                VerticalOptions = LayoutOptions.StartAndExpand, 
                HorizontalOptions = LayoutOptions.Fill,
                TextColor = Color.FromHex("787878"),
                Font = Font.SystemFontOfSize(9)
            };
            lblAddres.SetBinding(Label.TextProperty, new Binding("Description"));
            
            

            var lblStatus = new Label()
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End,
                TextColor = Color.FromHex("787878"),
                Font = Font.SystemFontOfSize(9)
            };
            lblStatus.SetBinding(Label.TextProperty, new Binding("Details"));

            var stackLayout2 = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Spacing = 0,
                Children = { stackLayout3, lblAddres, lblStatus }
            };

            stackLayout1.Children.Add(imgCafe);
            stackLayout1.Children.Add(stackLayout2);

            mainStackLayout.Children.Add(stackLayout1);

            View = mainStackLayout;
        }
    }
}
