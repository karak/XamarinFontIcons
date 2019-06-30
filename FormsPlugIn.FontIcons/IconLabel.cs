using Xamarin.Forms;

namespace FormsPlugin.FontIcons
{
    public class IconLabel : Label
    {
        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(
                "Icon",
                typeof(string),
                typeof(IconLabel),
                propertyChanged: IconPropertyChanged
            );

        private static void IconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var (fontFamily, code) = FontIconRepository.Find((string)newValue);
            bindable.SetValue(FontFamilyProperty, fontFamily);
            bindable.SetValue(TextProperty, code);
        }
        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }
}