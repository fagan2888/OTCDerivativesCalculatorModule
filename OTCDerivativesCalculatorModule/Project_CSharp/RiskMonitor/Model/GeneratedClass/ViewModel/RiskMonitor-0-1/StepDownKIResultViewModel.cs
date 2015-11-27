using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StepDownKIResultViewModel : PricingResultViewModel
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
        
        public StepDownKIResultViewModel() { }
        
        #region UnderylingInfoResultViewModel_
        private UnderylingInfoResultViewModel underylingInfoResultViewModel_;
        public UnderylingInfoResultViewModel UnderylingInfoResultViewModel_
        {
            get { return this.underylingInfoResultViewModel_; }
            set
            {
                if (this.underylingInfoResultViewModel_ != value)
                {
                    this.underylingInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("UnderylingInfoResultViewModel_");
                }
            }
        }
        #endregion
        
        #region CashFlowInfoResultViewModel_
        private CashFlowInfoResultViewModel cashFlowInfoResultViewModel_;
        public CashFlowInfoResultViewModel CashFlowInfoResultViewModel_
        {
            get { return this.cashFlowInfoResultViewModel_; }
            set
            {
                if (this.cashFlowInfoResultViewModel_ != value)
                {
                    this.cashFlowInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("CashFlowInfoResultViewModel_");
                }
            }
        }
        #endregion
        
        #region Theta_
        private string theta_;
        public string Theta_
        {
            get { return this.theta_; }
            set
            {
                if (this.theta_ != value)
                {
                    this.theta_ = value;
                    this.NotifyPropertyChanged("Theta_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("pricingResult");
                xmlWriter.WriteElementString("type" , "stepDownKIResult");
                xmlWriter.WriteStartElement("stepDownKIResult");
                    underylingInfoResultViewModel_.buildXml(xmlWriter);
                    
                    cashFlowInfoResultViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("theta" , this.theta_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StepDownKIResultView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingResult serial_PricingResult = serial_Class as FpmlSerializedCSharp.PricingResult;
            FpmlSerializedCSharp.StepDownKIResult serial_StepDownKIResult = serial_PricingResult.StepDownKIResult_;
        
            FpmlSerializedCSharp.UnderylingInfoResult serial_underylingInfoResult = serial_StepDownKIResult.UnderylingInfoResult_;
            string underylingInfoResulttype = serial_underylingInfoResult.Excel_type_.ValueStr;
            this.underylingInfoResultViewModel_ = UnderylingInfoResultViewModel.CreateUnderylingInfoResult(underylingInfoResulttype);
            this.underylingInfoResultViewModel_.setFromSerial(serial_underylingInfoResult);
            
            FpmlSerializedCSharp.CashFlowInfoResult serial_cashFlowInfoResult = serial_StepDownKIResult.CashFlowInfoResult_;
            string cashFlowInfoResulttype = serial_cashFlowInfoResult.Excel_type_.ValueStr;
            this.cashFlowInfoResultViewModel_ = CashFlowInfoResultViewModel.CreateCashFlowInfoResult(cashFlowInfoResulttype);
            this.cashFlowInfoResultViewModel_.setFromSerial(serial_cashFlowInfoResult);
            
            this.theta_ = serial_StepDownKIResult.Theta_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

