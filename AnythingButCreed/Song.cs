using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnythingButCreed
{
    internal class Song 
    {
        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }

        public string Artist { get; set; }
        public string Name { get; set; }
       

    }
}
