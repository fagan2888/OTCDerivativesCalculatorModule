using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_swapLegInfoViewModel : Excel_issueInfoViewModel
    {
        public Excel_swapLegInfoViewModel() { }
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_swapLegInfo");
                xmlWriter.WriteStartElement("excel_swapLegInfo");
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    xmlWriter.WriteElementString("currency", this.currency_.CurrencyString_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);
                    //xmlWriter.WriteElementString("premium" , this.premium_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_swapLegInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_swapLegInfo serial_Excel_swapLegInfo = serial_Excel_issueInfo.Excel_swapLegInfo_;
        
            this.notional_ = serial_Excel_swapLegInfo.Notional_.ValueStr;
            this.currency_ = CurrencyViewModel.CreateCurrencyComboViewModel(serial_Excel_swapLegInfo.Currency_.ValueStr);
            this.vba_description_ = serial_Excel_swapLegInfo.Vba_description_.ValueStr;
            //this.premium_ = serial_Excel_swapLegInfo.Premium_.ValueStr;
            
        }

        //public override void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void vmBuildFromExcel_interface()
        //{
        //    throw new NotImplementedException();
        //}
    }
    
}

