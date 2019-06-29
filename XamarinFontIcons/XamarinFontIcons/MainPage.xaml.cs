using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListViewSelectionMode = Xamarin.Forms.PlatformConfiguration.WindowsSpecific.ListViewSelectionMode;

namespace XamarinFontIcons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainPageViewModel();

            InitializeComponent();
        }

    }
}