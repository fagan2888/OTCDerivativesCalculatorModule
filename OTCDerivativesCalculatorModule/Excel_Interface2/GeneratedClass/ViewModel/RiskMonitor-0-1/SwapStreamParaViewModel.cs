using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SwapStreamParaViewModel : IXmlData
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
        
        public SwapStreamParaViewModel() { }
        
        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion
        
        #region DiscountCurve_paraViewModel_
        private DiscountCurve_paraViewModel discountCurve_paraViewModel_;
        public DiscountCurve_paraViewModel DiscountCurve_paraViewModel_
        {
            get { return this.discountCurve_paraViewModel_; }
            set
            {
                if (this.discountCurve_paraViewModel_ != value)
                {
                    this.discountCurve_paraViewModel_ = value;
                    this.NotifyPropertyChanged("DiscountCurve_paraViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "swapStreamPara");
                xmlWriter.WriteStartElement("swapStreamPara");
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new SwapStreamParaView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SwapStreamPara serial_SwapStreamPara = serial_Class as FpmlSerializedCSharp.SwapStreamPara;
        
            this.notional_ = serial_SwapStreamPara.Notional_.ValueStr;
            
            FpmlSerializedCSharp.DiscountCurve_para serial_discountCurve_para = serial_SwapStreamPara.DiscountCurve_para_;
            string discountCurve_paratype = serial_discountCurve_para.Excel_type_.ValueStr;
            this.discountCurve_paraViewModel_ = DiscountCurve_paraViewModel.CreateDiscountCurve_para(discountCurve_paratype);
            this.discountCurve_paraViewModel_.setFromSerial(serial_discountCurve_para);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

