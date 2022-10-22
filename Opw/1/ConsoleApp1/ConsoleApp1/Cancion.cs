using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cancion: IMedia
    {
        public long Seconds { get; set; }
        public String Title { get; set; }
        public ShelvePosition position { get; set; }


        public void play()
        {
            Console.WriteLine($"This Song {this.Title} Is Playing");
        }
    }
}
