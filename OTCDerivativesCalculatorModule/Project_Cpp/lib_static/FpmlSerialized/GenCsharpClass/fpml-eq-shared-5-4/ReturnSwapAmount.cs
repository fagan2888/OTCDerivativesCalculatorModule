using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapAmount
    {
        public ReturnSwapAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList cashSettlementNodeList = xmlNode.SelectNodes("cashSettlement");
            if (cashSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(cashSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeDividendsNodeList = xmlNode.SelectNodes("optionsExchangeDividends");
            if (optionsExchangeDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionsExchangeDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionsExchangeDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(optionsExchangeDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionsExchangeDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionsExchangeDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList additionalDividendsNodeList = xmlNode.SelectNodes("additionalDividends");
            if (additionalDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(additionalDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList allDividendsNodeList = xmlNode.SelectNodes("allDividends");
            if (allDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(allDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region CashSettlement
        private XsdTypeBoolean cashSettlement;
        public XsdTypeBoolean CashSettlement
        {
            get
            {
                if (this.cashSettlement != null)
                {
                    return this.cashSettlement; 
                }
                else if (this.cashSettlementIDRef != null)
                {
                    cashSettlement = IDManager.getID(cashSettlementIDRef) as XsdTypeBoolean;
                    return this.cashSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlement != value)
                {
                    this.cashSettlement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region OptionsExchangeDividends
        private XsdTypeBoolean optionsExchangeDividends;
        public XsdTypeBoolean OptionsExchangeDividends
        {
            get
            {
                if (this.optionsExchangeDividends != null)
                {
                    return this.optionsExchangeDividends; 
                }
                else if (this.optionsExchangeDividendsIDRef != null)
                {
                    optionsExchangeDividends = IDManager.getID(optionsExchangeDividendsIDRef) as XsdTypeBoolean;
                    return this.optionsExchangeDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionsExchangeDividends != value)
                {
                    this.optionsExchangeDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AdditionalDividends
        private XsdTypeBoolean additionalDividends;
        public XsdTypeBoolean AdditionalDividends
        {
            get
            {
                if (this.additionalDividends != null)
                {
                    return this.additionalDividends; 
                }
                else if (this.additionalDividendsIDRef != null)
                {
                    additionalDividends = IDManager.getID(additionalDividendsIDRef) as XsdTypeBoolean;
                    return this.additionalDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalDividends != value)
                {
                    this.additionalDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AllDividends
        private XsdTypeBoolean allDividends;
        public XsdTypeBoolean AllDividends
        {
            get
            {
                if (this.allDividends != null)
                {
                    return this.allDividends; 
                }
                else if (this.allDividendsIDRef != null)
                {
                    allDividends = IDManager.getID(allDividendsIDRef) as XsdTypeBoolean;
                    return this.allDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allDividends != value)
                {
                    this.allDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

