﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_autolote.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VWCliente : ContentPage
    {
        public VWCliente()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            InitializeComponent();
        }
    }
}