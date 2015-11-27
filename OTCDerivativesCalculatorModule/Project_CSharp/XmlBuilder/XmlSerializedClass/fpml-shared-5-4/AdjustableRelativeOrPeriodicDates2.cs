using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableRelativeOrPeriodicDates2 : ISerialized
    {
        public AdjustableRelativeOrPeriodicDates2(XmlNode xmlNode)
        {
            XmlNode adjustableDatesNode = xmlNode.SelectSingleNode("adjustableDates");
            
            if (adjustableDatesNode != null)
            {
                if (adjustableDatesNode.Attributes["href"] != null || adjustableDatesNode.Attributes["id"] != null) 
                {
                    if (adjustableDatesNode.Attributes["id"] != null) 
                    {
                        adjustableDatesIDRef_ = adjustableDatesNode.Attributes["id"].Value;
                        AdjustableDates ob = new AdjustableDates(adjustableDatesNode);
                        IDManager.SetID(adjustableDatesIDRef_, ob);
                    }
                    else if (adjustableDatesNode.Attributes["href"] != null)
                    {
                        adjustableDatesIDRef_ = adjustableDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustableDates_ = new AdjustableDates(adjustableDatesNode);
                    }
                }
                else
                {
                    adjustableDates_ = new AdjustableDates(adjustableDatesNode);
                }
            }
            
        
            XmlNode relativeDatesNode = xmlNode.SelectSingleNode("relativeDates");
            
            if (relativeDatesNode != null)
            {
                if (relativeDatesNode.Attributes["href"] != null || relativeDatesNode.Attributes["id"] != null) 
                {
                    if (relativeDatesNode.Attributes["id"] != null) 
                    {
                        relativeDatesIDRef_ = relativeDatesNode.Attributes["id"].Value;
                        RelativeDates ob = new RelativeDates(relativeDatesNode);
                        IDManager.SetID(relativeDatesIDRef_, ob);
                    }
                    else if (relativeDatesNode.Attributes["href"] != null)
                    {
                        relativeDatesIDRef_ = relativeDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDates_ = new RelativeDates(relativeDatesNode);
                    }
                }
                else
                {
                    relativeDates_ = new RelativeDates(relativeDatesNode);
                }
            }
            
        
            XmlNode periodicDatesNode = xmlNode.SelectSingleNode("periodicDates");
            
            if (periodicDatesNode != null)
            {
                if (periodicDatesNode.Attributes["href"] != null || periodicDatesNode.Attributes["id"] != null) 
                {
                    if (periodicDatesNode.Attributes["id"] != null) 
                    {
                        periodicDatesIDRef_ = periodicDatesNode.Attributes["id"].Value;
                        PeriodicDates ob = new PeriodicDates(periodicDatesNode);
                        IDManager.SetID(periodicDatesIDRef_, ob);
                    }
                    else if (periodicDatesNode.Attributes["href"] != null)
                    {
                        periodicDatesIDRef_ = periodicDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodicDates_ = new PeriodicDates(periodicDatesNode);
                    }
                }
                else
                {
                    periodicDates_ = new PeriodicDates(periodicDatesNode);
                }
            }
            
        
        }
        
    
        #region AdjustableDates_
        private AdjustableDates adjustableDates_;
        public AdjustableDates AdjustableDates_
        {
            get
            {
                if (this.adjustableDates_ != null)
                {
                    return this.adjustableDates_; 
                }
                else if (this.adjustableDatesIDRef_ != null)
                {
                    adjustableDates_ = IDManager.getID(adjustableDatesIDRef_) as AdjustableDates;
                    return this.adjustableDates_; 
                }
                else
                {
                      return this.adjustableDates_; 
                }
            }
            set
            {
                if (this.adjustableDates_ != value)
                {
                    this.adjustableDates_ = value;
                }
            }
        }
        #endregion
        
        public string adjustableDatesIDRef_ { get; set; }
        #region RelativeDates_
        private RelativeDates relativeDates_;
        public RelativeDates RelativeDates_
        {
            get
            {
                if (this.relativeDates_ != null)
                {
                    return this.relativeDates_; 
                }
                else if (this.relativeDatesIDRef_ != null)
                {
                    relativeDates_ = IDManager.getID(relativeDatesIDRef_) as RelativeDates;
                    return this.relativeDates_; 
                }
                else
                {
                      return this.relativeDates_; 
                }
            }
            set
            {
                if (this.relativeDates_ != value)
                {
                    this.relativeDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDatesIDRef_ { get; set; }
        #region PeriodicDates_
        private PeriodicDates periodicDates_;
        public PeriodicDates PeriodicDates_
        {
            get
            {
                if (this.periodicDates_ != null)
                {
                    return this.periodicDates_; 
                }
                else if (this.periodicDatesIDRef_ != null)
                {
                    periodicDates_ = IDManager.getID(periodicDatesIDRef_) as PeriodicDates;
                    return this.periodicDates_; 
                }
                else
                {
                      return this.periodicDates_; 
                }
            }
            set
            {
                if (this.periodicDates_ != value)
                {
                    this.periodicDates_ = value;
                }
            }
        }
        #endregion
        
        public string periodicDatesIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

