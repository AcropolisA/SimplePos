using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TMTodayIncome : ContentPage
    {
        public TMTodayIncome()
        {
            InitializeComponent();
        }
        void OnTapGestureBillTapped(object sender, EventArgs args)
        {
            int tapCounts = 0;

            tapCounts++;

            if (tapCounts >= 1)
            {
                Navigation.PushAsync(new TMBill());
            }
            else {}
        }
    }
}