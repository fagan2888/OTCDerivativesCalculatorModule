using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestRateSwapPayoff : ISerialized
    {
        public InterestRateSwapPayoff() { }
        public InterestRateSwapPayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList couponPartNodeList = xmlNode.SelectNodes("couponPart");
            
            if (couponPartNodeList != null)
            {
                this.couponPart_ = new List<CouponPart>();
                foreach (XmlNode item in couponPartNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            couponPartIDRef_ = item.Attributes["id"].Value;
                            couponPart_.Add(new CouponPart(item));
                            IDManager.SetID(couponPartIDRef_, couponPart_[couponPart_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            couponPartIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        couponPart_.Add(new CouponPart(item));
                        }
                    }
                    else
                    {
                        couponPart_.Add(new CouponPart(item));
                    }
                }
            }
            
        
        }
        
    
        #region CouponPart_
        private List<CouponPart> couponPart_;
        public List<CouponPart> CouponPart_
        {
            get
            {
                if (this.couponPart_ != null)
                {
                    return this.couponPart_; 
                }
                else if (this.couponPartIDRef_ != null)
                {
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

