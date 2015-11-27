using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableDates : ISerialized
    {
        public AdjustableDates(XmlNode xmlNode)
        {
            XmlNodeList unadjustedDateNodeList = xmlNode.SelectNodes("unadjustedDate");
            
            if (unadjustedDateNodeList != null)
            {
                this.unadjustedDate_ = new List<IdentifiedDate>();
                foreach (XmlNode item in unadjustedDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            unadjustedDateIDRef_ = item.Attributes["id"].Value;
                            unadjustedDate_.Add(new IdentifiedDate(item));
                            IDManager.SetID(unadjustedDateIDRef_, unadjustedDate_[unadjustedDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            unadjustedDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        unadjustedDate_.Add(new IdentifiedDate(item));
                        }
                    }
                    else
                    {
                        unadjustedDate_.Add(new IdentifiedDate(item));
                    }
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
            
        
            XmlNodeList adjustedDateNodeList = xmlNode.SelectNodes("adjustedDate");
            
            if (adjustedDateNodeList != null)
            {
                this.adjustedDate_ = new List<IdentifiedDate>();
                foreach (XmlNode item in adjustedDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            adjustedDateIDRef_ = item.Attributes["id"].Value;
                            adjustedDate_.Add(new IdentifiedDate(item));
                            IDManager.SetID(adjustedDateIDRef_, adjustedDate_[adjustedDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            adjustedDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        adjustedDate_.Add(new IdentifiedDate(item));
                        }
                    }
                    else
                    {
                        adjustedDate_.Add(new IdentifiedDate(item));
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedDate_
        private List<IdentifiedDate> unadjustedDate_;
        public List<IdentifiedDate> UnadjustedDate_
        {
            get
            {
                if (this.unadjustedDate_ != null)
                {
                    return this.unadjustedDate_; 
                }
                else if (this.unadjustedDateIDRef_ != null)
                {
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
        #region AdjustedDate_
        private List<IdentifiedDate> adjustedDate_;
        public List<IdentifiedDate> AdjustedDate_
        {
            get
            {
                if (this.adjustedDate_ != null)
                {
                    return this.adjustedDate_; 
                }
                else if (this.adjustedDateIDRef_ != null)
                {
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
        
    
        
    
    }
    
}

