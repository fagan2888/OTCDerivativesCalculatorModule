using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class EventCalculationInfoViewModel : IXmlData
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
        
        public EventCalculationInfoViewModel() { }
        
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
        
        #region EventCalculationViewModel_
        private ObservableCollection<EventCalculationViewModel> eventCalculationViewModel_;
        public ObservableCollection<EventCalculationViewModel> EventCalculationViewModel_
        {
            get { return this.eventCalculationViewModel_; }
            set
            {
                if (this.eventCalculationViewModel_ != value)
                {
                    this.eventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region JointSimpleCalculationViewModel_
        private JointSimpleCalculationViewModel jointSimpleCalculationViewModel_;
        public JointSimpleCalculationViewModel JointSimpleCalculationViewModel_
        {
            get { return this.jointSimpleCalculationViewModel_; }
            set
            {
                if (this.jointSimpleCalculationViewModel_ != value)
                {
                    this.jointSimpleCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("JointSimpleCalculationViewModel_");
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "eventCalculationInfo");
                xmlWriter.WriteStartElement("eventCalculationInfo");
                    preConditionEventViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in eventCalculationViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    jointSimpleCalculationViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("pastEventOcc" , this.pastEventOcc_);
                    
                    refVariable_eventOccViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new EventCalculationInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculationInfo serial_EventCalculationInfo = serial_Class as FpmlSerializedCSharp.EventCalculationInfo;
        
            FpmlSerializedCSharp.PreConditionEvent serial_preConditionEvent = serial_EventCalculationInfo.PreConditionEvent_;
            string preConditionEventtype = serial_preConditionEvent.Excel_type_.ValueStr;
            this.preConditionEventViewModel_ = PreConditionEventViewModel.CreatePreConditionEvent(preConditionEventtype);
            this.preConditionEventViewModel_.setFromSerial(serial_preConditionEvent);
            
            List<FpmlSerializedCSharp.EventCalculation> serial_eventCalculation = serial_EventCalculationInfo.EventCalculation_;
            this.eventCalculationViewModel_ = new ObservableCollection<EventCalculationViewModel>();
            foreach (var item in serial_eventCalculation)
            {
                string type = item.Excel_type_.ValueStr;
                EventCalculationViewModel viewModel = EventCalculationViewModel.CreateEventCalculation(type);
                viewModel.setFromSerial(item);
                this.eventCalculationViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.JointSimpleCalculation serial_jointSimpleCalculation = serial_EventCalculationInfo.JointSimpleCalculation_;
            string jointSimpleCalculationtype = serial_jointSimpleCalculation.Excel_type_.ValueStr;
            this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(jointSimpleCalculationtype);
            this.jointSimpleCalculationViewModel_.setFromSerial(serial_jointSimpleCalculation);
            
            this.pastEventOcc_ = serial_EventCalculationInfo.PastEventOcc_.ValueStr;
            
            FpmlSerializedCSharp.RefVariable_eventOcc serial_refVariable_eventOcc = serial_EventCalculationInfo.RefVariable_eventOcc_;
            string refVariable_eventOcctype = serial_refVariable_eventOcc.Excel_type_.ValueStr;
            this.refVariable_eventOccViewModel_ = RefVariable_eventOccViewModel.CreateRefVariable_eventOcc(refVariable_eventOcctype);
            this.refVariable_eventOccViewModel_.setFromSerial(serial_refVariable_eventOcc);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

