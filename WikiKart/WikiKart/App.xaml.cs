using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WikiKart.Database;
using WikiKart.Views.AccessApp;

namespace WikiKart
{
    public partial class App : Application
    {

        #region Database
        static DatabaseQuerys database;

        public static DatabaseQuerys Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname.db"));
                }
                return database;
            }
        }
        #endregion

        static NoteDatabase databaseNote;

        public static NoteDatabase DatabaseNote
        {
            get
            {
                if (databaseNote == null)
                {
                    databaseNote = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db"));
                }
                return databaseNote;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

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
