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
            new Film { FilmId=0, User="wqedasd23", ImageURL="dotnet_bot.png"  },
            new Film { FilmId=1, User="ewe2sd3", ImageURL="dotnet_bot.png"  },
            new Film { FilmId=2, User="tonnyStark2", ImageURL="https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UX1000_.jpg"}
        };
        public static List<Film> GetContacts() => _contacts;
        public static Film GetContactById(int ContactId) { return _contacts.FirstOrDefault(x => x.FilmId == ContactId); }
    }
}
