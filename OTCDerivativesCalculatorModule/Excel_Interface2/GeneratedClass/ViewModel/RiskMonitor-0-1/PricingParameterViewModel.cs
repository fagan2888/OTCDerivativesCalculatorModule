using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PricingParameterViewModel : IXmlData
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
        
        public PricingParameterViewModel() { }
        
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
        
        #region MethodViewModel_
        private MethodViewModel methodViewModel_;
        public MethodViewModel MethodViewModel_
        {
            get { return this.methodViewModel_; }
            set
            {
                if (this.methodViewModel_ != value)
                {
                    this.methodViewModel_ = value;
                    this.NotifyPropertyChanged("MethodViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "pricingParameter");
                xmlWriter.WriteStartElement("pricingParameter");
                    xmlWriter.WriteElementString("type" , this.type_);
                    
                    methodViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new PricingParameterView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
        
            this.type_ = serial_PricingParameter.Type_.ValueStr;
            
            FpmlSerializedCSharp.Method serial_method = serial_PricingParameter.Method_;
            string methodtype = serial_method.Excel_type_.ValueStr;
            this.methodViewModel_ = MethodViewModel.CreateMethod(methodtype);
            this.methodViewModel_.setFromSerial(serial_method);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

