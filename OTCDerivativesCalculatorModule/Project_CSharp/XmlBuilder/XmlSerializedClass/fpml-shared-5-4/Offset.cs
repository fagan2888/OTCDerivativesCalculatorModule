using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Offset : Period
    {
        public Offset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dayTypeNode = xmlNode.SelectSingleNode("dayType");
            
            if (dayTypeNode != null)
            {
                if (dayTypeNode.Attributes["href"] != null || dayTypeNode.Attributes["id"] != null) 
                {
                    if (dayTypeNode.Attributes["id"] != null) 
                    {
                        dayTypeIDRef_ = dayTypeNode.Attributes["id"].Value;
                        DayTypeEnum ob = new DayTypeEnum(dayTypeNode);
                        IDManager.SetID(dayTypeIDRef_, ob);
                    }
                    else if (dayTypeNode.Attributes["href"] != null)
                    {
                        dayTypeIDRef_ = dayTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayType_ = new DayTypeEnum(dayTypeNode);
                    }
                }
                else
                {
                    dayType_ = new DayTypeEnum(dayTypeNode);
                }
            }
            
        
        }
        
    
        #region DayType_
        private DayTypeEnum dayType_;
        public DayTypeEnum DayType_
        {
            get
            {
                if (this.dayType_ != null)
                {
                    return this.dayType_; 
                }
                else if (this.dayTypeIDRef_ != null)
                {
                    dayType_ = IDManager.getID(dayTypeIDRef_) as DayTypeEnum;
                    return this.dayType_; 
                }
                else
                {
                      return this.dayType_; 
                }
            }
            set
            {
                if (this.dayType_ != value)
                {
                    this.dayType_ = value;
                }
            }
        }
        #endregion
        
        public string dayTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

