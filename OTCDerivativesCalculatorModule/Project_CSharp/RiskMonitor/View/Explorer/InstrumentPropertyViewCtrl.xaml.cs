using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
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
    /// InstrumentPropertyViewCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InstrumentPropertyViewCtrl : UserControl
    {

        #region ShortCut Information Property

        #region ProductType_
        private string productType_;
        public string ProductType_
        {
            get { return this.productType_; }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                    this.NotifyPropertyChanged("ProductType_");
                }
            }
        }
        #endregion

        #region Notional_
        private long notional_;
        public long Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        #region ProductKRCode_
        private string productKRCode_;
        public string ProductKRCode_
        {
            get { return this.productKRCode_; }
            set
            {
                if (this.productKRCode_ != value)
                {
                    this.productKRCode_ = value;
                    this.NotifyPropertyChanged("ProductKRCode_");
                }
            }
        }
        #endregion

        #region ProductName_
        private string productName_;
        public string ProductName_
        {
            get { return this.productName_; }
            set
            {
                if (this.productName_ != value)
                {
                    this.productName_ = value;
                    this.NotifyPropertyChanged("ProductName_");
                }
            }
        }
        #endregion

        #endregion

        public InstrumentPropertyViewCtrl()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
