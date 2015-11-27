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
    /// Excel_underlyingCalcIDLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingCalcIDLoaderView : UserControl
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

        public enum underCalcIDTypeEnum
        {
            MAXIMUM,
            MINIMUM,
            AVERAGE,
            CHOICE
        };

        #region SelectedUnderCalcIDTypeViewModel_ 
		private Excel_underlyingCalcIDViewModel selectedUnderCalcIDTypeViewModel_;
		public Excel_underlyingCalcIDViewModel SelectedUnderCalcIDTypeViewModel_ 
		{ 
			get { return this.selectedUnderCalcIDTypeViewModel_; }
			set
			{
			if (this.selectedUnderCalcIDTypeViewModel_ != value)
			{
				this.selectedUnderCalcIDTypeViewModel_ = value;

                //this.selectedUnderCalcIDGrid_.Children.Clear();
                //this.selectedUnderCalcIDGrid_.Children.Add(this.selectedUnderCalcIDTypeViewModel_.view());

				this.NotifyPropertyChanged("SelectedUnderCalcIDTypeViewModel_");
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

        public Excel_underlyingCalcIDLoaderView()
        {
            InitializeComponent();
            underCalcIDTypeCombBox_.ItemsSource = Enum.GetValues(typeof(underCalcIDTypeEnum));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            underCalcIDTypeEnum? item = this.underCalcIDTypeCombBox_.SelectedItem as underCalcIDTypeEnum?;
            string underType = item.ToString();

            if (underType.ToUpper() == "MAXIMUM")
            {
                this.SelectedUnderCalcIDTypeViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();
            }
            else if (underType.ToUpper() == "MINIMUM")
            {
                this.SelectedUnderCalcIDTypeViewModel_ = new Excel_minimumUnderlyingCalcIDViewModel();
            }
            else if (underType.ToUpper() == "AVERAGE")
            {
                this.SelectedUnderCalcIDTypeViewModel_ = new Excel_averageUnderlyingCalcIDViewModel();
            }
            else if (underType.ToUpper() == "CHOICE")
            {
                this.SelectedUnderCalcIDTypeViewModel_ = new Excel_choiceUnderlyingCalcIDViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist underType : " + underType);
            }

            //// 이거 위로 prop 안으로 집어넣어야하나..?  ㅇㅇ 집어 넣었음 , 다시뺌
            this.selectedUnderCalcIDTypeViewModel_.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

            this.selectedUnderCalcIDGrid_.Children.Clear();
            this.selectedUnderCalcIDGrid_.Children.Add(this.selectedUnderCalcIDTypeViewModel_.view());
        
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_MAXIMUMUNDERLYINGCALCID")
            {
                return 0;
            }
            else if (type.ToUpper() == "EXCEL_MINIMUMUNDERLYINGCALCID")
            {
                return 1;
            }
            else if (type.ToUpper() == "EXCEL_AVERAGEUNDERLYINGCALCID")
            {
                return 2;
            }
            else if (type.ToUpper() == "EXCEL_CHOICEUNDERLYINGCALCID")
            {
                return 3;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_underlyingCalcIDViewModel e_ucidvm)
        {
            this.underCalcIDTypeCombBox_.SelectedIndex = this.comboBoxNum(e_ucidvm.Excel_type_);
            this.underCalcIDTypeCombBox_.SelectionChanged += new SelectionChangedEventHandler(ComboBox_SelectionChanged);
            
            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedUnderCalcIDTypeViewModel_ = e_ucidvm;
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


        
    }
}
