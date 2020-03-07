using CollectionViewBug.BugPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void IosButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IosBugPage());
        }

        private void DroidButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AndroidBugPage());
        }

        private void HeaderButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IOSFooterHeaderBugPage());
        }
    }
}
