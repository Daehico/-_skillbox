using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            async Task DownloadTwitterProfileImage(IEnumerable<Claim> claims, string userId)
            {
                // Retrieve the twitter access token and claim
                var accessTokenClaim = claims.FirstOrDefault(x => x.Type == "urn:tokens:twitter:accesstoken");
                var accessTokenSecretClaim = claims.FirstOrDefault(x => x.Type == "urn:tokens:twitter:accesstokensecret");

                if (accessTokenClaim != null && accessTokenSecretClaim != null)
                {
                    // Initialize the Twitter client
                    var service = new TwitterService(
                        "your twitter consumer key",
                        "your twitter consumer secret",
                        accessTokenClaim.Value,
                        accessTokenSecretClaim.Value
                        );

                    var profile = service.GetUserProfile(new GetUserProfileOptions());
                    if (profile != null && !String.IsNullOrWhiteSpace(profile.ProfileImageUrlHttps))
                    {
                        string filename = Server.MapPath(string.Format("~/ProfileImages/{0}.jpeg", userId));

                        await DownloadProfileImage(new Uri(profile.ProfileImageUrlHttps), filename);
                    }
                }
            }

        }
    }
}

