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
    /// Excel_fxSwapView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_fxSwapView : UserControl
    {
        #region ViewModel_
        private Excel_fxSwapViewModel viewModel_;
        public Excel_fxSwapViewModel ViewModel_
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

        public Excel_fxSwapView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_fxSwapViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.FxExchangeLegFirstGrid_.Children.Clear();
            this.FxExchangeLegFirstGrid_.Children.Add(this.viewModel_.Fx_exchangeLegViewModel_[0].view());

            this.FxExchangeLegSecondGrid_.Children.Clear();
            this.FxExchangeLegSecondGrid_.Children.Add(this.viewModel_.Fx_exchangeLegViewModel_[1].view());
        }
    }
}
