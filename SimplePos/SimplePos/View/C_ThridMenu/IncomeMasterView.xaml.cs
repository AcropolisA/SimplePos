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
        IncomMasterViewModel vm = new IncomMasterViewModel();

        public IncomeMasterView()
        {
            InitializeComponent();
        }

        private void OnGoMonthlyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeMonthlyView());
        }

        private void OnGoWeeklyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeWeeklyView());
        }

        private void OnGoDailyViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeDailyView());
        }

    }
}