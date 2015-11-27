using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class SwapStream : ISerialized
    {
        public SwapStream() { }
        public SwapStream(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode irCalculationNode = xmlNode.SelectSingleNode("irCalculation");
            
            if (irCalculationNode != null)
            {
                if (irCalculationNode.Attributes["href"] != null || irCalculationNode.Attributes["id"] != null) 
                {
                    if (irCalculationNode.Attributes["id"] != null) 
                    {
                        irCalculationIDRef_ = irCalculationNode.Attributes["id"].Value;
                        IRCalculation ob = new IRCalculation(irCalculationNode);
                        IDManager.SetID(irCalculationIDRef_, ob);
                    }
                    else if (irCalculationNode.Attributes["href"] != null)
                    {
                        irCalculationIDRef_ = irCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        irCalculation_ = new IRCalculation(irCalculationNode);
                    }
                }
                else
                {
                    irCalculation_ = new IRCalculation(irCalculationNode);
                }
            }
            
        
        }
        
    
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
                      return this.calculationAmount_; 
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
        #region IrCalculation_
        private IRCalculation irCalculation_;
        public IRCalculation IrCalculation_
        {
            get
            {
                if (this.irCalculation_ != null)
                {
                    return this.irCalculation_; 
                }
                else if (this.irCalculationIDRef_ != null)
                {
                    irCalculation_ = IDManager.getID(irCalculationIDRef_) as IRCalculation;
                    return this.irCalculation_; 
                }
                else
                {
                      return this.irCalculation_; 
                }
            }
            set
            {
                if (this.irCalculation_ != value)
                {
                    this.irCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string irCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

