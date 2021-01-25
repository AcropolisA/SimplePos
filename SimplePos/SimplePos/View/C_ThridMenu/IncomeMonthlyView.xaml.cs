using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SimplePos.Model;

namespace SimplePos.View.C_ThridMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncomeMonthlyView : ContentPage
    {
        public IncomeMonthlyView()
        {
            InitializeComponent();
        }
        private void OnGoWeeklyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeWeeklyView());
        }
    }
}