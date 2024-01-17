//using Android.Hardware.Camera2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Models
{

    public static class ModelMockup
    {
        static int a = Film.obj;

        public static List<Film> _films = new List<Film>() {
            new Film { FilmId=0, FilmName="Pulp Fiction", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.themoviedb.org%2Ft%2Fp%2Foriginal%2FjlVOS4D6ledQGxGdL0EIte3TXfL.jpg&f=1&nofb=1&ipt=529dcb3f58baa034c5729ae3ea1a0c2b889b6eb0732d6afb0ea81f9e25fa845d&ipo=images"  },
            new Film { FilmId=1, FilmName="The Dark Knight", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwallpaperaccess.com%2Ffull%2F769961.jpg&f=1&nofb=1&ipt=4a9704fcd909d27dfbc85ea4737f2b0caeb4bbc2b26c6b2126ea7e257fbdd025&ipo=images"  },
            new Film { FilmId=2, FilmName="Iron Man", ImageURL="https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UX1000_.jpg"},
            new Film { FilmId=3, FilmName="Fight Club", ImageURL="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwallpapercave.com%2Fwp%2FWRyhvxr.jpg&f=1&nofb=1&ipt=82b4ae0b1cafde794bc01399b26a759b7af83b99d6f3e38d4ec4c5ab7f98762b&ipo=images"},
            new Film { FilmId=4, FilmName="Cyberpunk", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimages.wallpapersden.com%2Fimage%2Fdownload%2Fbackground-of-cyberpunk-2077_bGVtZWiUmZqaraWkpJRnZWltrWdlaW0.jpg&f=1&nofb=1&ipt=75f872aac2b83104237cc842239a5e3f6a18120d7a954ed5ebd1bd73c3f8f046&ipo=images"},
            new Film { FilmId=5, FilmName="punkShould", ImageURL="https://wallpaperaccess.com/full/3078197.jpg"},
            new Film { FilmId=6, FilmName="The Godfather", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2F1.bp.blogspot.com%2F-AiVGG0pdHnM%2FW1M-ADo4uyI%2FAAAAAAAAAA4%2FCvEQdQvwa0MzcgWZLJRuxgs2Y20pWINggCEwYBhgL%2Fs1600%2Fgodfather%252B2.jpg&f=1&nofb=1&ipt=08fb6c9e29749472ce2bb2a990220124a80258504b5337cfd4575f192a9144ae&ipo=images"},
            new Film { FilmId=7, FilmName="Spider-Man: Across the Spider-Verse", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmanofmany.com%2Fwp-content%2Fuploads%2F2022%2F12%2FSpider-Man-Across-the-Spider-Verse-Part-One-1.png&f=1&nofb=1&ipt=0d95bebfc44a956b3b777501ab90865fac56d8c3ea618a0f56d0db8b91bfdaaa&ipo=images" },
            new Film { FilmId=8, FilmName="Interstellar", ImageURL="https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.hdwallpapers.in%2Fwalls%2Finterstellar_2014-wide.jpg&f=1&nofb=1&ipt=7bad52393032913fa9c8629cf185b4dabc96463583f6541b877540e3a49e8db0&ipo=images"},
            new Film { FilmId=9, FilmName=(Film.obj).ToString(), ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.photographylife.com%2Fwp-content%2Fuploads%2F2018%2F11%2FMoeraki-Boulders-New-Zealand.jpg&f=1&nofb=1&ipt=6e5f608ebc582ced0e7cde74272af90891a14d5f285667edba04c5b14049f305&ipo=images"}
        
        };

        
        public static int GetLastElement() { return Film.obj;  }
        public static List<Film> GetFilms() => _films;
        public static Film GetContactById(int FilmId) { return _films.FirstOrDefault(x => x.FilmId == FilmId); }
    }
}
