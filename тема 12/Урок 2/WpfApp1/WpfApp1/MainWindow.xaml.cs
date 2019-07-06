using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TweetSharp;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            const string consumerKey = "x6roMQs0MZ1PwjNmAELfziqq9";
            const string consumerSecret = "LztwfuCe5wFMbTh2i5MmCuBCcog2taz39Jfock7CiCJbooWWJP";
            var service = new TwitterService(consumerKey, consumerSecret);

            var requestToken = service.GetRequestToken();


            var uri = service.GetAuthorizationUri(requestToken);
            Process.Start(uri.ToString());

            var window = new Authorization();
            var result = window.ShowDialog();

            if (result == true)
            {

                var access = service.GetAccessToken(requestToken, window.Verifaer);

                service.AuthenticateWith(access.Token, access.TokenSecret);
            }

            
            var profile = service.GetUserProfile(new GetUserProfileOptions());

            string profileImg = profile.ProfileImageUrlHttps;
            WebClient webClient = new WebClient();
            
            webClient.DownloadFile(profileImg, "user avatars/user_avatar" + System.IO.Path.GetExtension(profileImg));


            IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions());
        }
    }
}
 