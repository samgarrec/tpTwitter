using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using twitter.Services;

namespace twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTweet : ContentPage
    {
        public ListeTweet()
        {

            var ts = new TwitterService();
            InitializeComponent();
            this.maListe.ItemsSource = ts.GetTweet();

        }
    }
}
