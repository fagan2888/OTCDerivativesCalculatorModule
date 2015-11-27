using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_kiEventCalculationViewModel : IXmlData , INotifyPropertyChanged
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
    
        public Excel_kiEventCalculationViewModel() { }
    
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

        #region EventDate_
        protected DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
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

        #region VBA_description_
        protected string vba_description_;
        public string VBA_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("VBA_description_");
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

        public virtual void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteElementString("eventDate", this.eventDate_.ToString(StringFormat.XmlDateFormat_));
            xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
            xmlWriter.WriteElementString("vba_description", this.vba_description_);
        }
        public abstract void setFromXml(System.Xml.XmlNode node);

        public virtual void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            FpmlSerializedCSharp.Excel_simpleKiEventCalc serial_Excel_simpleKiEventCalc = serial_Excel_kiEventCalculation.Excel_simpleKiEventCalc_;

            this.eventDate_ = serial_Excel_simpleKiEventCalc.EventDate_.DateTimeValue();
            this.payoffDate_ = serial_Excel_simpleKiEventCalc.PayoffDate_.DateTimeValue();
            this.vba_description_ = serial_Excel_simpleKiEventCalc.Vba_description_.ValueStr;
        }
    
        //eventDate 만들어야함.
        public static Excel_kiEventCalculationViewModel CreateExcel_kiEventCalculation(string typeStr)
        {
            if ( typeStr == "excel_simpleKiEventCalc")
            {
                return new Excel_simpleKiEventCalcViewModel();
            }
            else if ( typeStr == "excel_dualKiEventCalc")
            {
                return new Excel_dualKiEventCalcViewModel();
            }
            else if ( typeStr == "excel_targetKiEventCalc")
            {
                return new Excel_targetKiEventCalcViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        public abstract Control view();

        public Control loaderView()
        {
            Excel_kiEventCalculationLoaderView kiEventCalcLoaderView = new Excel_kiEventCalculationLoaderView();

            kiEventCalcLoaderView.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            kiEventCalcLoaderView.initialize(this);

            kiEventCalcLoaderView.selectedKICalcGrid_.Children.Add(this.view());

            return kiEventCalcLoaderView;
        }

        public abstract void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under);

        public abstract void defaultSetting();

    }
    
}

