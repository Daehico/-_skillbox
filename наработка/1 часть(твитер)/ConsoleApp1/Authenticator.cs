using System;
using System.Collections.Generic;
using System.Diagnostics;
using TweetSharp;

namespace ConsoleApp1
{
    class Authenticator
    {

        public const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
        public const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
        public static TwitterService service = new TwitterService(consumerKey, consumerSecret);

        public static OAuthRequestToken requestToken = service.GetRequestToken();

        public static object Authenticators()
        {
            var uri = service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());

            string verifier = Console.ReadLine();
            OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);

            service.AuthenticateWith(access.Token, access.TokenSecret);
            IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions());

            return service;
        }

        public static string ProfileImage()
        {
            var profile = service.GetUserProfile(new GetUserProfileOptions());

            string profileImg = profile.ProfileImageUrlHttps;

            return profileImg;

        }
        

    }
}
