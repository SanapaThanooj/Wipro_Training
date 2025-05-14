using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    interface IMusicPlayer 
    {
        void Play(string song);
        void Pause();
        void Stop();
    }

    class SpotifyPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Spotify.");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing Spotify.");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping Spotify.");
        }
    }
    class AppleMusicPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Apple Music.");
        }
        public void Pause()
        {
            Console.WriteLine("Apple Music Playback paused.");
        }
        public void Stop()
        {
            Console.WriteLine("Apple Music playback stopped");
        }
    }
     
         class Program
     {
     static void Main(string[] args)
     {
         IMusicPlayer spotify = new SpotifyPlayer();
         spotify.Play("Chutamale.MP4song");
         spotify.Pause();
         spotify.Stop();
         IMusicPlayer appleMusic = new AppleMusicPlayer();
         appleMusic.Play("Yedhee.MP4song");
         appleMusic.Pause();
         appleMusic.Stop();
     }
    }

}
