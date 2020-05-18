using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using TweetSharp;
using System.Threading;
using System.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TwitterTrends twitterTrends;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
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

            var trendTask = Task.Run(() => GetTrends(service));
            var listOFTrends = await trendTask;
            trendsList.ItemsSource = listOFTrends.Select(y=> y.Name);            

            var useravatarTask = Task.Run(() => GetUserAvatar(service));
            var userAvatar = await useravatarTask;
            userPic.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString(userAvatar.ProfileImageUrlHttps);

            var tweet = Task.Run(() => GetTweet(service));
            var tweetText = await tweet;
            listOfTweets.ItemsSource = tweetText.Select(x=>x.Text);

            IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions());
        }

        private TwitterTrends GetTrends(TwitterService service)
        {
            Thread.Sleep(1000);
            return service.ListLocalTrendsFor(new ListLocalTrendsForOptions{Id = 1 });
        }

        private TwitterUser GetUserAvatar(TwitterService service)
        {
            Thread.Sleep(1000);
            var profile = service.GetUserProfile(new GetUserProfileOptions());
       
            return profile;
        }

        private IEnumerable <TwitterStatus> GetTweet(TwitterService service)
        {
            Thread.Sleep(1000);
          
            return service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();
        }
    }
}
 