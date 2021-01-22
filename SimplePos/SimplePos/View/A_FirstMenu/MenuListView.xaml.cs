using SimplePos.ViewModel.A_FirstMenu;
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
        //ViewModel Access
        MenuListViewModel vm = new MenuListViewModel();

        //OrderListView Access
        OrderListView olview = new OrderListView();

        public MenuListView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        async void OnGoOrderListViewClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}