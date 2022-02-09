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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace Simulateur_de_guichet_automatique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        
    {
    
        
        //SqlCommand com = new SqlCommand();
       // SqlDataReader dr;
        public static string codeClient;
        public MainWindow()
        {
            
           
            InitializeComponent();
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
       /* private bool VerifyUser(string codeClient,string nip)
        {
            
            conn.Open();
            com.Connection = conn;
            com.CommandText = "select Status from Clients where codeClient='" + codeClient + "' and NIP='" + nip + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }*/
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WENSON-LAPTOP;Initial Catalog=Guichet_dba;Integrated Security=True");
            try
            {


                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String query = "SELECT COUNT(1) FROM Client WHERE codeClient=@Username AND NIP=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, conn);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", textBox_codeClient.Text);
                sqlCmd.Parameters.AddWithValue("@Password", textnip.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonLogoff_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void PasswordBox_nip_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key ==Key.Enter)
            {
                ButtonLogin_Click(this, new RoutedEventArgs());
            }            

        }
    }
}
