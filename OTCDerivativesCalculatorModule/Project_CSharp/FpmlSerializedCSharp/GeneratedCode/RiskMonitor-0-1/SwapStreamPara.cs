using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class SwapStreamPara : ISerialized
    {
        public SwapStreamPara() { }
        public SwapStreamPara(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new XsdTypeDouble(notionalNode);
                    }
                }
                else
                {
                    notional_ = new XsdTypeDouble(notionalNode);
                }
            }
            
        
            XmlNode discountCurveNode = xmlNode.SelectSingleNode("discountCurve");
            
            if (discountCurveNode != null)
            {
                if (discountCurveNode.Attributes["href"] != null || discountCurveNode.Attributes["id"] != null) 
                {
                    if (discountCurveNode.Attributes["id"] != null) 
                    {
                        discountCurveIDRef_ = discountCurveNode.Attributes["id"].Value;
                        DiscountCurve ob = new DiscountCurve(discountCurveNode);
                        IDManager.SetID(discountCurveIDRef_, ob);
                    }
                    else if (discountCurveNode.Attributes["href"] != null)
                    {
                        discountCurveIDRef_ = discountCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountCurve_ = new DiscountCurve(discountCurveNode);
                    }
                }
                else
                {
                    discountCurve_ = new DiscountCurve(discountCurveNode);
                }
            }
            
        
        }
        
    
        #region Notional_
        private XsdTypeDouble notional_;
        public XsdTypeDouble Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as XsdTypeDouble;
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region DiscountCurve_
        private DiscountCurve discountCurve_;
        public DiscountCurve DiscountCurve_
        {
            get
            {
                if (this.discountCurve_ != null)
                {
                    return this.discountCurve_; 
                }
                else if (this.discountCurveIDRef_ != null)
                {
                    discountCurve_ = IDManager.getID(discountCurveIDRef_) as DiscountCurve;
                    return this.discountCurve_; 
                }
                else
                {
                      return this.discountCurve_; 
                }
            }
            set
            {
                if (this.discountCurve_ != value)
                {
                    this.discountCurve_ = value;
                }
            }
        }
        #endregion
        
        public string discountCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

