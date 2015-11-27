using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RateCalculation : ISerialized
    {
        public RateCalculation() { }
        public RateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode calculationAmountNode = xmlNode.SelectSingleNode("calculationAmount");
            
            if (calculationAmountNode != null)
            {
                if (calculationAmountNode.Attributes["href"] != null || calculationAmountNode.Attributes["id"] != null) 
                {
                    if (calculationAmountNode.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["id"].Value;
                        CalculationAmount ob = new CalculationAmount(calculationAmountNode);
                        IDManager.SetID(calculationAmountIDRef_, ob);
                    }
                    else if (calculationAmountNode.Attributes["href"] != null)
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAmount_ = new CalculationAmount(calculationAmountNode);
                    }
                }
                else
                {
                    calculationAmount_ = new CalculationAmount(calculationAmountNode);
                }
            }
            
        
            XmlNode calculationStartDateNode = xmlNode.SelectSingleNode("calculationStartDate");
            
            if (calculationStartDateNode != null)
            {
                if (calculationStartDateNode.Attributes["href"] != null || calculationStartDateNode.Attributes["id"] != null) 
                {
                    if (calculationStartDateNode.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
                }
            }
            
        
            XmlNode calculationEndDateNode = xmlNode.SelectSingleNode("calculationEndDate");
            
            if (calculationEndDateNode != null)
            {
                if (calculationEndDateNode.Attributes["href"] != null || calculationEndDateNode.Attributes["id"] != null) 
                {
                    if (calculationEndDateNode.Attributes["id"] != null) 
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new XsdTypeDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new XsdTypeDate(paymentDateNode);
                }
            }
            
        
            XmlNode vanillaRateCalculationNode = xmlNode.SelectSingleNode("vanillaRateCalculation");
            
            if (vanillaRateCalculationNode != null)
            {
                if (vanillaRateCalculationNode.Attributes["href"] != null || vanillaRateCalculationNode.Attributes["id"] != null) 
                {
                    if (vanillaRateCalculationNode.Attributes["id"] != null) 
                    {
                        vanillaRateCalculationIDRef_ = vanillaRateCalculationNode.Attributes["id"].Value;
                        VanillaRateCalculation ob = new VanillaRateCalculation(vanillaRateCalculationNode);
                        IDManager.SetID(vanillaRateCalculationIDRef_, ob);
                    }
                    else if (vanillaRateCalculationNode.Attributes["href"] != null)
                    {
                        vanillaRateCalculationIDRef_ = vanillaRateCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaRateCalculation_ = new VanillaRateCalculation(vanillaRateCalculationNode);
                    }
                }
                else
                {
                    vanillaRateCalculation_ = new VanillaRateCalculation(vanillaRateCalculationNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region CalculationAmount_
        private CalculationAmount calculationAmount_;
        public CalculationAmount CalculationAmount_
        {
            get
            {
                if (this.calculationAmount_ != null)
                {
                    return this.calculationAmount_; 
                }
                else if (this.calculationAmountIDRef_ != null)
                {
                    calculationAmount_ = IDManager.getID(calculationAmountIDRef_) as CalculationAmount;
                    return this.calculationAmount_; 
                }
                else
                {
                    throw new Exception( "calculationAmount_Node no exist!");
                }
            }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAmountIDRef_ { get; set; }
        #region CalculationStartDate_
        private XsdTypeDate calculationStartDate_;
        public XsdTypeDate CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as XsdTypeDate;
                    return this.calculationStartDate_; 
                }
                else
                {
                    throw new Exception( "calculationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationStartDateIDRef_ { get; set; }
        #region CalculationEndDate_
        private XsdTypeDate calculationEndDate_;
        public XsdTypeDate CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as XsdTypeDate;
                    return this.calculationEndDate_; 
                }
                else
                {
                    throw new Exception( "calculationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationEndDateIDRef_ { get; set; }
        #region PaymentDate_
        private XsdTypeDate paymentDate_;
        public XsdTypeDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as XsdTypeDate;
                    return this.paymentDate_; 
                }
                else
                {
                    throw new Exception( "paymentDate_Node no exist!");
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
        #region VanillaRateCalculation_
        private VanillaRateCalculation vanillaRateCalculation_;
        public VanillaRateCalculation VanillaRateCalculation_
        {
            get
            {
                if (this.vanillaRateCalculation_ != null)
                {
                    return this.vanillaRateCalculation_; 
                }
                else if (this.vanillaRateCalculationIDRef_ != null)
                {
                    vanillaRateCalculation_ = IDManager.getID(vanillaRateCalculationIDRef_) as VanillaRateCalculation;
                    return this.vanillaRateCalculation_; 
                }
                else
                {
                    throw new Exception( "vanillaRateCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaRateCalculation_ != value)
                {
                    this.vanillaRateCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaRateCalculationIDRef_ { get; set; }
        public string choiceStr_rateCalType;
        
    
        
    
    }
    
}

