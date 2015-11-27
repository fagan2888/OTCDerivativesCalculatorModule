using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class SwapPayoffInfoViewModel : IXmlData
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
        
        public SwapPayoffInfoViewModel() { }
        
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
        
        #region VanillaSwapPayoffViewModel_
        private VanillaSwapPayoffViewModel vanillaSwapPayoffViewModel_;
        public VanillaSwapPayoffViewModel VanillaSwapPayoffViewModel_
        {
            get { return this.vanillaSwapPayoffViewModel_; }
            set
            {
                if (this.vanillaSwapPayoffViewModel_ != value)
                {
                    this.vanillaSwapPayoffViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaSwapPayoffViewModel_");
                }
            }
        }
        #endregion
        
        #region AutoCallableSwapPayoffViewModel_
        private AutoCallableSwapPayoffViewModel autoCallableSwapPayoffViewModel_;
        public AutoCallableSwapPayoffViewModel AutoCallableSwapPayoffViewModel_
        {
            get { return this.autoCallableSwapPayoffViewModel_; }
            set
            {
                if (this.autoCallableSwapPayoffViewModel_ != value)
                {
                    this.autoCallableSwapPayoffViewModel_ = value;
                    this.NotifyPropertyChanged("AutoCallableSwapPayoffViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_swapPayoffType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static SwapPayoffInfoViewModel CreateSwapPayoffInfo(string typeStr)
        {
            if ( typeStr == "vanillaSwapPayoff")
            {
                return new VanillaSwapPayoffViewModel();
            }
            else if ( typeStr == "autoCallableSwapPayoff")
            {
                return new AutoCallableSwapPayoffViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

