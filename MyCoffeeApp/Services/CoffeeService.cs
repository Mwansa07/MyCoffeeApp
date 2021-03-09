using System;
using System.IO;
using System.Threading.Tasks;
using MyCoffeeApp.Models;
using SQLite;
using Xamarin.Essentials;

namespace MyCoffeeApp.Services
{
    public static class CoffeeService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            //use FileSystem.AppDataDirectory for database location
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Coffee>();
        }

        public static async Task AddCoffee(string name, string roaster)
        {
            await Init();
        }

        public static async Task RemoveCoffee(int id)
        {
            await Init();
        }

        public static async Task GetCoffee()
        {
            await Init();
        }
    }
}
