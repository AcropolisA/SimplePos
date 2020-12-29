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
    public partial class TMBill : ContentPage
    {
        public TMBill()
        {
            InitializeComponent();
        }

        public class App : Application
        {
        }
    }
}