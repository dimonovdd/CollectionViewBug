﻿using System;
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
            BindingContext = this;
        }


        public List<string> Collect { get; set; } = new List<string>();

        bool boolVal;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (boolVal)
                Collect = new List<string>()
                {
                    "wefwrtrthhrtefwef"
                };
            else
                Collect = new List<string>()
                {
                    "sgerthgerg",
                    "ewfwerthrtfwef",
                    "ewfwerthrthfwefwe"
                };
            OnPropertyChanged(nameof(Collect));
            boolVal = !boolVal;
        }
    }
}