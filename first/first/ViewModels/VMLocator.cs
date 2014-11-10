using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.ViewModels
{
    public class VMLocator
    {
        private static FindCafeViewModel _findCafe;
        public static FindCafeViewModel FindCafeVM
        {
            get
            {
                if (_findCafe == null)
                    _findCafe = new FindCafeViewModel();
                return _findCafe;
            }
        }
    }
}
