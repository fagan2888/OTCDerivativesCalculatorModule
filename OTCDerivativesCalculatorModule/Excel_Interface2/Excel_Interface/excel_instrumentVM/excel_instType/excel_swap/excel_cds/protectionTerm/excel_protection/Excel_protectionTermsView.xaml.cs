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
    /// Excel_protectionTermsView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_protectionTermsView : UserControl
    {
        #region ViewModel_
        private Excel_protectionTermsViewModel viewModel_;
        public Excel_protectionTermsViewModel ViewModel_
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

        public Excel_protectionTermsView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_protectionTermsViewModel;

            this.creditEventsGrid_.Children.Clear();
            this.creditEventsGrid_.Children.Add(this.viewModel_.Excel_creditEventsViewModel_.view());
        }
    }
}
