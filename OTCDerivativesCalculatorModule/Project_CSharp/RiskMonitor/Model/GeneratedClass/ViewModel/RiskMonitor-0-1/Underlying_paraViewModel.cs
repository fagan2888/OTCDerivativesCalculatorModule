using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Underlying_paraViewModel : IXmlData
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
        
        public Underlying_paraViewModel() { }
        
        #region Type_
        private string type_;
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
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        #region UnderName_
        private string underName_;
        public string UnderName_
        {
            get { return this.underName_; }
            set
            {
                if (this.underName_ != value)
                {
                    this.underName_ = value;
                    this.NotifyPropertyChanged("UnderName_");
                }
            }
        }
        #endregion
        
        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion
        
        #region GeometricBMViewModel_
        private GeometricBMViewModel geometricBMViewModel_;
        public GeometricBMViewModel GeometricBMViewModel_
        {
            get { return this.geometricBMViewModel_; }
            set
            {
                if (this.geometricBMViewModel_ != value)
                {
                    this.geometricBMViewModel_ = value;
                    this.NotifyPropertyChanged("GeometricBMViewModel_");
                }
            }
        }
        #endregion
        
        #region HullWhiteOneFactorViewModel_
        private HullWhiteOneFactorViewModel hullWhiteOneFactorViewModel_;
        public HullWhiteOneFactorViewModel HullWhiteOneFactorViewModel_
        {
            get { return this.hullWhiteOneFactorViewModel_; }
            set
            {
                if (this.hullWhiteOneFactorViewModel_ != value)
                {
                    this.hullWhiteOneFactorViewModel_ = value;
                    this.NotifyPropertyChanged("HullWhiteOneFactorViewModel_");
                }
            }
        }
        #endregion
        
        #region ForwardModelViewModel_
        private ForwardModelViewModel forwardModelViewModel_;
        public ForwardModelViewModel ForwardModelViewModel_
        {
            get { return this.forwardModelViewModel_; }
            set
            {
                if (this.forwardModelViewModel_ != value)
                {
                    this.forwardModelViewModel_ = value;
                    this.NotifyPropertyChanged("ForwardModelViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_underParaType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Underlying_paraViewModel CreateUnderlying_para(string typeStr)
        {
            if ( typeStr == "geometricBM")
            {
                return new GeometricBMViewModel();
            }
            else if ( typeStr == "hullWhiteOneFactor")
            {
                return new HullWhiteOneFactorViewModel();
            }
            else if ( typeStr == "forwardModel")
            {
                return new ForwardModelViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

