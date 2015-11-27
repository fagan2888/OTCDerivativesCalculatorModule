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

namespace VolatiltityManager
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private VolCalculationInformationViewModel volCalVM_;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            this.volCalVM_ = new VolCalculationInformationViewModel();

            volCalVM_.AddCalculationMethod("HIST", 3);
            volCalVM_.AddCalculationMethod("HIST", 6);

            volCalVM_.calculate("KR_ANSANG");
            
            this.result_Grid.ItemsSource = volCalVM_.Result_;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
