using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableDateOrRelativeDateSequence : ISerialized
    {
        public AdjustableDateOrRelativeDateSequence(XmlNode xmlNode)
        {
            XmlNode adjustableDateNode = xmlNode.SelectSingleNode("adjustableDate");
            
            if (adjustableDateNode != null)
            {
                if (adjustableDateNode.Attributes["href"] != null || adjustableDateNode.Attributes["id"] != null) 
                {
                    if (adjustableDateNode.Attributes["id"] != null) 
                    {
                        adjustableDateIDRef_ = adjustableDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(adjustableDateNode);
                        IDManager.SetID(adjustableDateIDRef_, ob);
                    }
                    else if (adjustableDateNode.Attributes["href"] != null)
                    {
                        adjustableDateIDRef_ = adjustableDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustableDate_ = new AdjustableDate(adjustableDateNode);
                    }
                }
                else
                {
                    adjustableDate_ = new AdjustableDate(adjustableDateNode);
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
            
        
        }
        
    
        #region AdjustableDate_
        private AdjustableDate adjustableDate_;
        public AdjustableDate AdjustableDate_
        {
            get
            {
                if (this.adjustableDate_ != null)
                {
                    return this.adjustableDate_; 
                }
                else if (this.adjustableDateIDRef_ != null)
                {
                    adjustableDate_ = IDManager.getID(adjustableDateIDRef_) as AdjustableDate;
                    return this.adjustableDate_; 
                }
                else
                {
                      return this.adjustableDate_; 
                }
            }
            set
            {
                if (this.adjustableDate_ != value)
                {
                    this.adjustableDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustableDateIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

