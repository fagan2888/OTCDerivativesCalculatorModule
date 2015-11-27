using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CouponPart : ISerialized
    {
        public CouponPart() { }
        public CouponPart(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payRecieveNode = xmlNode.SelectSingleNode("payRecieve");
            
            if (payRecieveNode != null)
            {
                if (payRecieveNode.Attributes["href"] != null || payRecieveNode.Attributes["id"] != null) 
                {
                    if (payRecieveNode.Attributes["id"] != null) 
                    {
                        payRecieveIDRef_ = payRecieveNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payRecieveNode);
                        IDManager.SetID(payRecieveIDRef_, ob);
                    }
                    else if (payRecieveNode.Attributes["href"] != null)
                    {
                        payRecieveIDRef_ = payRecieveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payRecieve_ = new XsdTypeToken(payRecieveNode);
                    }
                }
                else
                {
                    payRecieve_ = new XsdTypeToken(payRecieveNode);
                }
            }
            
        
        }
        
    
        #region PayRecieve_
        private XsdTypeToken payRecieve_;
        public XsdTypeToken PayRecieve_
        {
            get
            {
                if (this.payRecieve_ != null)
                {
                    return this.payRecieve_; 
                }
                else if (this.payRecieveIDRef_ != null)
                {
                    payRecieve_ = IDManager.getID(payRecieveIDRef_) as XsdTypeToken;
                    return this.payRecieve_; 
                }
                else
                {
                    throw new Exception( "payRecieve_Node no exist!");
                }
            }
            set
            {
                if (this.payRecieve_ != value)
                {
                    this.payRecieve_ = value;
                }
            }
        }
        #endregion
        
        public string payRecieveIDRef_ { get; set; }
        
    
        
    
    }
    
}

