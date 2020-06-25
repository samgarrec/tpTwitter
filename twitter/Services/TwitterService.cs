using System;
using System.Collections.Generic;
using System.Linq;
using twitter.Models;

namespace twitter.Services
{
    public class TwitterService : ITwitterService

    {
        public TwitterService()
        {
        }

      

        public bool Authentificate(string user, string pwd)
        {

            Boolean resultat;
            List<Tweet> laListe = GetTweet();

            Boolean resultatRequete = laListe.Any(p => p.identifiant.Equals(user));


            Console.WriteLine(resultatRequete);
            if (resultatRequete)
            {

                resultat = true;
            }else
            {

                resultat = false;
            }
            return resultat;
        }

        public List<Tweet> GetTweet()
        {
            List<Tweet> tweetList = new List<Tweet>();

            Tweet tweet1 = new Tweet();
            tweet1.identifiant = "samuel";
            tweet1.nom = "Garrec";
            tweet1.dateCreation = "12-12-2020";
            tweet1.texte = "Non mais franchement qui à inventé le cahier à spirale?";
            tweet1.pseudo = "samsam";


            Tweet tweet2 = new Tweet();
            tweet1.identifiant = "Clement";
            tweet1.nom = "Bricola";
            tweet1.dateCreation = "12-10-2019";
            tweet1.texte = "Non mais franchement comment on gere les dates en java?";
            tweet1.pseudo = "clem";



            tweetList.Add(tweet1);
            tweetList.Add(tweet2);
            return tweetList;
        }

        List<Tweet> ITwitterService.GetTweet()
        {
            throw new NotImplementedException();
        }
    }
}
