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
    /// RedemptionInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RedemptionInfoView : UserControl
    {
        #region ViewModel_
        private RedemptionInfoViewModel viewModel_;
        public RedemptionInfoViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.scheduleDataGrid_.ItemsSource = viewModel_.RedemtionEvents_.RedemptionEvents_;
                    ////this.UnderlyingListView_.ItemsSource = viewModel_.UnderlyingInfo_.Underlyings_;
                    //this.kiStackPanel_.DataContext = viewModel_.KIPayoff_;
                }
            }
        }
        #endregion

        public RedemptionInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as RedemptionInfoViewModel;

            this.RedemptionListDataGrid_.ItemsSource = this.viewModel_.EventTriggerViewModel_;

            //scheduleDataGrid_.ItemsSource = this.viewModel_.RedemptionEvents_;
            //this.PayoffStackPanel_.Children.Add(this.viewModel_.ReturnCalculationViewModel_.ReturnCalculationView_);
        }



        private void RedemptionListDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void RedemptionListDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RiskMonitor.EventTriggerViewModel selectedVM = this.RedemptionListDataGrid_.SelectedItem as EventTriggerViewModel;

            RedemptionSelectorView redemSelectorView = new RedemptionSelectorView();
            redemSelectorView.DataContext = selectedVM;

                //selectedVM.View_;
            redemSelectorView.Width = 300;
            redemSelectorView.Height = 300;
            redemSelectorView.ShowDialog();


        }
    }
}
