using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public ImageSource ImageURL { get; set; }

        public string Description { get; set; }
        public double Rating { get; set; }
        public int Date_added { get; set; }
    }
}

