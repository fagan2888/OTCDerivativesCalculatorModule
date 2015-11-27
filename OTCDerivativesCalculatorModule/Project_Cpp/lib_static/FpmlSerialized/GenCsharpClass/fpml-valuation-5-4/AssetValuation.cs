using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AssetValuation
    {
        public AssetValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            foreach (XmlNode item in quoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteIDRef = item.Attributes["id"].Name;
                        List<Quotation> ob = new List<Quotation>();
                        ob.Add(new Quotation(item));
                        IDManager.SetID(quoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quote.Add(new Quotation(item));
                    }
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            foreach (XmlNode item in fxRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxRateIDRef = item.Attributes["id"].Name;
                        List<FxRate> ob = new List<FxRate>();
                        ob.Add(new FxRate(item));
                        IDManager.SetID(fxRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fxRate.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region Quote
        private List<Quotation> quote;
        public List<Quotation> Quote
        {
            get
            {
                if (this.quote != null)
                {
                    return this.quote; 
                }
                else if (this.quoteIDRef != null)
                {
                    quote = IDManager.getID(quoteIDRef) as List<Quotation>;
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
        
        public string QuotationIDRef { get; set; }
        #region FxRate
        private List<FxRate> fxRate;
        public List<FxRate> FxRate
        {
            get
            {
                if (this.fxRate != null)
                {
                    return this.fxRate; 
                }
                else if (this.fxRateIDRef != null)
                {
                    fxRate = IDManager.getID(fxRateIDRef) as List<FxRate>;
                    return this.fxRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxRate != value)
                {
                    this.fxRate = value;
                }
            }
        }
        #endregion
        
        public string FxRateIDRef { get; set; }
        
    
        
    
    }
    
}

