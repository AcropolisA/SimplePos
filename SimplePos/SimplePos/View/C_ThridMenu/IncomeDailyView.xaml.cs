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
    public partial class IncomeDailyView : ContentPage
    {
        public IncomeDailyView()
        {
            InitializeComponent();
        }

        private void OnGoOrderListViewTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomeOrderListView());
        }
    }
}