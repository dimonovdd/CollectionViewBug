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
    public partial class AndroidBugPage : ContentPage
    {
        public AndroidBugPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public ObservableCollection<string> Collect { get; set; } = new ObservableCollection<string>();
        public bool CanDelete { get; set; }


        int clickCount = 0;

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void SetCanDelete()
        {
            CanDelete = clickCount > 3;
            OnPropertyChanged(nameof(CanDelete));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Collect.Add($"click: {++clickCount}");
            SetCanDelete();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (Collect?.Count > 3)
                Collect.Remove(Collect[0]);

            SetCanDelete();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Collect?.Clear();
        }
    }
}
