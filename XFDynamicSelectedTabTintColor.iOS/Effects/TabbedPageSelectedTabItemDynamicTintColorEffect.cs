using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFDynamicSelectedTabTintColor.Effects;
using System.Linq;

[assembly: ResolutionGroupName("XFDynamicSelectedTabTintColor.Effects")]
[assembly: ExportEffect(typeof(XFDynamicSelectedTabTintColor.iOS.Effects.TabbedPageSelectedTabItemDynamicTintColorEffect), nameof(TabbedPageSelectedTabItemDynamicTintColorEffect))]
namespace XFDynamicSelectedTabTintColor.iOS.Effects
{
    public class TabbedPageSelectedTabItemDynamicTintColorEffect : PlatformEffect
    {
        protected override void OnAttached() { }
        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == SelectedTabItemDynamicTintColorEffect.SelectedTabTintColorProperty.PropertyName)
                SetTintColor();
        }

        void SetTintColor()
        {
            var tabBar = Container.Subviews.First(v => v is UIKit.UITabBar);
            tabBar.TintColor = SelectedTabItemDynamicTintColorEffect.GetSelectedTabTintColor(Element).ToUIColor();
        }
    }
}
