using BarPlus.Viewmodels;
using BarPlus.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BarPlus
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow app;
        public static MainWindow App
        {
            get { return app; }
            set { app = value; }
        }


        public MainWindow()
        {
            InitializeComponent();

            //Makes the MainWindow object public so that it and its public methods are visible in the whole project.
            MainWindow.App = this;

            SwitchPage(new MainViewModel());
        }

        public void DispatcherTimerSample()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            main_time.Content = DateTime.Now.ToLongTimeString();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SwitchPage(new MainViewModel());
        }

        //-----------------------[ PUBLIC METHODS ]-----------------------

        /// <summary>The method <c>SwitchPage</c> is used to change the page of the application.
        /// <example>For example:
        /// <code>
        ///    MainWindow.App.SwitchPage(new MainViewModel());
        /// </code>
        /// changes the current page to MainView.
        /// </example>
        /// </summary>
        /// <param name="page">the ViewModel of the new page.</param>
        public void SwitchPage(Object page)
        {
            DataContext = page;
        }

        private void Btn_configuration_click(object sender, RoutedEventArgs e)
        {
            SwitchPage(new ConfigurationViewModel());
        }
    }
}
