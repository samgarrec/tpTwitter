using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using twitter.Services;
namespace twitter
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

       

        private void Disconnection_Clicked(Object sender, EventArgs a)
        {
            var id = this.id.Text;
            var pwd = this.pwd.Text;
            var estswitch = this.monSwitch.IsToggled;


            this.deconnexion.IsVisible = false;
            this.connect.IsVisible = true;

            this.tweet.IsVisible = false;

            this.formulaire.IsVisible = true;

        }


        private void Connection_Clicked(Object sender, EventArgs a)
        {
            var id = this.id.Text;
            var pwd = this.pwd.Text;
            var estswitch = this.monSwitch.IsToggled;
            var validPwd = true;
            var validId = true;



            if (this.id.Text == null || this.id.Text.Length < 3)
            {

                this.id.Placeholder = "Veuillez saisir un id valide";
                this.id.Text = "";
                this.id.PlaceholderColor = Color.Red;
                Console.WriteLine("test");
                validId = false;



            }
            if (this.pwd.Text == null || this.pwd.Text.Length < 6)
            {

                this.pwd.Placeholder = "Veuillez saisir un password valide (au moins 6 caracteres)";
                this.pwd.Text = "";
                this.pwd.PlaceholderColor = Color.Red;
                validPwd = false;
                Console.WriteLine("test");



            }
            if (validPwd && validId)
            {
                TwitterService ts = new TwitterService();
                Boolean resultat = ts.Authentificate(this.id.Text, this.pwd.Text);
                if (resultat)
                {
                    DisplayAlert("get", "Vos informations seront mémorisées pour la prochaine fois !", "ok");

                    if (estswitch)
                    {
                        DisplayAlert("information", "Vos informations seront mémorisées pour la prochaine fois !", "ok");



                    }
                    this.tweet.IsVisible = true;

                    this.formulaire.IsVisible = false;

                    this.deconnexion.IsVisible = true;
                    this.connect.IsVisible = false;

                }
            }



        }


    }
}
