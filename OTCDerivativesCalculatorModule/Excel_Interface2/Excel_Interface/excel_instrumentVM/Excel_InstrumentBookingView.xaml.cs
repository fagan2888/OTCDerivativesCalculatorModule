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
    /// Excel_InstrumentBookingView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_InstrumentBookingView : UserControl
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

        public Excel_InstrumentBookingView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_instrumentViewModel;

            this.MasterInfoGrid_.Children.Clear();

            MasterInformationView masterInfoView = this.viewModel_.MasterInformationViewModel_.view();
            masterInfoView.bookingModeSetting(BookingMode.Booking);

            this.MasterInfoGrid_.Children.Add(masterInfoView);

            this.ProductGrid_.Children.Clear();
            this.ProductGrid_.Children.Add(this.viewModel_.Excel_interfaceViewModel_.view());

            this.ProfitLossGrid_.Children.Clear();
            this.ProfitLossGrid_.Children.Add(this.viewModel_.Excel_profitLossViewModel_.view());

        }

        //private void Booking_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //positionDB.booking(this.viewModel_)
        //    string productXmlStr = this.viewModel_.Excel_interfaceViewModel_.productXml();

        //    // 현재 program foler로 저장됨
        //    System.IO.File.WriteAllText("testProductInfo.xml", productXmlStr);

        //    MessageBoxResult result = MessageBox.Show("test booking OK");

        //}

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

        private void BookingButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.checkDataValid())
            {
                ((Window)this.Parent).DialogResult = true;
                ((Window)this.Parent).Close();
            }
        }

        private bool checkDataValid()
        {
            return DataErrorCheck.check("null", "Book Value", this.viewModel_.Excel_profitLossViewModel_.BookValue_);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }
    }
}
