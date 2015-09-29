using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using SQLite3 = System.Data.SQLite;
using SQLite;

namespace WpfApplication1
{
    public static class Database
    {
        public static void Login(User user)
        {
                  
            if (!File.Exists("database.db"))
            {
                SQLite3.SQLiteConnection.CreateFile("database.db");
            }
            try
            {
                //TODO: общение с базой и продумать базу
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        

        public static bool Answer(Question q, string ans)
        {
            return false;
        }



    }
}
