﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void SignUp_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}
