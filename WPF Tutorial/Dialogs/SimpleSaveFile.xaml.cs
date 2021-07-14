using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Dialogs
{
    public partial class SimpleSaveFile : Window
    {
        public SimpleSaveFile()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
			if(saveFileDialog.ShowDialog() == true)
				File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
		}
    }
}
