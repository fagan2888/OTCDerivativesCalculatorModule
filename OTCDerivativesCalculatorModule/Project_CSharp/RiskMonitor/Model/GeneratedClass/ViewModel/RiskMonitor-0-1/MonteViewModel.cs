using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MonteViewModel : MethodViewModel
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
        
        public MonteViewModel() { }
        
        #region SimulationNum_
        private string simulationNum_;
        public string SimulationNum_
        {
            get { return this.simulationNum_; }
            set
            {
                if (this.simulationNum_ != value)
                {
                    this.simulationNum_ = value;
                    this.NotifyPropertyChanged("SimulationNum_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("method");
                xmlWriter.WriteElementString("type" , "monte");
                xmlWriter.WriteStartElement("monte");
                    xmlWriter.WriteElementString("simulationNum" , this.simulationNum_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new MonteView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Method serial_Method = serial_Class as FpmlSerializedCSharp.Method;
            FpmlSerializedCSharp.Monte serial_Monte = serial_Method.Monte_;
        
            this.simulationNum_ = serial_Monte.SimulationNum_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

