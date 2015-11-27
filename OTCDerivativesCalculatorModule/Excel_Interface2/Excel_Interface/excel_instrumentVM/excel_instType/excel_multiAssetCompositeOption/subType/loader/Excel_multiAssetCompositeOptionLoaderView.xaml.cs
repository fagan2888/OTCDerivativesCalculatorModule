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
    /// Excel_multiAssetCompositeOptionLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_multiAssetCompositeOptionLoaderView : UserControl
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

        public enum multiAssetCompositeOption_subtypeEnum
        {
            Multi_Vanilla_Call_Put,
            Multi_Up_InOut_Call,
            Multi_Down_InOut_Put,
            Multi_Digital_Call_Put
        };

        #region SelectedOptionTypeViewModel_
        private Excel_multiAsset_compositeOption_subtypeViewModel selectedOptionTypeViewModel_;
        public Excel_multiAsset_compositeOption_subtypeViewModel SelectedOptionTypeViewModel_
        {
            get { return this.selectedOptionTypeViewModel_; }
            set
            {
                if (this.selectedOptionTypeViewModel_ != value)
                {
                    this.selectedOptionTypeViewModel_ = value;

                    //this.selectedOptionTypeViewModel_.BaseUnderlyingValue_ =
                    //    this.baseUnderlyingValue_;

                    //this.selectedOptionGrid_.Children.Clear();
                    //this.selectedOptionGrid_.Children.Add(this.selectedOptionTypeViewModel_.view());

                    this.NotifyPropertyChanged("SelectedOptionTypeViewModel_");
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

        #region InterfaceViewModel_
        private Excel_multiAssetCompositeOptionViewModel interfaceViewModel_;
        public Excel_multiAssetCompositeOptionViewModel InterfaceViewModel_
        {
            get { return this.interfaceViewModel_; }
            set
            {
                if (this.interfaceViewModel_ != value)
                {
                    this.interfaceViewModel_ = value;
                    this.NotifyPropertyChanged("InterfaceViewModel_");
                }
            }
        }
        #endregion

        public Excel_multiAssetCompositeOptionLoaderView()
        {
            InitializeComponent();
            optionTypeCombBox_.ItemsSource = Enum.GetValues(typeof(multiAssetCompositeOption_subtypeEnum));

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            multiAssetCompositeOption_subtypeEnum? item = this.optionTypeCombBox_.SelectedItem as multiAssetCompositeOption_subtypeEnum?;
            string optionType = item.ToString();

            if (optionType.ToUpper() == "VANILLA CALL/PUT" || optionType.ToUpper() == "MULTI_VANILLA_CALL_PUT")
            {
                this.SelectedOptionTypeViewModel_ = new Excel_multiAsset_vanillaCallPutViewModel();
            }
            else if (optionType.ToUpper() == "UP IN/OUT CALL" || optionType.ToUpper() == "MULTI_UP_INOUT_CALL")
            {
                this.SelectedOptionTypeViewModel_ = new Excel_multiAsset_upInOutCallViewModel();
            }
            else if (optionType.ToUpper() == "DOWN IN/OUT PUT" || optionType.ToUpper() == "MULTI_DOWN_INOUT_PUT")
            {
                OutputLogViewModel.addResult("no exist optionType : " + optionType);
            }
            //else if (optionType.ToUpper() == "DIGITAL CALL/PUT" || optionType.ToUpper() == "Multi_Digital_Call_Put")
            //{
            //    this.selectedOptionTypeViewModel_ = new Excel_();
            //}
            else
            {
                OutputLogViewModel.addResult("no exist optionType : " + optionType);
            }

            this.selectedOptionTypeViewModel_.DefaultSetting(this.interfaceViewModel_);
            this.selectedOptionTypeViewModel_.setInterfaceViewModel(this.interfaceViewModel_);
            this.selectedOptionTypeViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.selectedOptionGrid_.Children.Clear();
            this.selectedOptionGrid_.Children.Add(this.selectedOptionTypeViewModel_.view());

        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            //this.selectedUnderlyingModelVM_ = this.detail_VM_;
            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }

        private void typeEditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void initialize(Excel_multiAsset_compositeOption_subtypeViewModel e_mcosvm)
        {
            this.optionTypeCombBox_.SelectedIndex = this.comboBoxNum(e_mcosvm.Excel_Type_);
            this.optionTypeCombBox_.SelectionChanged += new SelectionChangedEventHandler(ComboBox_SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedOptionTypeViewModel_ = e_mcosvm;
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_MULTI_VANILLACALLPUT")
            {
                return 0;
            }
            else if (type.ToUpper() == "EXCEL_MULTIASSET_UPINOUTCALL")
            {
                return 1;
            }
            else if (type.ToUpper() == "EXCEL_VANILLARETURNCAL")
            {
                return 2;
            }
            else if (type.ToUpper() == "EXCEL_DIGITALCALLPUT")
            {
                return 3;
            }

            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }
    }


}
