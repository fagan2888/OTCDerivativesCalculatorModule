using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_hifive_subtypeViewModel : IXmlData , INotifyPropertyChanged
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

        #region EffectiveDate_
        protected DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion

        #region MaturityDate_
        protected DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion

        #region ProductString_
        protected string productString_;
        public string ProductString_
        {
            get { return this.productString_; }
            set
            {
                if (this.productString_ != value)
                {
                    this.productString_ = value;
                    this.NotifyPropertyChanged("ProductString_");
                }
            }
        }
        #endregion

        public void underlyingPropertyChangeObserver(object sender, PropertyChangedEventArgs e)
        {
            this.excel_underlyingCalcInfoViewModel_
                = sender as Excel_underlyingCalcInfoViewModel;

            this.buildProduct();
        }

        #region Excel_underlyingCalcInfoViewModel_
        protected Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
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

        #region ScheduleGeneratorVM_
        protected ScheduleGeneratorViewModel scheduleGeneratorVM_;
        public ScheduleGeneratorViewModel ScheduleGeneratorVM_
        {
            get { return this.scheduleGeneratorVM_; }
            set
            {
                if (this.scheduleGeneratorVM_ != value)
                {
                    this.scheduleGeneratorVM_ = value;
                    this.NotifyPropertyChanged("ScheduleGeneratorVM_");
                }
            }
        }
        #endregion
        
        #region Excel_scheduleListViewModel_
        protected Excel_scheduleListViewModel excel_scheduleListViewModel_;
        public Excel_scheduleListViewModel Excel_scheduleListViewModel_
        {
            get { return this.excel_scheduleListViewModel_; }
            set
            {
                if (this.excel_scheduleListViewModel_ != value)
                {
                    this.excel_scheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_scheduleListViewModel_");
                }
            }
        }
        #endregion

        #region Excel_kiEventCalculationViewModel_
        protected Excel_kiEventCalculationViewModel excel_kiEventCalculationViewModel_;
        public Excel_kiEventCalculationViewModel Excel_kiEventCalculationViewModel_
        {
            get { return this.excel_kiEventCalculationViewModel_; }
            set
            {
                if (this.excel_kiEventCalculationViewModel_ != value)
                {
                    this.excel_kiEventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_kiEventCalculationViewModel_");
                }
            }
        }
        #endregion

        public Excel_hifive_subtypeViewModel()
        {
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            // shcuduleInfoVm 의 default 로드

            // 그냥 static에서 가져와서 해도댐

            this.scheduleGeneratorVM_ = new ScheduleGeneratorViewModel();

        }
    
        #region Excel_Type_
        private string excel_Type_;
        public string Excel_Type_
        {
            get { return this.excel_Type_; }
            set
            {
                if (this.excel_Type_ != value)
                {
                    this.excel_Type_ = value;
                    this.NotifyPropertyChanged("Excel_Type_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        //public abstract void buildPricingXml(XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        public abstract void scheduleDataGenerate();

        public static Excel_hifive_subtypeViewModel CreateExcel_hifive_subtype(string typeStr)
        {
            if (typeStr.ToUpper() == "EXCEL_HIFIVE_STEPDOWN_KI" || typeStr.ToUpper() == "STEPDOWNKI")
            {
                return new Excel_hifive_stepDown_kiViewModel();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        
        public abstract void buildProduct();

        public abstract void excel_scheduleListVMBuild();
        public abstract void excel_kiEventCalculationBuild();



        public Excel_hifive_subtypeLoaderView loaderView()
        {
            Excel_hifive_subtypeLoaderView subTypeLoaderView = new Excel_hifive_subtypeLoaderView();

            subTypeLoaderView.initialize(this);

            subTypeLoaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;
            
            subTypeLoaderView.selectedSubtypeGrid_.Children.Add(this.view());

            return subTypeLoaderView;
        }

        public abstract Control view();

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel);

        //public abstract Excel_kiEventCalculationViewModel excel_kiEventCalculationVM();

        public abstract void scheduleDataGenerateFromProductStr(TradeString ts);

        public abstract void DefaultSetting(Excel_hifiveViewModel e_hvm);

    }
    
}

