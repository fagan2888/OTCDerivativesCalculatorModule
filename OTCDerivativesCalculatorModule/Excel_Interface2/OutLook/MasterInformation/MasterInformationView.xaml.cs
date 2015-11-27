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
    /// MasterInformationView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MasterInformationView : UserControl
    {
        #region ViewModel_
        private MasterInformationViewModel viewModel_;
        public MasterInformationViewModel ViewModel_
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

        public MasterInformationView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            #region ComboBox Initialize

            this.currencyCombo_.ItemsSource = ProgramVariable.CurrencyStringList_;
            this.underlyingCombo_.ItemsSource = ProgramVariable.UnderlyingComboDisplayStrList_;

            //this.underlyingDetailCombo_.ItemsSource = ProgramVariable.UnderlyingDetailComboDisplayStrList_;
            this.contractCombo_.ItemsSource = ProgramVariable.ContractComboDisplayStrList_;
            this.contractSubCombo_.ItemsSource = ProgramVariable.ContractSubComboDisplayStrList_;
            //this.contractDetailCombo_.ItemsSource = ProgramVariable.ContractDetailComboDisplayStrList_;

            #endregion
            
        }

        private BookingMode bookingMode_;

        public void bookingModeSetting(BookingMode mode)
        {
            this.bookingMode_ = mode;

            if (mode == BookingMode.Booking)
            {
                this.item_nameTxb_.IsReadOnly = false;
                this.item_nameTxb_.Foreground = Brushes.Black;
                this.notionalTxb_.IsReadOnly = false;
                this.notionalTxb_.Foreground = Brushes.Black;
                this.remainNotionalTxb_.IsReadOnly = true;
                this.remainNotionalTxb_.Foreground = Brushes.Gray;

            }
            else
            {
                this.item_nameTxb_.IsReadOnly = true;
                this.item_nameTxb_.Foreground = Brushes.Gray;
                this.notionalTxb_.IsReadOnly = true;
                this.notionalTxb_.Foreground = Brushes.Gray;
                this.remainNotionalTxb_.IsReadOnly = false;
                this.remainNotionalTxb_.Foreground = Brushes.Black;
            }
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as MasterInformationViewModel;
            this.bindingPanel_.DataContext = this.viewModel_;

            this.currencyCombo_.DataContext = this.viewModel_.Currency_;

            this.underlyingCombo_.DataContext = this.viewModel_.Underlying_type_;
            this.contractCombo_.DataContext = this.viewModel_.Contract_type_;
            this.contractSubCombo_.DataContext = this.viewModel_.Contract_subtype_;

            //this.Contract_detail_type_Combo_.SelectedItem_.Copy(this.viewModel_.Contract_detail_type_);
            //this.Contract_detail_type_Combo_.refreshComboBox();


        }

        private string selectedYM_ ;

        private void MaturityRadioBtnChecked(object sender, RoutedEventArgs e)
        {
            
            var btn = sender as RadioButton;

            string ym = btn.Content.ToString();
            selectedYM_ = ym;

            try
            {
                double ymAdd_F = Convert.ToDouble(this.ymTextBox_.Text);

                if (ym == "Y")
                {
                    double convDays = ymAdd_F * 365;
                    int convDaysInt = Convert.ToInt32(convDays);

                    //maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddYears(ymAdd); 
                    maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddDays(convDaysInt);

                    //this.viewModel_.MaturityDate_ = this.viewModel_.TradeDate_.AddYears(ymAdd); 
                }
                else if (ym == "M")
                {
                    double convMonths = ymAdd_F * 30.5;
                    int convMonthsInt = Convert.ToInt32(convMonths);

                    //maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddMonths(ymAdd);
                    maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddDays(convMonthsInt);
                }
                else
                {

                }
            }
            catch (Exception)
            {

                return;
            }


        }

        private void ymTextBox__TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //int ymAdd = Convert.ToInt32(this.ymTextBox_.Text);
                double ymAdd_F = Convert.ToDouble(this.ymTextBox_.Text);

                if (selectedYM_ == "Y")
                {
                    double convDays = ymAdd_F * 365;
                    int convDaysInt = Convert.ToInt32(convDays);

                    maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddDays(convDaysInt);
                    //this.viewModel_.MaturityDate_ = this.viewModel_.TradeDate_.AddYears(ymAdd); 
                }
                else if (selectedYM_ == "M")
                {
                    double convMonths = ymAdd_F * 30.5;
                    int convMonthsInt = Convert.ToInt32(convMonths);

                    maturityDatePicker_.SelectedDate = this.viewModel_.Trade_date_.AddDays(convMonthsInt);
                    //this.viewModel_.MaturityDate_ = this.viewModel_.TradeDate_.AddMonths(ymAdd);
                }
                else
                {

                }
            }
            catch (Exception)
            {
                
            }

        }

        private void counterPartyEdit_Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 400;
            w.Height = 300;

            CounterPartyLoaderView cplv = new CounterPartyLoaderView();

            w.Content = cplv;

            w.Visibility = 0;

            // booking button 눌리면
            if (w.ShowDialog() == true)
            {
                this.viewModel_.Counterparty_
                    = cplv.SelectedCounterParty_;
            }
            else
            {

            }
        }

        private void setExportItemCodeButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.setExportCode();
        }

        private void setContractDetailButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //booking 시 remainNotional link event
        private void notionalTxb__TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.bookingMode_ == BookingMode.Booking)
            {
                this.remainNotionalTxb_.Text = this.notionalTxb_.Text;
            }
        }

        private void currencyCombo__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = this.currencyCombo_.SelectedIndex;

            this.viewModel_.Currency_ = ProgramVariable.CurrencyStringList_[index].Clone();

            this.currencyCombo_.DataContext = this.viewModel_.Currency_;

        }

        
    }
}
