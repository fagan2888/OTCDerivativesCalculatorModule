using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_valueSideResultViewModel : IXmlData
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
        
        public Excel_valueSideResultViewModel() { }
        
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region Dirty_
        private string dirty_;
        public string Dirty_
        {
            get { return this.dirty_; }
            set
            {
                if (this.dirty_ != value)
                {
                    this.dirty_ = value;
                    this.NotifyPropertyChanged("Dirty_");
                }
            }
        }
        #endregion
        
        #region Clean_
        private string clean_;
        public string Clean_
        {
            get { return this.clean_; }
            set
            {
                if (this.clean_ != value)
                {
                    this.clean_ = value;
                    this.NotifyPropertyChanged("Clean_");
                }
            }
        }
        #endregion
        
        #region AccrualAmt_
        private string accrualAmt_;
        public string AccrualAmt_
        {
            get { return this.accrualAmt_; }
            set
            {
                if (this.accrualAmt_ != value)
                {
                    this.accrualAmt_ = value;
                    this.NotifyPropertyChanged("AccrualAmt_");
                }
            }
        }
        #endregion
        
        #region Option_
        private string option_;
        public string Option_
        {
            get { return this.option_; }
            set
            {
                if (this.option_ != value)
                {
                    this.option_ = value;
                    this.NotifyPropertyChanged("Option_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_valueSideResult");
                xmlWriter.WriteStartElement("excel_valueSideResult");
                    xmlWriter.WriteElementString("type" , this.type_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("dirty" , this.dirty_);
                    
                    xmlWriter.WriteElementString("clean" , this.clean_);
                    
                    xmlWriter.WriteElementString("accrualAmt" , this.accrualAmt_);
                    
                    xmlWriter.WriteElementString("option" , this.option_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_valueSideResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_valueSideResult serial_Excel_valueSideResult = serial_Class as FpmlSerializedCSharp.Excel_valueSideResult;
        
            this.type_ = serial_Excel_valueSideResult.Type_.ValueStr;
            
            this.currency_ = serial_Excel_valueSideResult.Currency_.ValueStr;
            
            this.dirty_ = serial_Excel_valueSideResult.Dirty_.ValueStr;
            
            this.clean_ = serial_Excel_valueSideResult.Clean_.ValueStr;
            
            this.accrualAmt_ = serial_Excel_valueSideResult.AccrualAmt_.ValueStr;
            
            this.option_ = serial_Excel_valueSideResult.Option_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

