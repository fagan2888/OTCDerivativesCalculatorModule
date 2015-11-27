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


namespace Excel_Interface
{
    /// <summary>
    /// IndexTickerInfoEditorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IndexTickerInfoEditorView : UserControl
    {
        #region ViewModel_
        private IndexTickerInfo viewModel_;
        public IndexTickerInfo ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.bindingPanel_.DataContext = this.viewModel_;
                    //this.indexTypeCB_.Text = this.viewModel_.Index_type_;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public IndexTickerInfoEditorView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
            this.viewModel_ = new IndexTickerInfo();
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as IndexTickerInfo;
            this.bindingPanel_.DataContext = this.viewModel_;
            
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            string ticker = this.yahoo_tickerTB_.Text;
            
            if (ticker == "")
            {
                return;
            }

            bool tf = YahooMarketDataLoader.dataTest(ticker);

            if (tf)
            {
                this.yahoo_tickerTestTB_.Text = "OK";
            }
            else
            {
                this.yahoo_tickerTestTB_.Text = "FAIL";
            }


        }

        private void surmitButton_Click(object sender, RoutedEventArgs e)
        {
            

            this.viewModel_.Name_ = this.nameTB_.Text;
            this.viewModel_.KrCode_ = this.krcodeTB_.Text;
            this.viewModel_.Yahoo_ticker_ = this.yahoo_tickerTB_.Text;
            this.viewModel_.Index_type_ = this.indexTypeCB_.Text;

            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            this.viewModel_.Index_type_ = cb.SelectedValue.ToString();
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            
            this.indexTypeCB_.IsEditable = true;
            
            this.indexTypeCB_.Items.Add("Stock");
            this.indexTypeCB_.Items.Add("InterestRate");
            this.indexTypeCB_.Items.Add("Swap");
        }



    }
}
