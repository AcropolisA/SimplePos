using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View.A_FirstMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuListView : ContentPage
    {
        public MenuListView()
        {
            InitializeComponent();
        }
        async void OnGoOrderListViewClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}