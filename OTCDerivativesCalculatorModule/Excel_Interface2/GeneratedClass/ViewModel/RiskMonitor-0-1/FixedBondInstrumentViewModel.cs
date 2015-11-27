using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class FixedBondInstrumentViewModel : IXmlData
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
        
        public FixedBondInstrumentViewModel() { }
        
        #region BondInformationViewModel_
        private BondInformationViewModel bondInformationViewModel_;
        public BondInformationViewModel BondInformationViewModel_
        {
            get { return this.bondInformationViewModel_; }
            set
            {
                if (this.bondInformationViewModel_ != value)
                {
                    this.bondInformationViewModel_ = value;
                    this.NotifyPropertyChanged("BondInformationViewModel_");
                }
            }
        }
        #endregion
        
        #region BondCouponInfoViewModel_
        private BondCouponInfoViewModel bondCouponInfoViewModel_;
        public BondCouponInfoViewModel BondCouponInfoViewModel_
        {
            get { return this.bondCouponInfoViewModel_; }
            set
            {
                if (this.bondCouponInfoViewModel_ != value)
                {
                    this.bondCouponInfoViewModel_ = value;
                    this.NotifyPropertyChanged("BondCouponInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region PayoffInfoAnalyticViewModel_
        private PayoffInfoAnalyticViewModel payoffInfoAnalyticViewModel_;
        public PayoffInfoAnalyticViewModel PayoffInfoAnalyticViewModel_
        {
            get { return this.payoffInfoAnalyticViewModel_; }
            set
            {
                if (this.payoffInfoAnalyticViewModel_ != value)
                {
                    this.payoffInfoAnalyticViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffInfoAnalyticViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "fixedBondInstrument");
                xmlWriter.WriteStartElement("fixedBondInstrument");
                    bondInformationViewModel_.buildXml(xmlWriter);
                    
                    bondCouponInfoViewModel_.buildXml(xmlWriter);
                    
                    payoffInfoAnalyticViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new FixedBondInstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixedBondInstrument serial_FixedBondInstrument = serial_Class as FpmlSerializedCSharp.FixedBondInstrument;
        
            FpmlSerializedCSharp.BondInformation serial_bondInformation = serial_FixedBondInstrument.BondInformation_;
            string bondInformationtype = serial_bondInformation.Excel_type_.ValueStr;
            this.bondInformationViewModel_ = BondInformationViewModel.CreateBondInformation(bondInformationtype);
            this.bondInformationViewModel_.setFromSerial(serial_bondInformation);
            
            FpmlSerializedCSharp.BondCouponInfo serial_bondCouponInfo = serial_FixedBondInstrument.BondCouponInfo_;
            string bondCouponInfotype = serial_bondCouponInfo.Excel_type_.ValueStr;
            this.bondCouponInfoViewModel_ = BondCouponInfoViewModel.CreateBondCouponInfo(bondCouponInfotype);
            this.bondCouponInfoViewModel_.setFromSerial(serial_bondCouponInfo);
            
            FpmlSerializedCSharp.PayoffInfoAnalytic serial_payoffInfoAnalytic = serial_FixedBondInstrument.PayoffInfoAnalytic_;
            string payoffInfoAnalytictype = serial_payoffInfoAnalytic.Excel_type_.ValueStr;
            this.payoffInfoAnalyticViewModel_ = PayoffInfoAnalyticViewModel.CreatePayoffInfoAnalytic(payoffInfoAnalytictype);
            this.payoffInfoAnalyticViewModel_.setFromSerial(serial_payoffInfoAnalytic);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

