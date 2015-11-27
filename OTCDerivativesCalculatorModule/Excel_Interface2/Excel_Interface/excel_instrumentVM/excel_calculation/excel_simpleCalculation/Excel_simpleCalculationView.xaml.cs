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
    /// Excel_simpleCalculationView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_simpleCalculationView : UserControl
    {
        #region ViewModel_
        private Excel_simpleCalculationViewModel viewModel_;
        public Excel_simpleCalculationViewModel ViewModel_
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

        public Excel_simpleCalculationView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_simpleCalculationViewModel;

            this.eventCalGrid_.Children.Clear();
            this.eventCalGrid_.Children.Add(this.viewModel_.Excel_eventCalcInfoViewModel_.loaderView());

            this.returnCalGrid_.Children.Clear();
            this.returnCalGrid_.Children.Add(this.viewModel_.Excel_returnCalcInfoViewModel_.loaderView());

            this.compReturnCalGrid_.Children.Clear();
            this.compReturnCalGrid_.Children.Add(this.viewModel_.Excel_complementReturnCalcViewModel_.loaderView());

            this.eventCalCallGrid_.Children.Clear();
            this.eventCalCallGrid_.Children.Add(this.viewModel_.Excel_eventCalcInfo_CallViewModel_.loaderView());

            this.returnCalCallGrid_.Children.Clear();
            this.returnCalCallGrid_.Children.Add(this.viewModel_.Excel_returnCalcInfo_CallViewModel_.loaderView());

        }

    }
}
