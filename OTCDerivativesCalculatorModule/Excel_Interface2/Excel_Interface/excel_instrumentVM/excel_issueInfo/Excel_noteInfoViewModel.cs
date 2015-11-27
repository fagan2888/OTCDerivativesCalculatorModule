using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_noteInfoViewModel : Excel_issueInfoViewModel
    {
        public Excel_noteInfoViewModel() 
        {
            //Excel_noteInfoView v = new Excel_noteInfoView();

            //this.PropertyChanged +=
            //    new PropertyChangedEventHandler(v.viewModel_PropertyChanged);

            //this.view_ = v;

            //this.view_.DataContext = this;
        }
        
        //#region Premium_
        //private string premium_;
        //public string Premium_
        //{
        //    get { return this.premium_; }
        //    set
        //    {
        //        if (this.premium_ != value)
        //        {
        //            this.premium_ = value;
        //            this.NotifyPropertyChanged("Premium_");
        //        }
        //    }
        //}
        //#endregion

        //#region NoteInfoViewModel_
        //private NoteInfoViewModel noteInfoViewModel_;
        //public NoteInfoViewModel NoteInfoViewModel_
        //{
        //    get { return this.noteInfoViewModel_; }
        //    set
        //    {
        //        if (this.noteInfoViewModel_ != value)
        //        {
        //            this.noteInfoViewModel_ = value;
        //            this.NotifyPropertyChanged("NoteInfoViewModel_");
        //        }
        //    }
        //}
        //#endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_noteInfo");
                xmlWriter.WriteStartElement("excel_noteInfo");
                    xmlWriter.WriteElementString("effectiveDate", this.effectiveDate_.ToString("yyyy-MM-dd"));
                    xmlWriter.WriteElementString("maturityDate", this.maturityDate_.ToString("yyyy-MM-dd"));
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    xmlWriter.WriteElementString("currency", this.currency_.CurrencyString_);
                    xmlWriter.WriteElementString("includeNotionalPayment", this.includeNotionalPayment_);
            
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_noteInfo serial_Excel_noteInfo = serial_Excel_issueInfo.Excel_noteInfo_;
        
            //this.tradeDate_ = DateTime.ParseExact(serial_Excel_noteInfo.TradeDate_.ValueStr,StringFormat.XmlDateFormat_,null);
            this.effectiveDate_ = DateTime.ParseExact(serial_Excel_noteInfo.EffectiveDate_.ValueStr, StringFormat.XmlDateFormat_, null);
            this.maturityDate_ = DateTime.ParseExact(serial_Excel_noteInfo.MaturityDate_.ValueStr, StringFormat.XmlDateFormat_, null);
            this.notional_ = serial_Excel_noteInfo.Notional_.ValueStr;
            this.currency_ = CurrencyViewModel.CreateCurrencyComboViewModel(serial_Excel_noteInfo.Currency_.ValueStr);
            this.includeNotionalPayment_ = serial_Excel_noteInfo.IncludeNotionalPayment_.ValueStr;
            this.vba_description_ = serial_Excel_noteInfo.Vba_description_.ValueStr;
            //this.premium_ = serial_Excel_noteInfo.Premium_.ValueStr;
            
            //this.view_ = new Excel_noteInfoView();
            //this.view_.DataContext = this;
        }

        public override Control view()
        {
            Excel_noteInfoView v = new Excel_noteInfoView();

            this.PropertyChanged +=
                new PropertyChangedEventHandler(v.viewModel_PropertyChanged);

            v.DataContext = this;

            return v;

        }
    }
    
}

