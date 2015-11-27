using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityForward : EquityDerivativeLongFormBase
    {
        public EquityForward(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode forwardPriceNode = xmlNode.SelectSingleNode("forwardPrice");
            
            if (forwardPriceNode != null)
            {
                if (forwardPriceNode.Attributes["href"] != null || forwardPriceNode.Attributes["id"] != null) 
                {
                    if (forwardPriceNode.Attributes["id"] != null) 
                    {
                        forwardPriceIDRef_ = forwardPriceNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(forwardPriceNode);
                        IDManager.SetID(forwardPriceIDRef_, ob);
                    }
                    else if (forwardPriceNode.Attributes["href"] != null)
                    {
                        forwardPriceIDRef_ = forwardPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardPrice_ = new NonNegativeMoney(forwardPriceNode);
                    }
                }
                else
                {
                    forwardPrice_ = new NonNegativeMoney(forwardPriceNode);
                }
            }
            
        
        }
        
    
        #region ForwardPrice_
        private NonNegativeMoney forwardPrice_;
        public NonNegativeMoney ForwardPrice_
        {
            get
            {
                if (this.forwardPrice_ != null)
                {
                    return this.forwardPrice_; 
                }
                else if (this.forwardPriceIDRef_ != null)
                {
                    forwardPrice_ = IDManager.getID(forwardPriceIDRef_) as NonNegativeMoney;
                    return this.forwardPrice_; 
                }
                else
                {
                      return this.forwardPrice_; 
                }
            }
            set
            {
                if (this.forwardPrice_ != value)
                {
                    this.forwardPrice_ = value;
                }
            }
        }
        #endregion
        
        public string forwardPriceIDRef_ { get; set; }
        
    
        
    
    }
    
}

