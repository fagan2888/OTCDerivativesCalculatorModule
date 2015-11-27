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
    /// StepDownKI_paraView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StepDownKI_paraView : UserControl
    {
        #region ViewModel_
        private StepDownKI_paraViewModel viewModel_;
        public StepDownKI_paraViewModel ViewModel_
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

        public StepDownKI_paraView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as StepDownKI_paraViewModel;

            this.notionalGrid_.Children.Add(this.viewModel_.CalculationAmountViewModel_.View_);
            this.underlyingGrid_.Children.Add(this.viewModel_.UnderlyingInfo_paraViewModel_.View_);
            this.discountCurveGrid_.Children.Add(this.viewModel_.DiscountCurve_paraViewModel_.View_);

        }

    }
}
