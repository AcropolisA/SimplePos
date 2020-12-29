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
    public partial class TMMonthIncome : ContentPage
    {
        public TMMonthIncome()
        {
            InitializeComponent();
        }
        void OnTapGestureGoWeekTapped(object sender, EventArgs args)
        {
            int tapCounts = 0;

            tapCounts++;

            if (tapCounts >= 1)
            {
                Navigation.PushAsync(new TMWeekIncome());
            }
            else { }
        }
    }
}