using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DirectionalLegUnderlyerValuation
    {
        public DirectionalLegUnderlyerValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList valuationNodeList = xmlNode.SelectNodes("valuation");
            if (valuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationIDRef = item.Attributes["id"].Name;
                        EquityValuation ob = EquityValuation();
                        IDManager.SetID(valuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuation = new EquityValuation(item);
                    }
                }
            }
            
        
        }
        
    
        #region Valuation
        private EquityValuation valuation;
        public EquityValuation Valuation
        {
            get
            {
                if (this.valuation != null)
                {
                    return this.valuation; 
                }
                else if (this.valuationIDRef != null)
                {
                    valuation = IDManager.getID(valuationIDRef) as EquityValuation;
                    return this.valuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuation != value)
                {
                    this.valuation = value;
                }
            }
        }
        #endregion
        
        public string EquityValuationIDRef { get; set; }
        
    
        
    
    }
    
}

