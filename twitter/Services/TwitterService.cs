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

      

        public bool Authentificate(User utilisateur)
        {

            Boolean resultat;
            List<Tweet> laListe = GetTweet();
            List<User> users = GetUsers();


            Boolean resultatRequete = users.Any(p =>p.identifiant.Equals(utilisateur.identifiant.ToString()));
            if (resultatRequete)
            {

                resultat = true;
            }else
            {

                resultat = false;
            }
            return resultat;
        }

        public List<User> GetUsers()
        {
            User sam = new User();
            sam.identifiant = "samuel";
            sam.pwd = "samuel";



            User clem = new User();
           clem.identifiant = "clement";
            clem.pwd = "clement";


            List<User> users = new List<User>();
            users.Add(sam);
            users.Add(clem);
            return users;


        }

            public List<Tweet> GetTweet()
        {

           
            User sam = new User();
            sam.identifiant = "samuel";
            sam.pwd = "samuel";

            

            User clem = new User();
            sam.identifiant = "clement";
            sam.pwd = "clement";

            List<Tweet> tweetList = new List<Tweet>();

            Tweet tweet1 = new Tweet();
            tweet1.dateCreation = "12-12-2020";
            tweet1.texte = "Non mais franchement qui à inventé le cahier à spirale?";
            tweet1.nom ="sam";


            Tweet tweet2 = new Tweet();
            tweet2.dateCreation = "12-10-2019";
            tweet2.texte = "Non mais franchement comment on gere les dates en java?";
            tweet2.nom = "john";



            tweetList.Add(tweet1);
            tweetList.Add(tweet2);
            return tweetList;
        }

       
    }
}
