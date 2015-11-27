using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_compositeOption_subtypeViewModel : IXmlData , INotifyPropertyChanged
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

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

        #region BaseUnderlyingValue_
        protected double baseUnderlyingValue_;
        public double BaseUnderlyingValue_
        {
            get { return this.baseUnderlyingValue_; }
            set
            {
                if (this.baseUnderlyingValue_ != value)
                {
                    this.baseUnderlyingValue_ = value;
                    this.NotifyPropertyChanged("BaseUnderlyingValue_");
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
        
        #region UnderlyingCode_
        protected string underlyingCode_;
        public string UnderlyingCode_
        {
            get { return this.underlyingCode_; }
            set
            {
                if (this.underlyingCode_ != value)
                {
                    this.underlyingCode_ = value;
                    this.NotifyPropertyChanged("UnderlyingCode_");
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

        public Excel_compositeOption_subtypeViewModel() 
        {
        }
    
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
        //public abstract void buildProduct();
        //public abstract void excel_scheduleListBuild();

        public static Excel_compositeOption_subtypeViewModel CreateExcel_compositeOption_subtype(string typeStr)
        {
            if (typeStr.ToUpper() == "EXCEL_VANILLACALLPUT")
            {
                return new Excel_vanillaCallPutViewModel();
            }
            else if (typeStr.ToUpper() == "EXCEL_UPINOUTCALL")
            {
                return new Excel_upInOutCallViewModel();
            }
            else if (typeStr.ToUpper() == "EXCEL_DIGITALCALL")
            {
                return new Excel_digitalCallPutViewModel();
            }
            else
            {
                OutputLogViewModel.addResult("type Not Valid , inputType -> " + typeStr);

                throw new NotImplementedException();
            }
        }

        public abstract Excel_compositeOption_subtypeViewModel Clone();

        public abstract void descriptionUpdate();

        // 즐겨찾기 setting
        public abstract void DefaultSetting(Excel_compositeOptionViewModel e_covm);

        public abstract Control view();

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                          EVENT_INFO_Table_DAO dao);

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public abstract Excel_compositeOptionLoaderView loaderView(Excel_compositeOptionViewModel e_covm);

        public abstract void setInterfaceViewModel(Excel_compositeOptionViewModel e_covm);
    }
    
}

