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
        private MenuList menulist = Singletone<MenuList>.Get();
        public MenuList Menulist { get => menulist; set => menulist = value; }
        public Command CompleteCommand { get; private set; }
        string menuName;
        string menuPrice;
        private Model.Menu menu;

        public MenuListViewModel()
        {
            CommandSet();
            MakeExample();
        }
        public void MakeExample()
        {
            Task.Run(() =>
            {
                Menulist.Add(new Model.Menu()
                {
                    MenuName = "국밥",
                    MenuPrice = "7000"
                });
                Menulist.Add(new Model.Menu()
                {
                    MenuName = "라면",
                    MenuPrice = "5000"
                });
                Menulist.Add(new Model.Menu()
                {
                    MenuName = "돈가스덮밥",
                    MenuPrice = "8500"
                });
            });
        }
        public void MenuSet(Model.Menu menu)
        {
            Menu = menu;

            MenuPrice = menu.MenuPrice;
            MenuName = menu.MenuName;
        }
        public void CommandSet()
        {
            CompleteCommand = new Command(
                    execute: () =>
                    {
                        if (menu == null)
                        {
                            var _menu = new Model.Menu()
                            {
                                MenuName = MenuName,
                                MenuPrice = MenuPrice
                            };
                            menulist.Add(_menu);
                        }
                        else
                        {
                            menu.MenuName = MenuName;
                            menu.MenuPrice = MenuPrice;
                            this.Menu = null;
                        };
                    });
        }
        public string MenuName
        {
            get { return menuName; }
            set { SetProperty<string>(ref menuName, value); }
        }

        public string MenuPrice
        {
            get { return menuPrice; }
            set { SetProperty<string>(ref menuPrice, value); }
        }


        public Model.Menu Menu { get => menu; set => menu = value; }
    }
}