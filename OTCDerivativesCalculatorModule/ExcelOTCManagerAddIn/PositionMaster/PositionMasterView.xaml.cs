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

namespace ExcelOTCManagerAddIn
{
    /// <summary>
    /// PositionMasterView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PositionMasterView : UserControl
    {
        #region ViewModel_
        private PositionMasterVM viewModel_;
        public PositionMasterVM ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public PositionMasterView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.loadPosition();
            this.postionListGrid_.ItemsSource = this.viewModel_.PositionBookingInfoVMList_;
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
