using System;
using System.Collections.Generic;
using twitter.Models;

    public interface ITwitterService
    {

        Boolean Authentificate(String user,String pwd);
        List<Tweet> GetTweet();


    }

