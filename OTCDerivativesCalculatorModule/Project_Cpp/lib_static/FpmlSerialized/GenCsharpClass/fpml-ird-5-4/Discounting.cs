using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Discounting
    {
        public Discounting(XmlNode xmlNode)
        {
            XmlNodeList discountingTypeNodeList = xmlNode.SelectNodes("discountingType");
            if (discountingTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountingTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountingTypeIDRef = item.Attributes["id"].Name;
                        DiscountingTypeEnum ob = DiscountingTypeEnum();
                        IDManager.SetID(discountingTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountingTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountingType = new DiscountingTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList discountRateNodeList = xmlNode.SelectNodes("discountRate");
            if (discountRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(discountRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList discountRateDayCountFractionNodeList = xmlNode.SelectNodes("discountRateDayCountFraction");
            if (discountRateDayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountRateDayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountRateDayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(discountRateDayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountRateDayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountRateDayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
        }
        
    
        #region DiscountingType
        private DiscountingTypeEnum discountingType;
        public DiscountingTypeEnum DiscountingType
        {
            get
            {
                if (this.discountingType != null)
                {
                    return this.discountingType; 
                }
                else if (this.discountingTypeIDRef != null)
                {
                    discountingType = IDManager.getID(discountingTypeIDRef) as DiscountingTypeEnum;
                    return this.discountingType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountingType != value)
                {
                    this.discountingType = value;
                }
            }
        }
        #endregion
        
        public string DiscountingTypeEnumIDRef { get; set; }
        #region DiscountRate
        private XsdTypeDecimal discountRate;
        public XsdTypeDecimal DiscountRate
        {
            get
            {
                if (this.discountRate != null)
                {
                    return this.discountRate; 
                }
                else if (this.discountRateIDRef != null)
                {
                    discountRate = IDManager.getID(discountRateIDRef) as XsdTypeDecimal;
                    return this.discountRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountRate != value)
                {
                    this.discountRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DiscountRateDayCountFraction
        private DayCountFraction discountRateDayCountFraction;
        public DayCountFraction DiscountRateDayCountFraction
        {
            get
            {
                if (this.discountRateDayCountFraction != null)
                {
                    return this.discountRateDayCountFraction; 
                }
                else if (this.discountRateDayCountFractionIDRef != null)
                {
                    discountRateDayCountFraction = IDManager.getID(discountRateDayCountFractionIDRef) as DayCountFraction;
                    return this.discountRateDayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountRateDayCountFraction != value)
                {
                    this.discountRateDayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        
    
        
    
    }
    
}

