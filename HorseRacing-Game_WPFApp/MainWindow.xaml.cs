using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HorseRacing_Game_WPFApp
{
    public partial class MainWindow : Window
    {
        private bool raceStarted = false;
        public MainWindow()
        {
            InitializeComponent();
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
