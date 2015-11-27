using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherLegCalculation : ISerialized
    {
        public WeatherLegCalculation(XmlNode xmlNode)
        {
            XmlNode settlementLevelNode = xmlNode.SelectSingleNode("settlementLevel");
            
            if (settlementLevelNode != null)
            {
                if (settlementLevelNode.Attributes["href"] != null || settlementLevelNode.Attributes["id"] != null) 
                {
                    if (settlementLevelNode.Attributes["id"] != null) 
                    {
                        settlementLevelIDRef_ = settlementLevelNode.Attributes["id"].Value;
                        WeatherSettlementLevelEnum ob = new WeatherSettlementLevelEnum(settlementLevelNode);
                        IDManager.SetID(settlementLevelIDRef_, ob);
                    }
                    else if (settlementLevelNode.Attributes["href"] != null)
                    {
                        settlementLevelIDRef_ = settlementLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementLevel_ = new WeatherSettlementLevelEnum(settlementLevelNode);
                    }
                }
                else
                {
                    settlementLevel_ = new WeatherSettlementLevelEnum(settlementLevelNode);
                }
            }
            
        
            XmlNode referenceLevelEqualsZeroNode = xmlNode.SelectSingleNode("referenceLevelEqualsZero");
            
            if (referenceLevelEqualsZeroNode != null)
            {
                if (referenceLevelEqualsZeroNode.Attributes["href"] != null || referenceLevelEqualsZeroNode.Attributes["id"] != null) 
                {
                    if (referenceLevelEqualsZeroNode.Attributes["id"] != null) 
                    {
                        referenceLevelEqualsZeroIDRef_ = referenceLevelEqualsZeroNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(referenceLevelEqualsZeroNode);
                        IDManager.SetID(referenceLevelEqualsZeroIDRef_, ob);
                    }
                    else if (referenceLevelEqualsZeroNode.Attributes["href"] != null)
                    {
                        referenceLevelEqualsZeroIDRef_ = referenceLevelEqualsZeroNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceLevelEqualsZero_ = new XsdTypeBoolean(referenceLevelEqualsZeroNode);
                    }
                }
                else
                {
                    referenceLevelEqualsZero_ = new XsdTypeBoolean(referenceLevelEqualsZeroNode);
                }
            }
            
        
            XmlNode calculationDateNode = xmlNode.SelectSingleNode("calculationDate");
            
            if (calculationDateNode != null)
            {
                if (calculationDateNode.Attributes["href"] != null || calculationDateNode.Attributes["id"] != null) 
                {
                    if (calculationDateNode.Attributes["id"] != null) 
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["id"].Value;
                        Period ob = new Period(calculationDateNode);
                        IDManager.SetID(calculationDateIDRef_, ob);
                    }
                    else if (calculationDateNode.Attributes["href"] != null)
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDate_ = new Period(calculationDateNode);
                    }
                }
                else
                {
                    calculationDate_ = new Period(calculationDateNode);
                }
            }
            
        
            XmlNode businessDaysNode = xmlNode.SelectSingleNode("businessDays");
            
            if (businessDaysNode != null)
            {
                if (businessDaysNode.Attributes["href"] != null || businessDaysNode.Attributes["id"] != null) 
                {
                    if (businessDaysNode.Attributes["id"] != null) 
                    {
                        businessDaysIDRef_ = businessDaysNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(businessDaysNode);
                        IDManager.SetID(businessDaysIDRef_, ob);
                    }
                    else if (businessDaysNode.Attributes["href"] != null)
                    {
                        businessDaysIDRef_ = businessDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessDays_ = new BusinessCenter(businessDaysNode);
                    }
                }
                else
                {
                    businessDays_ = new BusinessCenter(businessDaysNode);
                }
            }
            
        
            XmlNode dataCorrectionNode = xmlNode.SelectSingleNode("dataCorrection");
            
            if (dataCorrectionNode != null)
            {
                if (dataCorrectionNode.Attributes["href"] != null || dataCorrectionNode.Attributes["id"] != null) 
                {
                    if (dataCorrectionNode.Attributes["id"] != null) 
                    {
                        dataCorrectionIDRef_ = dataCorrectionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(dataCorrectionNode);
                        IDManager.SetID(dataCorrectionIDRef_, ob);
                    }
                    else if (dataCorrectionNode.Attributes["href"] != null)
                    {
                        dataCorrectionIDRef_ = dataCorrectionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dataCorrection_ = new XsdTypeBoolean(dataCorrectionNode);
                    }
                }
                else
                {
                    dataCorrection_ = new XsdTypeBoolean(dataCorrectionNode);
                }
            }
            
        
            XmlNode correctionPeriodNode = xmlNode.SelectSingleNode("correctionPeriod");
            
            if (correctionPeriodNode != null)
            {
                if (correctionPeriodNode.Attributes["href"] != null || correctionPeriodNode.Attributes["id"] != null) 
                {
                    if (correctionPeriodNode.Attributes["id"] != null) 
                    {
                        correctionPeriodIDRef_ = correctionPeriodNode.Attributes["id"].Value;
                        Period ob = new Period(correctionPeriodNode);
                        IDManager.SetID(correctionPeriodIDRef_, ob);
                    }
                    else if (correctionPeriodNode.Attributes["href"] != null)
                    {
                        correctionPeriodIDRef_ = correctionPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correctionPeriod_ = new Period(correctionPeriodNode);
                    }
                }
                else
                {
                    correctionPeriod_ = new Period(correctionPeriodNode);
                }
            }
            
        
            XmlNode maximumPaymentAmountNode = xmlNode.SelectSingleNode("maximumPaymentAmount");
            
            if (maximumPaymentAmountNode != null)
            {
                if (maximumPaymentAmountNode.Attributes["href"] != null || maximumPaymentAmountNode.Attributes["id"] != null) 
                {
                    if (maximumPaymentAmountNode.Attributes["id"] != null) 
                    {
                        maximumPaymentAmountIDRef_ = maximumPaymentAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(maximumPaymentAmountNode);
                        IDManager.SetID(maximumPaymentAmountIDRef_, ob);
                    }
                    else if (maximumPaymentAmountNode.Attributes["href"] != null)
                    {
                        maximumPaymentAmountIDRef_ = maximumPaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumPaymentAmount_ = new NonNegativeMoney(maximumPaymentAmountNode);
                    }
                }
                else
                {
                    maximumPaymentAmount_ = new NonNegativeMoney(maximumPaymentAmountNode);
                }
            }
            
        
            XmlNode maximumTransactionPaymentAmountNode = xmlNode.SelectSingleNode("maximumTransactionPaymentAmount");
            
            if (maximumTransactionPaymentAmountNode != null)
            {
                if (maximumTransactionPaymentAmountNode.Attributes["href"] != null || maximumTransactionPaymentAmountNode.Attributes["id"] != null) 
                {
                    if (maximumTransactionPaymentAmountNode.Attributes["id"] != null) 
                    {
                        maximumTransactionPaymentAmountIDRef_ = maximumTransactionPaymentAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(maximumTransactionPaymentAmountNode);
                        IDManager.SetID(maximumTransactionPaymentAmountIDRef_, ob);
                    }
                    else if (maximumTransactionPaymentAmountNode.Attributes["href"] != null)
                    {
                        maximumTransactionPaymentAmountIDRef_ = maximumTransactionPaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumTransactionPaymentAmount_ = new NonNegativeMoney(maximumTransactionPaymentAmountNode);
                    }
                }
                else
                {
                    maximumTransactionPaymentAmount_ = new NonNegativeMoney(maximumTransactionPaymentAmountNode);
                }
            }
            
        
            XmlNode roundingNode = xmlNode.SelectSingleNode("rounding");
            
            if (roundingNode != null)
            {
                if (roundingNode.Attributes["href"] != null || roundingNode.Attributes["id"] != null) 
                {
                    if (roundingNode.Attributes["id"] != null) 
                    {
                        roundingIDRef_ = roundingNode.Attributes["id"].Value;
                        Rounding ob = new Rounding(roundingNode);
                        IDManager.SetID(roundingIDRef_, ob);
                    }
                    else if (roundingNode.Attributes["href"] != null)
                    {
                        roundingIDRef_ = roundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rounding_ = new Rounding(roundingNode);
                    }
                }
                else
                {
                    rounding_ = new Rounding(roundingNode);
                }
            }
            
        
        }
        
    
        #region SettlementLevel_
        private WeatherSettlementLevelEnum settlementLevel_;
        public WeatherSettlementLevelEnum SettlementLevel_
        {
            get
            {
                if (this.settlementLevel_ != null)
                {
                    return this.settlementLevel_; 
                }
                else if (this.settlementLevelIDRef_ != null)
                {
                    settlementLevel_ = IDManager.getID(settlementLevelIDRef_) as WeatherSettlementLevelEnum;
                    return this.settlementLevel_; 
                }
                else
                {
                      return this.settlementLevel_; 
                }
            }
            set
            {
                if (this.settlementLevel_ != value)
                {
                    this.settlementLevel_ = value;
                }
            }
        }
        #endregion
        
        public string settlementLevelIDRef_ { get; set; }
        #region ReferenceLevelEqualsZero_
        private XsdTypeBoolean referenceLevelEqualsZero_;
        public XsdTypeBoolean ReferenceLevelEqualsZero_
        {
            get
            {
                if (this.referenceLevelEqualsZero_ != null)
                {
                    return this.referenceLevelEqualsZero_; 
                }
                else if (this.referenceLevelEqualsZeroIDRef_ != null)
                {
                    referenceLevelEqualsZero_ = IDManager.getID(referenceLevelEqualsZeroIDRef_) as XsdTypeBoolean;
                    return this.referenceLevelEqualsZero_; 
                }
                else
                {
                      return this.referenceLevelEqualsZero_; 
                }
            }
            set
            {
                if (this.referenceLevelEqualsZero_ != value)
                {
                    this.referenceLevelEqualsZero_ = value;
                }
            }
        }
        #endregion
        
        public string referenceLevelEqualsZeroIDRef_ { get; set; }
        #region CalculationDate_
        private Period calculationDate_;
        public Period CalculationDate_
        {
            get
            {
                if (this.calculationDate_ != null)
                {
                    return this.calculationDate_; 
                }
                else if (this.calculationDateIDRef_ != null)
                {
                    calculationDate_ = IDManager.getID(calculationDateIDRef_) as Period;
                    return this.calculationDate_; 
                }
                else
                {
                      return this.calculationDate_; 
                }
            }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDateIDRef_ { get; set; }
        #region BusinessDays_
        private BusinessCenter businessDays_;
        public BusinessCenter BusinessDays_
        {
            get
            {
                if (this.businessDays_ != null)
                {
                    return this.businessDays_; 
                }
                else if (this.businessDaysIDRef_ != null)
                {
                    businessDays_ = IDManager.getID(businessDaysIDRef_) as BusinessCenter;
                    return this.businessDays_; 
                }
                else
                {
                      return this.businessDays_; 
                }
            }
            set
            {
                if (this.businessDays_ != value)
                {
                    this.businessDays_ = value;
                }
            }
        }
        #endregion
        
        public string businessDaysIDRef_ { get; set; }
        #region DataCorrection_
        private XsdTypeBoolean dataCorrection_;
        public XsdTypeBoolean DataCorrection_
        {
            get
            {
                if (this.dataCorrection_ != null)
                {
                    return this.dataCorrection_; 
                }
                else if (this.dataCorrectionIDRef_ != null)
                {
                    dataCorrection_ = IDManager.getID(dataCorrectionIDRef_) as XsdTypeBoolean;
                    return this.dataCorrection_; 
                }
                else
                {
                      return this.dataCorrection_; 
                }
            }
            set
            {
                if (this.dataCorrection_ != value)
                {
                    this.dataCorrection_ = value;
                }
            }
        }
        #endregion
        
        public string dataCorrectionIDRef_ { get; set; }
        #region CorrectionPeriod_
        private Period correctionPeriod_;
        public Period CorrectionPeriod_
        {
            get
            {
                if (this.correctionPeriod_ != null)
                {
                    return this.correctionPeriod_; 
                }
                else if (this.correctionPeriodIDRef_ != null)
                {
                    correctionPeriod_ = IDManager.getID(correctionPeriodIDRef_) as Period;
                    return this.correctionPeriod_; 
                }
                else
                {
                      return this.correctionPeriod_; 
                }
            }
            set
            {
                if (this.correctionPeriod_ != value)
                {
                    this.correctionPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string correctionPeriodIDRef_ { get; set; }
        #region MaximumPaymentAmount_
        private NonNegativeMoney maximumPaymentAmount_;
        public NonNegativeMoney MaximumPaymentAmount_
        {
            get
            {
                if (this.maximumPaymentAmount_ != null)
                {
                    return this.maximumPaymentAmount_; 
                }
                else if (this.maximumPaymentAmountIDRef_ != null)
                {
                    maximumPaymentAmount_ = IDManager.getID(maximumPaymentAmountIDRef_) as NonNegativeMoney;
                    return this.maximumPaymentAmount_; 
                }
                else
                {
                      return this.maximumPaymentAmount_; 
                }
            }
            set
            {
                if (this.maximumPaymentAmount_ != value)
                {
                    this.maximumPaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string maximumPaymentAmountIDRef_ { get; set; }
        #region MaximumTransactionPaymentAmount_
        private NonNegativeMoney maximumTransactionPaymentAmount_;
        public NonNegativeMoney MaximumTransactionPaymentAmount_
        {
            get
            {
                if (this.maximumTransactionPaymentAmount_ != null)
                {
                    return this.maximumTransactionPaymentAmount_; 
                }
                else if (this.maximumTransactionPaymentAmountIDRef_ != null)
                {
                    maximumTransactionPaymentAmount_ = IDManager.getID(maximumTransactionPaymentAmountIDRef_) as NonNegativeMoney;
                    return this.maximumTransactionPaymentAmount_; 
                }
                else
                {
                      return this.maximumTransactionPaymentAmount_; 
                }
            }
            set
            {
                if (this.maximumTransactionPaymentAmount_ != value)
                {
                    this.maximumTransactionPaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string maximumTransactionPaymentAmountIDRef_ { get; set; }
        #region Rounding_
        private Rounding rounding_;
        public Rounding Rounding_
        {
            get
            {
                if (this.rounding_ != null)
                {
                    return this.rounding_; 
                }
                else if (this.roundingIDRef_ != null)
                {
                    rounding_ = IDManager.getID(roundingIDRef_) as Rounding;
                    return this.rounding_; 
                }
                else
                {
                      return this.rounding_; 
                }
            }
            set
            {
                if (this.rounding_ != value)
                {
                    this.rounding_ = value;
                }
            }
        }
        #endregion
        
        public string roundingIDRef_ { get; set; }
        
    
        
    
    }
    
}

