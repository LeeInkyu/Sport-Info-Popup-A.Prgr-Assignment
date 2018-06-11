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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LayOut
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbBx_BaseballEventPicker_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in baseballEventList)
            {
                CbBx_BaseballEventPicker.Items.Add(item);
            }
        }

        private void CbBx_BaseballTimePicker_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in baseballTimeList)
            {
                CbBx_BaseballTimePicker.Items.Add(item);
            }
        }
    }
}
