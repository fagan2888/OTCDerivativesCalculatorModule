using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FallbackReferencePrice : ISerialized
    {
        public FallbackReferencePrice(XmlNode xmlNode)
        {
            XmlNode valuationPostponementNode = xmlNode.SelectSingleNode("valuationPostponement");
            
            if (valuationPostponementNode != null)
            {
                if (valuationPostponementNode.Attributes["href"] != null || valuationPostponementNode.Attributes["id"] != null) 
                {
                    if (valuationPostponementNode.Attributes["id"] != null) 
                    {
                        valuationPostponementIDRef_ = valuationPostponementNode.Attributes["id"].Value;
                        ValuationPostponement ob = new ValuationPostponement(valuationPostponementNode);
                        IDManager.SetID(valuationPostponementIDRef_, ob);
                    }
                    else if (valuationPostponementNode.Attributes["href"] != null)
                    {
                        valuationPostponementIDRef_ = valuationPostponementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationPostponement_ = new ValuationPostponement(valuationPostponementNode);
                    }
                }
                else
                {
                    valuationPostponement_ = new ValuationPostponement(valuationPostponementNode);
                }
            }
            
        
            XmlNodeList fallbackSettlementRateOptionNodeList = xmlNode.SelectNodes("fallbackSettlementRateOption");
            
            if (fallbackSettlementRateOptionNodeList != null)
            {
                this.fallbackSettlementRateOption_ = new List<SettlementRateOption>();
                foreach (XmlNode item in fallbackSettlementRateOptionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fallbackSettlementRateOptionIDRef_ = item.Attributes["id"].Value;
                            fallbackSettlementRateOption_.Add(new SettlementRateOption(item));
                            IDManager.SetID(fallbackSettlementRateOptionIDRef_, fallbackSettlementRateOption_[fallbackSettlementRateOption_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fallbackSettlementRateOptionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fallbackSettlementRateOption_.Add(new SettlementRateOption(item));
                        }
                    }
                    else
                    {
                        fallbackSettlementRateOption_.Add(new SettlementRateOption(item));
                    }
                }
            }
            
        
            XmlNode fallbackSurveyValuationPostponenmentNode = xmlNode.SelectSingleNode("fallbackSurveyValuationPostponenment");
            
            if (fallbackSurveyValuationPostponenmentNode != null)
            {
                if (fallbackSurveyValuationPostponenmentNode.Attributes["href"] != null || fallbackSurveyValuationPostponenmentNode.Attributes["id"] != null) 
                {
                    if (fallbackSurveyValuationPostponenmentNode.Attributes["id"] != null) 
                    {
                        fallbackSurveyValuationPostponenmentIDRef_ = fallbackSurveyValuationPostponenmentNode.Attributes["id"].Value;
                        Empty ob = new Empty(fallbackSurveyValuationPostponenmentNode);
                        IDManager.SetID(fallbackSurveyValuationPostponenmentIDRef_, ob);
                    }
                    else if (fallbackSurveyValuationPostponenmentNode.Attributes["href"] != null)
                    {
                        fallbackSurveyValuationPostponenmentIDRef_ = fallbackSurveyValuationPostponenmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallbackSurveyValuationPostponenment_ = new Empty(fallbackSurveyValuationPostponenmentNode);
                    }
                }
                else
                {
                    fallbackSurveyValuationPostponenment_ = new Empty(fallbackSurveyValuationPostponenmentNode);
                }
            }
            
        
            XmlNode calculationAgentDeterminationNode = xmlNode.SelectSingleNode("calculationAgentDetermination");
            
            if (calculationAgentDeterminationNode != null)
            {
                if (calculationAgentDeterminationNode.Attributes["href"] != null || calculationAgentDeterminationNode.Attributes["id"] != null) 
                {
                    if (calculationAgentDeterminationNode.Attributes["id"] != null) 
                    {
                        calculationAgentDeterminationIDRef_ = calculationAgentDeterminationNode.Attributes["id"].Value;
                        CalculationAgent ob = new CalculationAgent(calculationAgentDeterminationNode);
                        IDManager.SetID(calculationAgentDeterminationIDRef_, ob);
                    }
                    else if (calculationAgentDeterminationNode.Attributes["href"] != null)
                    {
                        calculationAgentDeterminationIDRef_ = calculationAgentDeterminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgentDetermination_ = new CalculationAgent(calculationAgentDeterminationNode);
                    }
                }
                else
                {
                    calculationAgentDetermination_ = new CalculationAgent(calculationAgentDeterminationNode);
                }
            }
            
        
        }
        
    
        #region ValuationPostponement_
        private ValuationPostponement valuationPostponement_;
        public ValuationPostponement ValuationPostponement_
        {
            get
            {
                if (this.valuationPostponement_ != null)
                {
                    return this.valuationPostponement_; 
                }
                else if (this.valuationPostponementIDRef_ != null)
                {
                    valuationPostponement_ = IDManager.getID(valuationPostponementIDRef_) as ValuationPostponement;
                    return this.valuationPostponement_; 
                }
                else
                {
                      return this.valuationPostponement_; 
                }
            }
            set
            {
                if (this.valuationPostponement_ != value)
                {
                    this.valuationPostponement_ = value;
                }
            }
        }
        #endregion
        
        public string valuationPostponementIDRef_ { get; set; }
        #region FallbackSettlementRateOption_
        private List<SettlementRateOption> fallbackSettlementRateOption_;
        public List<SettlementRateOption> FallbackSettlementRateOption_
        {
            get
            {
                if (this.fallbackSettlementRateOption_ != null)
                {
                    return this.fallbackSettlementRateOption_; 
                }
                else if (this.fallbackSettlementRateOptionIDRef_ != null)
                {
                    return this.fallbackSettlementRateOption_; 
                }
                else
                {
                      return this.fallbackSettlementRateOption_; 
                }
            }
            set
            {
                if (this.fallbackSettlementRateOption_ != value)
                {
                    this.fallbackSettlementRateOption_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackSettlementRateOptionIDRef_ { get; set; }
        #region FallbackSurveyValuationPostponenment_
        private Empty fallbackSurveyValuationPostponenment_;
        public Empty FallbackSurveyValuationPostponenment_
        {
            get
            {
                if (this.fallbackSurveyValuationPostponenment_ != null)
                {
                    return this.fallbackSurveyValuationPostponenment_; 
                }
                else if (this.fallbackSurveyValuationPostponenmentIDRef_ != null)
                {
                    fallbackSurveyValuationPostponenment_ = IDManager.getID(fallbackSurveyValuationPostponenmentIDRef_) as Empty;
                    return this.fallbackSurveyValuationPostponenment_; 
                }
                else
                {
                      return this.fallbackSurveyValuationPostponenment_; 
                }
            }
            set
            {
                if (this.fallbackSurveyValuationPostponenment_ != value)
                {
                    this.fallbackSurveyValuationPostponenment_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackSurveyValuationPostponenmentIDRef_ { get; set; }
        #region CalculationAgentDetermination_
        private CalculationAgent calculationAgentDetermination_;
        public CalculationAgent CalculationAgentDetermination_
        {
            get
            {
                if (this.calculationAgentDetermination_ != null)
                {
                    return this.calculationAgentDetermination_; 
                }
                else if (this.calculationAgentDeterminationIDRef_ != null)
                {
                    calculationAgentDetermination_ = IDManager.getID(calculationAgentDeterminationIDRef_) as CalculationAgent;
                    return this.calculationAgentDetermination_; 
                }
                else
                {
                      return this.calculationAgentDetermination_; 
                }
            }
            set
            {
                if (this.calculationAgentDetermination_ != value)
                {
                    this.calculationAgentDetermination_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentDeterminationIDRef_ { get; set; }
        
    
        
    
    }
    
}

