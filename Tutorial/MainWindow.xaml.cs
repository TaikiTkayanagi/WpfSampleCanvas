using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tutorial
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var path in myCanvas.Children.OfType<Path>())
            {
                var translateTransform = new TranslateTransform();
                path.RenderTransform = translateTransform;

                var animation = new DoubleAnimation
                {
                    From = 0,
                    To = 110,
                    Duration = TimeSpan.FromSeconds(2),
                    AutoReverse = false,
                    RepeatBehavior = RepeatBehavior.Forever
                };

                translateTransform.BeginAnimation(TranslateTransform.XProperty, animation);
            }

            foreach (var path in myCanvas2.Children.OfType<Path>())
            {
                var translateTransform = new TranslateTransform();
                path.RenderTransform = translateTransform;

                var animation = new DoubleAnimation
                {
                    From = 0,
                    To = 110,
                    Duration = TimeSpan.FromSeconds(2),
                    AutoReverse = false,
                    RepeatBehavior = RepeatBehavior.Forever
                };

                translateTransform.BeginAnimation(TranslateTransform.XProperty, animation);
            }
        }
    }
}
