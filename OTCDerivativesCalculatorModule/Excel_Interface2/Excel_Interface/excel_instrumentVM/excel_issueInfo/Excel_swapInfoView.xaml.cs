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
    /// Excel_swapInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_swapInfoView : UserControl
    {
        #region ViewModel_
        private Excel_swapInfoViewModel viewModel_;
        public Excel_swapInfoViewModel ViewModel_
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

        public Excel_swapInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_swapInfoViewModel;
            this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);

            this.bindingPanel_.DataContext = this.viewModel_;

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

            //this.DataContext = null;
            //this.DataContext = this.viewModel_;

            //this.MaturityDatePicker_.SelectedDate = this.viewModel_.MaturityDate_;

        }


        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}
    }
}
