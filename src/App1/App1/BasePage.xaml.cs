using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace App1
{

    public partial class BasePage : Page
    {
        public BasePage()
        {
            InitializeComponent();
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
