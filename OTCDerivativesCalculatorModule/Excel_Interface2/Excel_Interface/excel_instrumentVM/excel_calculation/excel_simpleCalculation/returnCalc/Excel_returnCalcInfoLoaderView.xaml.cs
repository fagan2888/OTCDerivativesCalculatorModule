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
    /// Excel_returnCalcInfoLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_returnCalcInfoLoaderView : UserControl
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

        #region SelectedReturnTypeViewModel_
        private Excel_returnCalcInfoViewModel selectedReturnTypeViewModel_;
        public Excel_returnCalcInfoViewModel SelectedReturnTypeViewModel_
        {
            get { return this.selectedReturnTypeViewModel_; }
            set
            {
                if (this.selectedReturnTypeViewModel_ != value)
                {
                    this.selectedReturnTypeViewModel_ = value;

                    ////this.selectedReturnTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

                    ////this.selectedOptionTypeViewModel_.BaseUnderlyingValue_ =
                    ////    this.baseUnderlyingValue_;

                    //this.returnCalGrid_.Children.Clear();
                    //this.returnCalGrid_.Children.Add(this.selectedReturnTypeViewModel_.view());

                    this.NotifyPropertyChanged("SelectedReturnTypeViewModel_");
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

        public Excel_returnCalcInfoLoaderView()
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
            ComboBoxItem item = this.returnTypeCombo_.SelectedItem as ComboBoxItem;
            string scheduleType = item.Content.ToString();

            if (scheduleType.ToUpper() == "CONSTANT")
            {
                this.SelectedReturnTypeViewModel_ = new Excel_constReturnCalViewModel();
            }
            else if (scheduleType.ToUpper() == "VANILLA")
            {
                this.SelectedReturnTypeViewModel_ = new Excel_vanillaReturnCalViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist scheduleType : " + scheduleType);
            }

            this.SelectedReturnTypeViewModel_.defaultSetting();
            this.SelectedReturnTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.returnCalGrid_.Children.Clear();
            this.returnCalGrid_.Children.Add(this.SelectedReturnTypeViewModel_.view());
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_CONSTRETURNCAL")
            {
                return 0;
            }
            else if (type.ToUpper() == "EXCEL_VANILLARETURNCAL")
            {
                return 1;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_returnCalcInfoViewModel e_rcaivm)
        {
            this.returnTypeCombo_.SelectedIndex = this.comboBoxNum(e_rcaivm.Excel_type_);
            this.returnTypeCombo_.SelectionChanged += new SelectionChangedEventHandler(eventTypeCombo__SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedReturnTypeViewModel_ = e_rcaivm;
        }
    }
}
