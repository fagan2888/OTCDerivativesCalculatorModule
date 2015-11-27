using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Premium
    {
        public Premium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList premiumTypeNodeList = xmlNode.SelectNodes("premiumType");
            if (premiumTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumTypeIDRef = item.Attributes["id"].Name;
                        PremiumTypeEnum ob = PremiumTypeEnum();
                        IDManager.SetID(premiumTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premiumType = new PremiumTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList pricePerOptionNodeList = xmlNode.SelectNodes("pricePerOption");
            if (pricePerOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricePerOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricePerOptionIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(pricePerOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricePerOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricePerOption = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList percentageOfNotionalNodeList = xmlNode.SelectNodes("percentageOfNotional");
            if (percentageOfNotionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in percentageOfNotionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        percentageOfNotionalIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(percentageOfNotionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        percentageOfNotionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        percentageOfNotional = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList discountFactorNodeList = xmlNode.SelectNodes("discountFactor");
            if (discountFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(discountFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList presentValueAmountNodeList = xmlNode.SelectNodes("presentValueAmount");
            if (presentValueAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in presentValueAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(presentValueAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        presentValueAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        presentValueAmount = new Money(item);
                    }
                }
            }
            
        
        }
        
    
        #region PremiumType
        private PremiumTypeEnum premiumType;
        public PremiumTypeEnum PremiumType
        {
            get
            {
                if (this.premiumType != null)
                {
                    return this.premiumType; 
                }
                else if (this.premiumTypeIDRef != null)
                {
                    premiumType = IDManager.getID(premiumTypeIDRef) as PremiumTypeEnum;
                    return this.premiumType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premiumType != value)
                {
                    this.premiumType = value;
                }
            }
        }
        #endregion
        
        public string PremiumTypeEnumIDRef { get; set; }
        #region PricePerOption
        private Money pricePerOption;
        public Money PricePerOption
        {
            get
            {
                if (this.pricePerOption != null)
                {
                    return this.pricePerOption; 
                }
                else if (this.pricePerOptionIDRef != null)
                {
                    pricePerOption = IDManager.getID(pricePerOptionIDRef) as Money;
                    return this.pricePerOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricePerOption != value)
                {
                    this.pricePerOption = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region PercentageOfNotional
        private XsdTypeDecimal percentageOfNotional;
        public XsdTypeDecimal PercentageOfNotional
        {
            get
            {
                if (this.percentageOfNotional != null)
                {
                    return this.percentageOfNotional; 
                }
                else if (this.percentageOfNotionalIDRef != null)
                {
                    percentageOfNotional = IDManager.getID(percentageOfNotionalIDRef) as XsdTypeDecimal;
                    return this.percentageOfNotional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.percentageOfNotional != value)
                {
                    this.percentageOfNotional = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DiscountFactor
        private XsdTypeDecimal discountFactor;
        public XsdTypeDecimal DiscountFactor
        {
            get
            {
                if (this.discountFactor != null)
                {
                    return this.discountFactor; 
                }
                else if (this.discountFactorIDRef != null)
                {
                    discountFactor = IDManager.getID(discountFactorIDRef) as XsdTypeDecimal;
                    return this.discountFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountFactor != value)
                {
                    this.discountFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PresentValueAmount
        private Money presentValueAmount;
        public Money PresentValueAmount
        {
            get
            {
                if (this.presentValueAmount != null)
                {
                    return this.presentValueAmount; 
                }
                else if (this.presentValueAmountIDRef != null)
                {
                    presentValueAmount = IDManager.getID(presentValueAmountIDRef) as Money;
                    return this.presentValueAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.presentValueAmount != value)
                {
                    this.presentValueAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

