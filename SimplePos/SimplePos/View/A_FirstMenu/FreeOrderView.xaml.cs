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
        class DragInfo
        {
            public DragInfo(long id, Point pressPoint)
            {
                Id = id;
                PressPoint = pressPoint;
            }

            public long Id { private set; get; }

            public Point PressPoint { private set; get; }
        }

        Dictionary<BoxView, DragInfo> dragDictionary = new Dictionary<BoxView, DragInfo>();

        public FreeOrderView()
        {
            InitializeComponent();
            AddBoxViewToLayout();
        }
        void OnNewBoxViewClicked(object sender, EventArgs args)
        {
            AddBoxViewToLayout();
        }

        void OnClearClicked(object sender, EventArgs args)
        {
            absoluteLayout.Children.Clear();
            dragDictionary.Clear();
        }

        void AddBoxViewToLayout()
        {
            BoxView boxView = new BoxView
            {
                WidthRequest = 100,
                HeightRequest = 100,
                Color = Color.Black
            };

            TouchEffect touchEffect = new TouchEffect();
            touchEffect.TouchAction += OnTouchEffectAction;
            boxView.Effects.Add(touchEffect);
            absoluteLayout.Children.Add(boxView);

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Navigation.PushAsync(new OrderListView());
            };
            boxView.GestureRecognizers.Add(tapGestureRecognizer);
        }

        void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            BoxView boxView = sender as BoxView;

            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    // Don't allow a second touch on an already touched BoxView
                    if (!dragDictionary.ContainsKey(boxView))
                    {
                        dragDictionary.Add(boxView, new DragInfo(args.Id, args.Location));

                        // Set Capture property to true
                        TouchEffect touchEffect = (TouchEffect)boxView.Effects.FirstOrDefault(e => e is TouchEffect);
                        touchEffect.Capture = true;
                    }
                    break;

                case TouchActionType.Moved:
                    if (dragDictionary.ContainsKey(boxView) && dragDictionary[boxView].Id == args.Id)
                    {
                        Rectangle rect = AbsoluteLayout.GetLayoutBounds(boxView);
                        Point initialLocation = dragDictionary[boxView].PressPoint;
                        rect.X += args.Location.X - initialLocation.X;
                        rect.Y += args.Location.Y - initialLocation.Y;
                        AbsoluteLayout.SetLayoutBounds(boxView, rect);
                    }
                    break;

                case TouchActionType.Released:
                    if (dragDictionary.ContainsKey(boxView) && dragDictionary[boxView].Id == args.Id)
                    {
                        dragDictionary.Remove(boxView);
                    }
                    break;
            }
        }
    }
}

/*public void OnCreateBox(object sender, EventArgs e)
        {
            BoxView boxView = new BoxView
            {
                WidthRequest = 100,
                HeightRequest = 100,
                Color = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            this.Content = new StackLayout
            {
                Children =
                {
                    boxView
                }
            };
        }*/