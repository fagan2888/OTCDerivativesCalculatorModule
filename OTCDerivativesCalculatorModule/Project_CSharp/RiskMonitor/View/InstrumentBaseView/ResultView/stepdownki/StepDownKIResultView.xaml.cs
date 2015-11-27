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
    /// StepDownKIResultView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StepDownKIResultView : UserControl
    {
        #region ViewModel_
        private StepDownKIResultViewModel viewModel_;
        public StepDownKIResultViewModel ViewModel_
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

        public StepDownKIResultView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as StepDownKIResultViewModel;

            this.commonResultGrid_.Children.Add(this.viewModel_.CommonResultViewModel_.View_);
            this.underylingInfoGrid_.Children.Add(this.viewModel_.UnderylingInfoResultViewModel_.View_);

        }

    }
}
