using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View.B_SecondMenu
{
    public partial class MenuListCell : ViewCell
    {
        public static readonly BindableProperty ImgProperty = BindableProperty.Create("IMGSource", typeof(string), typeof(MenuListCell), default(string));
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(MenuListCell), default(string));
        public static readonly BindableProperty PriceProperty = BindableProperty.Create("Price", typeof(string), typeof(MenuListCell), default(string));

        public MenuListCell()
        {
            InitializeComponent();
        }

        public string IMGSource
        {
            set { SetValue(ImgProperty, value); }
            get { return (string)GetValue(ImgProperty); }
        }

        public string Name
        {
            set { SetValue(NameProperty, value); }
            get { return (string)GetValue(NameProperty); }
        }

        public string Price
        {
            set { SetValue(PriceProperty, value); }
            get { return (string)GetValue(PriceProperty); }
        }
    }
}