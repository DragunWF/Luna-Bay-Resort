
    using System.Windows;
    using System.Windows.Controls;

    namespace Luna_Bay_Resort.Controls
    {
        /// <summary>
        /// Interaction logic for NavBarControl.xaml
        /// </summary>
        public partial class NavBarControl : UserControl
        {
            // Declare an event to signal when a button is clicked
            public event Action<string>? ButtonClicked;

            public NavBarControl()
            {
                InitializeComponent();
            }

            private void NavButton_Click(object sender, RoutedEventArgs e)
            {
                if (sender is Button button)
                {
                    string tagValue = button.Tag?.ToString() ?? string.Empty;
                    // Raise the event with the tag value of the clicked button
                    ButtonClicked?.Invoke(tagValue);
                }
            }
        }
    }
