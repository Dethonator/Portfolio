using System;
using System.Windows;
using System.Windows.Media;


namespace Misc_Controls
{
    public partial class SliderRespondingToChanges : Window
    {
        public SliderRespondingToChanges()
        {
            InitializeComponent();
        }
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
			this.Background = new SolidColorBrush(color);
		}
    }
}
