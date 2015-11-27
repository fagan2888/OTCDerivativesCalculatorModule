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
    /// Fx_exchangeLegView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Fx_exchangeLegView : UserControl
    {
        

        #region ViewModel_
        private Fx_exchangeLegViewModel viewModel_;
        public Fx_exchangeLegViewModel ViewModel_
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

        

        public Fx_exchangeLegView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            #region ComboBox Initialize

            this.baseCurrencyCombo_.ItemsSource = ProgramVariable.CurrencyStringList_;
            this.targetCurrencyCombo_.ItemsSource = ProgramVariable.CurrencyStringList_;

            #endregion
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Fx_exchangeLegViewModel;
            this.bindingPanel_.DataContext = this.viewModel_;

            this.baseCurrencyCombo_.DataContext = this.viewModel_.BaseCurrency_;
            this.targetCurrencyCombo_.DataContext = this.viewModel_.TargetCurrency_;

            //this.currencyCombo_.DataContext = this.viewModel_.Currency_;

            //this.underlyingCombo_.DataContext = this.viewModel_.Underlying_type_;
            //this.contractCombo_.DataContext = this.viewModel_.Contract_type_;
            //this.contractSubCombo_.DataContext = this.viewModel_.Contract_subtype_;

            //this.Contract_detail_type_Combo_.SelectedItem_.Copy(this.viewModel_.Contract_detail_type_);
            //this.Contract_detail_type_Combo_.refreshComboBox();


        }

        public void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            //if (e.PropertyName == "MaturityDate_")
            //{
            //    this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;
            //}
            //else if (e.PropertyName == "BaseNotional_")
            //{
            //    this.notio.Text = this.viewModel_.Notional_.ToString();
            //}
            //else if (e.PropertyName == "BaseCurrency_")
            //{
            //    this.notionalTextBox_.Text = this.viewModel_.Notional_.ToString();
            //}
            //else if (e.PropertyName == "TargetNotional_")
            //{
            //    this.notionalTextBox_.Text = this.viewModel_.Notional_.ToString();
            //}
            //else if (e.PropertyName == "TargetCurrency_")
            //{
            //    this.notionalTextBox_.Text = this.viewModel_.Notional_.ToString();
            //}


            //this.DataContext = null;
            //this.DataContext = this.viewModel_;

            //this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;

        }

    }
}
