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

namespace Common_Interface_Controls
{
    public partial class StatusBar : Window
    {
        public StatusBar()
        {
            InitializeComponent();
        }
        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{

			int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
			int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
			lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
		}
    }
}
