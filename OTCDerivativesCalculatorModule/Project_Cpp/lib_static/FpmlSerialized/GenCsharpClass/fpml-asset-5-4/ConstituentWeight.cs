using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ConstituentWeight
    {
        public ConstituentWeight(XmlNode xmlNode)
        {
            XmlNodeList openUnitsNodeList = xmlNode.SelectNodes("openUnits");
            if (openUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in openUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        openUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(openUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        openUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        openUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList basketPercentageNodeList = xmlNode.SelectNodes("basketPercentage");
            if (basketPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketPercentageIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(basketPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketPercentage = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList basketAmountNodeList = xmlNode.SelectNodes("basketAmount");
            if (basketAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(basketAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region OpenUnits
        private XsdTypeDecimal openUnits;
        public XsdTypeDecimal OpenUnits
        {
            get
            {
                if (this.openUnits != null)
                {
                    return this.openUnits; 
                }
                else if (this.openUnitsIDRef != null)
                {
                    openUnits = IDManager.getID(openUnitsIDRef) as XsdTypeDecimal;
                    return this.openUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.openUnits != value)
                {
                    this.openUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region BasketPercentage
        private RestrictedPercentage basketPercentage;
        public RestrictedPercentage BasketPercentage
        {
            get
            {
                if (this.basketPercentage != null)
                {
                    return this.basketPercentage; 
                }
                else if (this.basketPercentageIDRef != null)
                {
                    basketPercentage = IDManager.getID(basketPercentageIDRef) as RestrictedPercentage;
                    return this.basketPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketPercentage != value)
                {
                    this.basketPercentage = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region BasketAmount
        private Money basketAmount;
        public Money BasketAmount
        {
            get
            {
                if (this.basketAmount != null)
                {
                    return this.basketAmount; 
                }
                else if (this.basketAmountIDRef != null)
                {
                    basketAmount = IDManager.getID(basketAmountIDRef) as Money;
                    return this.basketAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketAmount != value)
                {
                    this.basketAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

