﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PSPM_MathQuiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ScoresPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
