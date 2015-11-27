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
using XmlBuilder.ViewModel;
using XmlBuilder.DataLoader;
using XmlBuilder.InstrumentModel;

namespace XmlBuilder
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

        private void addNewCtrl(XmlBuilderViewModel xbvm) 
        {
            
            // 만들어서 add함. 위치도 지정하고, 잡일여기서함.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FpmlSerializedCSharp.IDManager.clearAll();
            XmlDocument xmldoc = new XmlDocument();

            //xmldoc.Load("http://localhost:8033/ch01-01.xml");
            myTextBox.Text = "";
            xmldoc.Load("..\\..\\testStructruedProductNodeExceptTime.xml");
            myTextBox.Text = "loading..";
            FpmlSerializedCSharp.StructuredProduct serial_sp = 
                        new FpmlSerializedCSharp.StructuredProduct(xmldoc.SelectSingleNode("StructuredProduct"));

            XmlBuilderViewModel xbvm = new XmlBuilderViewModel();
            xbvm.setProduct(serial_sp);
            myTextBox.Text = "Done";

            XmlBuilderCtrl_.setViewModel(xbvm);

        }

        private void PortfolioLoading()
        {

            XmlDataLoader xdl = new XmlDataLoader();

            //XmlDataLoader setting 함.

            //XmlDataLoader load 함.

            //xdl.loadXml();

            List<Instrument> instList = new List<Instrument>();

            for (int i = 0; i < 20; i++)
            {
                string name = "ELS_" + Convert.ToString(i);
                instList.Add(new Instrument(name));
            }

            //this.ListExplorerCtrl_.InstrumentList_ListView_.ItemsSource = xdl.InstrumentList_;
            this.ListExplorerCtrl_.InstrumentList_ListView_.ItemsSource = instList;
        }

        private void LoadInstrument_Click(object sender, RoutedEventArgs e)
        {
            this.PortfolioLoading();
        }

            
    }
}
