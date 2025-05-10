using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_10th
{
     class SocialMedia
    {
        public virtual void Post()
        {
            Console.WriteLine("Posting on social media");
        }
    }

    class FacebookPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Facebook");
        }
    }

    class TwitterPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Tweeting on Twitter");
        }
    }

    class InstagramPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Instagram");
        }
    }
}

using May_10th;

class Program
{
    static void Main()
    {
        FacebookPost facebookpost = new FacebookPost();
        facebookpost.Post();

        TwitterPost twitterpost = new TwitterPost();
        twitterpost.Post();

        InstagramPost instagrampost = new InstagramPost();
        instagrampost.Post();

    }
}
