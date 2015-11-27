using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_creditEventsViewModel : IXmlData
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
        
        public Excel_creditEventsViewModel() { }
        
        #region FailureToPay_
        private string failureToPay_;
        public string FailureToPay_
        {
            get { return this.failureToPay_; }
            set
            {
                if (this.failureToPay_ != value)
                {
                    this.failureToPay_ = value;
                    this.NotifyPropertyChanged("FailureToPay_");
                }
            }
        }
        #endregion
        
        #region ObligationAcceleration_
        private string obligationAcceleration_;
        public string ObligationAcceleration_
        {
            get { return this.obligationAcceleration_; }
            set
            {
                if (this.obligationAcceleration_ != value)
                {
                    this.obligationAcceleration_ = value;
                    this.NotifyPropertyChanged("ObligationAcceleration_");
                }
            }
        }
        #endregion
        
        #region RepudiationMoratorium_
        private string repudiationMoratorium_;
        public string RepudiationMoratorium_
        {
            get { return this.repudiationMoratorium_; }
            set
            {
                if (this.repudiationMoratorium_ != value)
                {
                    this.repudiationMoratorium_ = value;
                    this.NotifyPropertyChanged("RepudiationMoratorium_");
                }
            }
        }
        #endregion
        
        #region Restructuring_
        private string restructuring_;
        public string Restructuring_
        {
            get { return this.restructuring_; }
            set
            {
                if (this.restructuring_ != value)
                {
                    this.restructuring_ = value;
                    this.NotifyPropertyChanged("Restructuring_");
                }
            }
        }
        #endregion
        
        #region DefaultRequirement_
        private string defaultRequirement_;
        public string DefaultRequirement_
        {
            get { return this.defaultRequirement_; }
            set
            {
                if (this.defaultRequirement_ != value)
                {
                    this.defaultRequirement_ = value;
                    this.NotifyPropertyChanged("DefaultRequirement_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_creditEvents");
                xmlWriter.WriteStartElement("excel_creditEvents");
                    xmlWriter.WriteElementString("failureToPay" , this.failureToPay_);
                    
                    xmlWriter.WriteElementString("obligationAcceleration" , this.obligationAcceleration_);
                    
                    xmlWriter.WriteElementString("repudiationMoratorium" , this.repudiationMoratorium_);
                    
                    xmlWriter.WriteElementString("restructuring" , this.restructuring_);
                    
                    xmlWriter.WriteElementString("defaultRequirement" , this.defaultRequirement_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_creditEventsView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_creditEvents serial_Excel_creditEvents = serial_Class as FpmlSerializedCSharp.Excel_creditEvents;
        
            this.failureToPay_ = serial_Excel_creditEvents.FailureToPay_.ValueStr;
            
            this.obligationAcceleration_ = serial_Excel_creditEvents.ObligationAcceleration_.ValueStr;
            
            this.repudiationMoratorium_ = serial_Excel_creditEvents.RepudiationMoratorium_.ValueStr;
            
            this.restructuring_ = serial_Excel_creditEvents.Restructuring_.ValueStr;
            
            this.defaultRequirement_ = serial_Excel_creditEvents.DefaultRequirement_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

