using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalEuropeanExercise : Exercise
    {
        public CommodityPhysicalEuropeanExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode expirationDateNode = xmlNode.SelectSingleNode("expirationDate");
            
            if (expirationDateNode != null)
            {
                if (expirationDateNode.Attributes["href"] != null || expirationDateNode.Attributes["id"] != null) 
                {
                    if (expirationDateNode.Attributes["id"] != null) 
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(expirationDateNode);
                        IDManager.SetID(expirationDateIDRef_, ob);
                    }
                    else if (expirationDateNode.Attributes["href"] != null)
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                    }
                }
                else
                {
                    expirationDate_ = new AdjustableOrRelativeDate(expirationDateNode);
                }
            }
            
        
            XmlNode expirationDatesNode = xmlNode.SelectSingleNode("expirationDates");
            
            if (expirationDatesNode != null)
            {
                if (expirationDatesNode.Attributes["href"] != null || expirationDatesNode.Attributes["id"] != null) 
                {
                    if (expirationDatesNode.Attributes["id"] != null) 
                    {
                        expirationDatesIDRef_ = expirationDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates2 ob = new AdjustableRelativeOrPeriodicDates2(expirationDatesNode);
                        IDManager.SetID(expirationDatesIDRef_, ob);
                    }
                    else if (expirationDatesNode.Attributes["href"] != null)
                    {
                        expirationDatesIDRef_ = expirationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDates_ = new AdjustableRelativeOrPeriodicDates2(expirationDatesNode);
                    }
                }
                else
                {
                    expirationDates_ = new AdjustableRelativeOrPeriodicDates2(expirationDatesNode);
                }
            }
            
        
            XmlNode relativeExpirationDatesNode = xmlNode.SelectSingleNode("relativeExpirationDates");
            
            if (relativeExpirationDatesNode != null)
            {
                if (relativeExpirationDatesNode.Attributes["href"] != null || relativeExpirationDatesNode.Attributes["id"] != null) 
                {
                    if (relativeExpirationDatesNode.Attributes["id"] != null) 
                    {
                        relativeExpirationDatesIDRef_ = relativeExpirationDatesNode.Attributes["id"].Value;
                        CommodityRelativeExpirationDates ob = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
                        IDManager.SetID(relativeExpirationDatesIDRef_, ob);
                    }
                    else if (relativeExpirationDatesNode.Attributes["href"] != null)
                    {
                        relativeExpirationDatesIDRef_ = relativeExpirationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeExpirationDates_ = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
                    }
                }
                else
                {
                    relativeExpirationDates_ = new CommodityRelativeExpirationDates(relativeExpirationDatesNode);
                }
            }
            
        
            XmlNode expirationTimeNode = xmlNode.SelectSingleNode("expirationTime");
            
            if (expirationTimeNode != null)
            {
                if (expirationTimeNode.Attributes["href"] != null || expirationTimeNode.Attributes["id"] != null) 
                {
                    if (expirationTimeNode.Attributes["id"] != null) 
                    {
                        expirationTimeIDRef_ = expirationTimeNode.Attributes["id"].Value;
                        PrevailingTime ob = new PrevailingTime(expirationTimeNode);
                        IDManager.SetID(expirationTimeIDRef_, ob);
                    }
                    else if (expirationTimeNode.Attributes["href"] != null)
                    {
                        expirationTimeIDRef_ = expirationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationTime_ = new PrevailingTime(expirationTimeNode);
                    }
                }
                else
                {
                    expirationTime_ = new PrevailingTime(expirationTimeNode);
                }
            }
            
        
        }
        
    
        #region ExpirationDate_
        private AdjustableOrRelativeDate expirationDate_;
        public AdjustableOrRelativeDate ExpirationDate_
        {
            get
            {
                if (this.expirationDate_ != null)
                {
                    return this.expirationDate_; 
                }
                else if (this.expirationDateIDRef_ != null)
                {
                    expirationDate_ = IDManager.getID(expirationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.expirationDate_; 
                }
                else
                {
                      return this.expirationDate_; 
                }
            }
            set
            {
                if (this.expirationDate_ != value)
                {
                    this.expirationDate_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateIDRef_ { get; set; }
        #region ExpirationDates_
        private AdjustableRelativeOrPeriodicDates2 expirationDates_;
        public AdjustableRelativeOrPeriodicDates2 ExpirationDates_
        {
            get
            {
                if (this.expirationDates_ != null)
                {
                    return this.expirationDates_; 
                }
                else if (this.expirationDatesIDRef_ != null)
                {
                    expirationDates_ = IDManager.getID(expirationDatesIDRef_) as AdjustableRelativeOrPeriodicDates2;
                    return this.expirationDates_; 
                }
                else
                {
                      return this.expirationDates_; 
                }
            }
            set
            {
                if (this.expirationDates_ != value)
                {
                    this.expirationDates_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDatesIDRef_ { get; set; }
        #region RelativeExpirationDates_
        private CommodityRelativeExpirationDates relativeExpirationDates_;
        public CommodityRelativeExpirationDates RelativeExpirationDates_
        {
            get
            {
                if (this.relativeExpirationDates_ != null)
                {
                    return this.relativeExpirationDates_; 
                }
                else if (this.relativeExpirationDatesIDRef_ != null)
                {
                    relativeExpirationDates_ = IDManager.getID(relativeExpirationDatesIDRef_) as CommodityRelativeExpirationDates;
                    return this.relativeExpirationDates_; 
                }
                else
                {
                      return this.relativeExpirationDates_; 
                }
            }
            set
            {
                if (this.relativeExpirationDates_ != value)
                {
                    this.relativeExpirationDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativeExpirationDatesIDRef_ { get; set; }
        #region ExpirationTime_
        private PrevailingTime expirationTime_;
        public PrevailingTime ExpirationTime_
        {
            get
            {
                if (this.expirationTime_ != null)
                {
                    return this.expirationTime_; 
                }
                else if (this.expirationTimeIDRef_ != null)
                {
                    expirationTime_ = IDManager.getID(expirationTimeIDRef_) as PrevailingTime;
                    return this.expirationTime_; 
                }
                else
                {
                      return this.expirationTime_; 
                }
            }
            set
            {
                if (this.expirationTime_ != value)
                {
                    this.expirationTime_ = value;
                }
            }
        }
        #endregion
        
        public string expirationTimeIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

