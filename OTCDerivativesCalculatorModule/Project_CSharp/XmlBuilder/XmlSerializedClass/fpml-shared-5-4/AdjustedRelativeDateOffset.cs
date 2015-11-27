using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdjustedRelativeDateOffset : RelativeDateOffset
    {
        public AdjustedRelativeDateOffset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode relativeDateAdjustmentsNode = xmlNode.SelectSingleNode("relativeDateAdjustments");
            
            if (relativeDateAdjustmentsNode != null)
            {
                if (relativeDateAdjustmentsNode.Attributes["href"] != null || relativeDateAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (relativeDateAdjustmentsNode.Attributes["id"] != null) 
                    {
                        relativeDateAdjustmentsIDRef_ = relativeDateAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(relativeDateAdjustmentsNode);
                        IDManager.SetID(relativeDateAdjustmentsIDRef_, ob);
                    }
                    else if (relativeDateAdjustmentsNode.Attributes["href"] != null)
                    {
                        relativeDateAdjustmentsIDRef_ = relativeDateAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativeDateAdjustments_ = new BusinessDayAdjustments(relativeDateAdjustmentsNode);
                    }
                }
                else
                {
                    relativeDateAdjustments_ = new BusinessDayAdjustments(relativeDateAdjustmentsNode);
                }
            }
            
        
        }
        
    
        #region RelativeDateAdjustments_
        private BusinessDayAdjustments relativeDateAdjustments_;
        public BusinessDayAdjustments RelativeDateAdjustments_
        {
            get
            {
                if (this.relativeDateAdjustments_ != null)
                {
                    return this.relativeDateAdjustments_; 
                }
                else if (this.relativeDateAdjustmentsIDRef_ != null)
                {
                    relativeDateAdjustments_ = IDManager.getID(relativeDateAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.relativeDateAdjustments_; 
                }
                else
                {
                      return this.relativeDateAdjustments_; 
                }
            }
            set
            {
                if (this.relativeDateAdjustments_ != value)
                {
                    this.relativeDateAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string relativeDateAdjustmentsIDRef_ { get; set; }
        
    
        
    
    }
    
}

