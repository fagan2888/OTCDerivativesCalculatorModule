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
    /// Excel_noteInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_noteInfoView : UserControl
    {
        #region ViewModel_
        private Excel_noteInfoViewModel viewModel_;
        public Excel_noteInfoViewModel ViewModel_
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

        public Excel_noteInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
            
            this.currencyCombo_.ItemsSource = ProgramVariable.CurrencyStringList_;
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_noteInfoViewModel;
            this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);
            
            this.bindingPanel_.DataContext = this.viewModel_;

            this.currencyCombo_.DataContext = this.viewModel_.Currency_;
        }

        private void MaturityDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.MaturityYearTB_.Text = (Math.Round(this.viewModel_.MaturityYear_,2)).ToString();
        }

        private void MaturityYearTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            //double maturityYear = this.viewModel_.MaturityYear_;

            //TextBox tb = sender as TextBox;
            //double maturityYear = Convert.ToDouble(tb.Text);
            //DateTime d = this.viewModel_.EffectiveDate_;
            //this.MaturityDatePicker_.SelectedDate = d.AddDays(maturityYear * 365);
            
            //this.viewModel_.MaturityDate_ = d.AddDays(maturityYear * 365);

            //= this.viewModel_.MaturityDate_;
        }

        public void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "MaturityDate_")
            {
                this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;
            }
            else if (e.PropertyName == "Notional_")
            {
                this.notionalTextBox_.Text = this.viewModel_.Notional_.ToString();
            }
            else if (e.PropertyName == "Currency_")
            {
                this.currencyCombo_.DataContext = this.viewModel_.Currency_;
            }

            
            //this.DataContext = null;
            //this.DataContext = this.viewModel_;
            
           //this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;
            
        }

        
        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

    }
}
