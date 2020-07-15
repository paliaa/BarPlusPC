using BarPlus.Viewmodels;
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

namespace BarPlus.Views
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Btn_kassa_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.App.SwitchPage(new BarMenuViewModel());
        }
        private void Click_statistic(object sender, RoutedEventArgs e)
        {
            MainWindow.App.SwitchPage(new StatisticViewModel());
        }
    }
}
