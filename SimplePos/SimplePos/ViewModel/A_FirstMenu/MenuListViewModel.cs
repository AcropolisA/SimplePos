using SimplePos.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimplePos.ViewModel.A_FirstMenu
{
    class MenuListViewModel : ViewModelBase
    {
        MenuList menulist = Singletone<OrderDataManager>.Get().Menulist;

        public MenuList Menulist { get => menulist; set => menulist = value; }


        public MenuListViewModel()
        {

        }

        
    }
}