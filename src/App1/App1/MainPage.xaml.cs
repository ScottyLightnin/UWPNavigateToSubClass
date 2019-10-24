using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace App1
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BasePageButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasePage));
        }
        private void SubPage1Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SubclassPage1));
        }
    }
}
