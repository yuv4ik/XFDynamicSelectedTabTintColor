using Xamarin.Forms;

namespace XFDynamicSelectedTabTintColor.Effects
{
    public class TabbedPageSelectedTabItemDynamicTintColorEffect : RoutingEffect
    {
        public TabbedPageSelectedTabItemDynamicTintColorEffect() : base($"XFDynamicSelectedTabTintColor.Effects.{nameof(TabbedPageSelectedTabItemDynamicTintColorEffect)}") { }
    }

    public static class SelectedTabItemDynamicTintColorEffect
    {
        public static readonly BindableProperty SelectedTabTintColorProperty =
            BindableProperty.CreateAttached("SelectedTabTintColor", typeof(Color), typeof(SelectedTabItemDynamicTintColorEffect), Color.Default);

        public static Color GetSelectedTabTintColor(BindableObject view) => (Color)view.GetValue(SelectedTabTintColorProperty);
        public static void SetSelectedTabTintColor(BindableObject view, Color value) => view.SetValue(SelectedTabTintColorProperty, value);
    }
}
