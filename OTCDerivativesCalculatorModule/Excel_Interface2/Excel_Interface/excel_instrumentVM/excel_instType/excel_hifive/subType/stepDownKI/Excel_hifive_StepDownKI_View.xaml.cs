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
    /// Excel_hifive_StepDownKI_View.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_hifive_StepDownKI_View : UserControl
    {
        #region ViewModel_
        private Excel_hifive_stepDown_kiViewModel viewModel_;
        public Excel_hifive_stepDown_kiViewModel ViewModel_
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

        public Excel_hifive_StepDownKI_View()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_hifive_stepDown_kiViewModel;

            this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);

            this.ScheduleDataGrid_.ItemsSource = viewModel_.SubScheduleDataList_;

            GenInformationPanel_.DataContext = this.viewModel_;

            //EffectiveDatePicker_.DataContext = this.viewModel_;

        }

        private void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DateTime d = this.viewModel_.EffectiveDate_;
            //EffectiveDatePicker_.SelectedDate = d;

        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        //private void ScheduleGen_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.viewModel_.scheduleDataGenerate();
        //}

        //private void MakeProduct_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.viewModel_.buildProduct();
        //    ((Window)this.Parent).DialogResult = true;
        //    ((Window)this.Parent).Close();

        //}

        //private void cancelButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ((Window)this.Parent).DialogResult = false;
        //    ((Window)this.Parent).Close();
        //}

        //private void TenorRadioBtnChecked(object sender, RoutedEventArgs e)
        //{
        //    var btn = sender as RadioButton;

        //    this.viewModel_.CouponTenorPeriod_ = btn.Content.ToString();

        //}

        //private void MaturityRadioBtnChecked(object sender, RoutedEventArgs e)
        //{
        //    var btn = sender as RadioButton;

        //    this.viewModel_.MaturityPeriod_ = btn.Content.ToString();
        //}

        private void underCalcTypeComboBox__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            this.viewModel_.UnderlyingCalcType_ = cb.SelectedValue.ToString();
        }

        //private void underCalcTypeComboBox__Initialized(object sender, EventArgs e)
        //{
        //    this.underCalcTypeComboBox_.Items.Add("Maximum");
        //    this.underCalcTypeComboBox_.Items.Add("Minimum");
        //    this.underCalcTypeComboBox_.Items.Add("Average");
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void productStringSetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel_.scheduleDataGenerate();

            //if (this.ViewModel_.MaturityPeriod_ == "M")
            //{ this.maturityRadioBtn_M.IsChecked = true; }
            //else if (this.ViewModel_.MaturityPeriod_ == "Y")
            //{ this.maturityRadioBtn_Y.IsChecked = true; }
            //else
            //{ throw new Exception("unknown period"); }

            //if (this.ViewModel_.MaturityPeriod_ == "M")
            //{ this.tenorRadioBtn_M.IsChecked = true; }
            //else if (this.ViewModel_.MaturityPeriod_ == "Y")
            //{ this.tenorRadioBtn_Y.IsChecked = true; }
            //else
            //{ throw new Exception("unknown period"); }

            //this.ViewModel_.
        }

        private void ScheduleSettingButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            ScheduleGeneratorViewModel sgvm = new ScheduleGeneratorViewModel();

            w.Content = sgvm.view();

            if (w.ShowDialog() == true)
            {
                this.viewModel_.ScheduleGeneratorVM_ = sgvm;
            }
            else
            {

            }
        }

        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_calendarLoaderViewModel e_clvm = new Excel_calendarLoaderViewModel();

            w.Content = e_clvm.view();

            if (w.ShowDialog() == true)
            {
                this.viewModel_.Excel_calendarViewModel_ = e_clvm.getCalendar();
                this.calendarStr_.Text = this.viewModel_.Excel_calendarViewModel_.description();
            }
            else
            {

            }
        }





    }
}
