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
    public class Standard_paraViewModel : PricingParameterViewModel
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
        
        public Standard_paraViewModel() { }
        
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
        
        #region UnderlyingInfo_paraViewModel_
        private UnderlyingInfo_paraViewModel underlyingInfo_paraViewModel_;
        public UnderlyingInfo_paraViewModel UnderlyingInfo_paraViewModel_
        {
            get { return this.underlyingInfo_paraViewModel_; }
            set
            {
                if (this.underlyingInfo_paraViewModel_ != value)
                {
                    this.underlyingInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("UnderlyingInfo_paraViewModel_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("pricingParameter");
                xmlWriter.WriteElementString("type" , "standard_para");
                xmlWriter.WriteStartElement("standard_para");
                    calculationAmountViewModel_.buildXml(xmlWriter);
                    
                    underlyingInfo_paraViewModel_.buildXml(xmlWriter);
                    
                    discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Standard_paraView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
            FpmlSerializedCSharp.Standard_para serial_Standard_para = serial_PricingParameter.Standard_para_;
        
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_Standard_para.CalculationAmount_;
            string calculationAmounttype = serial_calculationAmount.Excel_type_.ValueStr;
            this.calculationAmountViewModel_ = CalculationAmountViewModel.CreateCalculationAmount(calculationAmounttype);
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            FpmlSerializedCSharp.UnderlyingInfo_para serial_underlyingInfo_para = serial_Standard_para.UnderlyingInfo_para_;
            string underlyingInfo_paratype = serial_underlyingInfo_para.Excel_type_.ValueStr;
            this.underlyingInfo_paraViewModel_ = UnderlyingInfo_paraViewModel.CreateUnderlyingInfo_para(underlyingInfo_paratype);
            this.underlyingInfo_paraViewModel_.setFromSerial(serial_underlyingInfo_para);
            
            FpmlSerializedCSharp.DiscountCurve_para serial_discountCurve_para = serial_Standard_para.DiscountCurve_para_;
            string discountCurve_paratype = serial_discountCurve_para.Excel_type_.ValueStr;
            this.discountCurve_paraViewModel_ = DiscountCurve_paraViewModel.CreateDiscountCurve_para(discountCurve_paratype);
            this.discountCurve_paraViewModel_.setFromSerial(serial_discountCurve_para);
            
        }
        
        
    
            #region SelectCalculationAmountInfo_
            private string selectCalculationAmountInfo_;
            public string SelectCalculationAmountInfo_
            {
                get { return this.selectCalculationAmountInfo_; }
                set
                {
                    if (this.selectCalculationAmountInfo_ != value)
                    {
                        this.selectCalculationAmountInfo_ = value;
                        this.NotifyPropertyChanged("SelectCalculationAmountInfo_");
                    }
                }
            }
            #endregion
            
            public void selectCalculationAmountInfo(string typeStr)
            {
                this.calculationAmountViewModel_ = CalculationAmountViewModel.CreateCalculationAmount(typeStr);
                this.view_.DataContext = this;
            }
            
            #region SelectUnderlyingInfo_paraInfo_
            private string selectUnderlyingInfo_paraInfo_;
            public string SelectUnderlyingInfo_paraInfo_
            {
                get { return this.selectUnderlyingInfo_paraInfo_; }
                set
                {
                    if (this.selectUnderlyingInfo_paraInfo_ != value)
                    {
                        this.selectUnderlyingInfo_paraInfo_ = value;
                        this.NotifyPropertyChanged("SelectUnderlyingInfo_paraInfo_");
                    }
                }
            }
            #endregion
            
            public void selectUnderlyingInfo_paraInfo(string typeStr)
            {
                this.underlyingInfo_paraViewModel_ = UnderlyingInfo_paraViewModel.CreateUnderlyingInfo_para(typeStr);
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

