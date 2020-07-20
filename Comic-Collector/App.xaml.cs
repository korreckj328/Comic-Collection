using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;
using ComicCollector.ViewModels;
using ComicCollector.Data;
using System.IO;

namespace Comic_Collector
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var factory = new XamvvmFormsFactory(this);
            factory.RegisterNavigationPage<MainNavigationPageModel>(() => this.GetPageFromCache<MainPageModel>());
            XamvvmCore.SetCurrentFactory(factory);
            MainPage = this.GetPageFromCache<MainNavigationPageModel>() as NavigationPage;
        }

        static ComicCollectorDatabase database;
        public static ComicCollectorDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ComicCollectorDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ComicCollector.db3"));
                }
                return database;
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
