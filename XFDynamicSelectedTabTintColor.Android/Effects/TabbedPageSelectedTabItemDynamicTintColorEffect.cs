using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFDynamicSelectedTabTintColor.Effects;

[assembly: ResolutionGroupName("XFDynamicSelectedTabTintColor.Effects")]
[assembly: ExportEffect(typeof(XFDynamicSelectedTabTintColor.Droid.Effects.TabbedPageSelectedTabItemDynamicTintColorEffect), nameof(TabbedPageSelectedTabItemDynamicTintColorEffect))]
namespace XFDynamicSelectedTabTintColor.Droid.Effects
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

        void SetTintColor() =>
            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetBarSelectedItemColor(Element, SelectedTabItemDynamicTintColorEffect.GetSelectedTabTintColor(Element));
    }
}
