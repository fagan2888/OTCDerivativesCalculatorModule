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
    /// Excel_stepDownKICustomView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_stepDownKICustomView : UserControl
    {
        #region ViewModel_
        private Excel_stepDownKICustomViewModel viewModel_;
        public Excel_stepDownKICustomViewModel ViewModel_
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

        public Excel_stepDownKICustomView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e) 
        {
            this.viewModel_ = this.DataContext as Excel_stepDownKICustomViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.UnderlyingInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            this.StepDownKICustomGrid_.Children.Clear();
            this.StepDownKICustomGrid_.Children.Add(this.viewModel_.Excel_hifive_StepDownKI_ViewModel_.view());

            
        }

        public void clear()
        {
            this.IssueInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Clear();
            this.StepDownKICustomGrid_.Children.Clear();        
        }

    }
}
