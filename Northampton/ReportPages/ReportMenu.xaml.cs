﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Northampton
{
    public partial class ReportMenu : ContentPage
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        async void AtThisLocationButtonClicked(object sender, EventArgs args)
        {
            Application.Current.Properties["WebServiceHandlerPageTitle"] = "Report a problem";
            Application.Current.Properties["WebServiceHandlerPageDescription"] = "Please wait whilst we find nearby streets...";
            await Application.Current.SavePropertiesAsync();
            await Navigation.PushAsync(new WebServiceHandlerPage("ReportMenuByLocation"));
        }

        async void ByStreetNameButtonClicked(object sender, EventArgs args)
        {
            Application.Current.Properties["WebServiceHandlerPageTitle"] = "Report a problem";
            Application.Current.Properties["WebServiceHandlerPageDescription"] = "Please wait whilst we find that street...";
            await Application.Current.SavePropertiesAsync();
            await Navigation.PushAsync(new ReportStreetNamePage());
        }

    }
}