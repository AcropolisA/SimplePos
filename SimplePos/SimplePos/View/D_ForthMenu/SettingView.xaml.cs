using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SimplePos.View;

namespace SimplePos.View.D_ForthMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingView : ContentPage
    {
        public SettingView()
        {
            InitializeComponent();
        }
        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {            
        }
    }
}