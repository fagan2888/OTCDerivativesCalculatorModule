using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PreEventCalculationViewModel : IXmlData
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
        
        public PreEventCalculationViewModel() { }
        
        #region EventCalculationListViewModel_
        private ObservableCollection<EventCalculationListViewModel> eventCalculationListViewModel_;
        public ObservableCollection<EventCalculationListViewModel> EventCalculationListViewModel_
        {
            get { return this.eventCalculationListViewModel_; }
            set
            {
                if (this.eventCalculationListViewModel_ != value)
                {
                    this.eventCalculationListViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationListViewModel_");
                }
            }
        }
        #endregion
        
        #region JointEventCalculationViewModel_
        private ObservableCollection<JointEventCalculationViewModel> jointEventCalculationViewModel_;
        public ObservableCollection<JointEventCalculationViewModel> JointEventCalculationViewModel_
        {
            get { return this.jointEventCalculationViewModel_; }
            set
            {
                if (this.jointEventCalculationViewModel_ != value)
                {
                    this.jointEventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("JointEventCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "preEventCalculation");
                xmlWriter.WriteStartElement("preEventCalculation");
                    foreach (var item in eventCalculationListViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    foreach (var item in jointEventCalculationViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new PreEventCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PreEventCalculation serial_PreEventCalculation = serial_Class as FpmlSerializedCSharp.PreEventCalculation;
        
            List<FpmlSerializedCSharp.EventCalculationList> serial_eventCalculationList = serial_PreEventCalculation.EventCalculationList_;
            this.eventCalculationListViewModel_ = new ObservableCollection<EventCalculationListViewModel>();
            foreach (var item in serial_eventCalculationList)
            {
                string type = item.Excel_type_.ValueStr;
                EventCalculationListViewModel viewModel = EventCalculationListViewModel.CreateEventCalculationList(type);
                viewModel.setFromSerial(item);
                this.eventCalculationListViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.JointEventCalculation> serial_jointEventCalculation = serial_PreEventCalculation.JointEventCalculation_;
            this.jointEventCalculationViewModel_ = new ObservableCollection<JointEventCalculationViewModel>();
            foreach (var item in serial_jointEventCalculation)
            {
                string type = item.Excel_type_.ValueStr;
                JointEventCalculationViewModel viewModel = JointEventCalculationViewModel.CreateJointEventCalculation(type);
                viewModel.setFromSerial(item);
                this.jointEventCalculationViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

