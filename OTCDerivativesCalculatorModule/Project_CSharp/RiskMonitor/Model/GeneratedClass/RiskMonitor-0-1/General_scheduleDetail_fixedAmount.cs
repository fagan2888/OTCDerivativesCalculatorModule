using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class General_scheduleDetail_fixedAmount : ISerialized
    {
        public General_scheduleDetail_fixedAmount() { }
        public General_scheduleDetail_fixedAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixedAmountNode = xmlNode.SelectSingleNode("fixedAmount");
            
            if (fixedAmountNode != null)
            {
                if (fixedAmountNode.Attributes["href"] != null || fixedAmountNode.Attributes["id"] != null) 
                {
                    if (fixedAmountNode.Attributes["id"] != null) 
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fixedAmountNode);
                        IDManager.SetID(fixedAmountIDRef_, ob);
                    }
                    else if (fixedAmountNode.Attributes["href"] != null)
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedAmount_ = new XsdTypeToken(fixedAmountNode);
                    }
                }
                else
                {
                    fixedAmount_ = new XsdTypeToken(fixedAmountNode);
                }
            }
            
        
        }
        
    
        #region FixedAmount_
        private XsdTypeToken fixedAmount_;
        public XsdTypeToken FixedAmount_
        {
            get
            {
                if (this.fixedAmount_ != null)
                {
                    return this.fixedAmount_; 
                }
                else if (this.fixedAmountIDRef_ != null)
                {
                    fixedAmount_ = IDManager.getID(fixedAmountIDRef_) as XsdTypeToken;
                    return this.fixedAmount_; 
                }
                else
                {
                    throw new Exception( "fixedAmount_Node no exist!");
                }
            }
            set
            {
                if (this.fixedAmount_ != value)
                {
                    this.fixedAmount_ = value;
                }
            }
        }
        #endregion
        
        public string fixedAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

