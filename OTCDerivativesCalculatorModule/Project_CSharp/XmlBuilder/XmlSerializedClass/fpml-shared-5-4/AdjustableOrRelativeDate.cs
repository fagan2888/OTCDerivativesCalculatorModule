using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustableOrRelativeDate : ISerialized
    {
        public AdjustableOrRelativeDate(XmlNode xmlNode)
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
            
        
            XmlNode relativeDateNode = xmlNode.SelectSingleNode("relativeDate");
            
            if (relativeDateNode != null)
            {
                if (relativeDateNode.Attributes["href"] != null || relativeDateNode.Attributes["id"] != null) 
                {
                    if (relativeDateNode.Attributes["id"] != null) 
                    {
                        relativeDateIDRef_ = relativeDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(relativeDateNode);
                        IDManager.SetID(relativeDateIDRef_, ob);
                    }
                    else if (relativeDateNode.Attributes["href"] != null)
                    {
                        relativeDateIDRef_ = relativeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDate_ = new RelativeDateOffset(relativeDateNode);
                    }
                }
                else
                {
                    relativeDate_ = new RelativeDateOffset(relativeDateNode);
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
        #region RelativeDate_
        private RelativeDateOffset relativeDate_;
        public RelativeDateOffset RelativeDate_
        {
            get
            {
                if (this.relativeDate_ != null)
                {
                    return this.relativeDate_; 
                }
                else if (this.relativeDateIDRef_ != null)
                {
                    relativeDate_ = IDManager.getID(relativeDateIDRef_) as RelativeDateOffset;
                    return this.relativeDate_; 
                }
                else
                {
                      return this.relativeDate_; 
                }
            }
            set
            {
                if (this.relativeDate_ != value)
                {
                    this.relativeDate_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

