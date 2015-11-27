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
    /// UnderlyingInfo_paraView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UnderlyingInfo_paraView : UserControl
    {
        #region ViewModel_
        private UnderlyingInfo_paraViewModel viewModel_;
        public UnderlyingInfo_paraViewModel ViewModel_
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

        public UnderlyingInfo_paraView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as UnderlyingInfo_paraViewModel;
            this.underParaDataGrid_.ItemsSource = this.viewModel_.Underlying_paraViewModel_;

            this.corrParaDataGrid_.ItemsSource = this.viewModel_.CorrelationInfo_paraViewModel_.CorrelationDataList_;
        }

        private void underParaDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void corrParaDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

    }
}
