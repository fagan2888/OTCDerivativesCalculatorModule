using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class EventCalculationViewModel : IXmlData
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
        
        #region UpperBarrierEventCalViewModel_
        private UpperBarrierEventCalViewModel upperBarrierEventCalViewModel_;
        public UpperBarrierEventCalViewModel UpperBarrierEventCalViewModel_
        {
            get { return this.upperBarrierEventCalViewModel_; }
            set
            {
                if (this.upperBarrierEventCalViewModel_ != value)
                {
                    this.upperBarrierEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("UpperBarrierEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region LowerBarrierEventCalViewModel_
        private LowerBarrierEventCalViewModel lowerBarrierEventCalViewModel_;
        public LowerBarrierEventCalViewModel LowerBarrierEventCalViewModel_
        {
            get { return this.lowerBarrierEventCalViewModel_; }
            set
            {
                if (this.lowerBarrierEventCalViewModel_ != value)
                {
                    this.lowerBarrierEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("LowerBarrierEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region DualBarrierEventCalViewModel_
        private DualBarrierEventCalViewModel dualBarrierEventCalViewModel_;
        public DualBarrierEventCalViewModel DualBarrierEventCalViewModel_
        {
            get { return this.dualBarrierEventCalViewModel_; }
            set
            {
                if (this.dualBarrierEventCalViewModel_ != value)
                {
                    this.dualBarrierEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("DualBarrierEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region SimpleRangeEventCalViewModel_
        private SimpleRangeEventCalViewModel simpleRangeEventCalViewModel_;
        public SimpleRangeEventCalViewModel SimpleRangeEventCalViewModel_
        {
            get { return this.simpleRangeEventCalViewModel_; }
            set
            {
                if (this.simpleRangeEventCalViewModel_ != value)
                {
                    this.simpleRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region ReferenceEventCalViewModel_
        private ReferenceEventCalViewModel referenceEventCalViewModel_;
        public ReferenceEventCalViewModel ReferenceEventCalViewModel_
        {
            get { return this.referenceEventCalViewModel_; }
            set
            {
                if (this.referenceEventCalViewModel_ != value)
                {
                    this.referenceEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceEventCalViewModel_");
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
        
        public string choiceStr_eventCalType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static EventCalculationViewModel CreateEventCalculation(string typeStr)
        {
            if ( typeStr == "preConditionEvent")
            {
                return new PreConditionEventViewModel();
            }
            else if ( typeStr == "upperBarrierEventCal")
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
            else if ( typeStr == "refVariable_eventOcc")
            {
                return new RefVariable_eventOccViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

