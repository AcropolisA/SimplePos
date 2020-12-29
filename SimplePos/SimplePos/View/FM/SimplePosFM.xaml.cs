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
    public partial class SimplePosFM : ContentPage
    {
        public SimplePosFM()
        {
            InitializeComponent();

            var boxTapHandler = new TapGestureRecognizer();
            boxTapHandler.Tapped += ChangeColor;
            myBox.GestureRecognizers.Add(boxTapHandler);

        }
        public void ChangeColor(object sender, EventArgs args)
        {
            myBox.Color = Color.Blue;
            //아래에 화면 리스트화면으로 이동하게 만들기
            Navigation.PushAsync(new FMOrderList());
        }
        async void OnOrderList(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FMOrderList());
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