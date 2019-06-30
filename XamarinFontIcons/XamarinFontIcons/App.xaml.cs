using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamarinFontIcons
{
    public partial class App : Application
    {
        public App()
        {
            FormsPlugin.FontIcons.FontAwesome.Init();

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}