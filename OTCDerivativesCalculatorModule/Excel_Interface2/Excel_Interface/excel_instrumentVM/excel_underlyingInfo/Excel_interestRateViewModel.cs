using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_interestRateViewModel : Excel_underlyingInfoViewModel
    {
        

        public Excel_interestRateViewModel() 
        {
            this.Excel_type_ = "excel_interestRate";
        }
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_interestRate");
                xmlWriter.WriteStartElement("excel_interestRate");
                    
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    xmlWriter.WriteElementString("name", this.nameTrans_.Value_);
                    xmlWriter.WriteElementString("tenor", this.tenor_);
                    xmlWriter.WriteElementString("linkedCurve", this.linkedCurveCode_);
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo serial_Excel_underlyingInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo;
            FpmlSerializedCSharp.Excel_interestRate serial_Excel_interestRate = serial_Excel_underlyingInfo.Excel_interestRate_;

            this.krCode_ = serial_Excel_interestRate.KrCode_.ValueStr;

            this.nameTrans_ = new NameTrans(serial_Excel_interestRate.Name_.ValueStr);

            this.tenor_ = serial_Excel_interestRate.Tenor_.ValueStr;

            this.linkedCurveCode_ = serial_Excel_interestRate.LinkedCurve_.ValueStr;

            this.basePrice_ = serial_Excel_interestRate.BasePrice_.ValueStr;


        }


    }
    
}

