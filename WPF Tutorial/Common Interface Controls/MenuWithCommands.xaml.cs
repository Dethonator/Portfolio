using System;
using System.Windows;
using System.Windows.Input;

namespace Common_Interface_Controls
{
    public partial class MenuWithCommands : Window
    {
        public MenuWithCommands()
        {
            InitializeComponent();
        }
        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Text = "";
		}
    }
}
