using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul6_1302210041
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string t)
        {
            this.title = t;
            Random x = new Random();
            id = x.Next(10000, 99999);
            this.playCount = 0;
            Debug.Assert(t.Length < 100 && t != null);
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count < 10000000);
            try
            {
                checked { this.playCount += count; }
            }
            catch (OverflowException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id        : " + this.id);
            Console.WriteLine("Title     : " + this.title);
            Console.WriteLine("PlayCount : " + this.playCount);
        }

        public int GetPlayCount()
        {
            return playCount;
        }

    }
}