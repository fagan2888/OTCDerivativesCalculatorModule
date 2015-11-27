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
    /// Excel_couponScheduleLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_couponScheduleLoaderView : UserControl
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

        #region SelectedCouponScheduleTypeViewModel_
        private Excel_couponScheduleViewModel selectedCouponScheduleTypeViewModel_;
        public Excel_couponScheduleViewModel SelectedCouponScheduleTypeViewModel_
        {
            get { return this.selectedCouponScheduleTypeViewModel_; }
            set
            {
                if (this.selectedCouponScheduleTypeViewModel_ != value)
                {
                    this.selectedCouponScheduleTypeViewModel_ = value;

                    this.selectedCouponScheduleTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

                    this.selectedCouponScheduleGrid_.Children.Clear();
                    this.selectedCouponScheduleGrid_.Children.Add(this.selectedCouponScheduleTypeViewModel_.view());

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

        public Excel_couponScheduleLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = this.couponScheduleTypeCombBox_.SelectedItem as ComboBoxItem;
            string scheduleType = item.Content.ToString();

            if (scheduleType.ToUpper() == "FixedRate")
            {
                this.SelectedCouponScheduleTypeViewModel_ = new Excel_fixedCouponScheduleViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist scheduleType : " + scheduleType);
            }

            //this.selectedOptionTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.selectedCouponScheduleGrid_.Children.Clear();
            this.selectedCouponScheduleGrid_.Children.Add(this.SelectedCouponScheduleTypeViewModel_.view());
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_FIXEDCOUPONSCHEDULE")
            {
                return 0;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_couponScheduleViewModel e_csvm)
        {
            this.couponScheduleTypeCombBox_.SelectedIndex = this.comboBoxNum(e_csvm.Excel_type_);
            this.couponScheduleTypeCombBox_.SelectionChanged += new SelectionChangedEventHandler(ComboBox_SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedCouponScheduleTypeViewModel_ = e_csvm;
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
