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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    /// <summary>
    /// EventManagerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EventManagerView : UserControl
    {
        #region ViewModel_
        private Excel_eventManagerViewModel viewModel_;
        public Excel_eventManagerViewModel ViewModel_
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

        public EventManagerView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_eventManagerViewModel;
            this.EVENT_INFOListListView_.ItemsSource = this.viewModel_.EventVMList_;
        }

        public void refereshDataContext()
        {
            this.EVENT_INFOListListView_.ItemsSource = this.viewModel_.EventVMList_;
        }
    }
}
