using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableRelativeOrPeriodicDates : ISerialized
    {
        public AdjustableRelativeOrPeriodicDates(XmlNode xmlNode)
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
            
        
            XmlNode relativeDateSequenceNode = xmlNode.SelectSingleNode("relativeDateSequence");
            
            if (relativeDateSequenceNode != null)
            {
                if (relativeDateSequenceNode.Attributes["href"] != null || relativeDateSequenceNode.Attributes["id"] != null) 
                {
                    if (relativeDateSequenceNode.Attributes["id"] != null) 
                    {
                        relativeDateSequenceIDRef_ = relativeDateSequenceNode.Attributes["id"].Value;
                        RelativeDateSequence ob = new RelativeDateSequence(relativeDateSequenceNode);
                        IDManager.SetID(relativeDateSequenceIDRef_, ob);
                    }
                    else if (relativeDateSequenceNode.Attributes["href"] != null)
                    {
                        relativeDateSequenceIDRef_ = relativeDateSequenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDateSequence_ = new RelativeDateSequence(relativeDateSequenceNode);
                    }
                }
                else
                {
                    relativeDateSequence_ = new RelativeDateSequence(relativeDateSequenceNode);
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
        #region RelativeDateSequence_
        private RelativeDateSequence relativeDateSequence_;
        public RelativeDateSequence RelativeDateSequence_
        {
            get
            {
                if (this.relativeDateSequence_ != null)
                {
                    return this.relativeDateSequence_; 
                }
                else if (this.relativeDateSequenceIDRef_ != null)
                {
                    relativeDateSequence_ = IDManager.getID(relativeDateSequenceIDRef_) as RelativeDateSequence;
                    return this.relativeDateSequence_; 
                }
                else
                {
                      return this.relativeDateSequence_; 
                }
            }
            set
            {
                if (this.relativeDateSequence_ != value)
                {
                    this.relativeDateSequence_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDateSequenceIDRef_ { get; set; }
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

