using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_TerminationEventDetail_targetViewModel : GeneralTerminationEventDetailViewModel
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
        
        public General_TerminationEventDetail_targetViewModel() { }
        
        #region Target_
        private string target_;
        public string Target_
        {
            get { return this.target_; }
            set
            {
                if (this.target_ != value)
                {
                    this.target_ = value;
                    this.NotifyPropertyChanged("Target_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalTerminationEventDetail");
                xmlWriter.WriteElementString("excel_type" , "general_TerminationEventDetail_target");
                xmlWriter.WriteStartElement("general_TerminationEventDetail_target");
                    xmlWriter.WriteElementString("target" , this.target_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new General_TerminationEventDetail_targetView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralTerminationEventDetail serial_GeneralTerminationEventDetail = serial_Class as FpmlSerializedCSharp.GeneralTerminationEventDetail;
            FpmlSerializedCSharp.General_TerminationEventDetail_target serial_General_TerminationEventDetail_target = serial_GeneralTerminationEventDetail.General_TerminationEventDetail_target_;
        
            this.target_ = serial_General_TerminationEventDetail_target.Target_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

