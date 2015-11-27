using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RelativeDates : RelativeDateOffset
    {
        public RelativeDates(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode periodSkipNode = xmlNode.SelectSingleNode("periodSkip");
            
            if (periodSkipNode != null)
            {
                if (periodSkipNode.Attributes["href"] != null || periodSkipNode.Attributes["id"] != null) 
                {
                    if (periodSkipNode.Attributes["id"] != null) 
                    {
                        periodSkipIDRef_ = periodSkipNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(periodSkipNode);
                        IDManager.SetID(periodSkipIDRef_, ob);
                    }
                    else if (periodSkipNode.Attributes["href"] != null)
                    {
                        periodSkipIDRef_ = periodSkipNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodSkip_ = new XsdTypePositiveInteger(periodSkipNode);
                    }
                }
                else
                {
                    periodSkip_ = new XsdTypePositiveInteger(periodSkipNode);
                }
            }
            
        
            XmlNode scheduleBoundsNode = xmlNode.SelectSingleNode("scheduleBounds");
            
            if (scheduleBoundsNode != null)
            {
                if (scheduleBoundsNode.Attributes["href"] != null || scheduleBoundsNode.Attributes["id"] != null) 
                {
                    if (scheduleBoundsNode.Attributes["id"] != null) 
                    {
                        scheduleBoundsIDRef_ = scheduleBoundsNode.Attributes["id"].Value;
                        DateRange ob = new DateRange(scheduleBoundsNode);
                        IDManager.SetID(scheduleBoundsIDRef_, ob);
                    }
                    else if (scheduleBoundsNode.Attributes["href"] != null)
                    {
                        scheduleBoundsIDRef_ = scheduleBoundsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        scheduleBounds_ = new DateRange(scheduleBoundsNode);
                    }
                }
                else
                {
                    scheduleBounds_ = new DateRange(scheduleBoundsNode);
                }
            }
            
        
        }
        
    
        #region PeriodSkip_
        private XsdTypePositiveInteger periodSkip_;
        public XsdTypePositiveInteger PeriodSkip_
        {
            get
            {
                if (this.periodSkip_ != null)
                {
                    return this.periodSkip_; 
                }
                else if (this.periodSkipIDRef_ != null)
                {
                    periodSkip_ = IDManager.getID(periodSkipIDRef_) as XsdTypePositiveInteger;
                    return this.periodSkip_; 
                }
                else
                {
                      return this.periodSkip_; 
                }
            }
            set
            {
                if (this.periodSkip_ != value)
                {
                    this.periodSkip_ = value;
                }
            }
        }
        #endregion
        
        public string periodSkipIDRef_ { get; set; }
        #region ScheduleBounds_
        private DateRange scheduleBounds_;
        public DateRange ScheduleBounds_
        {
            get
            {
                if (this.scheduleBounds_ != null)
                {
                    return this.scheduleBounds_; 
                }
                else if (this.scheduleBoundsIDRef_ != null)
                {
                    scheduleBounds_ = IDManager.getID(scheduleBoundsIDRef_) as DateRange;
                    return this.scheduleBounds_; 
                }
                else
                {
                      return this.scheduleBounds_; 
                }
            }
            set
            {
                if (this.scheduleBounds_ != value)
                {
                    this.scheduleBounds_ = value;
                }
            }
        }
        #endregion
        
        public string scheduleBoundsIDRef_ { get; set; }
        
    
        
    
    }
    
}

