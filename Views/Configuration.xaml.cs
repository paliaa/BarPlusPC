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
using System.Data;

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

            funcDLL.Func.LogWrite_Info("View Configuration wurde gestartet");
            //Load all the configurations from DB
            try
            {
                //generate the connection string
                string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

                //create a MySQL connection with a query string
                MySqlConnection connection = new MySqlConnection(connectionString);

                MySqlCommand cmdProd = new MySqlCommand("select p_id AS PRODNR, p_name as NOME, p_groupid AS GROUDNR, p_price AS PREZZO, p_ivaid AS IVA from t_products", connection);
                MySqlCommand cmdGroup = new MySqlCommand("SELECT g_id as ID, g_name AS NOME, g_uscita AS USCITA FROM t_groups", connection);

                //open the connection
                connection.Open();

                DataTable dtprod = new DataTable();
                DataTable dtgroup = new DataTable();

                dtprod.Load(cmdProd.ExecuteReader());
                dtgroup.Load(cmdGroup.ExecuteReader());

                //close the connection
                connection.Close();

                dtGridProd.DataContext = dtprod;
                dtGridGroup.DataContext = dtgroup;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
