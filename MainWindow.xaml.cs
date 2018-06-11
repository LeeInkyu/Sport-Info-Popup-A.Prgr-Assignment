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
            foreach(var item in TimeList)
            {
                CbBx_BaseballTimePicker.Items.Add(item);
            }
        }

        private void CbBx_FootballEventPicker_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in footballEventList)
            {
                CbBx_FootballEventPicker.Items.Add(item);
            }
        }

        private void CbBx_FootballTimePicker_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in TimeList)
            {
                CbBx_FootballTimePicker.Items.Add(item);
            }
        }

        private void CbBx_TypePicker_Loaded(object sender, RoutedEventArgs e)
        {
            CbBx_TypePicker.Items.Add("메신저형");
            CbBx_TypePicker.Items.Add("팝업형");
        }

        private void BT_Submit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("설정 완료");
            //TODO: Submit 로직 구현
        }
    }
}
