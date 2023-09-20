using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace HorseRacing_Game_WPFApp
{
    public partial class MainWindow : Window
    {
        private bool raceStarted = false;

        private int luffyPosition = 0;
        private int zoroPosition = 0;
        private int namiPosition = 0;
        private int ussopPosition = 0;
        private int sanjiPosition = 0;
        private int lineEndPosition = 542;
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

            Luffy.Visibility = Visibility.Collapsed;
            Zoro.Visibility = Visibility.Collapsed;
            Nami.Visibility = Visibility.Collapsed;
            Ussop.Visibility = Visibility.Collapsed;
            Sanji.Visibility = Visibility.Collapsed;
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

            Luffy.Visibility = Visibility.Visible;
            Zoro.Visibility = Visibility.Visible;
            Nami.Visibility = Visibility.Visible;
            Ussop.Visibility = Visibility.Visible;
            Sanji.Visibility = Visibility.Visible;

            StartButton.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Button1)
            {
                luffyPosition += 10;
                TranslateTransform transform = new TranslateTransform(luffyPosition, 0);
                Luffy.RenderTransform = transform;

                if (luffyPosition >= lineEndPosition)
                {
                    MessageBox.Show("Luffy is the winner!");
                }
            }
            else if(sender == Button2) 
            {
                zoroPosition += 10;
                TranslateTransform transform = new TranslateTransform(zoroPosition, 0);
                Zoro.RenderTransform = transform;

                if(zoroPosition >= lineEndPosition) 
                {
                    MessageBox.Show("Zoro is the winner");
                }
            }
            else if(sender == Button3)
            {
                namiPosition += 10;
                TranslateTransform transform = new TranslateTransform(namiPosition, 0);
                Nami.RenderTransform = transform;

                if(namiPosition >= lineEndPosition)
                {
                    MessageBox.Show("Nami is the winner");
                }
            }
            else if( sender == Button4)
            {
                ussopPosition += 10;
                TranslateTransform transform = new TranslateTransform(ussopPosition, 0);
                Ussop.RenderTransform = transform;

                if(ussopPosition >= lineEndPosition)
                {
                    MessageBox.Show("Ussop is the winner");
                }
            }
            else if (sender == Button5) 
            {
                sanjiPosition += 10;
                TranslateTransform transform = new TranslateTransform(sanjiPosition, 0);
                Sanji.RenderTransform = transform;

                if(sanjiPosition >= lineEndPosition)
                {
                    MessageBox.Show("Sanji is the winner");
                }
            }
        }
    }
}
