using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HorseRacing_Game_WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] progressValues = { 0, 0, 0, 0, 0 };
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
            if (raceStarted)
            {
                Button clickedButton = (Button)sender;

                int buttonIndex = int.Parse(clickedButton.Content.ToString()) - 1;

                if (progressValues[buttonIndex] < 100)
                {
                    progressValues[buttonIndex]++;
                    UpdateProgressBar(buttonIndex);
                }
            }
        }

        private void UpdateProgressBar(int index)
        {
            switch (index)
            {
                case 0:
                    PrBar1.Value = progressValues[index];
                    break;
                case 1:
                    PrBar2.Value = progressValues[index];
                    break;
                case 2:
                    PrBar3.Value = progressValues[index];
                    break;
                case 3:
                    PrBar4.Value = progressValues[index];
                    break;
                case 4:
                    PrBar5.Value = progressValues[index];
                    break;
            }
        }
    }
}
