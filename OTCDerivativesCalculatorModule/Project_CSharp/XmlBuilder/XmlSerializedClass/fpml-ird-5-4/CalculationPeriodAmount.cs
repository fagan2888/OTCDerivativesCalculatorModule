using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodAmount : ISerialized
    {
        public CalculationPeriodAmount(XmlNode xmlNode)
        {
            XmlNode calculationNode = xmlNode.SelectSingleNode("calculation");
            
            if (calculationNode != null)
            {
                if (calculationNode.Attributes["href"] != null || calculationNode.Attributes["id"] != null) 
                {
                    if (calculationNode.Attributes["id"] != null) 
                    {
                        calculationIDRef_ = calculationNode.Attributes["id"].Value;
                        Calculation ob = new Calculation(calculationNode);
                        IDManager.SetID(calculationIDRef_, ob);
                    }
                    else if (calculationNode.Attributes["href"] != null)
                    {
                        calculationIDRef_ = calculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculation_ = new Calculation(calculationNode);
                    }
                }
                else
                {
                    calculation_ = new Calculation(calculationNode);
                }
            }
            
        
            XmlNode knownAmountScheduleNode = xmlNode.SelectSingleNode("knownAmountSchedule");
            
            if (knownAmountScheduleNode != null)
            {
                if (knownAmountScheduleNode.Attributes["href"] != null || knownAmountScheduleNode.Attributes["id"] != null) 
                {
                    if (knownAmountScheduleNode.Attributes["id"] != null) 
                    {
                        knownAmountScheduleIDRef_ = knownAmountScheduleNode.Attributes["id"].Value;
                        AmountSchedule ob = new AmountSchedule(knownAmountScheduleNode);
                        IDManager.SetID(knownAmountScheduleIDRef_, ob);
                    }
                    else if (knownAmountScheduleNode.Attributes["href"] != null)
                    {
                        knownAmountScheduleIDRef_ = knownAmountScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        knownAmountSchedule_ = new AmountSchedule(knownAmountScheduleNode);
                    }
                }
                else
                {
                    knownAmountSchedule_ = new AmountSchedule(knownAmountScheduleNode);
                }
            }
            
        
        }
        
    
        #region Calculation_
        private Calculation calculation_;
        public Calculation Calculation_
        {
            get
            {
                if (this.calculation_ != null)
                {
                    return this.calculation_; 
                }
                else if (this.calculationIDRef_ != null)
                {
                    calculation_ = IDManager.getID(calculationIDRef_) as Calculation;
                    return this.calculation_; 
                }
                else
                {
                      return this.calculation_; 
                }
            }
            set
            {
                if (this.calculation_ != value)
                {
                    this.calculation_ = value;
                }
            }
        }
        #endregion
        
        public string calculationIDRef_ { get; set; }
        #region KnownAmountSchedule_
        private AmountSchedule knownAmountSchedule_;
        public AmountSchedule KnownAmountSchedule_
        {
            get
            {
                if (this.knownAmountSchedule_ != null)
                {
                    return this.knownAmountSchedule_; 
                }
                else if (this.knownAmountScheduleIDRef_ != null)
                {
                    knownAmountSchedule_ = IDManager.getID(knownAmountScheduleIDRef_) as AmountSchedule;
                    return this.knownAmountSchedule_; 
                }
                else
                {
                      return this.knownAmountSchedule_; 
                }
            }
            set
            {
                if (this.knownAmountSchedule_ != value)
                {
                    this.knownAmountSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string knownAmountScheduleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

