using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_interfaceViewModel : IXmlData
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
        
        public Excel_interfaceViewModel() { }
        
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
        
        #region Excel_hifiveViewModel_
        private Excel_hifiveViewModel excel_hifiveViewModel_;
        public Excel_hifiveViewModel Excel_hifiveViewModel_
        {
            get { return this.excel_hifiveViewModel_; }
            set
            {
                if (this.excel_hifiveViewModel_ != value)
                {
                    this.excel_hifiveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifiveViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_stepDownKICustomViewModel_
        private Excel_stepDownKICustomViewModel excel_stepDownKICustomViewModel_;
        public Excel_stepDownKICustomViewModel Excel_stepDownKICustomViewModel_
        {
            get { return this.excel_stepDownKICustomViewModel_; }
            set
            {
                if (this.excel_stepDownKICustomViewModel_ != value)
                {
                    this.excel_stepDownKICustomViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_stepDownKICustomViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_compositeOptionViewModel_
        private Excel_compositeOptionViewModel excel_compositeOptionViewModel_;
        public Excel_compositeOptionViewModel Excel_compositeOptionViewModel_
        {
            get { return this.excel_compositeOptionViewModel_; }
            set
            {
                if (this.excel_compositeOptionViewModel_ != value)
                {
                    this.excel_compositeOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_compositeOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_generalViewModel_
        private Excel_generalViewModel excel_generalViewModel_;
        public Excel_generalViewModel Excel_generalViewModel_
        {
            get { return this.excel_generalViewModel_; }
            set
            {
                if (this.excel_generalViewModel_ != value)
                {
                    this.excel_generalViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_generalViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_fixedBondViewModel_
        private Excel_fixedBondViewModel excel_fixedBondViewModel_;
        public Excel_fixedBondViewModel Excel_fixedBondViewModel_
        {
            get { return this.excel_fixedBondViewModel_; }
            set
            {
                if (this.excel_fixedBondViewModel_ != value)
                {
                    this.excel_fixedBondViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fixedBondViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_vanillaFloatingBondViewModel_
        private Excel_vanillaFloatingBondViewModel excel_vanillaFloatingBondViewModel_;
        public Excel_vanillaFloatingBondViewModel Excel_vanillaFloatingBondViewModel_
        {
            get { return this.excel_vanillaFloatingBondViewModel_; }
            set
            {
                if (this.excel_vanillaFloatingBondViewModel_ != value)
                {
                    this.excel_vanillaFloatingBondViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_vanillaFloatingBondViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_structuredBondViewModel_
        private Excel_structuredBondViewModel excel_structuredBondViewModel_;
        public Excel_structuredBondViewModel Excel_structuredBondViewModel_
        {
            get { return this.excel_structuredBondViewModel_; }
            set
            {
                if (this.excel_structuredBondViewModel_ != value)
                {
                    this.excel_structuredBondViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_structuredBondViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_fxForwardViewModel_
        private Excel_fxForwardViewModel excel_fxForwardViewModel_;
        public Excel_fxForwardViewModel Excel_fxForwardViewModel_
        {
            get { return this.excel_fxForwardViewModel_; }
            set
            {
                if (this.excel_fxForwardViewModel_ != value)
                {
                    this.excel_fxForwardViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fxForwardViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_fxSwapViewModel_
        private Excel_fxSwapViewModel excel_fxSwapViewModel_;
        public Excel_fxSwapViewModel Excel_fxSwapViewModel_
        {
            get { return this.excel_fxSwapViewModel_; }
            set
            {
                if (this.excel_fxSwapViewModel_ != value)
                {
                    this.excel_fxSwapViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fxSwapViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_multiAssetCompositeOptionViewModel_
        private Excel_multiAssetCompositeOptionViewModel excel_multiAssetCompositeOptionViewModel_;
        public Excel_multiAssetCompositeOptionViewModel Excel_multiAssetCompositeOptionViewModel_
        {
            get { return this.excel_multiAssetCompositeOptionViewModel_; }
            set
            {
                if (this.excel_multiAssetCompositeOptionViewModel_ != value)
                {
                    this.excel_multiAssetCompositeOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multiAssetCompositeOptionViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_interfaceViewModel CreateExcel_interface(string typeStr)
        {
            if ( typeStr == "excel_hifive")
            {
                return new Excel_hifiveViewModel();
            }
            else if ( typeStr == "excel_stepDownKICustom")
            {
                return new Excel_stepDownKICustomViewModel();
            }
            else if ( typeStr == "excel_compositeOption")
            {
                return new Excel_compositeOptionViewModel();
            }
            else if ( typeStr == "excel_general")
            {
                return new Excel_generalViewModel();
            }
            else if ( typeStr == "excel_fixedBond")
            {
                return new Excel_fixedBondViewModel();
            }
            else if ( typeStr == "excel_vanillaFloatingBond")
            {
                return new Excel_vanillaFloatingBondViewModel();
            }
            else if ( typeStr == "excel_structuredBond")
            {
                return new Excel_structuredBondViewModel();
            }
            else if ( typeStr == "excel_fxForward")
            {
                return new Excel_fxForwardViewModel();
            }
            else if ( typeStr == "excel_fxSwap")
            {
                return new Excel_fxSwapViewModel();
            }
            else if ( typeStr == "excel_multiAssetCompositeOption")
            {
                return new Excel_multiAssetCompositeOptionViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

