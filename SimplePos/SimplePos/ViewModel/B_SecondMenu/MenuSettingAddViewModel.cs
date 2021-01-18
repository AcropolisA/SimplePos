using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimplePos.ViewModel.B_SecondMenu
{
    public class MenuSettingAddViewModel : ViewModelBase
    {
        Uri imageSource = new Uri("Resource/ImageChange.png");
        string menuName;
        string menuPrice;
        string menuAllPrice;

        public MenuSettingAddViewModel()
        {
            AddCommand = new Command(
                execute: () =>
                {
                    // TODO
                });
            ImageChange = new Command(
                execute: () =>
                {
                    // TODO
                },
                canExecute: () =>
                {
                    return true;
                });
        }

        #region Command
        public ICommand AddCommand { private set; get; }
        public ICommand ImageChange { private get; set; }
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

        public Uri ImageSource
        {
            get { return imageSource; }
            set { SetProperty<Uri>(ref imageSource, value); }
        }
        #endregion
    }
}
