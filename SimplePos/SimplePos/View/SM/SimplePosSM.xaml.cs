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
    public partial class SimplePosSM : ContentPage
    {
        public SimplePosSM()
        {
            InitializeComponent();
        }
        async void OnAddMenuButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SMAddMenu());
        }
    }
}