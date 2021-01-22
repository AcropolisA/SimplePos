using SimplePos.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using SimplePos.View.B_SecondMenu;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SimplePos.ViewModel.B_SecondMenu
{
    public class MenuSettingListViewModel : ViewModelBase
    {
        private MenuList menulist = Singletone<MenuList>.Get();
        public MenuList Menulist { get => menulist; set => menulist = value; }

        public MenuSettingListViewModel()
        {
            MakeExample();
        }

#if DEBUG
        public void MakeExample()
        {
            Task.Run(() =>
            {
            });
        }

        public override string ToString()
        {
            return "MenuSettingListViewModel";
        }
#endif

    }
}
