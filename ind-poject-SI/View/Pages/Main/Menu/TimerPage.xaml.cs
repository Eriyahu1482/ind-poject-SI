using ind_poject_SI.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ind_poject_SI.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TimerPage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        public TimerPage()
        {
            InitializeComponent();
        }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            if (_time == TimeSpan.Zero)
                _timer = new DispatcherTimer();
            _timer.Start();
        }

        private void BtnBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new MainPage());
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(00);

            tbTime.Text = _time.ToString("c");

            _timer.Stop();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void M1_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(60);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void M3_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(180);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void M4_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(240);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
    }
}
