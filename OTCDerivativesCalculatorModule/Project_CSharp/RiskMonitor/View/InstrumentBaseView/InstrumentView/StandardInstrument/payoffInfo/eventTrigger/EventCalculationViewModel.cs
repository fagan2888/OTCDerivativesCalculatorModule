using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class EventCalculationViewModel : IXmlData
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
    
        public EventCalculationViewModel() { }
    
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
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
        
        #region PastEventOcc_
        private string pastEventOcc_;
        public string PastEventOcc_
        {
            get { return this.pastEventOcc_; }
            set
            {
                if (this.pastEventOcc_ != value)
                {
                    this.pastEventOcc_ = value;
                    this.NotifyPropertyChanged("PastEventOcc_");
                }
            }
        }
        #endregion
        
        #region RefVariable_eventOccViewModel_
        private RefVariable_eventOccViewModel refVariable_eventOccViewModel_;
        public RefVariable_eventOccViewModel RefVariable_eventOccViewModel_
        {
            get { return this.refVariable_eventOccViewModel_; }
            set
            {
                if (this.refVariable_eventOccViewModel_ != value)
                {
                    this.refVariable_eventOccViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariable_eventOccViewModel_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
        public static EventCalculationViewModel CreateEventCalculation(string typeStr)
        {
            if ( typeStr == "upperBarrierEventCal")
            {
                return new UpperBarrierEventCalViewModel();
            }
            else if ( typeStr == "lowerBarrierEventCal")
            {
                return new LowerBarrierEventCalViewModel();
            }
            else if ( typeStr == "dualBarrierEventCal")
            {
                return new DualBarrierEventCalViewModel();
            }
            else if ( typeStr == "simpleRangeEventCal")
            {
                return new SimpleRangeEventCalViewModel();
            }
            else if ( typeStr == "referenceEventCal")
            {
                return new ReferenceEventCalViewModel();
            }
            else
            {
                throw new NotImplementedException();    
            }
        }
        
        public static EventCalculationViewModel CreateEventCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculation serial_EventCalculation = serial_Class as FpmlSerializedCSharp.EventCalculation;
            string typeStr = serial_EventCalculation.Type_.ValueStr;
            return EventCalculationViewModel.CreateEventCalculation(typeStr);
        }
        
    
    }
    
}

