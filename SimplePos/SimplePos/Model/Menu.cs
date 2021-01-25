using SimplePos.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimplePos.Model
{
    public class Menu : ViewModelBase
    {
        string imageSource;
        string menuName;
        string menuPrice;
        ulong menuPriceInt = 0;
        uint menuCount = 0;

        public string ImageSource { set { SetProperty<string>(ref imageSource, value); } get => imageSource; }
        public string MenuName { set { SetProperty<string>(ref menuName, value); } get => menuName; }
        public ulong MenuPriceInt { get => menuPriceInt; }
        public string MenuPrice { set { SetProperty<string>(ref menuPrice, value); menuPriceInt=ulong.Parse(value); } get => menuPrice; }
        public uint MenuCount { set { SetProperty<uint>(ref menuCount, value); } get => menuCount; }

        public override string ToString() => String.Format("Menu : {0}, Price : {1}", MenuName, MenuPrice);
        
    }

    public class MenuList : ObservableCollection<Menu>
    {
#if DEBUG
        public new void Add(Menu t)
        {
            this.Add(t);
            Console.WriteLine("Menu 등록됨 : {0}, {1}, {2}", t.ImageSource ,t.MenuName, t.MenuPrice);
        }
#endif
    }
}
