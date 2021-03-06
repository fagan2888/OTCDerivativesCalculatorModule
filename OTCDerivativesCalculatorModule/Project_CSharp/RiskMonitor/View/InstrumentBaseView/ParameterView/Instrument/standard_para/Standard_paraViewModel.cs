using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Standard_paraViewModel : PricingParameterViewModel
    {
        public Standard_paraViewModel() 
        {
            this.discountCurve_paraViewModel_ = new DiscountCurve_paraViewModel();
            this.view_ = new Standard_paraView();
        }
    
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
            xmlWriter.WriteElementString("type", "standard_para");

            MethodViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteStartElement("standard_para");
            
                calculationAmountViewModel_.buildXml(xmlWriter);
                underlyingInfo_paraViewModel_.buildXml(xmlWriter);
                discountCurve_paraViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();

        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
            //FpmlSerializedCSharp.Standard_para serial_Standard_para = serial_PricingParameter.Standard_para_;
        
            //FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_Standard_para.CalculationAmount_;
            //this.calculationAmountViewModel_ = new CalculationAmountViewModel();
            //this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            //FpmlSerializedCSharp.UnderlyingInfo_para serial_underlyingInfo_para = serial_Standard_para.UnderlyingInfo_para_;
            //this.underlyingInfo_paraViewModel_ = new UnderlyingInfo_paraViewModel();
            //this.underlyingInfo_paraViewModel_.setFromSerial(serial_underlyingInfo_para);
            
            //FpmlSerializedCSharp.DiscountCurve_para serial_discountCurve_para = serial_Standard_para.DiscountCurve_para_;
            //this.discountCurve_paraViewModel_ = new DiscountCurve_paraViewModel();
            //this.discountCurve_paraViewModel_.setFromSerial(serial_discountCurve_para);
            
            //this.view_ = new Standard_paraView();
            //this.view_.DataContext = this;
        }

        public override void loadData(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        // ----------------------------------------------------------------------
        // 데이터를 로드하고, 기본 골격을 잡는 곳
        // ----------------------------------------------------------------------

        public override void initializeParameter(InstrumentViewModel instrumentViewModel)
        {
            StandardInstViewModel standInstVM = instrumentViewModel as StandardInstViewModel;
            IndexUnderInfoViewModel indexUnderInfoVM = standInstVM.UnderlyingViewModel_ as IndexUnderInfoViewModel;

            this.calculationAmountViewModel_ = new CalculationAmountViewModel();

            this.underlyingInfo_paraViewModel_ = new UnderlyingInfo_paraViewModel();
            this.underlyingInfo_paraViewModel_.initializeParameter(indexUnderInfoVM);

            this.discountCurve_paraViewModel_ = new DiscountCurve_paraViewModel();


            this.view_ = new Standard_paraView();
            this.view_.DataContext = this;

        }


        public override Underlying_paraViewModel getUnderlyingPara()
        {
            throw new NotImplementedException();
        }
    }
    
}

