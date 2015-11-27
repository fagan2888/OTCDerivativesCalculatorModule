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
    /// CreditDefaultSwapView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CreditDefaultSwapView : UserControl
    {
        #region ViewModel_
        private CreditDefaultSwapViewModel viewModel_;
        public CreditDefaultSwapViewModel ViewModel_
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

        public CreditDefaultSwapView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as CreditDefaultSwapViewModel;

            this.ProtectionGrid_.Children.Clear();
            this.ProtectionGrid_.Children.Add(this.viewModel_.ProtectionPartViewModel_.View_);

            this.CouponPartGrid_.Children.Clear();
            this.CouponPartGrid_.Children.Add(this.viewModel_.CouponPartViewModel_.View_);

        }

    }
}
