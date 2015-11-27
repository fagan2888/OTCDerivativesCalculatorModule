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
    /// OTCApplication.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OTCApplication : UserControl
    {
        #region ViewModel_
        private OTCApplicationViewModel viewModel_;
        public OTCApplicationViewModel ViewModel_
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

        public OTCApplication()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as OTCApplicationViewModel;

            this.BookManagerGrid_.Children.Clear();
            this.BookManagerGrid_.Children.Add(this.viewModel_.ApplicationTab_BookViewModel_.View_);

            this.EventManagerGrid_.Children.Clear();
            this.EventManagerGrid_.Children.Add(this.viewModel_.ApplicationTab_EventViewModel_.View_);

            this.BatchManagerGrid_.Children.Clear();
            this.BatchManagerGrid_.Children.Add(this.viewModel_.ApplicationTab_BatchViewModel_.view());
            //this.ISDAManagerGrid_.Children.Clear();
            //this.ISDAManagerGrid_.Children.Add(this.viewModel_.ApplicationTab_EventViewModel_.View_);
        }
    }
}
