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

namespace RiskMonitor
{
    /// <summary>
    /// BatchControlView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BatchControlView : UserControl
    {

        #region ViewModel_
        private BatchControlViewModel viewModel_;
        public BatchControlViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.DataContext = value; 
                    //this.InstrumentListDataGrid_.ItemsSource = viewModel_.InstHierarchyList_;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public BatchControlView()
        {
            InitializeComponent();
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void ParameterLoadBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel_.loadParaResult();
            this.InstrumentListDataGrid_.Items.Refresh();
        }

        private void ParameterBuildBtn_Click(object sender, RoutedEventArgs e)
        {
            //viewModel_.buildParameter();
            viewModel_.loadParaResult();
            this.InstrumentListDataGrid_.Items.Refresh();
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

        private void CalculationBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel_.calculate();
            this.InstrumentListDataGrid_.Items.Refresh();
        }


    }
}
