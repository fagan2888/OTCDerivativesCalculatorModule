using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_indexTypeViewModel : Excel_underlyingInfoViewModel
    {
        public Excel_indexTypeViewModel() 
        {
            this.Excel_type_ = "excel_indexType";
        }
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_indexType");
                xmlWriter.WriteStartElement("excel_indexType");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    xmlWriter.WriteElementString("name", this.nameTrans_.Value_);
                    xmlWriter.WriteElementString("sub_type", this.sub_type_);
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    xmlWriter.WriteElementString("linkedCurve", this.linkedCurveCode_);
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo serial_Excel_underlyingInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo;
            FpmlSerializedCSharp.Excel_indexType serial_Excel_indexType = serial_Excel_underlyingInfo.Excel_indexType_;

            this.krCode_ = serial_Excel_indexType.KrCode_.ValueStr;

            this.nameTrans_ = new NameTrans(serial_Excel_indexType.Name_.ValueStr);

            this.tenor_ = serial_Excel_indexType.Tenor_.ValueStr;

            this.sub_type_ = serial_Excel_indexType.Sub_type_.ValueStr;

            this.linkedCurveCode_ = serial_Excel_indexType.LinkedCurve_.ValueStr;

            this.basePrice_ = serial_Excel_indexType.BasePrice_.ValueStr;
            
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
    
}

