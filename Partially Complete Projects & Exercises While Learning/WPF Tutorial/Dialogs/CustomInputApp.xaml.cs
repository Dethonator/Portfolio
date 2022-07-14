using System;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for CustomInputApp.xaml
    /// </summary>
    public partial class CustomInputApp : Window
    {
        public CustomInputApp()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
		{
			CustomInput inputDialog = new CustomInput("Please enter your name:", "John Doe");
			if(inputDialog.ShowDialog() == true)
				lblName.Text = inputDialog.Answer;
		}
    }
}
