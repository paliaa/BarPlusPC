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
    /// Interaktionslogik für BarMenu.xaml
    /// </summary>
    public partial class BarMenu : UserControl
    {
        public BarMenu()
        {
            InitializeComponent();
        }

        private void btn_click_1(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 1;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if(tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }

        private void btn_click_2(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 2;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_3(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 3;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_4(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 4;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_5(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 5;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_6(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 6;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_7(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 7;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_8(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 8;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_9(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 9;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }
        private void btn_click_0(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 0;

            if (tb == "")
            {
                tb_kassa.Text = num.ToString();
            }
            else if (tb == "0")
            {
                tb_kassa.Clear();
                tb_kassa.Text = num.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + num.ToString();
            }
        }

        private void btn_del(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();

            if (tb.Length > 1)
            {
                tb = tb.Substring(0, tb.Length - 1);
            }
            else
            {
                tb = "0";
            }
            tb_kassa.Text = tb.ToString();
        }

        private void btn_multi(object sender, RoutedEventArgs e)
        {

        }

        private void btn_minus(object sender, RoutedEventArgs e)
        {

        }

        private void btn_plus(object sender, RoutedEventArgs e)
        {

        }

        private void btn_click_result(object sender, RoutedEventArgs e)
        {

        }

        private void btn_click_comma(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            String comm = ",";

            if (tb == "")
            {
                tb_kassa.Text = comm.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text = tb_kassa.Text + comm.ToString();
            }
        }

        private void btn_varie_click(object sender, RoutedEventArgs e)
        {
            //Variable
            string tb =  tb_kassa.Text.ToString();
            char[] separator = {'.',','};
            Int32 count = 2;
            Double priceTb;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = tb.Split(separator, count, StringSplitOptions.None);

            if(strlist[1].Length == 1)
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1] + "0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            this.lv_Users.Items.Add(new MyItem { product = "Varie 10%", price = priceTb });

            //Textbox zurücksetzen
            tb_kassa.Clear();
            tb_kassa.Text = "0";
        }
    }

    internal class MyItem
    {
        public String product { get; set; }
        public double price { get; set; }
    }
}
