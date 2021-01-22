using SimplePos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public class Menu : ViewModelBase
    {
        string imageSource;
        string menuName;
        string menuPrice;
        uint menuCount = 0;

        public string ImageSource 
        { 
            get { return imageSource; } 
            set { SetProperty<string>(ref imageSource, value); } 
        }
        public string MenuName 
        {
            set { SetProperty<string>(ref menuName, value); }
            get { return menuName; } 
        }
        public string MenuPrice 
        { 
            set { SetProperty<string>(ref menuPrice, value); }
            get { return menuPrice; }  
        }

        public uint MenuCount
        {
            set { SetProperty<uint>(ref menuCount, value); }
            get { return menuCount; }
        }

        public override string ToString()
        {
            return String.Format("Menu : {0}, Price : {1}", MenuName, MenuPrice);
        }
    }
}
