using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class EventTriggerViewModel : IXmlData
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
        private string eventDate_;
        public string EventDate_
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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public void baseSetFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            
            this.EventDate_ = serial_EventTrigger.EventDate_.ValueStr;

            FpmlSerializedCSharp.PreEventCalculation serial_preEventCalculation = serial_EventTrigger.PreEventCalculation_;
            this.preEventCalculationViewModel_.setFromSerial(serial_preEventCalculation);

            FpmlSerializedCSharp.PreConditionEvent serial_preConditionEvent = serial_EventTrigger.PreConditionEvent_;
            this.preConditionEventViewModel_.setFromSerial(serial_preConditionEvent);

            FpmlSerializedCSharp.PostCalculation serial_postCalculation = serial_EventTrigger.PostCalculation_;
            this.postCalculationViewModel_.setFromSerial(serial_postCalculation);

            FpmlSerializedCSharp.AutoTerminationTrigger serial_autoTerminationTrigger = serial_EventTrigger.AutoTerminationTrigger_;
            this.autoTerminationTriggerViewModel_.setFromSerial(serial_autoTerminationTrigger);


        }

        public void preBuildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteElementString("eventDate", this.EventDate_);
            
            if (this.preEventCalculationViewModel_ != null)
            {
                this.preEventCalculationViewModel_.buildXml(xmlWriter);
            }

            if (this.preConditionEventViewModel_ != null)
            {
                this.preConditionEventViewModel_.buildXml(xmlWriter);
            }
                 
        }

        public void postBuildXml(System.Xml.XmlWriter xmlWriter)
        {
            if ( this.autoTerminationTriggerViewModel_ != null)
            {
                this.autoTerminationTriggerViewModel_.buildXml(xmlWriter);
            }

            if (this.postCalculationViewModel_ != null)
            {
                this.postCalculationViewModel_.buildXml(xmlWriter);
            }
        }

        public static EventTriggerViewModel CreateEventTrigger(string typeStr)
        {
            if ( typeStr == "simpleEventCouponTrigger")
            {
                return new SimpleEventCouponTriggerViewModel();
            }
            else if (typeStr == "vanillaRateTrigger")
            {
                return new VanillaRateTriggerViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static EventTriggerViewModel CreateEventTrigger(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            string typeStr = serial_EventTrigger.Type_.ValueStr;
            return EventTriggerViewModel.CreateEventTrigger(typeStr);
        }
    
    }
    
}

