
using Facebook.Helpers;
using Facebook.Models.Input;
using Facebook.Models.Output.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IFConfiguration config = new IFConfiguration();
            config.Subscription = "cnn";
            // update does not work because of https://newsroom.fb.com/news/2018/03/cracking-down-on-platform-abuse/ 

            FacebookSubscription subscription = config.GetSubscription();

            Console.WriteLine(subscription.Name);
            Console.WriteLine(subscription.Id);

            FacebookPost[] posts = config.GetPosts();
            for (int i = 0;
                    i < posts.Length && i < 300;
                    i++)
            {
                FacebookPost facebookPost = posts[i];
                Console.WriteLine(facebookPost.Message);
            }
            Console.WriteLine(config.GetPicture().Url);
            Console.WriteLine(config.GetPhotos()[3].CreationDate);
            Console.WriteLine(config.GetVideos()[3].UpdateDate);
            Console.WriteLine(config.GetAlbums()[3].Name);
            Console.WriteLine(config.GetEvents()[0].EndTime);
            Console.WriteLine(config.GetPosts()[0].Id.GetLink());
            Console.WriteLine(config.GetPosts()[0].Id.GetNumberShares());
            Console.WriteLine(config.GetPosts()[0].Id.GetPicture());
            Console.WriteLine(config.GetVideos()[0].Id.GetSource());
            Console.WriteLine(config.GetPosts()[0].Id.GetNumberLikes());
            Console.WriteLine(config.GetPosts()[0].Id.GetNumberComments());

            Console.ReadLine();
        }
    }
}
