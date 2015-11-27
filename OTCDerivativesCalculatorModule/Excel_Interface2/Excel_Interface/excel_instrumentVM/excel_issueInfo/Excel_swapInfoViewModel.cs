using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_swapInfoViewModel : Excel_issueInfoViewModel
    {
        public Excel_swapInfoViewModel() 
        {
        
        }
        
        #region Premium_
        private string premium_;
        public string Premium_
        {
            get { return this.premium_; }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                    this.NotifyPropertyChanged("Premium_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_swapInfo");
                xmlWriter.WriteStartElement("excel_swapInfo");
                    //xmlWriter.WriteElementString("tradeDate", this.tradeDate_.ToString("yyyy-MM-dd"));
                    xmlWriter.WriteElementString("effectiveDate", this.effectiveDate_.ToString("yyyy-MM-dd"));
                    xmlWriter.WriteElementString("maturityDate", this.maturityDate_.ToString("yyyy-MM-dd"));
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    xmlWriter.WriteElementString("currency", this.currency_.CurrencyString_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_swapInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_swapInfo serial_Excel_swapInfo = serial_Excel_issueInfo.Excel_swapInfo_;

            //this.tradeDate_ = DateTime.ParseExact(serial_Excel_swapInfo.TradeDate_.ValueStr, StringFormat.XmlDateFormat_, null);
            this.effectiveDate_ = DateTime.ParseExact(serial_Excel_swapInfo.EffectiveDate_.ValueStr, StringFormat.XmlDateFormat_, null);
            this.maturityDate_ = DateTime.ParseExact(serial_Excel_swapInfo.MaturityDate_.ValueStr, StringFormat.XmlDateFormat_, null);
            
            this.notional_ = serial_Excel_swapInfo.Notional_.ValueStr;
            this.premium_ = serial_Excel_swapInfo.Premium_.ValueStr;

            this.currency_ = CurrencyViewModel.CreateCurrencyComboViewModel(serial_Excel_swapInfo.Currency_.ValueStr);
            this.vba_description_ = serial_Excel_swapInfo.Vba_description_.ValueStr;
            
            
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

