﻿using RecipeProject.WPF.Stores;
using RecipeProject.WPF.ViewModels;
using RecipeProject.WPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeProject.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        public App()
        {
            _modalNavigationStore= new ModalNavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            //var loginView = new LoginView()
            //{
            //    DataContext = new LoginViewModel(_modalNavigationStore)
            //};
            //loginView.Show();
            //loginView.IsVisibleChanged += (s, ev) =>
            //{
            //    if (loginView.IsVisible == false && loginView.IsLoaded)
            //    {
            //        var mainView = new MainWindow();
            //        mainView.Show();
            //        loginView.Close();
            //    }
            //};
            base.OnStartup(e);
        }
    }
}
