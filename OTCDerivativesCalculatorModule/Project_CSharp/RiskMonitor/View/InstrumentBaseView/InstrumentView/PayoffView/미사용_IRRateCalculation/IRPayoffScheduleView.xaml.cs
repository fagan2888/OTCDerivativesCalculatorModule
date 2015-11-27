using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RiskMonitor
{
    /// <summary>
    /// IRCalculationPayoffView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IRPayoffScheduleView : UserControl
    {
        public IRPayoffScheduleView()
        {
            InitializeComponent();
        }

        private void IRCalculationBtn_Click(object sender, RoutedEventArgs e)
        {
            // 새창 띄워서 거기다가 박음
            // IRCalculationEdit 박음
        }
    }
}
