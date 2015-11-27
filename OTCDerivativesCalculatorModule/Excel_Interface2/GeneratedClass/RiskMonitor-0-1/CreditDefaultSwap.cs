using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditDefaultSwap : ISerialized
    {
        public CreditDefaultSwap() { }
        public CreditDefaultSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode protectionPartNode = xmlNode.SelectSingleNode("protectionPart");
            
            if (protectionPartNode != null)
            {
                if (protectionPartNode.Attributes["href"] != null || protectionPartNode.Attributes["id"] != null) 
                {
                    if (protectionPartNode.Attributes["id"] != null) 
                    {
                        protectionPartIDRef_ = protectionPartNode.Attributes["id"].Value;
                        ProtectionPart ob = new ProtectionPart(protectionPartNode);
                        IDManager.SetID(protectionPartIDRef_, ob);
                    }
                    else if (protectionPartNode.Attributes["href"] != null)
                    {
                        protectionPartIDRef_ = protectionPartNode.Attributes["href"].Value;
                    }
                    else
                    {
                        protectionPart_ = new ProtectionPart(protectionPartNode);
                    }
                }
                else
                {
                    protectionPart_ = new ProtectionPart(protectionPartNode);
                }
            }
            
        
            XmlNode couponPartNode = xmlNode.SelectSingleNode("couponPart");
            
            if (couponPartNode != null)
            {
                if (couponPartNode.Attributes["href"] != null || couponPartNode.Attributes["id"] != null) 
                {
                    if (couponPartNode.Attributes["id"] != null) 
                    {
                        couponPartIDRef_ = couponPartNode.Attributes["id"].Value;
                        CouponPart ob = new CouponPart(couponPartNode);
                        IDManager.SetID(couponPartIDRef_, ob);
                    }
                    else if (couponPartNode.Attributes["href"] != null)
                    {
                        couponPartIDRef_ = couponPartNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponPart_ = new CouponPart(couponPartNode);
                    }
                }
                else
                {
                    couponPart_ = new CouponPart(couponPartNode);
                }
            }
            
        
        }
        
    
        #region ProtectionPart_
        private ProtectionPart protectionPart_;
        public ProtectionPart ProtectionPart_
        {
            get
            {
                if (this.protectionPart_ != null)
                {
                    return this.protectionPart_; 
                }
                else if (this.protectionPartIDRef_ != null)
                {
                    protectionPart_ = IDManager.getID(protectionPartIDRef_) as ProtectionPart;
                    return this.protectionPart_; 
                }
                else
                {
                    throw new Exception( "protectionPart_Node no exist!");
                }
            }
            set
            {
                if (this.protectionPart_ != value)
                {
                    this.protectionPart_ = value;
                }
            }
        }
        #endregion
        
        public string protectionPartIDRef_ { get; set; }
        #region CouponPart_
        private CouponPart couponPart_;
        public CouponPart CouponPart_
        {
            get
            {
                if (this.couponPart_ != null)
                {
                    return this.couponPart_; 
                }
                else if (this.couponPartIDRef_ != null)
                {
                    couponPart_ = IDManager.getID(couponPartIDRef_) as CouponPart;
                    return this.couponPart_; 
                }
                else
                {
                    throw new Exception( "couponPart_Node no exist!");
                }
            }
            set
            {
                if (this.couponPart_ != value)
                {
                    this.couponPart_ = value;
                }
            }
        }
        #endregion
        
        public string couponPartIDRef_ { get; set; }
        
    
        
    
    }
    
}

