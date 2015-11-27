using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_obligationsViewModel : IXmlData
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
        
        public Excel_obligationsViewModel() { }
        
        #region Category_
        private string category_;
        public string Category_
        {
            get { return this.category_; }
            set
            {
                if (this.category_ != value)
                {
                    this.category_ = value;
                    this.NotifyPropertyChanged("Category_");
                }
            }
        }
        #endregion
        
        #region NotSubordinated_
        private string notSubordinated_;
        public string NotSubordinated_
        {
            get { return this.notSubordinated_; }
            set
            {
                if (this.notSubordinated_ != value)
                {
                    this.notSubordinated_ = value;
                    this.NotifyPropertyChanged("NotSubordinated_");
                }
            }
        }
        #endregion
        
        #region NotDomesticCurrency_
        private string notDomesticCurrency_;
        public string NotDomesticCurrency_
        {
            get { return this.notDomesticCurrency_; }
            set
            {
                if (this.notDomesticCurrency_ != value)
                {
                    this.notDomesticCurrency_ = value;
                    this.NotifyPropertyChanged("NotDomesticCurrency_");
                }
            }
        }
        #endregion
        
        #region NotDomesticLaw_
        private string notDomesticLaw_;
        public string NotDomesticLaw_
        {
            get { return this.notDomesticLaw_; }
            set
            {
                if (this.notDomesticLaw_ != value)
                {
                    this.notDomesticLaw_ = value;
                    this.NotifyPropertyChanged("NotDomesticLaw_");
                }
            }
        }
        #endregion
        
        #region NotDomesticIssuance_
        private string notDomesticIssuance_;
        public string NotDomesticIssuance_
        {
            get { return this.notDomesticIssuance_; }
            set
            {
                if (this.notDomesticIssuance_ != value)
                {
                    this.notDomesticIssuance_ = value;
                    this.NotifyPropertyChanged("NotDomesticIssuance_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_obligations");
                xmlWriter.WriteStartElement("excel_obligations");
                    xmlWriter.WriteElementString("category" , this.category_);
                    
                    xmlWriter.WriteElementString("notSubordinated" , this.notSubordinated_);
                    
                    xmlWriter.WriteElementString("notDomesticCurrency" , this.notDomesticCurrency_);
                    
                    xmlWriter.WriteElementString("notDomesticLaw" , this.notDomesticLaw_);
                    
                    xmlWriter.WriteElementString("notDomesticIssuance" , this.notDomesticIssuance_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_obligationsView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_obligations serial_Excel_obligations = serial_Class as FpmlSerializedCSharp.Excel_obligations;
        
            this.category_ = serial_Excel_obligations.Category_.ValueStr;
            
            this.notSubordinated_ = serial_Excel_obligations.NotSubordinated_.ValueStr;
            
            this.notDomesticCurrency_ = serial_Excel_obligations.NotDomesticCurrency_.ValueStr;
            
            this.notDomesticLaw_ = serial_Excel_obligations.NotDomesticLaw_.ValueStr;
            
            this.notDomesticIssuance_ = serial_Excel_obligations.NotDomesticIssuance_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

