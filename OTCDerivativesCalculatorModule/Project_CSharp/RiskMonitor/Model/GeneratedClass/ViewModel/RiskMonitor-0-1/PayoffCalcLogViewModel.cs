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
    public class PayoffCalcLogViewModel : IXmlData
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
        
        public PayoffCalcLogViewModel() { }
        
        #region PathDate_
        private ObservableCollection<string> pathDate_;
        public ObservableCollection<string> PathDate_
        {
            get { return this.pathDate_; }
            set
            {
                if (this.pathDate_ != value)
                {
                    this.pathDate_ = value;
                    this.NotifyPropertyChanged("PathDate_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "payoffCalcLog");
                xmlWriter.WriteStartElement("payoffCalcLog");
                    xmlWriter.WriteElementString("pathDate" , this.pathDate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new PayoffCalcLogView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffCalcLog serial_PayoffCalcLog = serial_Class as FpmlSerializedCSharp.PayoffCalcLog;
        
            this.pathDateViewModel_ = new ObservableCollection<PathDateViewModel>();
            foreach (var item in serial_PayoffCalcLog.PathDate_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
        
    
        
    
    }
    
}

