using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class Film
    {
        public static int obj = 0;
        public Film()
        {
            obj++;
        }
        
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public ImageSource ImageURL { get; set; }
        public double Rating { get; set; }
        public int Date_added { get; set; }
    }
}

