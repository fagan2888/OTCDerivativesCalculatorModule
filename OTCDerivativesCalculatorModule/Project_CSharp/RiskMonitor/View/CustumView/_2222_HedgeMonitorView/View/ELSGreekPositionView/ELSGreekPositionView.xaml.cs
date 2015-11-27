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
    /// ELSGreekPositionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ELSGreekPositionView : UserControl
    {
        private GreekPositionAnalyzerViewModel viewModel_;

        public ELSGreekPositionView()
        {
            InitializeComponent();
        }

        public void dataLoad()
        {
            
            Factory_ELSGreekPosition factory = new Factory_ELSGreekPosition();
            viewModel_ = factory.viewModel();
            

        }
    }
}
