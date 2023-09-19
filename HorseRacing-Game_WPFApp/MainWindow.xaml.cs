using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace HorseRacing_Game_WPFApp
{
    public partial class MainWindow : Window
    {
        private bool raceStarted = false;
        public MainWindow()
        {
            InitializeComponent();

            Line1.Visibility = Visibility.Collapsed;
            Line2.Visibility = Visibility.Collapsed;
            Line3.Visibility = Visibility.Collapsed;
            Line4.Visibility = Visibility.Collapsed;
            Line5.Visibility = Visibility.Collapsed;

            Button1.Visibility = Visibility.Collapsed;
            Button2.Visibility = Visibility.Collapsed;
            Button3.Visibility = Visibility.Collapsed;
            Button4.Visibility = Visibility.Collapsed;
            Button5.Visibility = Visibility.Collapsed;
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            raceStarted = true;

            for (int i = 3; i > 0; i--)
            {
                CountdownText.Text = i.ToString();
                CountdownPopup.IsOpen = true;
                await Task.Delay(1000);
                CountdownPopup.IsOpen = false;
                await Task.Delay(500);
            }

            CountdownText.Text = "Start!";
            CountdownPopup.IsOpen = true;
            await Task.Delay(1000);
            CountdownPopup.IsOpen = false;

            Line1.Visibility = Visibility.Visible;
            Line2.Visibility = Visibility.Visible;
            Line3.Visibility = Visibility.Visible;
            Line4.Visibility = Visibility.Visible;
            Line5.Visibility = Visibility.Visible;

            Button1.Visibility = Visibility.Visible;
            Button2.Visibility = Visibility.Visible;
            Button3.Visibility = Visibility.Visible;
            Button4.Visibility = Visibility.Visible;
            Button5.Visibility = Visibility.Visible;

            StartButton.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
