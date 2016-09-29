using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwkTurtleCounter
{
    class AwkTwitt
    {

        public static string ParseMessage(string message)
        {
            string guid = Guid.NewGuid().ToString();

            string truncatedGuid = guid.Substring(0, 5);

            DateTime date = DateTime.UtcNow;
            message = message.ToLower();
            string ConsumerKey = Tokens.ConsumerKey;
            string ConsumerKeySecret = Tokens.ConsumerKeySecret;
            string AccessToken = Tokens.AccessToken;
            string AccessTokenSecret = Tokens.AccessTokenSecret;
            string response = "";
            var twitter = new TwitterApi(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            if(message.Contains("turtle++"))
            {
                if(message.Contains("jericho"))
                {
                    twitter.Tweet("Jericho gains 1 turtle. " + truncatedGuid);
                    Turtle.Default.JerichoTurtle++;
                }
                if (message.Contains("helen"))
                {
                    twitter.Tweet("Helen gains 1 turtle. " + truncatedGuid);
                    Turtle.Default.HelenTurtle++;
                }
            }
            if (message.Contains("cookie++"))
            {
                if (message.Contains("jericho"))
                {
                    twitter.Tweet("Jericho gains 1 cookie. " + truncatedGuid);
                    Turtle.Default.JerichoCookie++;
                }
                if (message.Contains("helen"))
                {
                    twitter.Tweet("Helen gains 1 cookie. " + truncatedGuid);
                    Turtle.Default.HelenCookie++;
                }
            }
            if (message.Contains("score=="))
            {
                twitter.Tweet(string.Format("Jericho : {0} turtles and {1} cookies. Helen : {2} turtles and {3} cookies", Turtle.Default.JerichoTurtle.ToString(), Turtle.Default.JerichoCookie.ToString(),
                                           Turtle.Default.HelenTurtle.ToString(), Turtle.Default.HelenCookie ));
            }
            return response;
        }
    }
}
