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
    /// Excel_profitLossView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_profitLossView : UserControl
    {
        #region ViewModel_
        private Excel_profitLossViewModel viewModel_;
        public Excel_profitLossViewModel ViewModel_
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

        public Excel_profitLossView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_profitLossViewModel;
            this.bindingPanel_.DataContext = this.viewModel_;
        }

        //private void LoadButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.viewModel_.loadNPV();
        //    this.viewModel_.loadTradeEvent();

        //    this.NPVTextBox_.Text = this.viewModel_.NPV_.ToString();
        //    this.TotalPLTextBox_.Text = this.viewModel_.TotalProfitLoss_.ToString();
        //    this.DailyPLTextBox_.Text = this.viewModel_.DailyProfitLoss_.ToString();

        //    //this.historyPL_DataGrid_.ItemsSource = this.viewModel_.PLViewModelList_;
        //    this.TradeEventHistory_DataGrid.ItemsSource = this.viewModel_.TradeEventViewModelList_;
        //}

        //private void PLHistoryLoadButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

    }
}
