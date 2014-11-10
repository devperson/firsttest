using first.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace first
{
    public class FindCafesPage :ContentPage
    {
        private CafeListView cafeListView;
        StackLayout mainLayout;
        public FindCafesPage()
        {
            InitDesign();
        }

        private void InitDesign()
        {
            this.BindingContext = VMLocator.FindCafeVM;

            mainLayout = new StackLayout() { Spacing = 0, Orientation= StackOrientation.Vertical, BackgroundColor = Color.FromHex("F0EFF8"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand};
            //header
            var header = new StackLayout() { BackgroundColor = Color.FromHex("F7F7F7"), Padding = new Thickness(30, 5, 30, 5), HorizontalOptions = LayoutOptions.FillAndExpand};
            var stacklayout = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };
            //entry find cafe
            SearchTextBox entry = new SearchTextBox() { Placeholder = "Find a cafe", HorizontalOptions = LayoutOptions.FillAndExpand };
            //img location
            LocationButton btnLocation = null;

            btnLocation = new LocationButton() 
            { 
                WidthRequest = 30, HeightRequest = 30, 
                Source = ImageSource.FromFile(Device.OnPlatform("location_arrow.png", "location_arrow.png", "Images/location_arrow.png")), 
                Orientation = Xamarin.Forms.Labs.Enums.ImageOrientation.ImageToLeft, 
                ImageHeightRequest = 15, 
                ImageWidthRequest = 15 
            };
            btnLocation.Clicked += btnLocation_Clicked;
            //separator
            var separator = new StackLayout() { BackgroundColor = Color.FromHex("A7A7A9"), HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 1 };

            stacklayout.Children.Add(entry);
            stacklayout.Children.Add(btnLocation);
            header.Children.Add(stacklayout);

            cafeListView = new CafeListView() { VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, RowHeight = 75, ItemTemplate = new DataTemplate(typeof(FindCafeCell)) };
            cafeListView.ItemSelected += cafeListView_ItemSelected;
            cafeListView.SetBinding(ListView.ItemsSourceProperty, new Binding("CafeList"));
            
            

            mainLayout.Children.Add(header);
            mainLayout.Children.Add(separator);
            mainLayout.Children.Add(cafeListView);

            var stackBackground = new StackLayout() { BackgroundColor = Color.Black, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            var absoluteLayout = new AbsoluteLayout() { VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            absoluteLayout.Children.Add(stackBackground, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(mainLayout, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            this.Content = absoluteLayout;
        }

        async void btnLocation_Clicked(object sender, EventArgs e)
        {
            if (mainLayout.TranslationX == -100)
            {
                Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
                {

                    if (mainLayout.TranslationX == 0)
                        return false;
                    else
                    {
                        mainLayout.TranslationX += 10;
                        return true;
                    }
                });
            }
            else
            {
                Device.StartTimer(TimeSpan.FromMilliseconds(10), () =>
                {

                    if (mainLayout.TranslationX == -100)
                        return false;
                    else
                    {
                        mainLayout.TranslationX -= 10;
                        return true;
                    }
                });
            }
            
            //mainLayout.TranslationX = -100;
        }

        void cafeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

        private void GenerateData()
        {

        }
    }

    public class SearchTextBox : Entry { }
    public class CustomImage : Image { }
    public class LocationButton : Xamarin.Forms.Labs.Controls.ImageButton { }
    public class CafeListView : ListView { }

}
