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

namespace Viskositeettilaskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.NorthwindConnectionString);
        SqlCeCommand cmd;

       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindows_load(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            con.open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Product FROM Categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
ComboBox.items.add(dr["Product"].ToString())
            }
            con.Close();
        }

       
    }

    internal class SqlCeCommand
    {
    }

internal class SqlCeConnection
{
    public SqlCeConnection(string northwindConnectionString)
    {
    }
}
}
