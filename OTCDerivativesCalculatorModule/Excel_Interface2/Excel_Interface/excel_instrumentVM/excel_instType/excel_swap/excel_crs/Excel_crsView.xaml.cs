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
    /// Excel_crsView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_crsView : UserControl
    {
        #region ViewModel_
        private Excel_crsViewModel viewModel_;
        public Excel_crsViewModel ViewModel_
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

        public Excel_crsView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_crsViewModel;

            //this.FxExchangeGrid_.Children.Clear();
            //this.FxExchangeGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.swapLegFirstGrid_.Children.Clear();
            this.swapLegFirstGrid_.Children.Add(this.viewModel_.Excel_swapLegViewModel_[0].view());

            this.swapLegSecondGrid_.Children.Clear();
            this.swapLegSecondGrid_.Children.Add(this.viewModel_.Excel_swapLegViewModel_[1].view());
        }
    }
}
