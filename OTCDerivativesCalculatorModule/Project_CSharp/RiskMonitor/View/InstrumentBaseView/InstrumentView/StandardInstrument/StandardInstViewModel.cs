using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace RiskMonitor
{
    public class StandardInstViewModel : InstrumentViewModel
    {
        public StandardInstViewModel() { }

        #region IssueInfoType_
        private string issueInfoType_;
        public string IssueInfoType_
        {
            get { return this.issueInfoType_; }
            set
            {
                if (this.issueInfoType_ != value)
                {
                    this.issueInfoType_ = value;
                    this.IssueInfoViewModel_ = IssueInformationViewModel.CreateIssueInformation(value);
                    this.NotifyPropertyChanged("IssueInfoType_");
                }
            }
        }
        #endregion
        public IssueInformationViewModel IssueInfoViewModel_ { get; set; }

        #region UnderInfoType_
        private string underInfoType_;
        public string UnderInfoType_
        {
            get { return this.underInfoType_; }
            set
            {
                if (this.underInfoType_ != value)
                {
                    this.underInfoType_ = value;
                    this.UnderlyingViewModel_ = UnderlyingInfoViewModel.CreateUnderlyingInfo(value);
                    this.NotifyPropertyChanged("UnderInfoType_");
                }
            }
        }
        #endregion
        public UnderlyingInfoViewModel UnderlyingViewModel_ { get; set; }

        #region PayoffInfoType_
        private string payoffInfoType_;
        public string PayoffInfoType_
        {
            get { return this.payoffInfoType_; }
            set
            {
                if (this.payoffInfoType_ != value)
                {
                    this.payoffInfoType_ = value;
                    this.PayoffViewModel_ = PayoffInfoViewModel.CreatePayoffInfo(value);
                    this.NotifyPropertyChanged("PayoffInfoType_");
                }
            }
        }
        #endregion
        public PayoffInfoViewModel PayoffViewModel_ { get; set; }

        public override void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("instrumentInfo");

                xmlWriter.WriteElementString("type", "standardInstrument");
                xmlWriter.WriteStartElement("standardInstrument");
                    IssueInfoViewModel_.buildXml(xmlWriter);
                    UnderlyingViewModel_.buildXml(xmlWriter);
                    PayoffViewModel_.buildXml(xmlWriter);
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }

        public override void setFromXml(XmlNode instNode)
        {
            FpmlSerializedCSharp.Instrument serial_inst = new FpmlSerializedCSharp.Instrument(instNode);

            this.setFromSerial(serial_inst.InstrumentInfo_);
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstrumentInfo serial_instInfo = serial_Class as FpmlSerializedCSharp.InstrumentInfo;
            FpmlSerializedCSharp.StandardInstrument serial_standInst = serial_instInfo.StandardInstrument_;
            
            try
            {

            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
            }

            //잠시 벗겨놈
            FpmlSerializedCSharp.IssueInformation serial_issueInfo = serial_standInst.IssueInformation_;
            string issueInfoType = serial_issueInfo.Type_.ValueStr;
            this.IssueInfoViewModel_ = IssueInformationViewModel.CreateIssueInformation(issueInfoType);
            this.IssueInfoViewModel_.setFromSerial(serial_issueInfo);

            FpmlSerializedCSharp.UnderlyingInformation serial_underInfo = serial_standInst.UnderlyingInformation_;
            string underInfoType = serial_underInfo.Type_.ValueStr;
            this.UnderlyingViewModel_ = UnderlyingInfoViewModel.CreateUnderlyingInfo(underInfoType);
            this.UnderlyingViewModel_.setFromSerial(serial_underInfo);

            FpmlSerializedCSharp.PayoffInfo serial_payoffInfo = serial_standInst.PayoffInfo_;
            string payoffInfoType = serial_payoffInfo.Type_.ValueStr;
            this.PayoffViewModel_ = PayoffInfoViewModel.CreatePayoffInfo(payoffInfoType);
            this.PayoffViewModel_.setFromSerial(serial_payoffInfo);
            this.payoffInfoType_ = this.PayoffViewModel_.Type_;

            this.view_ = new StandardInstView();
            this.view_.DataContext = this;

        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }


        public override UnderlyingViewModel getUnderlying()
        {
            throw new NotImplementedException();
        }
    }
}
