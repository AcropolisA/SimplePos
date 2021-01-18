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
    public partial class MenuSettingAddView : ContentPage
    {
        MenuSettingAddViewModel vm = new MenuSettingAddViewModel();

        public MenuSettingAddView()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public void ItemSelected(Model.Menu menu)
        {
            vm.MenuSet(menu);
        }

        async void OnComplete(object sender, EventArgs args)
        {
            // Pop View
            await Navigation.PopAsync();
            vm.CompleteCommand.Execute(this);
        }
    }
}