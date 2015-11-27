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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_InstrumentView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_InstrumentView : UserControl
    {
        #region ViewModel_
        private Excel_instrumentViewModel viewModel_;
        public Excel_instrumentViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public Excel_InstrumentView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext != null)
            { 
                this.viewModel_ = this.DataContext as Excel_instrumentViewModel;

                //this.viewModel_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged +=
                //    this.viewModel_.Excel_parameterViewModel_.instrumentEventObserver;

                this.MasterInfoGrid_.Children.Clear();
                this.MasterInfoGrid_.Children.Add(this.viewModel_.MasterInformationViewModel_.view());

                this.ProductGrid_.Children.Clear();
                this.ProductGrid_.Children.Add(this.viewModel_.Excel_interfaceViewModel_.view());

                this.ParameterGrid_.Children.Clear();
                this.ParameterGrid_.Children.Add(this.viewModel_.Excel_parameterViewModel_.view());

                this.ResultGrid_.Children.Clear();
                this.ResultGrid_.Children.Add(this.viewModel_.Excel_parameterViewModel_.Excel_resultViewModel_.view());

                this.ProfitLossGrid_.Children.Clear();
                this.ProfitLossGrid_.Children.Add(this.viewModel_.Excel_profitLossViewModel_.view());

                this.EventGrid_.Children.Clear();
                this.EventGrid_.Children.Add(this.viewModel_.Excel_eventManagerViewModel_.view());
            }

        }

        private void Booking_Button_Click(object sender, RoutedEventArgs e)
        {
            OutputLogViewModel.addResult("not implemented! now test");

            XMLFileLoader.SaveInstrument(this.viewModel_);
        }

        private void Calc_Button_Click(object sender, RoutedEventArgs e)
        {

            this.viewModel_.calculate();
            
            //string productXmlStr = this.viewModel_.Excel_interfaceViewModel_.productXml();
            //string parameterXmlStr = this.viewModel_.Excel_parameterViewModel_.paraXml();
            
            //// < date , value > //
            //string underHistData = this.viewModel_.Excel_parameterViewModel_.historyUnderData();

            ////string result = CalculationModuleDLL.calculationLibCall(productXmlStr, parameterXmlStr);
            //string result = CalculationModuleDLL.calculationLibCall(productXmlStr, 
            //                                                        parameterXmlStr,
            //                                                        underHistData
            //                                                        );

            ////this.viewModel_.Excel_parameterViewModel_.Excel_resultViewModel_.Price_ = result;
            
            //this.viewModel_.Excel_parameterViewModel_.loadResult(result);
            ////this.viewModel_.Excel_profitLossViewModel_.

        }

        private void product_xmlBuild_Button_Click(object sender, RoutedEventArgs e)
        {
            string productXmlStr = this.viewModel_.Excel_interfaceViewModel_.productXml();
            Window w = new Window();
            
            XMLViewer.Viewer v = new XMLViewer.Viewer();

            XmlDocument XMLdoc = new XmlDocument();

            XMLdoc.LoadXml(productXmlStr);

            v.xmlDocument = XMLdoc;

            w.Content = v;

            w.ShowDialog();

        }

        private void parameter_xmlBuild_Button_Click(object sender, RoutedEventArgs e)
        {
            string parameterXmlStr = this.viewModel_.Excel_parameterViewModel_.paraXml();

            Window w = new Window();

            XMLViewer.Viewer v = new XMLViewer.Viewer();

            XmlDocument XMLdoc = new XmlDocument();

            XMLdoc.LoadXml(parameterXmlStr);

            v.xmlDocument = XMLdoc;

            w.Content = v;

            w.ShowDialog();

            
        }

    }
}
