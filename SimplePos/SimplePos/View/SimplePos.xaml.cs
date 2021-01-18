#define BINSMODE

using SimplePos.View.B_SecondMenu;
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
#if BINSMODE
            listviewLoad.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new MenuSettingListView(), true);
            };

            addviewLoad.Clicked += async (sender, args) =>
           {
               await Navigation.PushModalAsync(new MenuSettingAddView(), true);
           };
#endif
        }
    }
}
