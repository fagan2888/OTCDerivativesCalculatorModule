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
    /// InstPositionInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InstPositionInfoView : UserControl
    {
        #region ViewModel_
        private InstPositionInfoViewModel viewModel_;
        public InstPositionInfoViewModel ViewModel_
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

        public InstPositionInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }
        
        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.ViewModel_ = this.DataContext as InstPositionInfoViewModel;
            this.mainPanel_.DataContext = this.viewModel_;
        }

    }
}
