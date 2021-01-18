using SimplePos.View.A_FirstMenu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


/*
 * FreeOrderView, GridOrderView, ListOrderView를 통합해서 사용합니다.
 */
namespace SimplePos.ViewModel.A_FirstMenu
{
    class OrderViewModel : INotifyPropertyChanged
    {
        int taps = 0;
        ICommand tapCommand;
        public OrderViewModel()
        {
            // configure the TapCommand with a method
            tapCommand = new Command(OnTapped);
        }
        public ICommand TapCommand
        {
            get { return tapCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnTapped(object s)
        {
            taps++;
            Debug.WriteLine("parameter: " + s);
        }
    }
}