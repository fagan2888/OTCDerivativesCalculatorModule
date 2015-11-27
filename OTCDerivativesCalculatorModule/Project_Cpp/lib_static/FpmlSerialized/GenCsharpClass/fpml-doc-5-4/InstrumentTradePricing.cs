using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradePricing
    {
        public InstrumentTradePricing(XmlNode xmlNode)
        {
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            foreach (XmlNode item in quoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteIDRef = item.Attributes["id"].Name;
                        List<BasicQuotation> ob = new List<BasicQuotation>();
                        ob.Add(new BasicQuotation(item));
                        IDManager.SetID(quoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quote.Add(new BasicQuotation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Quote
        private List<BasicQuotation> quote;
        public List<BasicQuotation> Quote
        {
            get
            {
                if (this.quote != null)
                {
                    return this.quote; 
                }
                else if (this.quoteIDRef != null)
                {
                    quote = IDManager.getID(quoteIDRef) as List<BasicQuotation>;
                    return this.quote; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quote != value)
                {
                    this.quote = value;
                }
            }
        }
        #endregion
        
        public string BasicQuotationIDRef { get; set; }
        
    
        
    
    }
    
}

