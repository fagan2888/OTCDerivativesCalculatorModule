using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MandatoryEarlyTermination : ISerialized
    {
        public MandatoryEarlyTermination(XmlNode xmlNode)
        {
            XmlNode mandatoryEarlyTerminationDateNode = xmlNode.SelectSingleNode("mandatoryEarlyTerminationDate");
            
            if (mandatoryEarlyTerminationDateNode != null)
            {
                if (mandatoryEarlyTerminationDateNode.Attributes["href"] != null || mandatoryEarlyTerminationDateNode.Attributes["id"] != null) 
                {
                    if (mandatoryEarlyTerminationDateNode.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationDateIDRef_ = mandatoryEarlyTerminationDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(mandatoryEarlyTerminationDateNode);
                        IDManager.SetID(mandatoryEarlyTerminationDateIDRef_, ob);
                    }
                    else if (mandatoryEarlyTerminationDateNode.Attributes["href"] != null)
                    {
                        mandatoryEarlyTerminationDateIDRef_ = mandatoryEarlyTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mandatoryEarlyTerminationDate_ = new AdjustableDate(mandatoryEarlyTerminationDateNode);
                    }
                }
                else
                {
                    mandatoryEarlyTerminationDate_ = new AdjustableDate(mandatoryEarlyTerminationDateNode);
                }
            }
            
        
            XmlNode calculationAgentNode = xmlNode.SelectSingleNode("calculationAgent");
            
            if (calculationAgentNode != null)
            {
                if (calculationAgentNode.Attributes["href"] != null || calculationAgentNode.Attributes["id"] != null) 
                {
                    if (calculationAgentNode.Attributes["id"] != null) 
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["id"].Value;
                        CalculationAgent ob = new CalculationAgent(calculationAgentNode);
                        IDManager.SetID(calculationAgentIDRef_, ob);
                    }
                    else if (calculationAgentNode.Attributes["href"] != null)
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgent_ = new CalculationAgent(calculationAgentNode);
                    }
                }
                else
                {
                    calculationAgent_ = new CalculationAgent(calculationAgentNode);
                }
            }
            
        
            XmlNode cashSettlementNode = xmlNode.SelectSingleNode("cashSettlement");
            
            if (cashSettlementNode != null)
            {
                if (cashSettlementNode.Attributes["href"] != null || cashSettlementNode.Attributes["id"] != null) 
                {
                    if (cashSettlementNode.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["id"].Value;
                        CashSettlement ob = new CashSettlement(cashSettlementNode);
                        IDManager.SetID(cashSettlementIDRef_, ob);
                    }
                    else if (cashSettlementNode.Attributes["href"] != null)
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlement_ = new CashSettlement(cashSettlementNode);
                    }
                }
                else
                {
                    cashSettlement_ = new CashSettlement(cashSettlementNode);
                }
            }
            
        
            XmlNode mandatoryEarlyTerminationAdjustedDatesNode = xmlNode.SelectSingleNode("mandatoryEarlyTerminationAdjustedDates");
            
            if (mandatoryEarlyTerminationAdjustedDatesNode != null)
            {
                if (mandatoryEarlyTerminationAdjustedDatesNode.Attributes["href"] != null || mandatoryEarlyTerminationAdjustedDatesNode.Attributes["id"] != null) 
                {
                    if (mandatoryEarlyTerminationAdjustedDatesNode.Attributes["id"] != null) 
                    {
                        mandatoryEarlyTerminationAdjustedDatesIDRef_ = mandatoryEarlyTerminationAdjustedDatesNode.Attributes["id"].Value;
                        MandatoryEarlyTerminationAdjustedDates ob = new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode);
                        IDManager.SetID(mandatoryEarlyTerminationAdjustedDatesIDRef_, ob);
                    }
                    else if (mandatoryEarlyTerminationAdjustedDatesNode.Attributes["href"] != null)
                    {
                        mandatoryEarlyTerminationAdjustedDatesIDRef_ = mandatoryEarlyTerminationAdjustedDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mandatoryEarlyTerminationAdjustedDates_ = new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode);
                    }
                }
                else
                {
                    mandatoryEarlyTerminationAdjustedDates_ = new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode);
                }
            }
            
        
        }
        
    
        #region MandatoryEarlyTerminationDate_
        private AdjustableDate mandatoryEarlyTerminationDate_;
        public AdjustableDate MandatoryEarlyTerminationDate_
        {
            get
            {
                if (this.mandatoryEarlyTerminationDate_ != null)
                {
                    return this.mandatoryEarlyTerminationDate_; 
                }
                else if (this.mandatoryEarlyTerminationDateIDRef_ != null)
                {
                    mandatoryEarlyTerminationDate_ = IDManager.getID(mandatoryEarlyTerminationDateIDRef_) as AdjustableDate;
                    return this.mandatoryEarlyTerminationDate_; 
                }
                else
                {
                      return this.mandatoryEarlyTerminationDate_; 
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationDate_ != value)
                {
                    this.mandatoryEarlyTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string mandatoryEarlyTerminationDateIDRef_ { get; set; }
        #region CalculationAgent_
        private CalculationAgent calculationAgent_;
        public CalculationAgent CalculationAgent_
        {
            get
            {
                if (this.calculationAgent_ != null)
                {
                    return this.calculationAgent_; 
                }
                else if (this.calculationAgentIDRef_ != null)
                {
                    calculationAgent_ = IDManager.getID(calculationAgentIDRef_) as CalculationAgent;
                    return this.calculationAgent_; 
                }
                else
                {
                      return this.calculationAgent_; 
                }
            }
            set
            {
                if (this.calculationAgent_ != value)
                {
                    this.calculationAgent_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentIDRef_ { get; set; }
        #region CashSettlement_
        private CashSettlement cashSettlement_;
        public CashSettlement CashSettlement_
        {
            get
            {
                if (this.cashSettlement_ != null)
                {
                    return this.cashSettlement_; 
                }
                else if (this.cashSettlementIDRef_ != null)
                {
                    cashSettlement_ = IDManager.getID(cashSettlementIDRef_) as CashSettlement;
                    return this.cashSettlement_; 
                }
                else
                {
                      return this.cashSettlement_; 
                }
            }
            set
            {
                if (this.cashSettlement_ != value)
                {
                    this.cashSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementIDRef_ { get; set; }
        #region MandatoryEarlyTerminationAdjustedDates_
        private MandatoryEarlyTerminationAdjustedDates mandatoryEarlyTerminationAdjustedDates_;
        public MandatoryEarlyTerminationAdjustedDates MandatoryEarlyTerminationAdjustedDates_
        {
            get
            {
                if (this.mandatoryEarlyTerminationAdjustedDates_ != null)
                {
                    return this.mandatoryEarlyTerminationAdjustedDates_; 
                }
                else if (this.mandatoryEarlyTerminationAdjustedDatesIDRef_ != null)
                {
                    mandatoryEarlyTerminationAdjustedDates_ = IDManager.getID(mandatoryEarlyTerminationAdjustedDatesIDRef_) as MandatoryEarlyTerminationAdjustedDates;
                    return this.mandatoryEarlyTerminationAdjustedDates_; 
                }
                else
                {
                      return this.mandatoryEarlyTerminationAdjustedDates_; 
                }
            }
            set
            {
                if (this.mandatoryEarlyTerminationAdjustedDates_ != value)
                {
                    this.mandatoryEarlyTerminationAdjustedDates_ = value;
                }
            }
        }
        #endregion
        
        public string mandatoryEarlyTerminationAdjustedDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

