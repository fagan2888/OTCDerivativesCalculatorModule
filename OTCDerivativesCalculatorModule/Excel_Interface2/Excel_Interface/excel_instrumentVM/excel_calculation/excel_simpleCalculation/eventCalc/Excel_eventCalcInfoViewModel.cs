using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_eventCalcInfoViewModel : IXmlData , INotifyPropertyChanged
    {

        #region Description_
        protected string description_;
        public string Description_
        {
            get 
            {
                this.descriptionUpdate();
                return this.description_; 
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

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
        
        public Excel_eventCalcInfoViewModel() { }
    
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

        #region ReferenceFixingDate_
        protected DateTime referenceFixingDate_;
        public DateTime ReferenceFixingDate_
        {
            get { return this.referenceFixingDate_; }
            set
            {
                if (this.referenceFixingDate_ != value)
                {
                    this.referenceFixingDate_ = value;
                    this.NotifyPropertyChanged("ReferenceFixingDate_");
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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
        public static Excel_eventCalcInfoViewModel CreateExcel_eventCalcInfo(string typeStr)
        {
            if ( typeStr == "excel_singleRangeEventCal")
            {
                return new Excel_singleRangeEventCalViewModel();
            }
            //else if ( typeStr == "excel_dualRangeEventCal")
            //{
            //    return new Excel_dualRangeEventCalViewModel();
            //}
            else if ( typeStr == "excel_singleBarrierEventCal")
            {
                return new Excel_singleBarrierEventCalViewModel();
            }
            //else if ( typeStr == "excel_dualBarrierEventCal")
            //{
            //    return new Excel_dualBarrierEventCalViewModel();
            //}
            else
            {
            throw new NotImplementedException();
            }
        }

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        // 이놈이 선택한것을 가지고 있음
        public Control loaderView() 
        {
            Excel_eventCalcInfoLoaderView eventCalcloaderView = new Excel_eventCalcInfoLoaderView();

            //underlying 먼저 set해야함.
            eventCalcloaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            eventCalcloaderView.initialize(this);

            eventCalcloaderView.selectedEventGrid_.Children.Add(this.view());

            return eventCalcloaderView;
        }

        public abstract Control view();

        public abstract void defaultSetting();

        public abstract void descriptionUpdate();

    }
    
}

