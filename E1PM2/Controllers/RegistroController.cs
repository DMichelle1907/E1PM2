using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using E1PM2.Models;

namespace E1PM2.Controllers
{
    public class RegistroController
    {
        readonly SQLiteAsyncConnection _connection;

        //Constructor
        public RegistroController()
        {
            SQLite.SQLiteOpenFlags extensiones = SQLite.SQLiteOpenFlags.ReadWrite |
                                                SQLite.SQLiteOpenFlags.Create |
                                                SQLite.SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "E1PM2.db3"), extensiones);

            _connection.CreateTableAsync<Registro>();
        }

        //Create

        public async Task<int> AgregarRegistro(Registro registro)
        {

            if (registro.Id == 0)
            {
                return await _connection.InsertAsync(registro);
            }
            else
            {
                return await _connection.UpdateAsync(registro);
            }
        }

    }
}
