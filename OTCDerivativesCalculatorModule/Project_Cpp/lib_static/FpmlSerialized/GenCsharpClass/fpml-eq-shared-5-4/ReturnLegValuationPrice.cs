using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnLegValuationPrice
    {
        public ReturnLegValuationPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList valuationRulesNodeList = xmlNode.SelectNodes("valuationRules");
            if (valuationRulesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationRulesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationRulesIDRef = item.Attributes["id"].Name;
                        EquityValuation ob = EquityValuation();
                        IDManager.SetID(valuationRulesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationRulesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationRules = new EquityValuation(item);
                    }
                }
            }
            
        
        }
        
    
        #region ValuationRules
        private EquityValuation valuationRules;
        public EquityValuation ValuationRules
        {
            get
            {
                if (this.valuationRules != null)
                {
                    return this.valuationRules; 
                }
                else if (this.valuationRulesIDRef != null)
                {
                    valuationRules = IDManager.getID(valuationRulesIDRef) as EquityValuation;
                    return this.valuationRules; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationRules != value)
                {
                    this.valuationRules = value;
                }
            }
        }
        #endregion
        
        public string EquityValuationIDRef { get; set; }
        
    
        
    
    }
    
}

