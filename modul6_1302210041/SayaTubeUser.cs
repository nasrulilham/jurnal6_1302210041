using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210041
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string Username)
        {
            Random random= new Random();
            id = random.Next(10000, 99999);
            this.Username = Username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User          : " + id);
            for(int i = 0;i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul " + uploadedVideos + " count " + uploadedVideos[i].GetPlayCount());
            }
        }

    }
}
