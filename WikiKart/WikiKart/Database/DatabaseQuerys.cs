using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using WikiKart.Models;

namespace WikiKart.Database
{
    public class DatabaseQuerys
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseQuerys(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<UserModel>().Wait();

        }

        // METODO SELECT
        public Task<List<UserModel>> GetUserModel()
        {
            return _database.Table<UserModel>().ToListAsync();
        }

        // METODO SELECT SEARCH BAR
        public Task<UserModel> GetUserModelAynsc(int id)
        {
            return _database.Table<UserModel>()
                            .Where(i => i.UserID == id)
                            .FirstOrDefaultAsync();
        }

        // METODO ELIMINAR
        public Task<int> DeleteUserModelAsync(UserModel userModel)
        {
            return _database.DeleteAsync(userModel);
        }

        public Task<List<UserModel>> GetUsersValidate(string email, string password)
        {
            return _database.QueryAsync<UserModel>("SELECT * FROM UserModel WHERE EmailField = '" + email + "' AND PasswordField = '" + password + "'");
        }

        // METODO GUARDAR Y ACTUALIZAR
        public Task<int> SaveUserModelAsync(UserModel userModel)
        {
            if (userModel.UserID != 0)
            {
                return _database.UpdateAsync(userModel);
            }
            else
            {
                return _database.InsertAsync(userModel);
            }
        }
    }
}
