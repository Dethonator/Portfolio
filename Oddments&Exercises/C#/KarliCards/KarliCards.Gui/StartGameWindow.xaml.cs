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
using System.IO;
using System.Xml.Serialization;

namespace KarliCards.Gui
{
    /// <summary>
    /// Interaction logic for StartGameWindow.xaml
    /// </summary>
    public partial class StartGameWindow : Window
    {
        private GameOptions gameOptions;
        public StartGameWindow()
        {
            InitializeComponent();
            DataContextChanged += StartGame_DataContextChanged;
        }

        private void ChangeListBoxOptions()
        {
            if (gameOptions.PlayAgainstComputer)
                playersBox.SelectionMode = SelectionMode.Single;
            else
                playersBox.SelectionMode = SelectionMode.Extended;
        }

        private void playerNamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gameOptions.PlayAgainstComputer)
                okButton.IsEnabled = (playersBox.SelectedItems.Count == 1);
            else
                okButton.IsEnabled = (playersBox.SelectedItems.Count == gameOptions.NumberOfPlayers);
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newPlayerBox.Text))
                gameOptions.AddPlayer(newPlayerBox.Text);
            newPlayerBox.Text = string.Empty;
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            var gameOptions = DataContext as GameOptions;
            gameOptions.SelectedPlayers = new List<string>();
            foreach (string item in playersBox.SelectedItems)
            {
                gameOptions.SelectedPlayers.Add(item);
            }

            this.DialogResult = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            gameOptions = null;
            Close();
        }

        void StartGame_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            gameOptions = DataContext as GameOptions;
            ChangeListBoxOptions();
        }
    }
}
