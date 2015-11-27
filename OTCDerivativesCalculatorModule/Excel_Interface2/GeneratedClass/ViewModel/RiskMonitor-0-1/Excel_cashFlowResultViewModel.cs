using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_cashFlowResultViewModel : IXmlData
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
        
        public Excel_cashFlowResultViewModel() { }
        
        #region Seq_
        private string seq_;
        public string Seq_
        {
            get { return this.seq_; }
            set
            {
                if (this.seq_ != value)
                {
                    this.seq_ = value;
                    this.NotifyPropertyChanged("Seq_");
                }
            }
        }
        #endregion
        
        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion
        
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
        
        #region CashFlow_
        private string cashFlow_;
        public string CashFlow_
        {
            get { return this.cashFlow_; }
            set
            {
                if (this.cashFlow_ != value)
                {
                    this.cashFlow_ = value;
                    this.NotifyPropertyChanged("CashFlow_");
                }
            }
        }
        #endregion
        
        #region Yield_
        private string yield_;
        public string Yield_
        {
            get { return this.yield_; }
            set
            {
                if (this.yield_ != value)
                {
                    this.yield_ = value;
                    this.NotifyPropertyChanged("Yield_");
                }
            }
        }
        #endregion
        
        #region Discount_
        private string discount_;
        public string Discount_
        {
            get { return this.discount_; }
            set
            {
                if (this.discount_ != value)
                {
                    this.discount_ = value;
                    this.NotifyPropertyChanged("Discount_");
                }
            }
        }
        #endregion
        
        #region ExProb_
        private string exProb_;
        public string ExProb_
        {
            get { return this.exProb_; }
            set
            {
                if (this.exProb_ != value)
                {
                    this.exProb_ = value;
                    this.NotifyPropertyChanged("ExProb_");
                }
            }
        }
        #endregion
        
        #region NotionalPayment_
        private string notionalPayment_;
        public string NotionalPayment_
        {
            get { return this.notionalPayment_; }
            set
            {
                if (this.notionalPayment_ != value)
                {
                    this.notionalPayment_ = value;
                    this.NotifyPropertyChanged("NotionalPayment_");
                }
            }
        }
        #endregion
        
        #region FxRate_forward_
        private string fxRate_forward_;
        public string FxRate_forward_
        {
            get { return this.fxRate_forward_; }
            set
            {
                if (this.fxRate_forward_ != value)
                {
                    this.fxRate_forward_ = value;
                    this.NotifyPropertyChanged("FxRate_forward_");
                }
            }
        }
        #endregion
        
        #region Value_
        private string value_;
        public string Value_
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_cashFlowResult");
                xmlWriter.WriteStartElement("excel_cashFlowResult");
                    xmlWriter.WriteElementString("seq" , this.seq_);
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("type" , this.type_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("cashFlow" , this.cashFlow_);
                    
                    xmlWriter.WriteElementString("yield" , this.yield_);
                    
                    xmlWriter.WriteElementString("discount" , this.discount_);
                    
                    xmlWriter.WriteElementString("exProb" , this.exProb_);
                    
                    xmlWriter.WriteElementString("notionalPayment" , this.notionalPayment_);
                    
                    xmlWriter.WriteElementString("fxRate_forward" , this.fxRate_forward_);
                    
                    xmlWriter.WriteElementString("value" , this.value_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_cashFlowResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_cashFlowResult serial_Excel_cashFlowResult = serial_Class as FpmlSerializedCSharp.Excel_cashFlowResult;
        
            this.seq_ = serial_Excel_cashFlowResult.Seq_.ValueStr;
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_cashFlowResult.EventDate_.ValueStr);
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_cashFlowResult.PayoffDate_.ValueStr);
            
            this.type_ = serial_Excel_cashFlowResult.Type_.ValueStr;
            
            this.currency_ = serial_Excel_cashFlowResult.Currency_.ValueStr;
            
            this.cashFlow_ = serial_Excel_cashFlowResult.CashFlow_.ValueStr;
            
            this.yield_ = serial_Excel_cashFlowResult.Yield_.ValueStr;
            
            this.discount_ = serial_Excel_cashFlowResult.Discount_.ValueStr;
            
            this.exProb_ = serial_Excel_cashFlowResult.ExProb_.ValueStr;
            
            this.notionalPayment_ = serial_Excel_cashFlowResult.NotionalPayment_.ValueStr;
            
            this.fxRate_forward_ = serial_Excel_cashFlowResult.FxRate_forward_.ValueStr;
            
            this.value_ = serial_Excel_cashFlowResult.Value_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

