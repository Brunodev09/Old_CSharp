using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP_1
{
    class VideoPosts:Posts
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        protected Boolean isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        public VideoPosts()
        {

        }
        public VideoPosts(string Title, string SentByUsername, string VideoURL, bool IsPublic, int Length)
        {
            this.Title = Title;
            this.SentByUsername = SentByUsername;
            this.VideoURL = VideoURL;
            this.IsPublic = IsPublic;
            this.Length = Length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing the timer!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            else
            {
                Console.WriteLine("Video is already playing!");
            }

        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                isPlaying = true;
                currDuration++;
                Console.WriteLine("Video is at {0}s", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine("Stopped at " + currDuration);
                currDuration = 0;
                timer.Dispose();
                isPlaying = false;
            }
            else
            {
                Console.WriteLine("Video is not playing to be stopped.");
            }

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} ", this.ID, this.Length, this.SentByUsername);
        }
    }
}
