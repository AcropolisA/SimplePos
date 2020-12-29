using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FMOrderList : ContentPage
    {
        public FMOrderList()
        {
            InitializeComponent();
        }
        async void OnResultPay(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("결제 방식을 선택해주세요", "취소", null, "카드", "현금");
            Debug.WriteLine("Action: " + action);
            await Navigation.PopAsync();
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            int tapCount = 0;

            tapCount++;

            if(tapCount == 1)
            {
                Navigation.PushAsync(new FMMenuList());
            }
            else
            {
            }
        }
    }
}