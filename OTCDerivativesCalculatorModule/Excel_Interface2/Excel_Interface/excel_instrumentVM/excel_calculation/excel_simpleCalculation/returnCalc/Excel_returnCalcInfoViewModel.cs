using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_returnCalcInfoViewModel : IXmlData , INotifyPropertyChanged
    {
        #region AttributeValue_
        protected string attributeValue_;
        public string AttributeValue_
        {
            get { return this.attributeValue_; }
            set
            {
                if (this.attributeValue_ != value)
                {
                    this.attributeValue_ = value;
                    this.NotifyPropertyChanged("AttributeValue_");
                }
            }
        }
        #endregion

        public abstract void attributeSetXml(System.Xml.XmlWriter xmlWriter);

        #region Description_
        protected string description_;
        public string Description_
        {
            get { return this.description_; }
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

        public Excel_returnCalcInfoViewModel() 
        {
            
        }
    
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
        
        public static Excel_returnCalcInfoViewModel CreateExcel_returnCalcInfo(string typeStr)
        {
            if ( typeStr == "excel_constReturnCal")
            {
                return new Excel_constReturnCalViewModel();
            }
            else if ( typeStr == "excel_vanillaReturnCal")
            {
                return new Excel_vanillaReturnCalViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        //public abstract ReturnCalculationInfoViewModel returnCalcInfoVM();

        // 이놈이 선택한것을 가지고 있음
        public Control loaderView()
        {
            Excel_returnCalcInfoLoaderView returnCalcloaderView = new Excel_returnCalcInfoLoaderView();

            returnCalcloaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;
            
            returnCalcloaderView.initialize(this);

            returnCalcloaderView.returnCalGrid_.Children.Add(this.view());

            return returnCalcloaderView;
        }

        // 설정 View
        public abstract Control view();
        
        // 각각의 cashflow에 underlying 정보를 setting해줌.
        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public abstract void defaultSetting();
    }
    
}

