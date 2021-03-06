﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhixserDef
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chat : ContentPage
    {
        public chat()
        {
            InitializeComponent();
        }
        public void MapClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            MainPage myHomePage = new MainPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        public void FormClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            Form myHomePage = new Form();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        public void ReviewClicked(object sender, EventArgs e)
        {
            //var videos = repo.getVideos();

            Page1 myHomePage = new Page1();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);



        }
        private void OpenWhatsApp(object sender, EventArgs e)
        {
            chat myHomePage = new chat();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);
        }
        private void PhixserNumber(object sender, EventArgs e)
        {
            long number = +17862669306;
            PhoneDialer.Open(number.ToString());
        }
    }
}