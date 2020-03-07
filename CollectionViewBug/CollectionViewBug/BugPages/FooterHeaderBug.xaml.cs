using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewBug.BugPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IOSFooterHeaderBugPage : ContentPage
    {
        public IOSFooterHeaderBugPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<string> Collect { get; set; } = new List<string>();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SetCollect();
        }

        void SetCollect()
        {          
        Collect = new List<string>()
        {
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe",
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe",
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe",
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe",
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe",
            "sgerthgerg",
            "ewfwerthrtfwef",
            "ewfwerthrthfwefwe"
        };
            OnPropertyChanged(nameof(Collect));
        }

    }
}