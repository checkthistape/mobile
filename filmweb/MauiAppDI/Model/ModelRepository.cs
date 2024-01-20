﻿//using Android.Hardware.Camera2;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Models
{

    public static class ModelMockup
    {
        static int a = Film.obj;

        private const string DB_NAME = "filmweb.db";
        private static readonly SQLiteAsyncConnection _connection;
        



        public static ObservableCollection<Film> _films = new ObservableCollection<Film>() {
            new Film { filmid=0, filmname="Pulp Fiction", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.wrDo_CaDwBgyE0R3yW6m2AHaLH%26pid%3DApi&f=1&ipt=a28cbcfe2dd25f1fbd841358f984bc5c93739fb7043f0143e9b77f3a8c3ac23d&ipo=images", film_rating=5  },
            new Film { filmid=1, filmname="The Dark Knight", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwallpaperaccess.com%2Ffull%2F769961.jpg&f=1&nofb=1&ipt=4a9704fcd909d27dfbc85ea4737f2b0caeb4bbc2b26c6b2126ea7e257fbdd025&ipo=images", film_rating=6  },
            new Film { filmid=2, filmname="Iron Man", filmImageURL="https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UX1000_.jpg", film_rating=4},
            new Film { filmid=3, filmname="Fight Club", filmImageURL="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2F3.bp.blogspot.com%2F_3N0VetpYvQE%2FS9jg0AGYwyI%2FAAAAAAAACz8%2FOP6C90Or-5s%2Fs1600%2FFight_Club_3.jpg&f=1&nofb=1&ipt=f1b37d70bf715e4e4ff7438fe4d0ec2ffe242bc0243ad12a6bd00beb8b3cecb2&ipo=images", film_rating=2},
            new Film { filmid=4, filmname="Cyberpunk", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimages.wallpapersden.com%2Fimage%2Fdownload%2Fbackground-of-cyberpunk-2077_bGVtZWiUmZqaraWkpJRnZWltrWdlaW0.jpg&f=1&nofb=1&ipt=75f872aac2b83104237cc842239a5e3f6a18120d7a954ed5ebd1bd73c3f8f046&ipo=images", film_rating=4},
            new Film { filmid=5, filmname="punkShould", filmImageURL="https://wallpaperaccess.com/full/3078197.jpg", film_rating=5},
            new Film { filmid=6, filmname="The Godfather", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2F1.bp.blogspot.com%2F-AiVGG0pdHnM%2FW1M-ADo4uyI%2FAAAAAAAAAA4%2FCvEQdQvwa0MzcgWZLJRuxgs2Y20pWINggCEwYBhgL%2Fs1600%2Fgodfather%252B2.jpg&f=1&nofb=1&ipt=08fb6c9e29749472ce2bb2a990220124a80258504b5337cfd4575f192a9144ae&ipo=images", film_rating=5},
            new Film { filmid=7, filmname="Spider-Man: Across the Spider-Verse", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic1.cbrimages.com%2Fwordpress%2Fwp-content%2Fuploads%2F2023%2F03%2Fspider-man-across-the-spider-verse-poster.jpg&f=1&nofb=1&ipt=b78d9cb49803ced29d29335ff9f14817d97fe8f1174f80d819b934e04123d1f4&ipo=images", film_rating=6 },
            new Film { filmid=8, filmname="Interstellar", filmImageURL="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.hdwallpapers.in%2Fwalls%2Finterstellar_2014-wide.jpg&f=1&nofb=1&ipt=7bad52393032913fa9c8629cf185b4dabc96463583f6541b877540e3a49e8db0&ipo=images", film_rating=3},
            new Film { filmid=9, filmname=(Film.obj).ToString(), filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.photographylife.com%2Fwp-content%2Fuploads%2F2018%2F11%2FMoeraki-Boulders-New-Zealand.jpg&f=1&nofb=1&ipt=6e5f608ebc582ced0e7cde74272af90891a14d5f285667edba04c5b14049f305&ipo=images", film_rating=2},
            new Film { filmid=10, filmname="Inception", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.themoviedb.org%2Ft%2Fp%2Foriginal%2F9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg&f=1&nofb=1&ipt=7d582167526c6af0271894d8360e242b05a1886c66db2252a4a09dbfb2f4304b&ipo=images", film_rating=6},
            new Film { filmid =11, filmname="The Silence of the Lambs", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimg.goldposter.com%2F2015%2F04%2FThe-Silence-of-the-Lambs_poster_goldposter_com_27.jpg&f=1&nofb=1&ipt=4652452610a60ef70944f16cc896302840377004f7094bf155a0af42b3d9bcbd&ipo=images", film_rating=5},
            new Film { filmid=12, filmname="Back to the Future", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F2d%2F4b%2Fd6%2F2d4bd67988c563409aa85f40651620ff.jpg&f=1&nofb=1&ipt=ae4ff0e0c040c1b36a014a294302ef1d71cde467c91701f7cde10a09f8ca73cd&ipo=images", film_rating=6},
            new Film { filmid=13, filmname="Léon: The Professional", filmImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpicfiles.alphacoders.com%2F366%2Fthumb-1920-366894.jpg&f=1&nofb=1&ipt=cf50c20847a4b70e8e07207880f34fe06f593e13755edb2f81f32ce5dcef7b49&ipo=images", film_rating=4 }

        };

        
        public static int GetLastElement() { return Film.obj;  }
        public static ObservableCollection<Film> GetFilms() => _films;


        public static Film GetContactById(int filmid) { return _films.FirstOrDefault(x => x.filmid == filmid); }

        public static void AddElementt(Film item) { _films.Add(item); }
    }
}
