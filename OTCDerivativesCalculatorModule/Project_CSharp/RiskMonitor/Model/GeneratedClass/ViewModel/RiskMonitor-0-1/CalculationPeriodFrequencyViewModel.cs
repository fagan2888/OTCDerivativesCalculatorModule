using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CalculationPeriodFrequencyViewModel : IXmlData
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
        
        public CalculationPeriodFrequencyViewModel() { }
        
        #region PeriodMultiplier_
        private string periodMultiplier_;
        public string PeriodMultiplier_
        {
            get { return this.periodMultiplier_; }
            set
            {
                if (this.periodMultiplier_ != value)
                {
                    this.periodMultiplier_ = value;
                    this.NotifyPropertyChanged("PeriodMultiplier_");
                }
            }
        }
        #endregion
        
        #region Period_
        private string period_;
        public string Period_
        {
            get { return this.period_; }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                    this.NotifyPropertyChanged("Period_");
                }
            }
        }
        #endregion
        
        #region RollConvention_
        private string rollConvention_;
        public string RollConvention_
        {
            get { return this.rollConvention_; }
            set
            {
                if (this.rollConvention_ != value)
                {
                    this.rollConvention_ = value;
                    this.NotifyPropertyChanged("RollConvention_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "calculationPeriodFrequency");
                xmlWriter.WriteStartElement("calculationPeriodFrequency");
                    xmlWriter.WriteElementString("periodMultiplier" , this.periodMultiplier_);
                    
                    xmlWriter.WriteElementString("period" , this.period_);
                    
                    xmlWriter.WriteElementString("rollConvention" , this.rollConvention_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CalculationPeriodFrequencyView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CalculationPeriodFrequency serial_CalculationPeriodFrequency = serial_Class as FpmlSerializedCSharp.CalculationPeriodFrequency;
        
            this.periodMultiplier_ = serial_CalculationPeriodFrequency.PeriodMultiplier_.ValueStr;
            
            this.period_ = serial_CalculationPeriodFrequency.Period_.ValueStr;
            
            this.rollConvention_ = serial_CalculationPeriodFrequency.RollConvention_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

