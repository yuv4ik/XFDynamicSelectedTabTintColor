using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFDynamicSelectedTabTintColor.Effects;

namespace XFDynamicSelectedTabTintColor.Views
{
    public partial class MainPage : TabbedPage
    {
        static IDictionary<Type, Color> colorMap = new Dictionary<Type, Color>
        {
            { typeof(RedTabView), Color.Red },
            { typeof(GreenTabView), Color.Green },
            { typeof(PurpleTabView), Color.Purple }
        };

        public Color SelectedTabTintColor
        {
            get { return (Color)GetValue(SelectedTabTintColorProperty); }
            set { SetValue(SelectedTabTintColorProperty, value); }
        }

        public static readonly BindableProperty SelectedTabTintColorProperty =
          BindableProperty.Create(nameof(SelectedTabTintColor), typeof(Color), typeof(MainPage));

        public MainPage()
        {
            BindingContext = this;
            Effects.Add(new TabbedPageSelectedTabItemDynamicTintColorEffect());
            SetBinding(SelectedTabItemDynamicTintColorEffect.SelectedTabTintColorProperty, new Binding { Source = this, Path = SelectedTabTintColorProperty.PropertyName });
            // Adding the first child will trigger `OnCurrentPageChanged` immediately, therefore we should take care of bindings beforehand
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            SelectedTabTintColor = colorMap[CurrentPage.GetType()];
        }
    }
}
