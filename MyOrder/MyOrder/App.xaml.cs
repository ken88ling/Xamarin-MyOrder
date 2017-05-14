using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyOrder.View;
using Xamarin.Forms;

namespace MyOrder
{
    public partial class App : Application
    {
        //private static Database database;
        //public static Database MyDatabase
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new Database();
        //        }
        //        return database;
        //    }
        //}

        //App.MyDatabase.DBConnect();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
