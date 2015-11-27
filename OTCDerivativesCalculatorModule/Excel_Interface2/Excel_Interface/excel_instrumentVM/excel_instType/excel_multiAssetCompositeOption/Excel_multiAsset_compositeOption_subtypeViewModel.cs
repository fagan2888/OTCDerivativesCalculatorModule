using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_multiAsset_compositeOption_subtypeViewModel : IXmlData
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
    
        public Excel_multiAsset_compositeOption_subtypeViewModel() 
        {
        }
        
        #region Excel_Type_
        protected string excel_Type_;
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

        // 만기는 하나?
        #region ExerciseDate_
        protected DateTime exerciseDate_;
        public DateTime ExerciseDate_
        {
            get { return this.exerciseDate_; }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                    this.NotifyPropertyChanged("ExerciseDate_");
                }
            }
        }
        #endregion

        #region PayoffDate_
        protected DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion

        // 새로 생기는 underCalcID에 setting을 하거나 하위의 것들에 대해 이걸 통해서 세팅해줌
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

        #region Type_
        protected string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
    
        public static Excel_multiAsset_compositeOption_subtypeViewModel CreateExcel_multiAsset_compositeOption_subtype(string typeStr)
        {
            if ( typeStr == "excel_multiAsset_vanillaCallPut")
            {
                return new Excel_multiAsset_vanillaCallPutViewModel();
            }
            else if ( typeStr == "excel_multiAsset_upInOutCall")
            {
                return new Excel_multiAsset_upInOutCallViewModel();
            }
            //else if ( typeStr == "excel_multiAsset_downInOutPut")
            //{
            //    return new Excel_multiAsset_downInOutPutViewModel();
            //}
            //else if ( typeStr == "excel_multiAsset_digitalCallPut")
            //{
            //    return new Excel_multiAsset_digitalCallPutViewModel();
            //}
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public abstract Excel_multiAsset_compositeOption_subtypeViewModel Clone();

        public abstract void descriptionUpdate();

        // 즐겨찾기 setting
        public abstract void DefaultSetting(Excel_multiAssetCompositeOptionViewModel e_mcovm);

        public abstract Control view();

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                          EVENT_INFO_Table_DAO dao);

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public abstract Excel_multiAssetCompositeOptionLoaderView loaderView(Excel_multiAssetCompositeOptionViewModel e_mcovm);

        public abstract void setInterfaceViewModel(Excel_multiAssetCompositeOptionViewModel e_mcovm);

    }
    
}

