using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class OptionInfoViewModel : IssueInformationViewModel
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
        
        public OptionInfoViewModel() { }
        
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
        
        #region TradeDate_
        private DateTime tradeDate_;
        public DateTime TradeDate_
        {
            get { return this.tradeDate_; }
            set
            {
                if (this.tradeDate_ != value)
                {
                    this.tradeDate_ = value;
                    this.NotifyPropertyChanged("TradeDate_");
                }
            }
        }
        #endregion
        
        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion
        
        #region MaturityDate_
        private DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
        #region CalculationAmountViewModel_
        private CalculationAmountViewModel calculationAmountViewModel_;
        public CalculationAmountViewModel CalculationAmountViewModel_
        {
            get { return this.calculationAmountViewModel_; }
            set
            {
                if (this.calculationAmountViewModel_ != value)
                {
                    this.calculationAmountViewModel_ = value;
                    this.NotifyPropertyChanged("CalculationAmountViewModel_");
                }
            }
        }
        #endregion
        
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
            xmlWriter.WriteStartElement("issueInformation");
                xmlWriter.WriteElementString("type" , "optionInfo");
                xmlWriter.WriteStartElement("optionInfo");
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    xmlWriter.WriteElementString("tradeDate" , StringConverter.xmlDateTimeToDateString(this.tradeDate_));
                    
                    xmlWriter.WriteElementString("effectiveDate" , StringConverter.xmlDateTimeToDateString(this.effectiveDate_));
                    
                    xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    
                    calculationAmountViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("premium" , this.premium_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new OptionInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IssueInformation serial_IssueInformation = serial_Class as FpmlSerializedCSharp.IssueInformation;
            FpmlSerializedCSharp.OptionInfo serial_OptionInfo = serial_IssueInformation.OptionInfo_;
        
            this.notional_ = serial_OptionInfo.Notional_.ValueStr;
            
            this.tradeDate_ = StringConverter.xmlDateToDateTime(serial_OptionInfo.TradeDate_.ValueStr);
            
            this.effectiveDate_ = StringConverter.xmlDateToDateTime(serial_OptionInfo.EffectiveDate_.ValueStr);
            
            this.maturityDate_ = StringConverter.xmlDateToDateTime(serial_OptionInfo.MaturityDate_.ValueStr);
            
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_OptionInfo.CalculationAmount_;
            string calculationAmounttype = serial_calculationAmount.Excel_type_.ValueStr;
            this.calculationAmountViewModel_ = CalculationAmountViewModel.CreateCalculationAmount(calculationAmounttype);
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            this.premium_ = serial_OptionInfo.Premium_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

