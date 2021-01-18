using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SimplePos.ViewModel.A_FirstMenu
{
    class MenuListViewModel : ViewModelBase
    {
        string Menuname;
        string _MenuPrice;
        string MenuAllPrice;
        string MenuPrice
        {
            get { return _MenuPrice; }
            set
            {
                _MenuPrice = value;
                OnPropertyChanged();
            }
        }

        public Command MenuAllPrices
        {
            get
            {
                return new Command(() => { MenuAllPrice += MenuPrice; });
            }
        }
    }
}
