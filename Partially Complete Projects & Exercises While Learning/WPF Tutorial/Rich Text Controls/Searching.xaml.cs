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
using System.Windows.Shapes;

namespace Rich_Text_Controls
{
    /// <summary>
    /// Interaction logic for Searching.xaml
    /// </summary>
    public partial class Searching : Window
    {
        public Searching()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
		{
			fdViewer.Find();
		}
    }
}
