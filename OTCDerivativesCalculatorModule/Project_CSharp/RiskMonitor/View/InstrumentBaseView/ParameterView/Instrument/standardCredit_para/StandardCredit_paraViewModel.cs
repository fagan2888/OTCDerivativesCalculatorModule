using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class StandardCredit_paraViewModel : PricingParameterViewModel
    {
    
        public StandardCredit_paraViewModel() { }
        
    
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
        
        #region EvaluationCurvesViewModel_
        private EvaluationCurvesViewModel evaluationCurvesViewModel_;
        public EvaluationCurvesViewModel EvaluationCurvesViewModel_
        {
            get { return this.evaluationCurvesViewModel_; }
            set
            {
                if (this.evaluationCurvesViewModel_ != value)
                {
                    this.evaluationCurvesViewModel_ = value;
                    this.NotifyPropertyChanged("EvaluationCurvesViewModel_");
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
                    calculationAmountViewModel_.buildXml(xmlWriter);
                    
                    referenceEntityInfo_paraViewModel_.buildXml(xmlWriter);
                    
                    evaluationCurvesViewModel_.buildXml(xmlWriter);
                    
                    discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("recoveryRate" , this.recoveryRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.PricingParameter serial_PricingParameter = serial_Class as FpmlSerializedCSharp.PricingParameter;
            //FpmlSerializedCSharp.StandardCredit_para serial_StandardCredit_para = serial_PricingParameter.StandardCredit_para_;
        
            //FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_StandardCredit_para.CalculationAmount_;
            //this.calculationAmountViewModel_ = new CalculationAmountViewModel();
            //this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            //FpmlSerializedCSharp.ReferenceEntityInfo_para serial_referenceEntityInfo_para = serial_StandardCredit_para.ReferenceEntityInfo_para_;
            //this.referenceEntityInfo_paraViewModel_ = new ReferenceEntityInfo_paraViewModel();
            //this.referenceEntityInfo_paraViewModel_.setFromSerial(serial_referenceEntityInfo_para);
            
            ////FpmlSerializedCSharp.EvaluationCurves serial_evaluationCurves = serial_StandardCredit_para.EvaluationCurves_;
            ////string evaluationCurvestype = serial_evaluationCurves.Type_.ValueStr;
            ////this.evaluationCurvesViewModel_ = EvaluationCurvesViewModel.CreateEvaluationCurves(evaluationCurvestype);
            ////this.evaluationCurvesViewModel_.setFromSerial(serial_evaluationCurves);
            
            //FpmlSerializedCSharp.DiscountCurve_para serial_discountCurve_para = serial_StandardCredit_para.DiscountCurve_para_;
            //this.discountCurve_paraViewModel_ = new DiscountCurve_paraViewModel();
            //this.discountCurve_paraViewModel_.setFromSerial(serial_discountCurve_para);
            
            //this.recoveryRate_ = serial_StandardCredit_para.RecoveryRate_.ValueStr;
            
            //this.view_ = new StandardCredit_paraView();
            //this.view_.DataContext = this;
        }
        
        public override Underlying_paraViewModel getUnderlyingPara()
        {
            throw new NotImplementedException();
        }

        public override void loadData(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public override void initializeParameter(InstrumentViewModel instrumentViewModel)
        {
            throw new NotImplementedException();
        }

    }
    
}

