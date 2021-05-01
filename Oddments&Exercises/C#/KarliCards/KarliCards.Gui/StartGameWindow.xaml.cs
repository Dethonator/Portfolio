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
            if (gameOptions == null)
            {
                if (File.Exists("GameOptions.xml"))
                {
                    using (var stream = File.OpenRead("GameOptions.xml"))
                    {
                        var serializer = new XmlSerializer(typeof(GameOptions));
                        gameOptions = serializer.Deserialize(stream) as GameOptions;
                    }
                }
                else
                    gameOptions = new GameOptions();
            }
            DataContext = gameOptions;
            InitializeComponent();
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
            foreach (string item in playersBox.SelectedItems)
            {
                gameOptions.SelectedPlayers.Add(item);
            }
            using (var stream = File.Open("GameOptions.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(GameOptions));
                serializer.Serialize(stream, gameOptions);
            }
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            gameOptions = null;
            Close();
        }
    }
}
