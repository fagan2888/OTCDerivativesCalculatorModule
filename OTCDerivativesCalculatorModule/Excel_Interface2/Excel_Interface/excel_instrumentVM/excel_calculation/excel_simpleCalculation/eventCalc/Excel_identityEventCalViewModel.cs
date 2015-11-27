using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_identityEventCalViewModel : Excel_eventCalcInfoViewModel
    {
        public Excel_identityEventCalViewModel() 
        {
        
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("excel_type", "excel_identityEventCal");
                xmlWriter.WriteStartElement("excel_identityEventCal");
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            //FpmlSerializedCSharp.Excel_identityEventCal serial_Excel_identityEventCal = serial_Excel_eventCalcInfo.Excel_identityEventCal_;

        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        public override System.Windows.Controls.Control view()
        {
            System.Windows.Controls.Control v = new Excel_identityEventCalView();

            v.DataContext = this;

            return v;
        }


        public override void defaultSetting()
        {
        }

        public override void descriptionUpdate()
        {
            this.description_ = "identity Test";
        }
    }
}
