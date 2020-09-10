using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace BarPlus.Views
{
    /// <summary>
    /// Interaktionslogik für BarMenu.xaml
    /// </summary>
    /// 


    //Einbinden einer DLL-Datei
    using BarPlus.funcDLL;

    public partial class BarMenu : UserControl
    {
        //globale Variable
        public static int quantity = 1;
        public Button buttonName;
        public TextBlock textBlockName;

        public BarMenu()
        {
            InitializeComponent();

            funcDLL.Func.LogWrite_Info("View BarMenu wurde gestartet");

            #region Fill all button
            try
            {
                //generate the connection string
                string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";
                
                //create a MySQL connection with a query string
                MySqlConnection connection = new MySqlConnection(connectionString);

                //MySQLCommand
                MySqlCommand cmdgroup = new MySqlCommand("select Count(*) from t_group", connection);

                //open the connection
                connection.Open();

                string countGroup = cmdgroup.ExecuteScalar().ToString();

                funcDLL.Func.LogWrite_Info("View Bar - Menu: Gruppenanzahl: " + countGroup);

                //close the connection
                connection.Close();

                int iCountGroup = int.Parse(countGroup);
                //int iCountProducts = int.Parse(countProducts);

                for(int i = 1; i <= iCountGroup; i++)
                {
                    textBlockName = this.FindName("Group" + i) as TextBlock;

                    Console.WriteLine("TextBox.Text: " + textBlockName.Text);
                    try
                    {
                        //MySQLCommand
                        MySqlCommand groupName = new MySqlCommand(@"select g_name from t_group WHERE g_id = @i", connection);
                        groupName.Parameters.Add("@i", (MySqlDbType)SqlDbType.Int).Value = i; //your id parameter!


                        connection.Open();

                        string nameGroup = groupName.ExecuteScalar().ToString();

                        connection.Close();

                        textBlockName.Text = nameGroup;
                        textBlockName.Visibility = Visibility.Visible;

                        //CREATE STATEMENT
                        string prodStatement = "select Count(*) from t_products WHERE p_groupid = " + i;
                        MySqlCommand cmdproducts = new MySqlCommand(prodStatement, connection);

                        //open the connection
                        connection.Open();

                        string countProducts = cmdproducts.ExecuteScalar().ToString();
                        funcDLL.Func.LogWrite_Info("View Bar - Menu: Produkteanzahl: " + countProducts);
                        connection.Close();
                        Console.WriteLine("Wert countProducts: " + countProducts);

                        int iCountProducts = int.Parse(countProducts);



                        for (int j = 1; j <= iCountProducts; j++)
                        {

                            buttonName = this.FindName("prod_" + i + "_" + j) as Button;
                            try
                            {
                                //MySQLCommand
                                string queryProductName = "select p_name from t_products WHERE p_groupid = " + i + " AND p_id = " + j;
                                Console.WriteLine("Test: " + queryProductName);

                                MySqlCommand productName = new MySqlCommand("select p_name from t_products WHERE p_groupid = '" + i + "' AND p_id = '" + j + "'", connection);
                                
                                connection.Open();

                                string nameProduct = productName.ExecuteScalar().ToString();

                                connection.Close();

                                buttonName.Content = nameProduct;
                                buttonName.Visibility = Visibility.Visible;
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        #region Btn_click_1
        private void Btn_click_1(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 1;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);

        }
        #endregion

        #region Btn_click_2
        private void Btn_click_2(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 2;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_3
        private void Btn_click_3(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 3;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_4
        private void Btn_click_4(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 4;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_5
        private void Btn_click_5(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 5;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_6
        private void Btn_click_6(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 6;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_7
        private void Btn_click_7(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 7;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_8
        private void Btn_click_8(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 8;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_9
        private void Btn_click_9(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 9;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_0
        private void Btn_click_0(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 0;

            tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_del
        private void Btn_del(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();

            var index = lv_Users.Items.IndexOf(lv_Users.SelectedItem);
            //MessageBox.Show("Index: " + index);
            if (index == -1)
            {
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
            else
            {
                double priceOne;
                string lblTotal;
                var selectedStockObject = lv_Users.SelectedItems[0] as MyItem;
                if (selectedStockObject == null)
                {
                    return;
                }

                priceOne = selectedStockObject.Price;
                lblTotal = lbl_totale.Content.ToString();
                lbl_totale.Content = funcDLL.Func.TotalSumMinus(priceOne, lblTotal);

                
                lv_Users.Items.RemoveAt(index);
            }
            
        }
        #endregion

        #region Btn_multi
        private void Btn_multi(object sender, RoutedEventArgs e)
        {
            if(tb_kassa.Text == "0")
            {
                lv_Users.SelectAll();
            }
            else
            {
                quantity = int.Parse(tb_kassa.Text);
                tb_kassa.Text = "0";
            }

        }
        #endregion

        #region Btn_minus
        private void Btn_minus(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_plus
        private void Btn_plus(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_click_result
        private void Btn_click_result(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_click_comma
        private void Btn_click_comma(object sender, RoutedEventArgs e)
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
                tb_kassa.Text += comm.ToString();
            }
        }
        #endregion

        #region Btn_varie_click
        private void Btn_varie_click(object sender, RoutedEventArgs e)
        {
            //Variable
            string tb =  tb_kassa.Text.ToString();
            char[] separator = {'.',','};
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = tb.Split(separator, count, StringSplitOptions.None);
            
            if (tb.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = "Varie 10%", Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);




            //Textbox zurücksetzen
            tb_kassa.Clear();
            tb_kassa.Text = "0";
            quantity = 1;
        }
        #endregion

        #region Lvi_loeschen
        private void Lvi_loeschen(object sender, RoutedEventArgs e)
        {
            var index = lv_Users.Items.IndexOf(lv_Users.SelectedItem);
            
            double priceOne;
            string lblTotal;
            var selectedStockObject = lv_Users.SelectedItems[0] as MyItem;
            if (selectedStockObject == null)
            {
                return;
            }

            priceOne = selectedStockObject.Price;
            lblTotal = lbl_totale.Content.ToString();
            lbl_totale.Content = funcDLL.Func.TotalSumMinus(priceOne, lblTotal);

            
            lv_Users.Items.RemoveAt(index);
            

        }

            private void Lvi_alleloeschen(object sender, RoutedEventArgs e)
        {
            lv_Users.Items.Clear();
            lbl_totale.Content = "0";
        }
        #endregion

        #region All groups
        #region Group1
        private void Btn_1_1(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_2(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_3(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_4(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_5(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_6(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_7(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_8(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_9(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_10(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_11(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_12(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_13(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_14(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_15(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_16(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_17(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_18(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_19(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_20(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_21(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_22(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_23(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_24(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_25(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_26(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_27(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_28(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_29(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_30(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_31(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_1_32(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_33(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_34(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_1_35(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group2
        private void Btn_2_1(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_2(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_3(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_4(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_5(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_6(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_7(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_8(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_9(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_10(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_11(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_12(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_13(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_14(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_15(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_16(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_17(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_18(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_19(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_20(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_21(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_22(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_23(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_24(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_25(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_26(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_27(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_28(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_29(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_30(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_31(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_2_32(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_33(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_34(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_2_35(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group3
        private void Btn_3_1(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_2(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_3(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_4(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_5(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_6(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_7(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_8(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_9(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_10(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_11(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_12(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_13(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_14(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_15(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_16(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_17(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_18(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_19(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_20(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_21(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_22(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_23(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_24(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_25(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_26(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_27(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_28(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_29(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_30(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_31(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_3_32(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_33(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_34(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_3_35(object sender, RoutedEventArgs e)
        {
            int group = 3;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group4
        private void Btn_4_1(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_2(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_3(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_4(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_5(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_6(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_7(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_8(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_9(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_10(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_11(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_12(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_13(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_14(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_15(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_16(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_17(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_18(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_19(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_20(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_21(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_22(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_23(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_24(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_25(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_26(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_27(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_28(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_29(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_30(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_31(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_4_32(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_33(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_34(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_4_35(object sender, RoutedEventArgs e)
        {
            int group = 4;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group5
        private void Btn_5_1(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_2(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_3(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_4(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_5(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_6(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_7(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_8(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_9(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_10(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_11(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_12(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_13(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_14(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_15(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_16(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_17(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_18(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_19(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_20(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_21(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_22(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_23(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_24(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_25(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_26(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_27(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_28(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_29(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_30(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_31(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_5_32(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_33(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_34(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_5_35(object sender, RoutedEventArgs e)
        {
            int group = 5;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group6
        private void Btn_6_1(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_2(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_3(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_4(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_5(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_6(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_7(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_8(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_9(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_10(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_11(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_12(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_13(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_14(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_15(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_16(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_17(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_18(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_19(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_20(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_21(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_22(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_23(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_24(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_25(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_26(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_27(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_28(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_29(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_30(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_31(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_6_32(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_33(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_34(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_6_35(object sender, RoutedEventArgs e)
        {
            int group = 6;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group7
        private void Btn_7_1(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_2(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_3(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_4(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_5(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_6(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_7(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_8(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_9(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_10(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_11(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_12(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_13(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_14(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_15(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_16(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_17(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_18(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_19(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_20(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_21(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_22(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_23(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_24(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_25(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_26(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_27(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_28(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_29(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_30(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_31(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_7_32(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_33(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_34(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_7_35(object sender, RoutedEventArgs e)
        {
            int group = 7;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group8
        private void Btn_8_1(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_2(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_3(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_4(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_5(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_6(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_7(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_8(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_9(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_10(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_11(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_12(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_13(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_14(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_15(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_16(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_17(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_18(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_19(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_20(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_21(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_22(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_23(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_24(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_25(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_26(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_27(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_28(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_29(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_30(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_31(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_8_32(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_33(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_34(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_8_35(object sender, RoutedEventArgs e)
        {
            int group = 8;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group9
        private void Btn_9_1(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_2(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_3(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_4(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_5(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_6(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_7(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_8(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_9(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_10(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_11(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_12(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_13(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_14(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_15(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_16(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_17(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_18(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_19(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_20(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_21(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_22(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_23(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_24(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_25(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_26(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_27(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_28(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_29(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_30(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_31(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_9_32(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_33(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_34(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_9_35(object sender, RoutedEventArgs e)
        {
            int group = 9;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion

        #region Group10
        private void Btn_10_1(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 1;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_2(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 2;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_3(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 3;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_4(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 4;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_5(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 5;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_6(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 6;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_7(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 7;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_8(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 8;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_9(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 9;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_10(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 10;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_11(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 11;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_12(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 12;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_13(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 13;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_14(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 14;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_15(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 15;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_16(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 16;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_17(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 17;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_18(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 18;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_19(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 19;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_20(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 20;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_21(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 21;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_22(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 22;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_23(object sender, RoutedEventArgs e)
        {
            int group = 1;
            int prod = 23;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_24(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 24;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_25(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 25;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_26(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 26;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_27(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 27;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_28(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 28;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_29(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 29;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_30(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 30;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_31(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 31;
            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }

        private void Btn_10_32(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 32;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_33(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 33;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_34(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 34;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }

        private void Btn_10_35(object sender, RoutedEventArgs e)
        {
            int group = 10;
            int prod = 35;

            //generate the connection string
            string connectionString = "SERVER=localhost;DATABASE=barplus;UID=root;PASSWORD=mima10492;";

            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection(connectionString);

            //create string Query
            string getValue = "select p_price FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;
            string getName = "select p_name FROM t_products WHERE p_groupid = " + group + " AND p_id = " + prod;

            //MySQLCommand
            MySqlCommand cmdPrice = new MySqlCommand(getValue, connection);
            MySqlCommand cmdName = new MySqlCommand(getName, connection);

            //open the connection
            connection.Open();

            string prodPrice = cmdPrice.ExecuteScalar().ToString();
            string prodName = cmdName.ExecuteScalar().ToString();

            //close the connection
            connection.Close();


            char[] separator = { '.', ',' };
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = prodPrice.Split(separator, count, StringSplitOptions.None);

            if (prodPrice.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
        }
        #endregion
        #endregion
    }

    internal class MyItem
    {
        public String Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
