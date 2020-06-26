using System;
using System.Collections.Generic;
using twitter.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace twitter
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked(Object sender, EventArgs a)
        {


            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {

                var ts = new TwitterService();
                var id = this.id.Text.ToString();

                // Connection to internet is available

                var pwd = this.pwd.Text.ToString();
                var estswitch = this.monSwitch.IsToggled;
               



                if (this.id.Text == null || this.id.Text.Length < 3)
                {

                    this.id.Placeholder = "Veuillez saisir un id valide";
                    this.id.PlaceholderColor = Color.Red;



                }
                if (this.pwd.Text == null || this.pwd.Text.Length < 6)
                {

                    this.pwd.Placeholder = "Veuillez saisir un password valide (au moins 6 caracteres)";
                    this.pwd.PlaceholderColor = Color.Red;
                    Console.WriteLine("test");



                }

                User user = new User();
                user.identifiant = id;

                user.pwd = pwd;
                var result = ts.Authentificate(user);

                if (result)
                {
                    this.redirige();


                    if (result)
                    {


                        if (estswitch)
                        {
                            DisplayAlert("information", "Vos informations seront mémorisées pour la prochaine fois !", "ok");



                        }

                     

                    }
                }



            }
            else
            {
                this.id.Text = "Aucune connection";

            }


        }

        public async void   redirige( )
        {



            await Navigation.PushAsync(new ListeTweet());
        }
    }




}

