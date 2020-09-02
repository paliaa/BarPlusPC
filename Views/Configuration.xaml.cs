using MySql.Data.MySqlClient;
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
    /// Interaktionslogik für Configuration.xaml
    /// </summary>
    public partial class Configuration : UserControl
    {
        public Configuration()
        {
            InitializeComponent();

            //Load all the configurations from DB
            try
            {
                //generate the connection string
                string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

                //create a MySQL connection with a query string
                MySqlConnection connection = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand("select Count(*) from t_group", connection);

                //open the connection
                connection.Open();

                string resultcount = cmd.ExecuteScalar().ToString();

                Console.WriteLine("Wert: " + resultcount);

                //close the connection
                connection.Close();

                int iCount = int.Parse(resultcount);

                if (resultcount != "0")
                {
                    for (int i = 0; i <= iCount; i++)
                    {

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
