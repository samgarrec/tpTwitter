using System;
using System.Collections.Generic;
using twitter;
using twitter.Models;

    public interface ITwitterService
    {

        Boolean Authentificate(User user);
        List<Tweet> GetTweet();


    }

