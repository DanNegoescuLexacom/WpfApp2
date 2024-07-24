using LibVLCSharp.Shared;
using System.Windows;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace WpfApp2
{
    public partial class MainWindow : FluentWindow
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;

        public MainWindow()
        {
            InitializeComponent();

            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            VideoView.MediaPlayer = _mediaPlayer;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (_mediaPlayer.Media == null)
            {
                var media = new Media(_libVLC, "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4", FromType.FromLocation);
                _mediaPlayer.Media = media;
            }
            _mediaPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            _mediaPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _mediaPlayer.Stop();
        }

        private void ThemeToggle_Checked(object sender, RoutedEventArgs e)
        {
            ApplicationThemeManager.Apply(ApplicationTheme.Dark);
        }

        private void ThemeToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            ApplicationThemeManager.Apply(ApplicationTheme.Light);
        }

        protected override void OnClosed(EventArgs e)
        {
            _mediaPlayer.Dispose();
            _libVLC.Dispose();
            base.OnClosed(e);
        }
    }
}