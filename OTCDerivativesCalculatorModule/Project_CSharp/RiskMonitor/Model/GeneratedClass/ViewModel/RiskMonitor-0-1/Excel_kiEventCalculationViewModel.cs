using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_kiEventCalculationViewModel : IXmlData
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
        
        #region Excel_simpleKiEventCalcViewModel_
        private Excel_simpleKiEventCalcViewModel excel_simpleKiEventCalcViewModel_;
        public Excel_simpleKiEventCalcViewModel Excel_simpleKiEventCalcViewModel_
        {
            get { return this.excel_simpleKiEventCalcViewModel_; }
            set
            {
                if (this.excel_simpleKiEventCalcViewModel_ != value)
                {
                    this.excel_simpleKiEventCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_simpleKiEventCalcViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_dualKiEventCalcViewModel_
        private Excel_dualKiEventCalcViewModel excel_dualKiEventCalcViewModel_;
        public Excel_dualKiEventCalcViewModel Excel_dualKiEventCalcViewModel_
        {
            get { return this.excel_dualKiEventCalcViewModel_; }
            set
            {
                if (this.excel_dualKiEventCalcViewModel_ != value)
                {
                    this.excel_dualKiEventCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_dualKiEventCalcViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_targetKiEventCalcViewModel_
        private Excel_targetKiEventCalcViewModel excel_targetKiEventCalcViewModel_;
        public Excel_targetKiEventCalcViewModel Excel_targetKiEventCalcViewModel_
        {
            get { return this.excel_targetKiEventCalcViewModel_; }
            set
            {
                if (this.excel_targetKiEventCalcViewModel_ != value)
                {
                    this.excel_targetKiEventCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_targetKiEventCalcViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
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
        
        
    
    }
    
}

