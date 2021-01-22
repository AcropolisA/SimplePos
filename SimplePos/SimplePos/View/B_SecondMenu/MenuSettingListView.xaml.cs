using SimplePos.Model;
using SimplePos.ViewModel.B_SecondMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View.B_SecondMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuSettingListView : ContentPage
    {
        // viewmodel
        MenuSettingListViewModel vm = new MenuSettingListViewModel();

        object orderList = new object();

        // Add View
        MenuSettingAddView addView = new MenuSettingAddView();

        public MenuSettingListView()
        {
            InitializeComponent();
            BindingContext = vm;
            Console.WriteLine(BindingContext.ToString());
        }
        
        async void LoadAddView(object sender, EventArgs args)
        {
            await Navigation.PushAsync(addView);
        }

        async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Model.Menu) 
            {
                // Throught instance.
                addView.ItemSelected((Model.Menu)e.SelectedItem);

                // Add View load
                await Navigation.PushAsync(addView);
            }
        }
    }
}