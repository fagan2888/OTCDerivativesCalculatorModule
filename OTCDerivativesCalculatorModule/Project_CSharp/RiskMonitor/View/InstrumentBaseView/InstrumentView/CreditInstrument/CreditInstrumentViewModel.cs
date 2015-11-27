using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CreditInstrumentViewModel : InstrumentViewModel
    {
        public CreditInstrumentViewModel() { }
        
        #region IssueInfoViewModel_
        private IssueInformationViewModel issueInfoViewModel_;
        public IssueInformationViewModel IssueInfoViewModel_
        {
            get { return this.issueInfoViewModel_; }
            set
            {
                if (this.issueInfoViewModel_ != value)
                {
                    this.issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("IssueInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region UnderlyingInfoViewModel_
        private UnderlyingInfoViewModel underlyingInfoViewModel_;
        public UnderlyingInfoViewModel UnderlyingInfoViewModel_
        {
            get { return this.underlyingInfoViewModel_; }
            set
            {
                if (this.underlyingInfoViewModel_ != value)
                {
                    this.underlyingInfoViewModel_ = value;
                    this.NotifyPropertyChanged("UnderlyingInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region CreditPayoffInfoViewModel_
        private CreditPayoffInfoViewModel creditPayoffInfoViewModel_;
        public CreditPayoffInfoViewModel CreditPayoffInfoViewModel_
        {
            get { return this.creditPayoffInfoViewModel_; }
            set
            {
                if (this.creditPayoffInfoViewModel_ != value)
                {
                    this.creditPayoffInfoViewModel_ = value;
                    this.NotifyPropertyChanged("CreditPayoffInfoViewModel_");
                }
            }
        }
        #endregion

        public override void calculate()
        {
            throw new NotImplementedException();
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstrumentInfo serial_instInfo = serial_Class as FpmlSerializedCSharp.InstrumentInfo;
            FpmlSerializedCSharp.CreditInstrument serial_CreditInstrument = serial_instInfo.CreditInstrument_ as FpmlSerializedCSharp.CreditInstrument;
        
            FpmlSerializedCSharp.IssueInformation serial_issueInfo = serial_CreditInstrument.IssueInformation_;
            string issueInfotype = serial_issueInfo.Type_.ValueStr;
            this.issueInfoViewModel_ = IssueInformationViewModel.CreateIssueInformation(issueInfotype);
            this.issueInfoViewModel_.setFromSerial(serial_issueInfo);
            
            FpmlSerializedCSharp.UnderlyingInformation serial_underlyingInfo = serial_CreditInstrument.UnderlyingInformation_;
            string underlyingInfotype = serial_underlyingInfo.Type_.ValueStr;
            this.underlyingInfoViewModel_ = UnderlyingInfoViewModel.CreateUnderlyingInfo(underlyingInfotype);
            this.underlyingInfoViewModel_.setFromSerial(serial_underlyingInfo);
            
            FpmlSerializedCSharp.CreditPayoffInfo serial_creditPayoffInfo = serial_CreditInstrument.CreditPayoffInfo_;
            string creditPayoffInfotype = serial_creditPayoffInfo.Type_.ValueStr;
            this.creditPayoffInfoViewModel_ = CreditPayoffInfoViewModel.CreateCreditPayoffInfo(creditPayoffInfotype);
            this.creditPayoffInfoViewModel_.setFromSerial(serial_creditPayoffInfo);
            
            this.view_ = new CreditInstrumentView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectIssueInfoInfo_
            private string selectIssueInfoInfo_;
            public string SelectIssueInfoInfo_
            {
                get { return this.selectIssueInfoInfo_; }
                set
                {
                    if (this.selectIssueInfoInfo_ != value)
                    {
                        this.selectIssueInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectIssueInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectIssueInfoInfo(string typeStr)
            {
                this.issueInfoViewModel_ = IssueInformationViewModel.CreateIssueInformation(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectUnderlyingInfoInfo_
            private string selectUnderlyingInfoInfo_;
            public string SelectUnderlyingInfoInfo_
            {
                get { return this.selectUnderlyingInfoInfo_; }
                set
                {
                    if (this.selectUnderlyingInfoInfo_ != value)
                    {
                        this.selectUnderlyingInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectUnderlyingInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectUnderlyingInfoInfo(string typeStr)
            {
                this.underlyingInfoViewModel_ = UnderlyingInfoViewModel.CreateUnderlyingInfo(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectCreditPayoffInfoInfo_
            private string selectCreditPayoffInfoInfo_;
            public string SelectCreditPayoffInfoInfo_
            {
                get { return this.selectCreditPayoffInfoInfo_; }
                set
                {
                    if (this.selectCreditPayoffInfoInfo_ != value)
                    {
                        this.selectCreditPayoffInfoInfo_ = value;
                        this.NotifyPropertyChanged("SelectCreditPayoffInfoInfo_");
                    }
                }
            }
            #endregion
            
            public void selectCreditPayoffInfoInfo(string typeStr)
            {
                this.creditPayoffInfoViewModel_ = CreditPayoffInfoViewModel.CreateCreditPayoffInfo(typeStr);
                this.view_.DataContext = this;
            }






            public override UnderlyingViewModel getUnderlying()
            {
                throw new NotImplementedException();
            }
    }
    
}

