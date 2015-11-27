using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableDate2 : ISerialized
    {
        public AdjustableDate2(XmlNode xmlNode)
        {
            XmlNode unadjustedDateNode = xmlNode.SelectSingleNode("unadjustedDate");
            
            if (unadjustedDateNode != null)
            {
                if (unadjustedDateNode.Attributes["href"] != null || unadjustedDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedDateNode.Attributes["id"] != null) 
                    {
                        unadjustedDateIDRef_ = unadjustedDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(unadjustedDateNode);
                        IDManager.SetID(unadjustedDateIDRef_, ob);
                    }
                    else if (unadjustedDateNode.Attributes["href"] != null)
                    {
                        unadjustedDateIDRef_ = unadjustedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedDate_ = new IdentifiedDate(unadjustedDateNode);
                    }
                }
                else
                {
                    unadjustedDate_ = new IdentifiedDate(unadjustedDateNode);
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
            
        
            XmlNode dateAdjustmentsReferenceNode = xmlNode.SelectSingleNode("dateAdjustmentsReference");
            
            if (dateAdjustmentsReferenceNode != null)
            {
                if (dateAdjustmentsReferenceNode.Attributes["href"] != null || dateAdjustmentsReferenceNode.Attributes["id"] != null) 
                {
                    if (dateAdjustmentsReferenceNode.Attributes["id"] != null) 
                    {
                        dateAdjustmentsReferenceIDRef_ = dateAdjustmentsReferenceNode.Attributes["id"].Value;
                        BusinessDayAdjustmentsReference ob = new BusinessDayAdjustmentsReference(dateAdjustmentsReferenceNode);
                        IDManager.SetID(dateAdjustmentsReferenceIDRef_, ob);
                    }
                    else if (dateAdjustmentsReferenceNode.Attributes["href"] != null)
                    {
                        dateAdjustmentsReferenceIDRef_ = dateAdjustmentsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateAdjustmentsReference_ = new BusinessDayAdjustmentsReference(dateAdjustmentsReferenceNode);
                    }
                }
                else
                {
                    dateAdjustmentsReference_ = new BusinessDayAdjustmentsReference(dateAdjustmentsReferenceNode);
                }
            }
            
        
            XmlNode adjustedDateNode = xmlNode.SelectSingleNode("adjustedDate");
            
            if (adjustedDateNode != null)
            {
                if (adjustedDateNode.Attributes["href"] != null || adjustedDateNode.Attributes["id"] != null) 
                {
                    if (adjustedDateNode.Attributes["id"] != null) 
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(adjustedDateNode);
                        IDManager.SetID(adjustedDateIDRef_, ob);
                    }
                    else if (adjustedDateNode.Attributes["href"] != null)
                    {
                        adjustedDateIDRef_ = adjustedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedDate_ = new IdentifiedDate(adjustedDateNode);
                    }
                }
                else
                {
                    adjustedDate_ = new IdentifiedDate(adjustedDateNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedDate_
        private IdentifiedDate unadjustedDate_;
        public IdentifiedDate UnadjustedDate_
        {
            get
            {
                if (this.unadjustedDate_ != null)
                {
                    return this.unadjustedDate_; 
                }
                else if (this.unadjustedDateIDRef_ != null)
                {
                    unadjustedDate_ = IDManager.getID(unadjustedDateIDRef_) as IdentifiedDate;
                    return this.unadjustedDate_; 
                }
                else
                {
                      return this.unadjustedDate_; 
                }
            }
            set
            {
                if (this.unadjustedDate_ != value)
                {
                    this.unadjustedDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedDateIDRef_ { get; set; }
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
        #region DateAdjustmentsReference_
        private BusinessDayAdjustmentsReference dateAdjustmentsReference_;
        public BusinessDayAdjustmentsReference DateAdjustmentsReference_
        {
            get
            {
                if (this.dateAdjustmentsReference_ != null)
                {
                    return this.dateAdjustmentsReference_; 
                }
                else if (this.dateAdjustmentsReferenceIDRef_ != null)
                {
                    dateAdjustmentsReference_ = IDManager.getID(dateAdjustmentsReferenceIDRef_) as BusinessDayAdjustmentsReference;
                    return this.dateAdjustmentsReference_; 
                }
                else
                {
                      return this.dateAdjustmentsReference_; 
                }
            }
            set
            {
                if (this.dateAdjustmentsReference_ != value)
                {
                    this.dateAdjustmentsReference_ = value;
                }
            }
        }
        #endregion
        
        public string dateAdjustmentsReferenceIDRef_ { get; set; }
        #region AdjustedDate_
        private IdentifiedDate adjustedDate_;
        public IdentifiedDate AdjustedDate_
        {
            get
            {
                if (this.adjustedDate_ != null)
                {
                    return this.adjustedDate_; 
                }
                else if (this.adjustedDateIDRef_ != null)
                {
                    adjustedDate_ = IDManager.getID(adjustedDateIDRef_) as IdentifiedDate;
                    return this.adjustedDate_; 
                }
                else
                {
                      return this.adjustedDate_; 
                }
            }
            set
            {
                if (this.adjustedDate_ != value)
                {
                    this.adjustedDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

