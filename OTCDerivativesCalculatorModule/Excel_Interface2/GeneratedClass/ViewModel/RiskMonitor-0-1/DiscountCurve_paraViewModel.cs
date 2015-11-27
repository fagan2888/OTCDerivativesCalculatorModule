using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DiscountCurve_paraViewModel : IXmlData
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
        
        public DiscountCurve_paraViewModel() { }
        
        #region YieldTermstructureViewModel_
        private YieldTermstructureViewModel yieldTermstructureViewModel_;
        public YieldTermstructureViewModel YieldTermstructureViewModel_
        {
            get { return this.yieldTermstructureViewModel_; }
            set
            {
                if (this.yieldTermstructureViewModel_ != value)
                {
                    this.yieldTermstructureViewModel_ = value;
                    this.NotifyPropertyChanged("YieldTermstructureViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "discountCurve_para");
                xmlWriter.WriteStartElement("discountCurve_para");
                    yieldTermstructureViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new DiscountCurve_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DiscountCurve_para serial_DiscountCurve_para = serial_Class as FpmlSerializedCSharp.DiscountCurve_para;
        
            FpmlSerializedCSharp.YieldTermstructure serial_yieldTermstructure = serial_DiscountCurve_para.YieldTermstructure_;
            string yieldTermstructuretype = serial_yieldTermstructure.Excel_type_.ValueStr;
            this.yieldTermstructureViewModel_ = YieldTermstructureViewModel.CreateYieldTermstructure(yieldTermstructuretype);
            this.yieldTermstructureViewModel_.setFromSerial(serial_yieldTermstructure);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

