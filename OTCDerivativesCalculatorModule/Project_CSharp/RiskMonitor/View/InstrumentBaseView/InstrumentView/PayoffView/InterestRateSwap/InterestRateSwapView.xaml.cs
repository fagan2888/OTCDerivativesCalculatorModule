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
    /// InterestRateSwapView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InterestRateSwapView : UserControl
    {
        #region ViewModel_
        private InterestRateSwapViewModel viewModel_;
        public InterestRateSwapViewModel ViewModel_
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

        public InterestRateSwapView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as InterestRateSwapViewModel;

            this.CouponPartGrid1_.Children.Clear();
            this.CouponPartGrid1_.Children.Add(this.viewModel_.CouponPartViewModel_[0].View_);

            this.CouponPartGrid2_.Children.Clear();
            this.CouponPartGrid2_.Children.Add(this.viewModel_.CouponPartViewModel_[1].View_);
        }

    }
}
