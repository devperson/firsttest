using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace first.ViewModels
{
    public class FindCafeViewModel : BaseViewModel
    {
        public ObservableCollection<Cafe> CafeList
        {
            get
            {
                return new ObservableCollection<Cafe>()
                {
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                    new Cafe()
                    {
                       Description ="323 West 23rd Street New York NY",
                       Details = "Open Today: 8:00am - 5:30 pm",
                       ImageSrc = ImageSource.FromFile(Device.OnPlatform("placeholder.png","placeholder.png","Images/placeholder.png")),
                       MilesTo = "0.2 mi",
                       Name = "Joe Coffee"
                    },
                };
            }
        }
    }

    public class Cafe : BaseViewModel
    {
        public ImageSource ImageSrc { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string MilesTo { get; set; }
    }
}
