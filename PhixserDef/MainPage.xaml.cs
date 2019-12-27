using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms.OpenWhatsApp;
using System.Text;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhixserDef
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()

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
