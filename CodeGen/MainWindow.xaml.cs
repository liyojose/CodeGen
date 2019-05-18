using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace CodeGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String connectionString = "Data Source=localhost;Initial Catalog=Test;Integrated Security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            ServerConnection conn = new ServerConnection(sqlConnection);
            Server srv = new Server(conn);
            treeView1.ItemsSource = new List<Server> { srv };
        }
    }
}
