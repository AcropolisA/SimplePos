using SimplePos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimplePos
{
    public partial class SimplePos : ContentPage
    {
        public SimplePos()
        {
            InitializeComponent();
        }
        async void OnGoFirstMenuButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SimplePosFM());
        }
        async void OnGoSecondMenuButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SimplePosSM());
        }
        async void OnGoThirdMenuButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SimplePosTM());
        }
        async void OnGoSetMenuButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SimplePosSet());
        }
    }
}