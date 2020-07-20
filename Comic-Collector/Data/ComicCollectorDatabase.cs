using System;
using SQLite;
using ComicCollector.Models;
using System.Collections.Generic;
using SQLiteNetExtensions.Extensions;
using System.Linq;
using System.Collections.ObjectModel;

namespace ComicCollector.Data
{
    public class ComicCollectorDatabase
    {
        public static SQLiteConnection database;

        public ComicCollectorDatabase(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Comics>();
        }

        public List<Comics> GetComics()
        {
            return database.GetAllWithChildren<Comics>().ToList();
        }

        public Comics GetComic(int id)
        {
            return database.Table<Comics>().Where(i => i.Id == id).FirstOrDefault();
        }

        public void AddComic(Comics comic)
        {
            if (comic.Id != 0)
            {
                database.UpdateWithChildren(comic);
            }
            database.InsertWithChildren(comic);
        }
    }
}
