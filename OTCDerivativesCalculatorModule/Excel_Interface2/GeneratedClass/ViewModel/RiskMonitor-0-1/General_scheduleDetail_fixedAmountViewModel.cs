using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_scheduleDetail_fixedAmountViewModel : GeneralScheduleDeatilViewModel
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
        
        public General_scheduleDetail_fixedAmountViewModel() { }
        
        #region FixedAmount_
        private string fixedAmount_;
        public string FixedAmount_
        {
            get { return this.fixedAmount_; }
            set
            {
                if (this.fixedAmount_ != value)
                {
                    this.fixedAmount_ = value;
                    this.NotifyPropertyChanged("FixedAmount_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalScheduleDeatil");
                xmlWriter.WriteElementString("excel_type" , "general_scheduleDetail_fixedAmount");
                xmlWriter.WriteStartElement("general_scheduleDetail_fixedAmount");
                    xmlWriter.WriteElementString("fixedAmount" , this.fixedAmount_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new General_scheduleDetail_fixedAmountView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralScheduleDeatil serial_GeneralScheduleDeatil = serial_Class as FpmlSerializedCSharp.GeneralScheduleDeatil;
            FpmlSerializedCSharp.General_scheduleDetail_fixedAmount serial_General_scheduleDetail_fixedAmount = serial_GeneralScheduleDeatil.General_scheduleDetail_fixedAmount_;
        
            this.fixedAmount_ = serial_General_scheduleDetail_fixedAmount.FixedAmount_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

