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
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelOTCManagerAddIn
{
    /// <summary>
    /// BookingPositionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BookingPositionView : UserControl
    {
        #region ViewModel_
        private PositionBookingInfoVM viewModel_;
        public PositionBookingInfoVM ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.DataContext = this.viewModel_;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public BookingPositionView()
        {
            InitializeComponent();
            
        }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        
    }
}
