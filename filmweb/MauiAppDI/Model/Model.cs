using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace filmweb.Models
{
    public class Film
    {
        public static int obj = 0;
        public Film()
        {
            obj++;
        }
        [PrimaryKey, AutoIncrement]
        [Column("filmid")]
        public int filmid { get; set; }

        [Column("filmname")]
        public string filmname { get; set; }

        [Column("film_date")]
        public int film_date { get; set; }

        [Column("film_rating")]
        public float film_rating { get; set; }

        [Column("filmImageURL")]
        public ImageSource filmImageURL { get; set; }

        [Column("filmImageBLOB")]
        public ImageSource filmImageBLOB { get; set; }

        [Column("filmImageURLhor")]
        public ImageSource filmImageURLhor { get; set; }

        [Column("filmDescription")]
        public string filmDescription { get; set; }

    }
}

