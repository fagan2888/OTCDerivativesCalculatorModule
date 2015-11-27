using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendPayout
    {
        public DividendPayout(XmlNode xmlNode)
        {
            XmlNodeList dividendPayoutRatioNodeList = xmlNode.SelectNodes("dividendPayoutRatio");
            if (dividendPayoutRatioNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPayoutRatioNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPayoutRatioIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(dividendPayoutRatioIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPayoutRatioIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPayoutRatio = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPayoutConditionsNodeList = xmlNode.SelectNodes("dividendPayoutConditions");
            if (dividendPayoutConditionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPayoutConditionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPayoutConditionsIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(dividendPayoutConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPayoutConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPayoutConditions = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPaymentNodeList = xmlNode.SelectNodes("dividendPayment");
            
            foreach (XmlNode item in dividendPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPaymentIDRef = item.Attributes["id"].Name;
                        List<PendingPayment> ob = new List<PendingPayment>();
                        ob.Add(new PendingPayment(item));
                        IDManager.SetID(dividendPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dividendPayment.Add(new PendingPayment(item));
                    }
                }
            }
            
        
        }
        
    
        #region DividendPayoutRatio
        private XsdTypeDecimal dividendPayoutRatio;
        public XsdTypeDecimal DividendPayoutRatio
        {
            get
            {
                if (this.dividendPayoutRatio != null)
                {
                    return this.dividendPayoutRatio; 
                }
                else if (this.dividendPayoutRatioIDRef != null)
                {
                    dividendPayoutRatio = IDManager.getID(dividendPayoutRatioIDRef) as XsdTypeDecimal;
                    return this.dividendPayoutRatio; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPayoutRatio != value)
                {
                    this.dividendPayoutRatio = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DividendPayoutConditions
        private XsdTypeString dividendPayoutConditions;
        public XsdTypeString DividendPayoutConditions
        {
            get
            {
                if (this.dividendPayoutConditions != null)
                {
                    return this.dividendPayoutConditions; 
                }
                else if (this.dividendPayoutConditionsIDRef != null)
                {
                    dividendPayoutConditions = IDManager.getID(dividendPayoutConditionsIDRef) as XsdTypeString;
                    return this.dividendPayoutConditions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPayoutConditions != value)
                {
                    this.dividendPayoutConditions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region DividendPayment
        private List<PendingPayment> dividendPayment;
        public List<PendingPayment> DividendPayment
        {
            get
            {
                if (this.dividendPayment != null)
                {
                    return this.dividendPayment; 
                }
                else if (this.dividendPaymentIDRef != null)
                {
                    dividendPayment = IDManager.getID(dividendPaymentIDRef) as List<PendingPayment>;
                    return this.dividendPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPayment != value)
                {
                    this.dividendPayment = value;
                }
            }
        }
        #endregion
        
        public string PendingPaymentIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

