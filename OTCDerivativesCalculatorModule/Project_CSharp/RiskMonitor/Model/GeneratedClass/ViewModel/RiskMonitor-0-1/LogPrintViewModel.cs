using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace Excel_Interface
{
    public class LogPrintViewModel : IXmlData
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
        
        public LogPrintViewModel() { }
        
        #region GeneratedPathLog_
        private string generatedPathLog_;
        public string GeneratedPathLog_
        {
            get { return this.generatedPathLog_; }
            set
            {
                if (this.generatedPathLog_ != value)
                {
                    this.generatedPathLog_ = value;
                    this.NotifyPropertyChanged("GeneratedPathLog_");
                }
            }
        }
        #endregion
        
        #region PayoffCalcLog_
        private string payoffCalcLog_;
        public string PayoffCalcLog_
        {
            get { return this.payoffCalcLog_; }
            set
            {
                if (this.payoffCalcLog_ != value)
                {
                    this.payoffCalcLog_ = value;
                    this.NotifyPropertyChanged("PayoffCalcLog_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "logPrint");
                xmlWriter.WriteStartElement("logPrint");
                    xmlWriter.WriteElementString("generatedPathLog" , this.generatedPathLog_);
                    
                    xmlWriter.WriteElementString("payoffCalcLog" , this.payoffCalcLog_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new LogPrintView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.LogPrint serial_LogPrint = serial_Class as FpmlSerializedCSharp.LogPrint;
        
            this.generatedPathLog_ = serial_LogPrint.GeneratedPathLog_.ValueStr;
            
            this.payoffCalcLog_ = serial_LogPrint.PayoffCalcLog_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

