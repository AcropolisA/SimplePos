using SimplePos.Model;
using SimplePos.View.B_SecondMenu;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SimplePos.ViewModel.B_SecondMenu
{
    public class MenuSettingAddViewModel : ViewModelBase
    {
        string imageSource = "Resource.ImageChange.png";
        string menuName;
        string menuPrice;
        string menuAllPrice;

        private MenuList menulist = Singletone<MenuList>.Get();
        private Model.Menu menu;


        public MenuSettingAddViewModel()
        {
            CommandSet();
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

            ImageChangeCommand = new Command(
                execute: () =>
                {
                    // TODO
                },
                canExecute: () =>
                {
                    return true;
                }
                );
        }

        #region Command
        public ICommand CompleteCommand { private set; get; }
        public ICommand ImageChangeCommand { private set; get; }
        #endregion


        #region BindableProperty
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

        public string ImageSource
        {
            get { return imageSource; }
            set { SetProperty<string>(ref imageSource, value); }
        }

        public Model.Menu Menu { get => menu; set => menu = value; }
        #endregion
    }
}
