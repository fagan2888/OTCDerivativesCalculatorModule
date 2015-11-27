using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwaptionPhysicalSettlement : ISerialized
    {
        public SwaptionPhysicalSettlement(XmlNode xmlNode)
        {
            XmlNode clearedPhysicalSettlementNode = xmlNode.SelectSingleNode("clearedPhysicalSettlement");
            
            if (clearedPhysicalSettlementNode != null)
            {
                if (clearedPhysicalSettlementNode.Attributes["href"] != null || clearedPhysicalSettlementNode.Attributes["id"] != null) 
                {
                    if (clearedPhysicalSettlementNode.Attributes["id"] != null) 
                    {
                        clearedPhysicalSettlementIDRef_ = clearedPhysicalSettlementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(clearedPhysicalSettlementNode);
                        IDManager.SetID(clearedPhysicalSettlementIDRef_, ob);
                    }
                    else if (clearedPhysicalSettlementNode.Attributes["href"] != null)
                    {
                        clearedPhysicalSettlementIDRef_ = clearedPhysicalSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearedPhysicalSettlement_ = new XsdTypeBoolean(clearedPhysicalSettlementNode);
                    }
                }
                else
                {
                    clearedPhysicalSettlement_ = new XsdTypeBoolean(clearedPhysicalSettlementNode);
                }
            }
            
        
        }
        
    
        #region ClearedPhysicalSettlement_
        private XsdTypeBoolean clearedPhysicalSettlement_;
        public XsdTypeBoolean ClearedPhysicalSettlement_
        {
            get
            {
                if (this.clearedPhysicalSettlement_ != null)
                {
                    return this.clearedPhysicalSettlement_; 
                }
                else if (this.clearedPhysicalSettlementIDRef_ != null)
                {
                    clearedPhysicalSettlement_ = IDManager.getID(clearedPhysicalSettlementIDRef_) as XsdTypeBoolean;
                    return this.clearedPhysicalSettlement_; 
                }
                else
                {
                      return this.clearedPhysicalSettlement_; 
                }
            }
            set
            {
                if (this.clearedPhysicalSettlement_ != value)
                {
                    this.clearedPhysicalSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string clearedPhysicalSettlementIDRef_ { get; set; }
        
    
        
    
    }
    
}

