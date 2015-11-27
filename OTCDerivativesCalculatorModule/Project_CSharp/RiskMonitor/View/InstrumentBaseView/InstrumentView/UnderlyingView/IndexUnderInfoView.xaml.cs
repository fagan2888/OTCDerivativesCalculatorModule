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
    /// IndexUnderInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IndexUnderInfoView : UserControl
    {
        #region ViewModel_
        private IndexUnderInfoViewModel viewModel_;
        public IndexUnderInfoViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                }
            }
        }
        #endregion

        public IndexUnderInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as IndexUnderInfoViewModel;

            this.IndexUnderListDataGrid_.ItemsSource = this.viewModel_.IndexUnderList_;

            //scheduleDataGrid_.ItemsSource = this.viewModel_.RedemptionEvents_;
            //this.PayoffStackPanel_.Children.Add(this.viewModel_.ReturnCalculationViewModel_.ReturnCalculationView_);
        }

        private void IndexUnderListDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

    }
}
