using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class Underlying_paraViewModel : IXmlData
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
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
    
        public Underlying_paraViewModel() { }
    
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
        
        #region KrCode_
        protected string krCode_;
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
        protected string underName_;
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

        #region CurrentValue_
        protected string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
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
                    //this.NotifyPropertyChanged("Description_");
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
            else if ( typeStr == "hullWhite")
            {
                return new HullWhiteViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static Underlying_paraViewModel CreateUnderlying_para(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Underlying_para serial_Underlying_para = serial_Class as FpmlSerializedCSharp.Underlying_para;
            string typeStr = serial_Underlying_para.Type_.ValueStr;
            return Underlying_paraViewModel.CreateUnderlying_para(typeStr);
        }
        
    
    }
    
}

