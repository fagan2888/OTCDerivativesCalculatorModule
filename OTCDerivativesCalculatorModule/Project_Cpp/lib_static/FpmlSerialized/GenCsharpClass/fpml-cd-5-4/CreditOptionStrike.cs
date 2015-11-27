using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditOptionStrike
    {
        public CreditOptionStrike(XmlNode xmlNode)
        {
            XmlNodeList spreadNodeList = xmlNode.SelectNodes("spread");
            if (spreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spread = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList priceNodeList = xmlNode.SelectNodes("price");
            if (priceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(priceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        price = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList strikeReferenceNodeList = xmlNode.SelectNodes("strikeReference");
            if (strikeReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeReferenceIDRef = item.Attributes["id"].Name;
                        FixedRateReference ob = FixedRateReference();
                        IDManager.SetID(strikeReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeReference = new FixedRateReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Spread
        private XsdTypeDecimal spread;
        public XsdTypeDecimal Spread
        {
            get
            {
                if (this.spread != null)
                {
                    return this.spread; 
                }
                else if (this.spreadIDRef != null)
                {
                    spread = IDManager.getID(spreadIDRef) as XsdTypeDecimal;
                    return this.spread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spread != value)
                {
                    this.spread = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Price
        private XsdTypeDecimal price;
        public XsdTypeDecimal Price
        {
            get
            {
                if (this.price != null)
                {
                    return this.price; 
                }
                else if (this.priceIDRef != null)
                {
                    price = IDManager.getID(priceIDRef) as XsdTypeDecimal;
                    return this.price; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StrikeReference
        private FixedRateReference strikeReference;
        public FixedRateReference StrikeReference
        {
            get
            {
                if (this.strikeReference != null)
                {
                    return this.strikeReference; 
                }
                else if (this.strikeReferenceIDRef != null)
                {
                    strikeReference = IDManager.getID(strikeReferenceIDRef) as FixedRateReference;
                    return this.strikeReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeReference != value)
                {
                    this.strikeReference = value;
                }
            }
        }
        #endregion
        
        public string FixedRateReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

