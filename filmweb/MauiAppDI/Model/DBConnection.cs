using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDI.Model
{
    internal class DBConnection
    {
        private const string DB_NAME = "filmweb.db";
        private readonly SQLiteAsyncConnection _connection;

        public DBConnection()
        {
            _connection = new SQLiteAsyncConnection(DB_NAME);

        }
    }
}
