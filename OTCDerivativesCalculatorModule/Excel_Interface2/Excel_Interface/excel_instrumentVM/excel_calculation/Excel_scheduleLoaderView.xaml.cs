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
    /// Excel_scheduleLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_scheduleLoaderView : UserControl
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region SelectedScheduleTypeViewModel_
        private Excel_scheduleViewModel selectedScheduleTypeViewModel_;
        public Excel_scheduleViewModel SelectedScheduleTypeViewModel_
        {
            get { return this.selectedScheduleTypeViewModel_; }
            set
            {
                if (this.selectedScheduleTypeViewModel_ != value)
                {
                    this.selectedScheduleTypeViewModel_ = value;

                    this.selectedScheduleTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

                    this.selectedScheduleGrid_.Children.Clear();
                    this.selectedScheduleGrid_.Children.Add(this.selectedScheduleTypeViewModel_.view());

                    this.NotifyPropertyChanged("SelectedScheduleTypeViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingCalcInfoViewModel_
        private Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { return this.excel_underlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion

        public Excel_scheduleLoaderView()
        {
            InitializeComponent();
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = this.scheduleTypeCombBox_.SelectedItem as ComboBoxItem;
            string scheduleType = item.Content.ToString();

            if (scheduleType.ToUpper() == "SIMPLE CALCULATION")
            {
                this.SelectedScheduleTypeViewModel_ = new Excel_simpleCalculationViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist scheduleType : " + scheduleType);
            }

            //this.selectedOptionTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.selectedScheduleGrid_.Children.Clear();
            this.selectedScheduleGrid_.Children.Add(this.SelectedScheduleTypeViewModel_.view());        
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_SIMPLECALCULATION")
            {
                return 0;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_scheduleViewModel e_svm)
        {
            this.scheduleTypeCombBox_.SelectedIndex = this.comboBoxNum(e_svm.Excel_type_);
            this.scheduleTypeCombBox_.SelectionChanged += new SelectionChangedEventHandler(ComboBox_SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedScheduleTypeViewModel_ = e_svm;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();
        }



    }
}
