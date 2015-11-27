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
    /// Excel_kiEventCalculationLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_kiEventCalculationLoaderView : UserControl
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

        // combo를 통해 선택되는 것들.
        #region SelectedViewModel_
        private Excel_kiEventCalculationViewModel selectedViewModel_;
        public Excel_kiEventCalculationViewModel SelectedViewModel_
        {
            get { return this.selectedViewModel_; }
            set
            {
                if (this.selectedViewModel_ != value)
                {
                    this.selectedViewModel_ = value;

                    //this.selectedViewModel_.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                    //this.selectedKICalcGrid_.Children.Clear();
                    //this.selectedKICalcGrid_.Children.Add(this.selectedViewModel_.view());

                    //this.NotifyPropertyChanged("SelectedViewModel_");
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

        // 저장용은... 우선 필요 없어보이는데...? ㅡ.ㅡ;;
        #region SavedViewModel_
        private Excel_kiEventCalculationViewModel savedViewModel_;
        public Excel_kiEventCalculationViewModel SavedViewModel_
        {
            get { return this.savedViewModel_; }
            set
            {
                if (this.savedViewModel_ != value)
                {
                    this.savedViewModel_ = value;
                    //this.NotifyPropertyChanged("SavedViewModel_");
                }
            }
        }
        #endregion

        public Excel_kiEventCalculationLoaderView()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = this.kiCalcTypeCombBox_.SelectedItem as ComboBoxItem;
            string underType = item.Content.ToString();

            if (underType.ToUpper() == "SIMPLE KI")
            {
                this.SelectedViewModel_ = new Excel_simpleKiEventCalcViewModel();
            }
            else if (underType.ToUpper() == "DUAL KI")
            {
                this.SelectedViewModel_ = new Excel_dualKiEventCalcViewModel();
            }
            else if (underType.ToUpper() == "TARGET KI")
            {
                this.SelectedViewModel_ = new Excel_targetKiEventCalcViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("no exist underType : " + underType);
            }

            //// 이거 위로 prop 안으로 집어넣어야하나..?  ㅇㅇ 집어 넣었음
            this.SelectedViewModel_.defaultSetting();
            this.SelectedViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            this.selectedKICalcGrid_.Children.Clear();
            this.selectedKICalcGrid_.Children.Add(this.SelectedViewModel_.view());
        }

        private int comboBoxNum(string type)
        {
            if (type.ToUpper() == "EXCEL_SIMPLEKIEVENTCALC")
            {
                return 0;
            }
            else if (type.ToUpper() == "EXCEL_DUALKIEVENTCALC")
            {
                return 1;
            }
            else if (type.ToUpper() == "EXCEL_TARGETKIEVENTCALC")
            {
                return 2;
            }
            else
            {
                // 못찾아서 미선택함
                return -1;
            }
        }

        public void initialize(Excel_kiEventCalculationViewModel e_kevcvm)
        {
            this.kiCalcTypeCombBox_.SelectedIndex = this.comboBoxNum(e_kevcvm.Excel_Type_);
            this.kiCalcTypeCombBox_.SelectionChanged += new SelectionChangedEventHandler(ComboBox_SelectionChanged);

            //view는 loaderView에서 적용했음. // 이건 submit했을때 적용할거 저장함.
            this.selectedViewModel_ = e_kevcvm;
        }
    }
}
