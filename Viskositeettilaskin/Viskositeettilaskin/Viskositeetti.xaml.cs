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
