using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class EventTriggerViewModel : IXmlData
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
        
        public EventTriggerViewModel() { }
        
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
        
        #region EventDate_
        private DateTime eventDate_;
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
        
        #region AutoTerminationTriggerViewModel_
        private AutoTerminationTriggerViewModel autoTerminationTriggerViewModel_;
        public AutoTerminationTriggerViewModel AutoTerminationTriggerViewModel_
        {
            get { return this.autoTerminationTriggerViewModel_; }
            set
            {
                if (this.autoTerminationTriggerViewModel_ != value)
                {
                    this.autoTerminationTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("AutoTerminationTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region PreEventCalculationViewModel_
        private PreEventCalculationViewModel preEventCalculationViewModel_;
        public PreEventCalculationViewModel PreEventCalculationViewModel_
        {
            get { return this.preEventCalculationViewModel_; }
            set
            {
                if (this.preEventCalculationViewModel_ != value)
                {
                    this.preEventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("PreEventCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region PreConditionEventViewModel_
        private PreConditionEventViewModel preConditionEventViewModel_;
        public PreConditionEventViewModel PreConditionEventViewModel_
        {
            get { return this.preConditionEventViewModel_; }
            set
            {
                if (this.preConditionEventViewModel_ != value)
                {
                    this.preConditionEventViewModel_ = value;
                    this.NotifyPropertyChanged("PreConditionEventViewModel_");
                }
            }
        }
        #endregion
        
        #region AutoCallConstReturnTriggerViewModel_
        private AutoCallConstReturnTriggerViewModel autoCallConstReturnTriggerViewModel_;
        public AutoCallConstReturnTriggerViewModel AutoCallConstReturnTriggerViewModel_
        {
            get { return this.autoCallConstReturnTriggerViewModel_; }
            set
            {
                if (this.autoCallConstReturnTriggerViewModel_ != value)
                {
                    this.autoCallConstReturnTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("AutoCallConstReturnTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region SimpleRangeConstReturnTriggerViewModel_
        private SimpleRangeConstReturnTriggerViewModel simpleRangeConstReturnTriggerViewModel_;
        public SimpleRangeConstReturnTriggerViewModel SimpleRangeConstReturnTriggerViewModel_
        {
            get { return this.simpleRangeConstReturnTriggerViewModel_; }
            set
            {
                if (this.simpleRangeConstReturnTriggerViewModel_ != value)
                {
                    this.simpleRangeConstReturnTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeConstReturnTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region SimpleRangeRateTriggerViewModel_
        private SimpleRangeRateTriggerViewModel simpleRangeRateTriggerViewModel_;
        public SimpleRangeRateTriggerViewModel SimpleRangeRateTriggerViewModel_
        {
            get { return this.simpleRangeRateTriggerViewModel_; }
            set
            {
                if (this.simpleRangeRateTriggerViewModel_ != value)
                {
                    this.simpleRangeRateTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeRateTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region SimpleRangeAccrualRateTriggerViewModel_
        private SimpleRangeAccrualRateTriggerViewModel simpleRangeAccrualRateTriggerViewModel_;
        public SimpleRangeAccrualRateTriggerViewModel SimpleRangeAccrualRateTriggerViewModel_
        {
            get { return this.simpleRangeAccrualRateTriggerViewModel_; }
            set
            {
                if (this.simpleRangeAccrualRateTriggerViewModel_ != value)
                {
                    this.simpleRangeAccrualRateTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeAccrualRateTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region FixedRateTriggerViewModel_
        private FixedRateTriggerViewModel fixedRateTriggerViewModel_;
        public FixedRateTriggerViewModel FixedRateTriggerViewModel_
        {
            get { return this.fixedRateTriggerViewModel_; }
            set
            {
                if (this.fixedRateTriggerViewModel_ != value)
                {
                    this.fixedRateTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("FixedRateTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaRateTriggerViewModel_
        private VanillaRateTriggerViewModel vanillaRateTriggerViewModel_;
        public VanillaRateTriggerViewModel VanillaRateTriggerViewModel_
        {
            get { return this.vanillaRateTriggerViewModel_; }
            set
            {
                if (this.vanillaRateTriggerViewModel_ != value)
                {
                    this.vanillaRateTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaRateTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region RedemptionNotionalTriggerViewModel_
        private RedemptionNotionalTriggerViewModel redemptionNotionalTriggerViewModel_;
        public RedemptionNotionalTriggerViewModel RedemptionNotionalTriggerViewModel_
        {
            get { return this.redemptionNotionalTriggerViewModel_; }
            set
            {
                if (this.redemptionNotionalTriggerViewModel_ != value)
                {
                    this.redemptionNotionalTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("RedemptionNotionalTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region AutoCallRangeReturnTriggerViewModel_
        private AutoCallRangeReturnTriggerViewModel autoCallRangeReturnTriggerViewModel_;
        public AutoCallRangeReturnTriggerViewModel AutoCallRangeReturnTriggerViewModel_
        {
            get { return this.autoCallRangeReturnTriggerViewModel_; }
            set
            {
                if (this.autoCallRangeReturnTriggerViewModel_ != value)
                {
                    this.autoCallRangeReturnTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("AutoCallRangeReturnTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaCouponTriggerViewModel_
        private VanillaCouponTriggerViewModel vanillaCouponTriggerViewModel_;
        public VanillaCouponTriggerViewModel VanillaCouponTriggerViewModel_
        {
            get { return this.vanillaCouponTriggerViewModel_; }
            set
            {
                if (this.vanillaCouponTriggerViewModel_ != value)
                {
                    this.vanillaCouponTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaCouponTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region SimpleEventCouponTriggerViewModel_
        private SimpleEventCouponTriggerViewModel simpleEventCouponTriggerViewModel_;
        public SimpleEventCouponTriggerViewModel SimpleEventCouponTriggerViewModel_
        {
            get { return this.simpleEventCouponTriggerViewModel_; }
            set
            {
                if (this.simpleEventCouponTriggerViewModel_ != value)
                {
                    this.simpleEventCouponTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleEventCouponTriggerViewModel_");
                }
            }
        }
        #endregion
        
        #region PostCalculationViewModel_
        private PostCalculationViewModel postCalculationViewModel_;
        public PostCalculationViewModel PostCalculationViewModel_
        {
            get { return this.postCalculationViewModel_; }
            set
            {
                if (this.postCalculationViewModel_ != value)
                {
                    this.postCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("PostCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_eventTriggerType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static EventTriggerViewModel CreateEventTrigger(string typeStr)
        {
            if ( typeStr == "autoTerminationTrigger")
            {
                return new AutoTerminationTriggerViewModel();
            }
            else if ( typeStr == "preEventCalculation")
            {
                return new PreEventCalculationViewModel();
            }
            else if ( typeStr == "preConditionEvent")
            {
                return new PreConditionEventViewModel();
            }
            else if ( typeStr == "autoCallConstReturnTrigger")
            {
                return new AutoCallConstReturnTriggerViewModel();
            }
            else if ( typeStr == "simpleRangeConstReturnTrigger")
            {
                return new SimpleRangeConstReturnTriggerViewModel();
            }
            else if ( typeStr == "simpleRangeRateTrigger")
            {
                return new SimpleRangeRateTriggerViewModel();
            }
            else if ( typeStr == "simpleRangeAccrualRateTrigger")
            {
                return new SimpleRangeAccrualRateTriggerViewModel();
            }
            else if ( typeStr == "fixedRateTrigger")
            {
                return new FixedRateTriggerViewModel();
            }
            else if ( typeStr == "vanillaRateTrigger")
            {
                return new VanillaRateTriggerViewModel();
            }
            else if ( typeStr == "redemptionNotionalTrigger")
            {
                return new RedemptionNotionalTriggerViewModel();
            }
            else if ( typeStr == "autoCallRangeReturnTrigger")
            {
                return new AutoCallRangeReturnTriggerViewModel();
            }
            else if ( typeStr == "vanillaCouponTrigger")
            {
                return new VanillaCouponTriggerViewModel();
            }
            else if ( typeStr == "simpleEventCouponTrigger")
            {
                return new SimpleEventCouponTriggerViewModel();
            }
            else if ( typeStr == "postCalculation")
            {
                return new PostCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

