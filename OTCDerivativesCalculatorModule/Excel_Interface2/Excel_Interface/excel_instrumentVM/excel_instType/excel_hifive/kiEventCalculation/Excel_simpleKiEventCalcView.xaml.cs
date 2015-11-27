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
    /// Excel_simpleKiEventCalcView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_simpleKiEventCalcView : UserControl
    {
        #region ViewModel_
        private Excel_simpleKiEventCalcViewModel viewModel_;
        public Excel_simpleKiEventCalcViewModel ViewModel_
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

        public Excel_simpleKiEventCalcView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_simpleKiEventCalcViewModel;

            this.EventGrid_.Children.Clear();
            this.EventGrid_.Children.Add(this.viewModel_.Excel_eventCalcInfoViewModel_.loaderView());

            this.OccReturnGrid_.Children.Clear();
            this.OccReturnGrid_.Children.Add(this.viewModel_.Excel_occReturnCalcInfoViewModel_.loaderView());

            this.noOccReturnGrid_.Children.Clear();
            this.noOccReturnGrid_.Children.Add(this.viewModel_.Excel_noOccReturnCalcInfoViewModel_.loaderView());

        }
    }
}
