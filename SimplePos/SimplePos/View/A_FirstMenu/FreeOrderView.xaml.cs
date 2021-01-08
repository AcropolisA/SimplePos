using SimplePos.Model;
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
    public partial class FreeOrderView : ContentPage
    {
        public FreeOrderView()
        {
            InitializeComponent();
        }
        
        public void OnCreateBox(object sender, EventArgs e)
        {
            BoxView boxview2 = new BoxView
            {
                Color = Color.Black,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            this.Padding = new Thickness(10, 0, 10, 5);
            this.Content = new StackLayout
            {
                Children =
                {
                    boxview2
                }
            };
        }
    }
    public class DraggableBoxView : BoxView
    {
        bool isBeingDragged;
        long touchId;
        Point pressPoint;

        public DraggableBoxView()
        {
            TouchEffect touchEffect = new TouchEffect
            {
                Capture = true
            };
            touchEffect.TouchAction += TouchEffect_TouchAction;
            Effects.Add(touchEffect);
        }

        void TouchEffect_TouchAction(object sender, EventArgs args)
        {
            var TouchArgs = (TouchActionEventArgs)args;
            switch (TouchArgs.Type)
            {
                case TouchActionType.Pressed:
                    if (!isBeingDragged)
                    {
                        isBeingDragged = true;
                        touchId = TouchArgs.Id;
                        pressPoint = TouchArgs.Location;
                    }
                    break;

                case TouchActionType.Moved:
                    if (isBeingDragged && touchId == TouchArgs.Id)
                    {
                        TranslationX += TouchArgs.Location.X - pressPoint.X;
                        TranslationY += TouchArgs.Location.Y - pressPoint.Y;
                    }
                    break;

                case TouchActionType.Released:
                    if (isBeingDragged && touchId == TouchArgs.Id)
                    {
                        isBeingDragged = false;
                    }
                    break;
            }
        }
    }
}