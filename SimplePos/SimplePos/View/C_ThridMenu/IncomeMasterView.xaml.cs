using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View.C_ThridMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncomeMasterView : ContentPage
    {
        public IncomeMasterView()
        {
            InitializeComponent();
        }

        private void OnGoMonthlyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeMonthlyView());
        }

        private void OnGoDailyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeDailyView());
        }

        private void OnGoWeeklyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeWeeklyView());
        }
    }
}