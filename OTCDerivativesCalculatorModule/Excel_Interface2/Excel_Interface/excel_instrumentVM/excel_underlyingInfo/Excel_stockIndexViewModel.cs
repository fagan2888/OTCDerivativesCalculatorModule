using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_stockIndexViewModel : Excel_underlyingInfoViewModel
    {
        public Excel_stockIndexViewModel() 
        {
            this.Excel_type_ = "stock";
        }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_stockIndex");
                xmlWriter.WriteStartElement("excel_stockIndex");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("name", this.nameTrans_.Value_);
                    
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        { 
            
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo serial_Excel_underlyingInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo;
            FpmlSerializedCSharp.Excel_stockIndex serial_Excel_stockIndex = serial_Excel_underlyingInfo.Excel_stockIndex_;
        
            this.krCode_ = serial_Excel_stockIndex.KrCode_.ValueStr;
            
            this.nameTrans_ =  new NameTrans(serial_Excel_stockIndex.Name_.ValueStr);
            
            this.basePrice_ = serial_Excel_stockIndex.BasePrice_.ValueStr;
            
            //this.view_ = new Excel_stockIndexView();
            //this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

