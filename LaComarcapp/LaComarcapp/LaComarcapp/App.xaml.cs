﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LaComarcapp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LaComarcapp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
