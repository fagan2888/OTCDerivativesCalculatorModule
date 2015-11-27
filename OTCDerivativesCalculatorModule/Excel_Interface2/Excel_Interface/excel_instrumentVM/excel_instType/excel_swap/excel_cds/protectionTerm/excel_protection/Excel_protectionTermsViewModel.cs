using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_protectionTermsViewModel : IXmlData
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
        
        public Excel_protectionTermsViewModel() 
        {
            this.excel_creditEventsViewModel_ = new Excel_creditEventsViewModel();
            this.excel_obligationsViewModel_ = new Excel_obligationsViewModel();
            this.accrualCoupon_ = "default";
        }
        
        #region Excel_creditEventsViewModel_
        private Excel_creditEventsViewModel excel_creditEventsViewModel_;
        public Excel_creditEventsViewModel Excel_creditEventsViewModel_
        {
            get { return this.excel_creditEventsViewModel_; }
            set
            {
                if (this.excel_creditEventsViewModel_ != value)
                {
                    this.excel_creditEventsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventsViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_obligationsViewModel_
        private Excel_obligationsViewModel excel_obligationsViewModel_;
        public Excel_obligationsViewModel Excel_obligationsViewModel_
        {
            get { return this.excel_obligationsViewModel_; }
            set
            {
                if (this.excel_obligationsViewModel_ != value)
                {
                    this.excel_obligationsViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_obligationsViewModel_");
                }
            }
        }
        #endregion
        
        #region AccrualCoupon_
        private string accrualCoupon_;
        public string AccrualCoupon_
        {
            get { return this.accrualCoupon_; }
            set
            {
                if (this.accrualCoupon_ != value)
                {
                    this.accrualCoupon_ = value;
                    this.NotifyPropertyChanged("AccrualCoupon_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
    
            xmlWriter.WriteStartElement("excel_protectionTerms");
                excel_creditEventsViewModel_.buildXml(xmlWriter);
                    
                excel_obligationsViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteElementString("accrualCoupon" , this.accrualCoupon_);
                    
          
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_protectionTermsView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_protectionTerms serial_Excel_protectionTerms = serial_Class as FpmlSerializedCSharp.Excel_protectionTerms;
        
            FpmlSerializedCSharp.Excel_creditEvents serial_excel_creditEvents = serial_Excel_protectionTerms.Excel_creditEvents_;
            //string excel_creditEventstype = serial_excel_creditEvents.Excel_type_.ValueStr;
            this.excel_creditEventsViewModel_ = new Excel_creditEventsViewModel();
            this.excel_creditEventsViewModel_.setFromSerial(serial_excel_creditEvents);
            
            FpmlSerializedCSharp.Excel_obligations serial_excel_obligations = serial_Excel_protectionTerms.Excel_obligations_;
            //string excel_obligationstype = serial_excel_obligations.Excel_type_.ValueStr;
            this.excel_obligationsViewModel_ = new Excel_obligationsViewModel();
            this.excel_obligationsViewModel_.setFromSerial(serial_excel_obligations);
            
            this.accrualCoupon_ = serial_Excel_protectionTerms.AccrualCoupon_.ValueStr;
            
        }
    
    }
    
}

