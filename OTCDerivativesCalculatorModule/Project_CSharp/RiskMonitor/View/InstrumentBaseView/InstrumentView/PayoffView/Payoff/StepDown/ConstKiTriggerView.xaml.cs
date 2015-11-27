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
    /// ConstKiTriggerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConstKiTriggerView : UserControl
    {
        #region ViewModel_
        private ConstKiTriggerViewModel viewModel_;
        public ConstKiTriggerViewModel ViewModel_
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

        public ConstKiTriggerView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as ConstKiTriggerViewModel;

            this.MainPanel_.DataContext = this.viewModel_;
            this.ConstKiDataGrid_.ItemsSource = this.viewModel_.Value_;

            

            //scheduleDataGrid_.ItemsSource = this.viewModel_.RedemptionEvents_;
            //this.PayoffStackPanel_.Children.Add(this.viewModel_.ReturnCalculationViewModel_.ReturnCalculationView_);
        }
    }
}
