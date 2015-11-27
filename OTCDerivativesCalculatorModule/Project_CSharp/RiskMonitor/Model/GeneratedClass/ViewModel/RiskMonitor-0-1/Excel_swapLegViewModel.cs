using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_swapLegViewModel : IXmlData
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
        
        public Excel_swapLegViewModel() { }
        
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
        
        #region Excel_fixedRateSwapLegViewModel_
        private Excel_fixedRateSwapLegViewModel excel_fixedRateSwapLegViewModel_;
        public Excel_fixedRateSwapLegViewModel Excel_fixedRateSwapLegViewModel_
        {
            get { return this.excel_fixedRateSwapLegViewModel_; }
            set
            {
                if (this.excel_fixedRateSwapLegViewModel_ != value)
                {
                    this.excel_fixedRateSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedRateSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_vanillaFloatingRateSwapLegViewModel_
        private Excel_vanillaFloatingRateSwapLegViewModel excel_vanillaFloatingRateSwapLegViewModel_;
        public Excel_vanillaFloatingRateSwapLegViewModel Excel_vanillaFloatingRateSwapLegViewModel_
        {
            get { return this.excel_vanillaFloatingRateSwapLegViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingRateSwapLegViewModel_ != value)
                {
                    this.excel_vanillaFloatingRateSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingRateSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_structuredRateSwapLegViewModel_
        private Excel_structuredRateSwapLegViewModel excel_structuredRateSwapLegViewModel_;
        public Excel_structuredRateSwapLegViewModel Excel_structuredRateSwapLegViewModel_
        {
            get { return this.excel_structuredRateSwapLegViewModel_; }
            set
            {
                if (this.excel_structuredRateSwapLegViewModel_ != value)
                {
                    this.excel_structuredRateSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredRateSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_creditEventSwapLegViewModel_
        private Excel_creditEventSwapLegViewModel excel_creditEventSwapLegViewModel_;
        public Excel_creditEventSwapLegViewModel Excel_creditEventSwapLegViewModel_
        {
            get { return this.excel_creditEventSwapLegViewModel_; }
            set
            {
                if (this.excel_creditEventSwapLegViewModel_ != value)
                {
                    this.excel_creditEventSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_hifiveSwapLegViewModel_
        private Excel_hifiveSwapLegViewModel excel_hifiveSwapLegViewModel_;
        public Excel_hifiveSwapLegViewModel Excel_hifiveSwapLegViewModel_
        {
            get { return this.excel_hifiveSwapLegViewModel_; }
            set
            {
                if (this.excel_hifiveSwapLegViewModel_ != value)
                {
                    this.excel_hifiveSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifiveSwapLegViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_swapLegViewModel CreateExcel_swapLeg(string typeStr)
        {
            if ( typeStr == "excel_fixedRateSwapLeg")
            {
                return new Excel_fixedRateSwapLegViewModel();
            }
            else if ( typeStr == "excel_vanillaFloatingRateSwapLeg")
            {
                return new Excel_vanillaFloatingRateSwapLegViewModel();
            }
            else if ( typeStr == "excel_structuredRateSwapLeg")
            {
                return new Excel_structuredRateSwapLegViewModel();
            }
            else if ( typeStr == "excel_creditEventSwapLeg")
            {
                return new Excel_creditEventSwapLegViewModel();
            }
            else if ( typeStr == "excel_hifiveSwapLeg")
            {
                return new Excel_hifiveSwapLegViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

