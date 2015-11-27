using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalendarSpread : ISerialized
    {
        public CalendarSpread(XmlNode xmlNode)
        {
            XmlNode expirationDateTwoNode = xmlNode.SelectSingleNode("expirationDateTwo");
            
            if (expirationDateTwoNode != null)
            {
                if (expirationDateTwoNode.Attributes["href"] != null || expirationDateTwoNode.Attributes["id"] != null) 
                {
                    if (expirationDateTwoNode.Attributes["id"] != null) 
                    {
                        expirationDateTwoIDRef_ = expirationDateTwoNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(expirationDateTwoNode);
                        IDManager.SetID(expirationDateTwoIDRef_, ob);
                    }
                    else if (expirationDateTwoNode.Attributes["href"] != null)
                    {
                        expirationDateTwoIDRef_ = expirationDateTwoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDateTwo_ = new AdjustableOrRelativeDate(expirationDateTwoNode);
                    }
                }
                else
                {
                    expirationDateTwo_ = new AdjustableOrRelativeDate(expirationDateTwoNode);
                }
            }
            
        
        }
        
    
        #region ExpirationDateTwo_
        private AdjustableOrRelativeDate expirationDateTwo_;
        public AdjustableOrRelativeDate ExpirationDateTwo_
        {
            get
            {
                if (this.expirationDateTwo_ != null)
                {
                    return this.expirationDateTwo_; 
                }
                else if (this.expirationDateTwoIDRef_ != null)
                {
                    expirationDateTwo_ = IDManager.getID(expirationDateTwoIDRef_) as AdjustableOrRelativeDate;
                    return this.expirationDateTwo_; 
                }
                else
                {
                      return this.expirationDateTwo_; 
                }
            }
            set
            {
                if (this.expirationDateTwo_ != value)
                {
                    this.expirationDateTwo_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateTwoIDRef_ { get; set; }
        
    
        
    
    }
    
}

