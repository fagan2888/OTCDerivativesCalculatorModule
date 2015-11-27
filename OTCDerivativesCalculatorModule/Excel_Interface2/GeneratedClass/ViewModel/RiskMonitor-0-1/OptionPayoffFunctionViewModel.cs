using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class OptionPayoffFunctionViewModel : IXmlData
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
        
        public OptionPayoffFunctionViewModel() { }
        
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
        
        #region VanillaCallFunctionViewModel_
        private VanillaCallFunctionViewModel vanillaCallFunctionViewModel_;
        public VanillaCallFunctionViewModel VanillaCallFunctionViewModel_
        {
            get { return this.vanillaCallFunctionViewModel_; }
            set
            {
                if (this.vanillaCallFunctionViewModel_ != value)
                {
                    this.vanillaCallFunctionViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaCallFunctionViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaPutFunctionViewModel_
        private VanillaPutFunctionViewModel vanillaPutFunctionViewModel_;
        public VanillaPutFunctionViewModel VanillaPutFunctionViewModel_
        {
            get { return this.vanillaPutFunctionViewModel_; }
            set
            {
                if (this.vanillaPutFunctionViewModel_ != value)
                {
                    this.vanillaPutFunctionViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaPutFunctionViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_optionPayoffFunctionType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static OptionPayoffFunctionViewModel CreateOptionPayoffFunction(string typeStr)
        {
            if ( typeStr == "vanillaCallFunction")
            {
                return new VanillaCallFunctionViewModel();
            }
            else if ( typeStr == "vanillaPutFunction")
            {
                return new VanillaPutFunctionViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

