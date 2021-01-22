using SimplePos.View.A_FirstMenu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderListView : ContentPage
    {
        public OrderListView()
        {
            InitializeComponent();
            tm.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }
        async void OnTwoSelectClicked(object sender, EventArgs e)
        {
            var choice = await DisplayActionSheet("결제 방식을 선택해 주세요.", "취소", null, "카드", "현금");
            Debug.WriteLine("Action: " + choice);
            switch(choice)
            {
                case "카드":
                    await Navigation.PopAsync();
                    break;

                case "현금":
                    await Navigation.PopAsync();
                    break;
            }
        }
        void OnGoMenuListTapped(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MenuListView());
        }
    }
}