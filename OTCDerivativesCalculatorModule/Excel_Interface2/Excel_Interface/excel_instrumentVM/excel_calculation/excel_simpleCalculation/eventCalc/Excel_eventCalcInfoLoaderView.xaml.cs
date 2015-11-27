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
    /// Excel_eventCalcInfoLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_eventCalcInfoLoaderView : UserControl
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

        #region SelectedEventTypeViewModel_
        private Excel_eventCalcInfoViewModel selectedEventTypeViewModel_;
        public Excel_eventCalcInfoViewModel SelectedEventTypeViewModel_
        {
            get { return this.selectedEventTypeViewModel_; }
            set
            {
                if (this.selectedEventTypeViewModel_ != value)
                {
                    this.selectedEventTypeViewModel_ = value;

                    //this.selectedEventTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

                    //this.selectedOptionTypeViewModel_.BaseUnderlyingValue_ =
                    //    this.baseUnderlyingValue_;

                    //this.selectedEventGrid_.Children.Clear();
                    //this.selectedEventGrid_.Children.Add(this.selectedEventTypeViewModel_.view());

                    this.NotifyPropertyChanged("SelectedEventTypeViewModel_");
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

        public Excel_eventCalcInfoLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void eventTypeCombo__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = this.eventTypeCombo_.SelectedItem as ComboBoxItem;
            string scheduleType = item.Content.ToString();

            if (scheduleType.ToUpper() == "SINGLE RANGE")
            {
                this.SelectedEventTypeViewModel_ = new Excel_singleRangeEventCalViewModel();
            }
            else if (scheduleType.ToUpper() == "SINGLE BARRIER")
            {
                this.SelectedEventTypeViewModel_ = new Excel_singleBarrierEventCalViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist scheduleType : " + scheduleType);
            }

            this.SelectedEventTypeViewModel_.defaultSetting();
            this.SelectedEventTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.selectedEventGrid_.Children.Clear();
            this.selectedEventGrid_.Children.Add(this.SelectedEventTypeViewModel_.view());

        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_SINGLERANGEEVENTCAL")
            {
                return 0;
            }
            else if (type.ToUpper() == "EXCEL_SINGLEBARRIEREVENTCAL")
            {
                return 1;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_eventCalcInfoViewModel e_ecaivm)
        {
            this.eventTypeCombo_.SelectedIndex = this.comboBoxNum(e_ecaivm.Excel_type_);
            this.eventTypeCombo_.SelectionChanged += new SelectionChangedEventHandler(eventTypeCombo__SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedEventTypeViewModel_ = e_ecaivm;
        }


    }
}
