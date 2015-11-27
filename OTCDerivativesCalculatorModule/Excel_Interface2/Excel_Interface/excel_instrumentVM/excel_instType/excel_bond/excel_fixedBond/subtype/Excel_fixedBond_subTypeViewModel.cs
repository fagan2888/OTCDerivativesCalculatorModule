using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_fixedBond_subtypeViewModel : IXmlData
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
    
        public Excel_fixedBond_subtypeViewModel() 
        {
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            // shcuduleInfoVm 의 default 로드

            // 그냥 static에서 가져와서 해도댐

            this.scheduleGeneratorVM_ = new ScheduleGeneratorViewModel();
            //this.scheduleGeneratorVM_.defaultLoad();
        }

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

        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        #region Excel_fixedCouponScheduleListViewModel_
        protected Excel_fixedCouponScheduleListViewModel excel_fixedCouponScheduleListViewModel_;
        public Excel_fixedCouponScheduleListViewModel Excel_fixedCouponScheduleListViewModel_
        {
            get { return this.excel_fixedCouponScheduleListViewModel_; }
            set
            {
                if (this.excel_fixedCouponScheduleListViewModel_ != value)
                {
                    this.excel_fixedCouponScheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedCouponScheduleListViewModel_");
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
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        public abstract void scheduleDataGenerate();

        public static Excel_fixedBond_subtypeViewModel CreateExcel_fixedBond_subtype(string typeStr)
        {
            if ( typeStr == "excel_fixedBond_constantRate")
            {
                return new Excel_fixedBond_constantRateViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        public abstract void buildProduct();

        public Excel_fixedBond_subtypeLoaderView loaderView()
        {
            Excel_fixedBond_subtypeLoaderView subTypeLoaderView = new Excel_fixedBond_subtypeLoaderView();

            subTypeLoaderView.initialize(this);

            subTypeLoaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            subTypeLoaderView.selectedSubtypeGrid_.Children.Add(this.view());

            return subTypeLoaderView;
        }

        public abstract Control view();

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public abstract void excel_scheduleListVMBuild();
    }
    
}

