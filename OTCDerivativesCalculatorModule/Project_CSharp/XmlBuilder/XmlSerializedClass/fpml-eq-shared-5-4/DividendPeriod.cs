using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendPeriod : ISerialized
    {
        public DividendPeriod(XmlNode xmlNode)
        {
            XmlNode unadjustedStartDateNode = xmlNode.SelectSingleNode("unadjustedStartDate");
            
            if (unadjustedStartDateNode != null)
            {
                if (unadjustedStartDateNode.Attributes["href"] != null || unadjustedStartDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedStartDateNode.Attributes["id"] != null) 
                    {
                        unadjustedStartDateIDRef_ = unadjustedStartDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(unadjustedStartDateNode);
                        IDManager.SetID(unadjustedStartDateIDRef_, ob);
                    }
                    else if (unadjustedStartDateNode.Attributes["href"] != null)
                    {
                        unadjustedStartDateIDRef_ = unadjustedStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedStartDate_ = new IdentifiedDate(unadjustedStartDateNode);
                    }
                }
                else
                {
                    unadjustedStartDate_ = new IdentifiedDate(unadjustedStartDateNode);
                }
            }
            
        
            XmlNode unadjustedEndDateNode = xmlNode.SelectSingleNode("unadjustedEndDate");
            
            if (unadjustedEndDateNode != null)
            {
                if (unadjustedEndDateNode.Attributes["href"] != null || unadjustedEndDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedEndDateNode.Attributes["id"] != null) 
                    {
                        unadjustedEndDateIDRef_ = unadjustedEndDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(unadjustedEndDateNode);
                        IDManager.SetID(unadjustedEndDateIDRef_, ob);
                    }
                    else if (unadjustedEndDateNode.Attributes["href"] != null)
                    {
                        unadjustedEndDateIDRef_ = unadjustedEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedEndDate_ = new IdentifiedDate(unadjustedEndDateNode);
                    }
                }
                else
                {
                    unadjustedEndDate_ = new IdentifiedDate(unadjustedEndDateNode);
                }
            }
            
        
            XmlNode dateAdjustmentsNode = xmlNode.SelectSingleNode("dateAdjustments");
            
            if (dateAdjustmentsNode != null)
            {
                if (dateAdjustmentsNode.Attributes["href"] != null || dateAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (dateAdjustmentsNode.Attributes["id"] != null) 
                    {
                        dateAdjustmentsIDRef_ = dateAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(dateAdjustmentsNode);
                        IDManager.SetID(dateAdjustmentsIDRef_, ob);
                    }
                    else if (dateAdjustmentsNode.Attributes["href"] != null)
                    {
                        dateAdjustmentsIDRef_ = dateAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateAdjustments_ = new BusinessDayAdjustments(dateAdjustmentsNode);
                    }
                }
                else
                {
                    dateAdjustments_ = new BusinessDayAdjustments(dateAdjustmentsNode);
                }
            }
            
        
            XmlNode underlyerReferenceNode = xmlNode.SelectSingleNode("underlyerReference");
            
            if (underlyerReferenceNode != null)
            {
                if (underlyerReferenceNode.Attributes["href"] != null || underlyerReferenceNode.Attributes["id"] != null) 
                {
                    if (underlyerReferenceNode.Attributes["id"] != null) 
                    {
                        underlyerReferenceIDRef_ = underlyerReferenceNode.Attributes["id"].Value;
                        AssetReference ob = new AssetReference(underlyerReferenceNode);
                        IDManager.SetID(underlyerReferenceIDRef_, ob);
                    }
                    else if (underlyerReferenceNode.Attributes["href"] != null)
                    {
                        underlyerReferenceIDRef_ = underlyerReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyerReference_ = new AssetReference(underlyerReferenceNode);
                    }
                }
                else
                {
                    underlyerReference_ = new AssetReference(underlyerReferenceNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedStartDate_
        private IdentifiedDate unadjustedStartDate_;
        public IdentifiedDate UnadjustedStartDate_
        {
            get
            {
                if (this.unadjustedStartDate_ != null)
                {
                    return this.unadjustedStartDate_; 
                }
                else if (this.unadjustedStartDateIDRef_ != null)
                {
                    unadjustedStartDate_ = IDManager.getID(unadjustedStartDateIDRef_) as IdentifiedDate;
                    return this.unadjustedStartDate_; 
                }
                else
                {
                      return this.unadjustedStartDate_; 
                }
            }
            set
            {
                if (this.unadjustedStartDate_ != value)
                {
                    this.unadjustedStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedStartDateIDRef_ { get; set; }
        #region UnadjustedEndDate_
        private IdentifiedDate unadjustedEndDate_;
        public IdentifiedDate UnadjustedEndDate_
        {
            get
            {
                if (this.unadjustedEndDate_ != null)
                {
                    return this.unadjustedEndDate_; 
                }
                else if (this.unadjustedEndDateIDRef_ != null)
                {
                    unadjustedEndDate_ = IDManager.getID(unadjustedEndDateIDRef_) as IdentifiedDate;
                    return this.unadjustedEndDate_; 
                }
                else
                {
                      return this.unadjustedEndDate_; 
                }
            }
            set
            {
                if (this.unadjustedEndDate_ != value)
                {
                    this.unadjustedEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedEndDateIDRef_ { get; set; }
        #region DateAdjustments_
        private BusinessDayAdjustments dateAdjustments_;
        public BusinessDayAdjustments DateAdjustments_
        {
            get
            {
                if (this.dateAdjustments_ != null)
                {
                    return this.dateAdjustments_; 
                }
                else if (this.dateAdjustmentsIDRef_ != null)
                {
                    dateAdjustments_ = IDManager.getID(dateAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.dateAdjustments_; 
                }
                else
                {
                      return this.dateAdjustments_; 
                }
            }
            set
            {
                if (this.dateAdjustments_ != value)
                {
                    this.dateAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string dateAdjustmentsIDRef_ { get; set; }
        #region UnderlyerReference_
        private AssetReference underlyerReference_;
        public AssetReference UnderlyerReference_
        {
            get
            {
                if (this.underlyerReference_ != null)
                {
                    return this.underlyerReference_; 
                }
                else if (this.underlyerReferenceIDRef_ != null)
                {
                    underlyerReference_ = IDManager.getID(underlyerReferenceIDRef_) as AssetReference;
                    return this.underlyerReference_; 
                }
                else
                {
                      return this.underlyerReference_; 
                }
            }
            set
            {
                if (this.underlyerReference_ != value)
                {
                    this.underlyerReference_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

