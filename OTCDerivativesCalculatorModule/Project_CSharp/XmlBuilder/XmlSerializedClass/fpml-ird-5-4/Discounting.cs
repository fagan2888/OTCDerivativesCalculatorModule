using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Discounting : ISerialized
    {
        public Discounting(XmlNode xmlNode)
        {
            XmlNode discountingTypeNode = xmlNode.SelectSingleNode("discountingType");
            
            if (discountingTypeNode != null)
            {
                if (discountingTypeNode.Attributes["href"] != null || discountingTypeNode.Attributes["id"] != null) 
                {
                    if (discountingTypeNode.Attributes["id"] != null) 
                    {
                        discountingTypeIDRef_ = discountingTypeNode.Attributes["id"].Value;
                        DiscountingTypeEnum ob = new DiscountingTypeEnum(discountingTypeNode);
                        IDManager.SetID(discountingTypeIDRef_, ob);
                    }
                    else if (discountingTypeNode.Attributes["href"] != null)
                    {
                        discountingTypeIDRef_ = discountingTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountingType_ = new DiscountingTypeEnum(discountingTypeNode);
                    }
                }
                else
                {
                    discountingType_ = new DiscountingTypeEnum(discountingTypeNode);
                }
            }
            
        
            XmlNode discountRateNode = xmlNode.SelectSingleNode("discountRate");
            
            if (discountRateNode != null)
            {
                if (discountRateNode.Attributes["href"] != null || discountRateNode.Attributes["id"] != null) 
                {
                    if (discountRateNode.Attributes["id"] != null) 
                    {
                        discountRateIDRef_ = discountRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(discountRateNode);
                        IDManager.SetID(discountRateIDRef_, ob);
                    }
                    else if (discountRateNode.Attributes["href"] != null)
                    {
                        discountRateIDRef_ = discountRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountRate_ = new XsdTypeDecimal(discountRateNode);
                    }
                }
                else
                {
                    discountRate_ = new XsdTypeDecimal(discountRateNode);
                }
            }
            
        
            XmlNode discountRateDayCountFractionNode = xmlNode.SelectSingleNode("discountRateDayCountFraction");
            
            if (discountRateDayCountFractionNode != null)
            {
                if (discountRateDayCountFractionNode.Attributes["href"] != null || discountRateDayCountFractionNode.Attributes["id"] != null) 
                {
                    if (discountRateDayCountFractionNode.Attributes["id"] != null) 
                    {
                        discountRateDayCountFractionIDRef_ = discountRateDayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(discountRateDayCountFractionNode);
                        IDManager.SetID(discountRateDayCountFractionIDRef_, ob);
                    }
                    else if (discountRateDayCountFractionNode.Attributes["href"] != null)
                    {
                        discountRateDayCountFractionIDRef_ = discountRateDayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountRateDayCountFraction_ = new DayCountFraction(discountRateDayCountFractionNode);
                    }
                }
                else
                {
                    discountRateDayCountFraction_ = new DayCountFraction(discountRateDayCountFractionNode);
                }
            }
            
        
        }
        
    
        #region DiscountingType_
        private DiscountingTypeEnum discountingType_;
        public DiscountingTypeEnum DiscountingType_
        {
            get
            {
                if (this.discountingType_ != null)
                {
                    return this.discountingType_; 
                }
                else if (this.discountingTypeIDRef_ != null)
                {
                    discountingType_ = IDManager.getID(discountingTypeIDRef_) as DiscountingTypeEnum;
                    return this.discountingType_; 
                }
                else
                {
                      return this.discountingType_; 
                }
            }
            set
            {
                if (this.discountingType_ != value)
                {
                    this.discountingType_ = value;
                }
            }
        }
        #endregion
        
        public string discountingTypeIDRef_ { get; set; }
        #region DiscountRate_
        private XsdTypeDecimal discountRate_;
        public XsdTypeDecimal DiscountRate_
        {
            get
            {
                if (this.discountRate_ != null)
                {
                    return this.discountRate_; 
                }
                else if (this.discountRateIDRef_ != null)
                {
                    discountRate_ = IDManager.getID(discountRateIDRef_) as XsdTypeDecimal;
                    return this.discountRate_; 
                }
                else
                {
                      return this.discountRate_; 
                }
            }
            set
            {
                if (this.discountRate_ != value)
                {
                    this.discountRate_ = value;
                }
            }
        }
        #endregion
        
        public string discountRateIDRef_ { get; set; }
        #region DiscountRateDayCountFraction_
        private DayCountFraction discountRateDayCountFraction_;
        public DayCountFraction DiscountRateDayCountFraction_
        {
            get
            {
                if (this.discountRateDayCountFraction_ != null)
                {
                    return this.discountRateDayCountFraction_; 
                }
                else if (this.discountRateDayCountFractionIDRef_ != null)
                {
                    discountRateDayCountFraction_ = IDManager.getID(discountRateDayCountFractionIDRef_) as DayCountFraction;
                    return this.discountRateDayCountFraction_; 
                }
                else
                {
                      return this.discountRateDayCountFraction_; 
                }
            }
            set
            {
                if (this.discountRateDayCountFraction_ != value)
                {
                    this.discountRateDayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string discountRateDayCountFractionIDRef_ { get; set; }
        
    
        
    
    }
    
}

