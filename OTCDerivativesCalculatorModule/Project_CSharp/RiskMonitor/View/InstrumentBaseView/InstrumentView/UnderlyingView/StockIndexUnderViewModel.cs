using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class StockIndexUnderViewModel : IndexUnderViewModel
    {
        // 증자 이런 이벤트
        
        public StockIndexUnderViewModel()
        {
            this.type_ = "stockIndex";
        }


        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("index");
                xmlWriter.WriteElementString("krCode", this.krCode_);
                xmlWriter.WriteElementString("name", this.name_);
                xmlWriter.WriteElementString("basePrice", Convert.ToString(this.basePrice_));

                xmlWriter.WriteElementString("type" , "stockIndex");
            
                xmlWriter.WriteStartElement("stockIndex");
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Index serial_index = serial_Class as FpmlSerializedCSharp.Index;
            FpmlSerializedCSharp.StockIndex serial_stockIndex = serial_index.StockIndex_;

            //this.KRCode_ = serial_stockIndex.KrCode_.ValueStr;
            //this.Name_ = serial_stockIndex.Name_.ValueStr;
            //this.BasePrice_ = serial_stockIndex.BasePrice_.DoubleValue();

        }
    }
}
