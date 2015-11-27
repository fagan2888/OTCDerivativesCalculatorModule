using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Compounding : ISerialized
    {
        public Compounding(XmlNode xmlNode)
        {
            XmlNode compoundingMethodNode = xmlNode.SelectSingleNode("compoundingMethod");
            
            if (compoundingMethodNode != null)
            {
                if (compoundingMethodNode.Attributes["href"] != null || compoundingMethodNode.Attributes["id"] != null) 
                {
                    if (compoundingMethodNode.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["id"].Value;
                        CompoundingMethodEnum ob = new CompoundingMethodEnum(compoundingMethodNode);
                        IDManager.SetID(compoundingMethodIDRef_, ob);
                    }
                    else if (compoundingMethodNode.Attributes["href"] != null)
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                    }
                }
                else
                {
                    compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                }
            }
            
        
            XmlNode compoundingRateNode = xmlNode.SelectSingleNode("compoundingRate");
            
            if (compoundingRateNode != null)
            {
                if (compoundingRateNode.Attributes["href"] != null || compoundingRateNode.Attributes["id"] != null) 
                {
                    if (compoundingRateNode.Attributes["id"] != null) 
                    {
                        compoundingRateIDRef_ = compoundingRateNode.Attributes["id"].Value;
                        CompoundingRate ob = new CompoundingRate(compoundingRateNode);
                        IDManager.SetID(compoundingRateIDRef_, ob);
                    }
                    else if (compoundingRateNode.Attributes["href"] != null)
                    {
                        compoundingRateIDRef_ = compoundingRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingRate_ = new CompoundingRate(compoundingRateNode);
                    }
                }
                else
                {
                    compoundingRate_ = new CompoundingRate(compoundingRateNode);
                }
            }
            
        
            XmlNode compoundingSpreadNode = xmlNode.SelectSingleNode("compoundingSpread");
            
            if (compoundingSpreadNode != null)
            {
                if (compoundingSpreadNode.Attributes["href"] != null || compoundingSpreadNode.Attributes["id"] != null) 
                {
                    if (compoundingSpreadNode.Attributes["id"] != null) 
                    {
                        compoundingSpreadIDRef_ = compoundingSpreadNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(compoundingSpreadNode);
                        IDManager.SetID(compoundingSpreadIDRef_, ob);
                    }
                    else if (compoundingSpreadNode.Attributes["href"] != null)
                    {
                        compoundingSpreadIDRef_ = compoundingSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingSpread_ = new XsdTypeDecimal(compoundingSpreadNode);
                    }
                }
                else
                {
                    compoundingSpread_ = new XsdTypeDecimal(compoundingSpreadNode);
                }
            }
            
        
            XmlNode compoundingDatesNode = xmlNode.SelectSingleNode("compoundingDates");
            
            if (compoundingDatesNode != null)
            {
                if (compoundingDatesNode.Attributes["href"] != null || compoundingDatesNode.Attributes["id"] != null) 
                {
                    if (compoundingDatesNode.Attributes["id"] != null) 
                    {
                        compoundingDatesIDRef_ = compoundingDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates2 ob = new AdjustableRelativeOrPeriodicDates2(compoundingDatesNode);
                        IDManager.SetID(compoundingDatesIDRef_, ob);
                    }
                    else if (compoundingDatesNode.Attributes["href"] != null)
                    {
                        compoundingDatesIDRef_ = compoundingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingDates_ = new AdjustableRelativeOrPeriodicDates2(compoundingDatesNode);
                    }
                }
                else
                {
                    compoundingDates_ = new AdjustableRelativeOrPeriodicDates2(compoundingDatesNode);
                }
            }
            
        
        }
        
    
        #region CompoundingMethod_
        private CompoundingMethodEnum compoundingMethod_;
        public CompoundingMethodEnum CompoundingMethod_
        {
            get
            {
                if (this.compoundingMethod_ != null)
                {
                    return this.compoundingMethod_; 
                }
                else if (this.compoundingMethodIDRef_ != null)
                {
                    compoundingMethod_ = IDManager.getID(compoundingMethodIDRef_) as CompoundingMethodEnum;
                    return this.compoundingMethod_; 
                }
                else
                {
                      return this.compoundingMethod_; 
                }
            }
            set
            {
                if (this.compoundingMethod_ != value)
                {
                    this.compoundingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingMethodIDRef_ { get; set; }
        #region CompoundingRate_
        private CompoundingRate compoundingRate_;
        public CompoundingRate CompoundingRate_
        {
            get
            {
                if (this.compoundingRate_ != null)
                {
                    return this.compoundingRate_; 
                }
                else if (this.compoundingRateIDRef_ != null)
                {
                    compoundingRate_ = IDManager.getID(compoundingRateIDRef_) as CompoundingRate;
                    return this.compoundingRate_; 
                }
                else
                {
                      return this.compoundingRate_; 
                }
            }
            set
            {
                if (this.compoundingRate_ != value)
                {
                    this.compoundingRate_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingRateIDRef_ { get; set; }
        #region CompoundingSpread_
        private XsdTypeDecimal compoundingSpread_;
        public XsdTypeDecimal CompoundingSpread_
        {
            get
            {
                if (this.compoundingSpread_ != null)
                {
                    return this.compoundingSpread_; 
                }
                else if (this.compoundingSpreadIDRef_ != null)
                {
                    compoundingSpread_ = IDManager.getID(compoundingSpreadIDRef_) as XsdTypeDecimal;
                    return this.compoundingSpread_; 
                }
                else
                {
                      return this.compoundingSpread_; 
                }
            }
            set
            {
                if (this.compoundingSpread_ != value)
                {
                    this.compoundingSpread_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingSpreadIDRef_ { get; set; }
        #region CompoundingDates_
        private AdjustableRelativeOrPeriodicDates2 compoundingDates_;
        public AdjustableRelativeOrPeriodicDates2 CompoundingDates_
        {
            get
            {
                if (this.compoundingDates_ != null)
                {
                    return this.compoundingDates_; 
                }
                else if (this.compoundingDatesIDRef_ != null)
                {
                    compoundingDates_ = IDManager.getID(compoundingDatesIDRef_) as AdjustableRelativeOrPeriodicDates2;
                    return this.compoundingDates_; 
                }
                else
                {
                      return this.compoundingDates_; 
                }
            }
            set
            {
                if (this.compoundingDates_ != value)
                {
                    this.compoundingDates_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

