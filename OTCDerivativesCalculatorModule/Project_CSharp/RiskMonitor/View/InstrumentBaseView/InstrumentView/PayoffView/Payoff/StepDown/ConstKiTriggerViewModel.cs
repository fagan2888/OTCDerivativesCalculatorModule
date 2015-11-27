using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ConstKiTriggerViewModel : KiEventInfoViewModel
    {
    
    
        public ConstKiTriggerViewModel() { }
        
    
        #region PastKI_
        private string pastKI_;
        public string PastKI_
        {
            get { return this.pastKI_; }
            set
            {
                if (this.pastKI_ != value)
                {
                    this.pastKI_ = value;
                    this.NotifyPropertyChanged("PastKI_");
                }
            }
        }
        #endregion
        
        #region Value_
        private ObservableCollection<string> value_;
        public ObservableCollection<string> Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("kiEventInfo");
                xmlWriter.WriteElementString("type" , "constKiTrigger");
                xmlWriter.WriteStartElement("constKiTrigger");
                    xmlWriter.WriteElementString("pastKI" , this.pastKI_);

                    foreach (var item in value_)
                    {
                        xmlWriter.WriteElementString("value", item);    
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.KiEventInfo serial_KiEventInfo = serial_Class as FpmlSerializedCSharp.KiEventInfo;
            FpmlSerializedCSharp.ConstKiTrigger serial_ConstKiTrigger = serial_KiEventInfo.ConstKiTrigger_;
        
            this.pastKI_ = serial_ConstKiTrigger.PastKI_.ValueStr;

            this.value_ = new ObservableCollection<string>();
            foreach (var item in serial_ConstKiTrigger.Value_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.view_ = new ConstKiTriggerView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
    }
    
}

