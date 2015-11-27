using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StartingDate : ISerialized
    {
        public StartingDate(XmlNode xmlNode)
        {
            XmlNode dateRelativeToNode = xmlNode.SelectSingleNode("dateRelativeTo");
            
            if (dateRelativeToNode != null)
            {
                if (dateRelativeToNode.Attributes["href"] != null || dateRelativeToNode.Attributes["id"] != null) 
                {
                    if (dateRelativeToNode.Attributes["id"] != null) 
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["id"].Value;
                        DateReference ob = new DateReference(dateRelativeToNode);
                        IDManager.SetID(dateRelativeToIDRef_, ob);
                    }
                    else if (dateRelativeToNode.Attributes["href"] != null)
                    {
                        dateRelativeToIDRef_ = dateRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateRelativeTo_ = new DateReference(dateRelativeToNode);
                    }
                }
                else
                {
                    dateRelativeTo_ = new DateReference(dateRelativeToNode);
                }
            }
            
        
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
            
        
        }
        
    
        #region DateRelativeTo_
        private DateReference dateRelativeTo_;
        public DateReference DateRelativeTo_
        {
            get
            {
                if (this.dateRelativeTo_ != null)
                {
                    return this.dateRelativeTo_; 
                }
                else if (this.dateRelativeToIDRef_ != null)
                {
                    dateRelativeTo_ = IDManager.getID(dateRelativeToIDRef_) as DateReference;
                    return this.dateRelativeTo_; 
                }
                else
                {
                      return this.dateRelativeTo_; 
                }
            }
            set
            {
                if (this.dateRelativeTo_ != value)
                {
                    this.dateRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string dateRelativeToIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

