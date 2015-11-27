using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class StandardOptionViewModel : IXmlData
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
        
        public StandardOptionViewModel() { }
        
        #region Unit_
        private string unit_;
        public string Unit_
        {
            get { return this.unit_; }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                    this.NotifyPropertyChanged("Unit_");
                }
            }
        }
        #endregion
        
        #region BaseCoupon_
        private string baseCoupon_;
        public string BaseCoupon_
        {
            get { return this.baseCoupon_; }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                    this.NotifyPropertyChanged("BaseCoupon_");
                }
            }
        }
        #endregion
        
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
        
        #region SingleBarrierViewModel_
        private SingleBarrierViewModel singleBarrierViewModel_;
        public SingleBarrierViewModel SingleBarrierViewModel_
        {
            get { return this.singleBarrierViewModel_; }
            set
            {
                if (this.singleBarrierViewModel_ != value)
                {
                    this.singleBarrierViewModel_ = value;
                    this.NotifyPropertyChanged("SingleBarrierViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaCallOptionViewModel_
        private VanillaCallOptionViewModel vanillaCallOptionViewModel_;
        public VanillaCallOptionViewModel VanillaCallOptionViewModel_
        {
            get { return this.vanillaCallOptionViewModel_; }
            set
            {
                if (this.vanillaCallOptionViewModel_ != value)
                {
                    this.vanillaCallOptionViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaCallOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaPutOptionViewModel_
        private VanillaPutOptionViewModel vanillaPutOptionViewModel_;
        public VanillaPutOptionViewModel VanillaPutOptionViewModel_
        {
            get { return this.vanillaPutOptionViewModel_; }
            set
            {
                if (this.vanillaPutOptionViewModel_ != value)
                {
                    this.vanillaPutOptionViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaPutOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region BarrierWithConstRebateCallOptionViewModel_
        private BarrierWithConstRebateCallOptionViewModel barrierWithConstRebateCallOptionViewModel_;
        public BarrierWithConstRebateCallOptionViewModel BarrierWithConstRebateCallOptionViewModel_
        {
            get { return this.barrierWithConstRebateCallOptionViewModel_; }
            set
            {
                if (this.barrierWithConstRebateCallOptionViewModel_ != value)
                {
                    this.barrierWithConstRebateCallOptionViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierWithConstRebateCallOptionViewModel_");
                }
            }
        }
        #endregion
        
        #region BarrierWithConstRebatePutOptionViewModel_
        private BarrierWithConstRebatePutOptionViewModel barrierWithConstRebatePutOptionViewModel_;
        public BarrierWithConstRebatePutOptionViewModel BarrierWithConstRebatePutOptionViewModel_
        {
            get { return this.barrierWithConstRebatePutOptionViewModel_; }
            set
            {
                if (this.barrierWithConstRebatePutOptionViewModel_ != value)
                {
                    this.barrierWithConstRebatePutOptionViewModel_ = value;
                    this.NotifyPropertyChanged("BarrierWithConstRebatePutOptionViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_standardOptionType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static StandardOptionViewModel CreateStandardOption(string typeStr)
        {
            if ( typeStr == "singleBarrier")
            {
                return new SingleBarrierViewModel();
            }
            else if ( typeStr == "vanillaCallOption")
            {
                return new VanillaCallOptionViewModel();
            }
            else if ( typeStr == "vanillaPutOption")
            {
                return new VanillaPutOptionViewModel();
            }
            else if ( typeStr == "barrierWithConstRebateCallOption")
            {
                return new BarrierWithConstRebateCallOptionViewModel();
            }
            else if ( typeStr == "barrierWithConstRebatePutOption")
            {
                return new BarrierWithConstRebatePutOptionViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

