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
    /// ConstNonKiTriggerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConstNonKiTriggerView : UserControl
    {
        #region ViewModel_
        private ConstNonKiTriggerViewModel viewModel_;
        public ConstNonKiTriggerViewModel ViewModel_
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

        public ConstNonKiTriggerView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as ConstNonKiTriggerViewModel;

            this.MainPanel_.DataContext = this.viewModel_;

            //scheduleDataGrid_.ItemsSource = this.viewModel_.RedemptionEvents_;
            //this.PayoffStackPanel_.Children.Add(this.viewModel_.ReturnCalculationViewModel_.ReturnCalculationView_);
        }
    }
}
