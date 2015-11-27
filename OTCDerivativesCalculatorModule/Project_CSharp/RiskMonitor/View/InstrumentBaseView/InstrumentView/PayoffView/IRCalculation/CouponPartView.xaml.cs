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
    /// CouponPartView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CouponPartView : UserControl
    {
        #region ViewModel_
        private CouponPartViewModel viewModel_;
        public CouponPartViewModel ViewModel_
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

        public CouponPartView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as CouponPartViewModel;

            this.SwapStreamGrid_.Children.Clear();
            this.SwapStreamGrid_.Children.Add(this.viewModel_.SwapStreamViewModel_.View_);

        }

    }
}
