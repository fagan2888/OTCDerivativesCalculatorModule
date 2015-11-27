using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_eventCalcInfoViewModel : IXmlData
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
        
        #region Excel_singleRangeEventCalViewModel_
        private Excel_singleRangeEventCalViewModel excel_singleRangeEventCalViewModel_;
        public Excel_singleRangeEventCalViewModel Excel_singleRangeEventCalViewModel_
        {
            get { return this.excel_singleRangeEventCalViewModel_; }
            set
            {
                if (this.excel_singleRangeEventCalViewModel_ != value)
                {
                    this.excel_singleRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_singleRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_dualRangeEventCalViewModel_
        private Excel_dualRangeEventCalViewModel excel_dualRangeEventCalViewModel_;
        public Excel_dualRangeEventCalViewModel Excel_dualRangeEventCalViewModel_
        {
            get { return this.excel_dualRangeEventCalViewModel_; }
            set
            {
                if (this.excel_dualRangeEventCalViewModel_ != value)
                {
                    this.excel_dualRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_dualRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_singleBarrierEventCalViewModel_
        private Excel_singleBarrierEventCalViewModel excel_singleBarrierEventCalViewModel_;
        public Excel_singleBarrierEventCalViewModel Excel_singleBarrierEventCalViewModel_
        {
            get { return this.excel_singleBarrierEventCalViewModel_; }
            set
            {
                if (this.excel_singleBarrierEventCalViewModel_ != value)
                {
                    this.excel_singleBarrierEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_singleBarrierEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_dualBarrierEventCalViewModel_
        private Excel_dualBarrierEventCalViewModel excel_dualBarrierEventCalViewModel_;
        public Excel_dualBarrierEventCalViewModel Excel_dualBarrierEventCalViewModel_
        {
            get { return this.excel_dualBarrierEventCalViewModel_; }
            set
            {
                if (this.excel_dualBarrierEventCalViewModel_ != value)
                {
                    this.excel_dualBarrierEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_dualBarrierEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_identityEventCalViewModel_
        private Excel_identityEventCalViewModel excel_identityEventCalViewModel_;
        public Excel_identityEventCalViewModel Excel_identityEventCalViewModel_
        {
            get { return this.excel_identityEventCalViewModel_; }
            set
            {
                if (this.excel_identityEventCalViewModel_ != value)
                {
                    this.excel_identityEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_identityEventCalViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_eventCalcInfoViewModel CreateExcel_eventCalcInfo(string typeStr)
        {
            if ( typeStr == "excel_singleRangeEventCal")
            {
                return new Excel_singleRangeEventCalViewModel();
            }
            else if ( typeStr == "excel_dualRangeEventCal")
            {
                return new Excel_dualRangeEventCalViewModel();
            }
            else if ( typeStr == "excel_singleBarrierEventCal")
            {
                return new Excel_singleBarrierEventCalViewModel();
            }
            else if ( typeStr == "excel_dualBarrierEventCal")
            {
                return new Excel_dualBarrierEventCalViewModel();
            }
            else if ( typeStr == "excel_identityEventCal")
            {
                return new Excel_identityEventCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

