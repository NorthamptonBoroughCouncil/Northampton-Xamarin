﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Northampton
{
    public partial class ReportMenu : ContentPage
    {
        Label monkeyNameLabel= new Label();
        public ReportMenu()
        {
            InitializeComponent();

        }

        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new UpcomingAppointmentsPage());
        }

    }
}