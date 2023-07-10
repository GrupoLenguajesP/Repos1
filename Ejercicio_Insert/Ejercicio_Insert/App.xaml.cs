using System;
using System.IO;
using Ejercicio_Insert.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_Insert
{
    public partial class App : Application
    {
        static SQLData db;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static SQLData SQLiteDB
        {
            get
            {
                if (db==null)
                {
                    db = new SQLData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Estudiantes.db"));
                }
                return db;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
