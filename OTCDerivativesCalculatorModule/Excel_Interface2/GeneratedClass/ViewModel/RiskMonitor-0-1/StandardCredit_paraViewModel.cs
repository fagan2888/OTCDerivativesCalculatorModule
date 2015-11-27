using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace Excel_Interface
{
    public class StandardCredit_paraViewModel : PricingParameterViewModel
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
        
        public StandardCredit_paraViewModel() { }
        
        #region ReferenceEntityInfo_paraViewModel_
        private ReferenceEntityInfo_paraViewModel referenceEntityInfo_paraViewModel_;
        public ReferenceEntityInfo_paraViewModel ReferenceEntityInfo_paraViewModel_
        {
            get { return this.referenceEntityInfo_paraViewModel_; }
            set
            {
                if (this.referenceEntityInfo_paraViewModel_ != value)
                {
                    this.referenceEntityInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceEntityInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region DiscountCurve_paraViewModel_
        private DiscountCurve_paraViewModel discountCurve_paraViewModel_;
        public DiscountCurve_paraViewModel DiscountCurve_paraViewModel_
        {
            get { return this.discountCurve_paraViewModel_; }
            set
            {
                if (this.discountCurve_paraViewModel_ != value)
                {
                    this.discountCurve_paraViewModel_ = value;
                    this.NotifyPropertyChanged("DiscountCurve_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region RecoveryRate_
        private string recoveryRate_;
        public string RecoveryRate_
        {
            get { return this.recoveryRate_; }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                    this.NotifyPropertyChanged("RecoveryRate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("pricingParameter");
                xmlWriter.WriteElementString("type" , "standardCredit_para");
                xmlWriter.WriteStartElement("standardCredit_para");
                    referenceEntityInfo_paraViewModel_.buildXml(xmlWriter);
                    
                    discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("recoveryRate" , this.recoveryRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StandardCredit_paraView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
            FpmlSerializedCSharp.StandardCredit_para serial_StandardCredit_para = serial_PricingParameter.StandardCredit_para_;
        
            FpmlSerializedCSharp.ReferenceEntityInfo_para serial_referenceEntityInfo_para = serial_StandardCredit_para.ReferenceEntityInfo_para_;
            string referenceEntityInfo_paratype = serial_referenceEntityInfo_para.Excel_type_.ValueStr;
            this.referenceEntityInfo_paraViewModel_ = ReferenceEntityInfo_paraViewModel.CreateReferenceEntityInfo_para(referenceEntityInfo_paratype);
            this.referenceEntityInfo_paraViewModel_.setFromSerial(serial_referenceEntityInfo_para);
            
            FpmlSerializedCSharp.DiscountCurve_para serial_discountCurve_para = serial_StandardCredit_para.DiscountCurve_para_;
            string discountCurve_paratype = serial_discountCurve_para.Excel_type_.ValueStr;
            this.discountCurve_paraViewModel_ = DiscountCurve_paraViewModel.CreateDiscountCurve_para(discountCurve_paratype);
            this.discountCurve_paraViewModel_.setFromSerial(serial_discountCurve_para);
            
            this.recoveryRate_ = serial_StandardCredit_para.RecoveryRate_.ValueStr;
            
        }
        
        
    
            #region SelectReferenceEntityInfo_paraInfo_
            private string selectReferenceEntityInfo_paraInfo_;
            public string SelectReferenceEntityInfo_paraInfo_
            {
                get { return this.selectReferenceEntityInfo_paraInfo_; }
                set
                {
                    if (this.selectReferenceEntityInfo_paraInfo_ != value)
                    {
                        this.selectReferenceEntityInfo_paraInfo_ = value;
                        this.NotifyPropertyChanged("SelectReferenceEntityInfo_paraInfo_");
                    }
                }
            }
            #endregion
            
            public void selectReferenceEntityInfo_paraInfo(string typeStr)
            {
                this.referenceEntityInfo_paraViewModel_ = ReferenceEntityInfo_paraViewModel.CreateReferenceEntityInfo_para(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectDiscountCurve_paraInfo_
            private string selectDiscountCurve_paraInfo_;
            public string SelectDiscountCurve_paraInfo_
            {
                get { return this.selectDiscountCurve_paraInfo_; }
                set
                {
                    if (this.selectDiscountCurve_paraInfo_ != value)
                    {
                        this.selectDiscountCurve_paraInfo_ = value;
                        this.NotifyPropertyChanged("SelectDiscountCurve_paraInfo_");
                    }
                }
            }
            #endregion
            
            public void selectDiscountCurve_paraInfo(string typeStr)
            {
                this.discountCurve_paraViewModel_ = DiscountCurve_paraViewModel.CreateDiscountCurve_para(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

