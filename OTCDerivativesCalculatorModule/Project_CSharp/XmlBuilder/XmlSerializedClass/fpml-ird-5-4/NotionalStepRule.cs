using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NotionalStepRule : ISerialized
    {
        public NotionalStepRule(XmlNode xmlNode)
        {
            XmlNode calculationPeriodDatesReferenceNode = xmlNode.SelectSingleNode("calculationPeriodDatesReference");
            
            if (calculationPeriodDatesReferenceNode != null)
            {
                if (calculationPeriodDatesReferenceNode.Attributes["href"] != null || calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["id"].Value;
                        CalculationPeriodDatesReference ob = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodDatesReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                }
            }
            
        
            XmlNode stepFrequencyNode = xmlNode.SelectSingleNode("stepFrequency");
            
            if (stepFrequencyNode != null)
            {
                if (stepFrequencyNode.Attributes["href"] != null || stepFrequencyNode.Attributes["id"] != null) 
                {
                    if (stepFrequencyNode.Attributes["id"] != null) 
                    {
                        stepFrequencyIDRef_ = stepFrequencyNode.Attributes["id"].Value;
                        Period ob = new Period(stepFrequencyNode);
                        IDManager.SetID(stepFrequencyIDRef_, ob);
                    }
                    else if (stepFrequencyNode.Attributes["href"] != null)
                    {
                        stepFrequencyIDRef_ = stepFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepFrequency_ = new Period(stepFrequencyNode);
                    }
                }
                else
                {
                    stepFrequency_ = new Period(stepFrequencyNode);
                }
            }
            
        
            XmlNode firstNotionalStepDateNode = xmlNode.SelectSingleNode("firstNotionalStepDate");
            
            if (firstNotionalStepDateNode != null)
            {
                if (firstNotionalStepDateNode.Attributes["href"] != null || firstNotionalStepDateNode.Attributes["id"] != null) 
                {
                    if (firstNotionalStepDateNode.Attributes["id"] != null) 
                    {
                        firstNotionalStepDateIDRef_ = firstNotionalStepDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstNotionalStepDateNode);
                        IDManager.SetID(firstNotionalStepDateIDRef_, ob);
                    }
                    else if (firstNotionalStepDateNode.Attributes["href"] != null)
                    {
                        firstNotionalStepDateIDRef_ = firstNotionalStepDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstNotionalStepDate_ = new XsdTypeDate(firstNotionalStepDateNode);
                    }
                }
                else
                {
                    firstNotionalStepDate_ = new XsdTypeDate(firstNotionalStepDateNode);
                }
            }
            
        
            XmlNode lastNotionalStepDateNode = xmlNode.SelectSingleNode("lastNotionalStepDate");
            
            if (lastNotionalStepDateNode != null)
            {
                if (lastNotionalStepDateNode.Attributes["href"] != null || lastNotionalStepDateNode.Attributes["id"] != null) 
                {
                    if (lastNotionalStepDateNode.Attributes["id"] != null) 
                    {
                        lastNotionalStepDateIDRef_ = lastNotionalStepDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(lastNotionalStepDateNode);
                        IDManager.SetID(lastNotionalStepDateIDRef_, ob);
                    }
                    else if (lastNotionalStepDateNode.Attributes["href"] != null)
                    {
                        lastNotionalStepDateIDRef_ = lastNotionalStepDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lastNotionalStepDate_ = new XsdTypeDate(lastNotionalStepDateNode);
                    }
                }
                else
                {
                    lastNotionalStepDate_ = new XsdTypeDate(lastNotionalStepDateNode);
                }
            }
            
        
            XmlNode notionalStepAmountNode = xmlNode.SelectSingleNode("notionalStepAmount");
            
            if (notionalStepAmountNode != null)
            {
                if (notionalStepAmountNode.Attributes["href"] != null || notionalStepAmountNode.Attributes["id"] != null) 
                {
                    if (notionalStepAmountNode.Attributes["id"] != null) 
                    {
                        notionalStepAmountIDRef_ = notionalStepAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalStepAmountNode);
                        IDManager.SetID(notionalStepAmountIDRef_, ob);
                    }
                    else if (notionalStepAmountNode.Attributes["href"] != null)
                    {
                        notionalStepAmountIDRef_ = notionalStepAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalStepAmount_ = new XsdTypeDecimal(notionalStepAmountNode);
                    }
                }
                else
                {
                    notionalStepAmount_ = new XsdTypeDecimal(notionalStepAmountNode);
                }
            }
            
        
            XmlNode notionalStepRateNode = xmlNode.SelectSingleNode("notionalStepRate");
            
            if (notionalStepRateNode != null)
            {
                if (notionalStepRateNode.Attributes["href"] != null || notionalStepRateNode.Attributes["id"] != null) 
                {
                    if (notionalStepRateNode.Attributes["id"] != null) 
                    {
                        notionalStepRateIDRef_ = notionalStepRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalStepRateNode);
                        IDManager.SetID(notionalStepRateIDRef_, ob);
                    }
                    else if (notionalStepRateNode.Attributes["href"] != null)
                    {
                        notionalStepRateIDRef_ = notionalStepRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalStepRate_ = new XsdTypeDecimal(notionalStepRateNode);
                    }
                }
                else
                {
                    notionalStepRate_ = new XsdTypeDecimal(notionalStepRateNode);
                }
            }
            
        
            XmlNode stepRelativeToNode = xmlNode.SelectSingleNode("stepRelativeTo");
            
            if (stepRelativeToNode != null)
            {
                if (stepRelativeToNode.Attributes["href"] != null || stepRelativeToNode.Attributes["id"] != null) 
                {
                    if (stepRelativeToNode.Attributes["id"] != null) 
                    {
                        stepRelativeToIDRef_ = stepRelativeToNode.Attributes["id"].Value;
                        StepRelativeToEnum ob = new StepRelativeToEnum(stepRelativeToNode);
                        IDManager.SetID(stepRelativeToIDRef_, ob);
                    }
                    else if (stepRelativeToNode.Attributes["href"] != null)
                    {
                        stepRelativeToIDRef_ = stepRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stepRelativeTo_ = new StepRelativeToEnum(stepRelativeToNode);
                    }
                }
                else
                {
                    stepRelativeTo_ = new StepRelativeToEnum(stepRelativeToNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference_
        private CalculationPeriodDatesReference calculationPeriodDatesReference_;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference_
        {
            get
            {
                if (this.calculationPeriodDatesReference_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef_ != null)
                {
                    calculationPeriodDatesReference_ = IDManager.getID(calculationPeriodDatesReferenceIDRef_) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference_ != value)
                {
                    this.calculationPeriodDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesReferenceIDRef_ { get; set; }
        #region StepFrequency_
        private Period stepFrequency_;
        public Period StepFrequency_
        {
            get
            {
                if (this.stepFrequency_ != null)
                {
                    return this.stepFrequency_; 
                }
                else if (this.stepFrequencyIDRef_ != null)
                {
                    stepFrequency_ = IDManager.getID(stepFrequencyIDRef_) as Period;
                    return this.stepFrequency_; 
                }
                else
                {
                      return this.stepFrequency_; 
                }
            }
            set
            {
                if (this.stepFrequency_ != value)
                {
                    this.stepFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string stepFrequencyIDRef_ { get; set; }
        #region FirstNotionalStepDate_
        private XsdTypeDate firstNotionalStepDate_;
        public XsdTypeDate FirstNotionalStepDate_
        {
            get
            {
                if (this.firstNotionalStepDate_ != null)
                {
                    return this.firstNotionalStepDate_; 
                }
                else if (this.firstNotionalStepDateIDRef_ != null)
                {
                    firstNotionalStepDate_ = IDManager.getID(firstNotionalStepDateIDRef_) as XsdTypeDate;
                    return this.firstNotionalStepDate_; 
                }
                else
                {
                      return this.firstNotionalStepDate_; 
                }
            }
            set
            {
                if (this.firstNotionalStepDate_ != value)
                {
                    this.firstNotionalStepDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstNotionalStepDateIDRef_ { get; set; }
        #region LastNotionalStepDate_
        private XsdTypeDate lastNotionalStepDate_;
        public XsdTypeDate LastNotionalStepDate_
        {
            get
            {
                if (this.lastNotionalStepDate_ != null)
                {
                    return this.lastNotionalStepDate_; 
                }
                else if (this.lastNotionalStepDateIDRef_ != null)
                {
                    lastNotionalStepDate_ = IDManager.getID(lastNotionalStepDateIDRef_) as XsdTypeDate;
                    return this.lastNotionalStepDate_; 
                }
                else
                {
                      return this.lastNotionalStepDate_; 
                }
            }
            set
            {
                if (this.lastNotionalStepDate_ != value)
                {
                    this.lastNotionalStepDate_ = value;
                }
            }
        }
        #endregion
        
        public string lastNotionalStepDateIDRef_ { get; set; }
        #region NotionalStepAmount_
        private XsdTypeDecimal notionalStepAmount_;
        public XsdTypeDecimal NotionalStepAmount_
        {
            get
            {
                if (this.notionalStepAmount_ != null)
                {
                    return this.notionalStepAmount_; 
                }
                else if (this.notionalStepAmountIDRef_ != null)
                {
                    notionalStepAmount_ = IDManager.getID(notionalStepAmountIDRef_) as XsdTypeDecimal;
                    return this.notionalStepAmount_; 
                }
                else
                {
                      return this.notionalStepAmount_; 
                }
            }
            set
            {
                if (this.notionalStepAmount_ != value)
                {
                    this.notionalStepAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalStepAmountIDRef_ { get; set; }
        #region NotionalStepRate_
        private XsdTypeDecimal notionalStepRate_;
        public XsdTypeDecimal NotionalStepRate_
        {
            get
            {
                if (this.notionalStepRate_ != null)
                {
                    return this.notionalStepRate_; 
                }
                else if (this.notionalStepRateIDRef_ != null)
                {
                    notionalStepRate_ = IDManager.getID(notionalStepRateIDRef_) as XsdTypeDecimal;
                    return this.notionalStepRate_; 
                }
                else
                {
                      return this.notionalStepRate_; 
                }
            }
            set
            {
                if (this.notionalStepRate_ != value)
                {
                    this.notionalStepRate_ = value;
                }
            }
        }
        #endregion
        
        public string notionalStepRateIDRef_ { get; set; }
        #region StepRelativeTo_
        private StepRelativeToEnum stepRelativeTo_;
        public StepRelativeToEnum StepRelativeTo_
        {
            get
            {
                if (this.stepRelativeTo_ != null)
                {
                    return this.stepRelativeTo_; 
                }
                else if (this.stepRelativeToIDRef_ != null)
                {
                    stepRelativeTo_ = IDManager.getID(stepRelativeToIDRef_) as StepRelativeToEnum;
                    return this.stepRelativeTo_; 
                }
                else
                {
                      return this.stepRelativeTo_; 
                }
            }
            set
            {
                if (this.stepRelativeTo_ != value)
                {
                    this.stepRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string stepRelativeToIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

