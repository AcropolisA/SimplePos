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
                Menulist.Add(new Model.Menu()
                {
                    MenuName="국밥",
                    MenuPrice="7000"
                });

                Menulist.Add(new Model.Menu()
                {
                    MenuName = "김밥",
                    MenuPrice = "3000"
                });
                Menulist.Add(new Model.Menu()
                {
                    MenuName = "라면",
                    MenuPrice = "2000"
                });
                Menulist.Add(new Model.Menu()
                {
                    MenuName = "돈까스",
                    MenuPrice = "6500"
                });

                foreach(Model.Menu item in Menulist)
                {
                    Console.WriteLine(item);
                }
            });
        }

        public override string ToString()
        {
            return "MenuSettingListViewModel";
        }
#endif

    }
}
