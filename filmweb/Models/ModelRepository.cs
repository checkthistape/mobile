using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Models
{

    public static class ModelMockup
    {
        public static List<Film> _contacts = new List<Film>() {
            new Film { FilmId=0, FilmName="wqedasd23", ImageURL="dotnet_bot.png"  },
            new Film { FilmId=1, FilmName="ewe2sd3", ImageURL="dotnet_bot.png"  },
            new Film { FilmId=2, FilmName="Iron Man", ImageURL="https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UX1000_.jpg"},
            new Film { FilmId=3, FilmName="tonn3", ImageURL="https://wallpaperaccess.com/full/3078197.jpg"},
            new Film { FilmId=4, FilmName="Cyberpunk", ImageURL="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimages.wallpapersden.com%2Fimage%2Fdownload%2Fbackground-of-cyberpunk-2077_bGVtZWiUmZqaraWkpJRnZWltrWdlaW0.jpg&f=1&nofb=1&ipt=75f872aac2b83104237cc842239a5e3f6a18120d7a954ed5ebd1bd73c3f8f046&ipo=images"},
            new Film { FilmId=4, FilmName="punkShould", ImageURL="https://wallpaperaccess.com/full/3078197.jpg"}
        };
        public static List<Film> GetContacts() => _contacts;
        public static Film GetContactById(int ContactId) { return _contacts.FirstOrDefault(x => x.FilmId == ContactId); }
    }
}
