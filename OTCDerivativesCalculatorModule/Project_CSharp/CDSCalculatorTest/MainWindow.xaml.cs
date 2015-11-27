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
using System.Xml;

namespace CDSCalculatorTest
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

        private void Load()
        { 
            string fileName = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\CDSCalculatorTest\\MultiNameCDS.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            MainWindowViewModel vm = new MainWindowViewModel();
            vm.load(xmlDoc);
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Load();
        }
    }
}
