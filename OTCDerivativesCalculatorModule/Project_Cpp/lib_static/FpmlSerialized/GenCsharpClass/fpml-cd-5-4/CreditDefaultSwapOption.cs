using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditDefaultSwapOption
    {
        public CreditDefaultSwapOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        CreditOptionStrike ob = CreditOptionStrike();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new CreditOptionStrike(item);
                    }
                }
            }
            
        
            XmlNodeList creditDefaultSwapNodeList = xmlNode.SelectNodes("creditDefaultSwap");
            if (creditDefaultSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditDefaultSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditDefaultSwapIDRef = item.Attributes["id"].Name;
                        CreditDefaultSwap ob = CreditDefaultSwap();
                        IDManager.SetID(creditDefaultSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditDefaultSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditDefaultSwap = new CreditDefaultSwap(item);
                    }
                }
            }
            
        
        }
        
    
        #region Strike
        private CreditOptionStrike strike;
        public CreditOptionStrike Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as CreditOptionStrike;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string CreditOptionStrikeIDRef { get; set; }
        #region CreditDefaultSwap
        private CreditDefaultSwap creditDefaultSwap;
        public CreditDefaultSwap CreditDefaultSwap
        {
            get
            {
                if (this.creditDefaultSwap != null)
                {
                    return this.creditDefaultSwap; 
                }
                else if (this.creditDefaultSwapIDRef != null)
                {
                    creditDefaultSwap = IDManager.getID(creditDefaultSwapIDRef) as CreditDefaultSwap;
                    return this.creditDefaultSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditDefaultSwap != value)
                {
                    this.creditDefaultSwap = value;
                }
            }
        }
        #endregion
        
        public string CreditDefaultSwapIDRef { get; set; }
        
    
        
    
    }
    
}

