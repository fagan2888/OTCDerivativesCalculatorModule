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
    /// Excel_generalView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_generalView : UserControl
    {
        #region ViewModel_
        private Excel_generalViewModel viewModel_;
        public Excel_generalViewModel ViewModel_
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

        public Excel_generalView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_generalViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.UnderlyingInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            this.generalScheduleGrid_.Children.Clear();
            this.generalScheduleGrid_.Children.Add(this.viewModel_.GeneralScheduleInfoViewModel_.view());

            this.generalTerminationEventGrid_.Children.Clear();
            this.generalTerminationEventGrid_.Children.Add(this.viewModel_.GeneralTerminationEventInfoViewModel_.view());

        }
    }
}
