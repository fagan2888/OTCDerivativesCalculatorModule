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
    /// Excel_swapLegInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_swapLegInfoView : UserControl
    {
        #region ViewModel_
        private Excel_swapLegInfoViewModel viewModel_;
        public Excel_swapLegInfoViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.bindingPanel_.DataContext = this.viewModel_;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public Excel_swapLegInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            this.currencyCombo_.ItemsSource = ProgramVariable.CurrencyStringList_;
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_swapLegInfoViewModel;
            this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);

            this.bindingPanel_.DataContext = this.viewModel_;

            this.currencyCombo_.DataContext = this.viewModel_.Currency_;
        }

        public void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Currency_")
            {
                this.currencyCombo_.DataContext = this.viewModel_.Currency_;
            }
            else if (e.PropertyName == "Notional_")
            {
                this.notionalTextBox_.Text = this.viewModel_.Notional_.ToString();
            }

            //this.DataContext = null;
            //this.DataContext = this.viewModel_;

            //this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;

        }

    }
}
