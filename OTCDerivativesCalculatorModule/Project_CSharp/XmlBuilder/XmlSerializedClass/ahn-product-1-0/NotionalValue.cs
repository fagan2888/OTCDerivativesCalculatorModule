using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NotionalValue : ISerialized
    {
        public NotionalValue(XmlNode xmlNode)
        {
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
                }
            }
            
        
        }
        
    
        #region NotionalAmount_
        private XsdTypeDecimal notionalAmount_;
        public XsdTypeDecimal NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as XsdTypeDecimal;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

