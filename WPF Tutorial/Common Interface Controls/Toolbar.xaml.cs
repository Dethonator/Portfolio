using System;
using System.Windows;
using System.Windows.Input;

namespace Common_Interface_Controls
{
    public partial class Toolbar : Window
    {
        public Toolbar()
        {
            InitializeComponent();
        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
    }
}
