using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Luna_Bay_Resort.Controls
{
    public partial class RoundedCard : UserControl
    {
        public RoundedCard()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(BitmapImage), typeof(RoundedCard), new PropertyMetadata(null));

        public BitmapImage ImageSource
        {
            get { return (BitmapImage)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(RoundedCard), new PropertyMetadata(string.Empty));

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Handle button click here
        }
    }
}
