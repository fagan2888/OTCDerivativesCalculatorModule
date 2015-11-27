using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FallbackReferencePrice
    {
        public FallbackReferencePrice(XmlNode xmlNode)
        {
            XmlNodeList valuationPostponementNodeList = xmlNode.SelectNodes("valuationPostponement");
            if (valuationPostponementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationPostponementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationPostponementIDRef = item.Attributes["id"].Name;
                        ValuationPostponement ob = ValuationPostponement();
                        IDManager.SetID(valuationPostponementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationPostponementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationPostponement = new ValuationPostponement(item);
                    }
                }
            }
            
        
            XmlNodeList fallbackSettlementRateOptionNodeList = xmlNode.SelectNodes("fallbackSettlementRateOption");
            
            foreach (XmlNode item in fallbackSettlementRateOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackSettlementRateOptionIDRef = item.Attributes["id"].Name;
                        List<SettlementRateOption> ob = new List<SettlementRateOption>();
                        ob.Add(new SettlementRateOption(item));
                        IDManager.SetID(fallbackSettlementRateOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackSettlementRateOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fallbackSettlementRateOption.Add(new SettlementRateOption(item));
                    }
                }
            }
            
        
            XmlNodeList fallbackSurveyValuationPostponenmentNodeList = xmlNode.SelectNodes("fallbackSurveyValuationPostponenment");
            if (fallbackSurveyValuationPostponenmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackSurveyValuationPostponenmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackSurveyValuationPostponenmentIDRef = item.Attributes["id"].Name;
                        Empty ob = Empty();
                        IDManager.SetID(fallbackSurveyValuationPostponenmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackSurveyValuationPostponenmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallbackSurveyValuationPostponenment = new Empty(item);
                    }
                }
            }
            
        
            XmlNodeList calculationAgentDeterminationNodeList = xmlNode.SelectNodes("calculationAgentDetermination");
            if (calculationAgentDeterminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationAgentDeterminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAgentDeterminationIDRef = item.Attributes["id"].Name;
                        CalculationAgent ob = CalculationAgent();
                        IDManager.SetID(calculationAgentDeterminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAgentDeterminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAgentDetermination = new CalculationAgent(item);
                    }
                }
            }
            
        
        }
        
    
        #region ValuationPostponement
        private ValuationPostponement valuationPostponement;
        public ValuationPostponement ValuationPostponement
        {
            get
            {
                if (this.valuationPostponement != null)
                {
                    return this.valuationPostponement; 
                }
                else if (this.valuationPostponementIDRef != null)
                {
                    valuationPostponement = IDManager.getID(valuationPostponementIDRef) as ValuationPostponement;
                    return this.valuationPostponement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationPostponement != value)
                {
                    this.valuationPostponement = value;
                }
            }
        }
        #endregion
        
        public string ValuationPostponementIDRef { get; set; }
        #region FallbackSettlementRateOption
        private List<SettlementRateOption> fallbackSettlementRateOption;
        public List<SettlementRateOption> FallbackSettlementRateOption
        {
            get
            {
                if (this.fallbackSettlementRateOption != null)
                {
                    return this.fallbackSettlementRateOption; 
                }
                else if (this.fallbackSettlementRateOptionIDRef != null)
                {
                    fallbackSettlementRateOption = IDManager.getID(fallbackSettlementRateOptionIDRef) as List<SettlementRateOption>;
                    return this.fallbackSettlementRateOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackSettlementRateOption != value)
                {
                    this.fallbackSettlementRateOption = value;
                }
            }
        }
        #endregion
        
        public string SettlementRateOptionIDRef { get; set; }
        #region FallbackSurveyValuationPostponenment
        private Empty fallbackSurveyValuationPostponenment;
        public Empty FallbackSurveyValuationPostponenment
        {
            get
            {
                if (this.fallbackSurveyValuationPostponenment != null)
                {
                    return this.fallbackSurveyValuationPostponenment; 
                }
                else if (this.fallbackSurveyValuationPostponenmentIDRef != null)
                {
                    fallbackSurveyValuationPostponenment = IDManager.getID(fallbackSurveyValuationPostponenmentIDRef) as Empty;
                    return this.fallbackSurveyValuationPostponenment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackSurveyValuationPostponenment != value)
                {
                    this.fallbackSurveyValuationPostponenment = value;
                }
            }
        }
        #endregion
        
        public string EmptyIDRef { get; set; }
        #region CalculationAgentDetermination
        private CalculationAgent calculationAgentDetermination;
        public CalculationAgent CalculationAgentDetermination
        {
            get
            {
                if (this.calculationAgentDetermination != null)
                {
                    return this.calculationAgentDetermination; 
                }
                else if (this.calculationAgentDeterminationIDRef != null)
                {
                    calculationAgentDetermination = IDManager.getID(calculationAgentDeterminationIDRef) as CalculationAgent;
                    return this.calculationAgentDetermination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAgentDetermination != value)
                {
                    this.calculationAgentDetermination = value;
                }
            }
        }
        #endregion
        
        public string CalculationAgentIDRef { get; set; }
        
    
        
    
    }
    
}

