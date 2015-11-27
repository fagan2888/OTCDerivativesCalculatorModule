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
    /// StandardInstView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StandardInstView : UserControl
    {
        #region ViewModel_
        private StandardInstViewModel viewModel_;
        public StandardInstViewModel ViewModel_
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

        public StandardInstView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as StandardInstViewModel;

            this.InformationGrid_.Children.Clear();
            this.UnderlyingGrid_.Children.Clear();
            this.PayoffGrid_.Children.Clear();

            this.InformationGrid_.Children.Add(this.viewModel_.IssueInfoViewModel_.View_);
            this.UnderlyingGrid_.Children.Add(this.viewModel_.UnderlyingViewModel_.View_);
            this.PayoffGrid_.Children.Add(this.viewModel_.PayoffViewModel_.View_);

        }

        
    }
}
