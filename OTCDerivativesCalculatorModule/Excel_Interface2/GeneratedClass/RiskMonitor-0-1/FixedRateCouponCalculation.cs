using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedRateCouponCalculation : ISerialized
    {
        public FixedRateCouponCalculation() { }
        public FixedRateCouponCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode rateNode = xmlNode.SelectSingleNode("rate");
            
            if (rateNode != null)
            {
                if (rateNode.Attributes["href"] != null || rateNode.Attributes["id"] != null) 
                {
                    if (rateNode.Attributes["id"] != null) 
                    {
                        rateIDRef_ = rateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(rateNode);
                        IDManager.SetID(rateIDRef_, ob);
                    }
                    else if (rateNode.Attributes["href"] != null)
                    {
                        rateIDRef_ = rateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rate_ = new XsdTypeDouble(rateNode);
                    }
                }
                else
                {
                    rate_ = new XsdTypeDouble(rateNode);
                }
            }
            
        
        }
        
    
        #region Rate_
        private XsdTypeDouble rate_;
        public XsdTypeDouble Rate_
        {
            get
            {
                if (this.rate_ != null)
                {
                    return this.rate_; 
                }
                else if (this.rateIDRef_ != null)
                {
                    rate_ = IDManager.getID(rateIDRef_) as XsdTypeDouble;
                    return this.rate_; 
                }
                else
                {
                    throw new Exception( "rate_Node no exist!");
                }
            }
            set
            {
                if (this.rate_ != value)
                {
                    this.rate_ = value;
                }
            }
        }
        #endregion
        
        public string rateIDRef_ { get; set; }
        
    
        
    
    }
    
}

