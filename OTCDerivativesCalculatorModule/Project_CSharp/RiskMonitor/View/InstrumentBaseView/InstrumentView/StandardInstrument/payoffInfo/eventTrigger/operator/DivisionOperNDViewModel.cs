using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DivisionOperNDViewModel : OperatorNDViewModel
    {
     
        
    
        public DivisionOperNDViewModel() { }
        
    
        #region Weight_
        private ObservableCollection<string> weight_;
        public ObservableCollection<string> Weight_
        {
            get { return this.weight_; }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                    this.NotifyPropertyChanged("Weight_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("operatorND");
                xmlWriter.WriteElementString("type" , "divisionOperND");
                xmlWriter.WriteStartElement("divisionOperND");

                foreach (var item in weight_)
                {
                    xmlWriter.WriteElementString("weight", item);
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
            FpmlSerializedCSharp.OperatorND serial_OperatorND = serial_Class as FpmlSerializedCSharp.OperatorND;
            FpmlSerializedCSharp.DivisionOperND serial_DivisionOperND = serial_OperatorND.DivisionOperND_;

            this.weight_ = new ObservableCollection<string>();
            foreach (var item in serial_DivisionOperND.Weight_)
            {
                this.weight_.Add(item.ValueStr);
            }
            
           //this.view_ = new DivisionOperNDView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

