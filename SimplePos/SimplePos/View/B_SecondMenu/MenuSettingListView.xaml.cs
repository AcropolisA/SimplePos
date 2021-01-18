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

        // view
        MenuSettingAddView addView = new MenuSettingAddView();

        public MenuSettingListView()
        {
            InitializeComponent();
            this.BindingContext = vm;
            Console.WriteLine(BindingContext.ToString());
        }
        
        async void LoadAddView(object sender, EventArgs args)
        {
            await Navigation.PushAsync(addView);
        }

        async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Model.Menu) {
                addView.ItemSelected((Model.Menu)e.SelectedItem);
                await Navigation.PushAsync(addView);
            }
        }
    }
}