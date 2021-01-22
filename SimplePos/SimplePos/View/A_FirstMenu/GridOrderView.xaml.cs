using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimplePos.View.A_FirstMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridOrderView : ContentPage
    {
        public GridOrderView()
        {
            InitializeComponent();
        }
        async void GoOrderListView(object sender, EventArgs args)
        {
            BoxView boxview = (BoxView)sender;
            int tapCount = 0;

            tapCount++;
            // watch the monkey go from color to black&white!
            if (tapCount == 1)
            {
                boxview.Color = Color.Blue;
                await Navigation.PushAsync(new OrderListView());
            }
            else if (boxview.Color == Color.Blue && tapCount == 1)
            {
                boxview.Color = Color.White;
            }
        }
    }
}