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
    public partial class MainWindow : Window
    {
        string[] baseballEventList = new string[5] { "경기", "이닝 교체", "점수", "타석 교대", "공 하나" };
        string[] baseballTimeList = new string[5] { "1시간", "30분", "10분", "5분", "시간 알림 사용 안함" };

    }
}
