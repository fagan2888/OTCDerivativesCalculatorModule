using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class YieldCurveValuation : PricingStructureValuation
    {
        public YieldCurveValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode inputsNode = xmlNode.SelectSingleNode("inputs");
            
            if (inputsNode != null)
            {
                if (inputsNode.Attributes["href"] != null || inputsNode.Attributes["id"] != null) 
                {
                    if (inputsNode.Attributes["id"] != null) 
                    {
                        inputsIDRef_ = inputsNode.Attributes["id"].Value;
                        QuotedAssetSet ob = new QuotedAssetSet(inputsNode);
                        IDManager.SetID(inputsIDRef_, ob);
                    }
                    else if (inputsNode.Attributes["href"] != null)
                    {
                        inputsIDRef_ = inputsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inputs_ = new QuotedAssetSet(inputsNode);
                    }
                }
                else
                {
                    inputs_ = new QuotedAssetSet(inputsNode);
                }
            }
            
        
            XmlNode zeroCurveNode = xmlNode.SelectSingleNode("zeroCurve");
            
            if (zeroCurveNode != null)
            {
                if (zeroCurveNode.Attributes["href"] != null || zeroCurveNode.Attributes["id"] != null) 
                {
                    if (zeroCurveNode.Attributes["id"] != null) 
                    {
                        zeroCurveIDRef_ = zeroCurveNode.Attributes["id"].Value;
                        ZeroRateCurve ob = new ZeroRateCurve(zeroCurveNode);
                        IDManager.SetID(zeroCurveIDRef_, ob);
                    }
                    else if (zeroCurveNode.Attributes["href"] != null)
                    {
                        zeroCurveIDRef_ = zeroCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        zeroCurve_ = new ZeroRateCurve(zeroCurveNode);
                    }
                }
                else
                {
                    zeroCurve_ = new ZeroRateCurve(zeroCurveNode);
                }
            }
            
        
            XmlNodeList forwardCurveNodeList = xmlNode.SelectNodes("forwardCurve");
            
            if (forwardCurveNodeList != null)
            {
                this.forwardCurve_ = new List<ForwardRateCurve>();
                foreach (XmlNode item in forwardCurveNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            forwardCurveIDRef_ = item.Attributes["id"].Value;
                            forwardCurve_.Add(new ForwardRateCurve(item));
                            IDManager.SetID(forwardCurveIDRef_, forwardCurve_[forwardCurve_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            forwardCurveIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        forwardCurve_.Add(new ForwardRateCurve(item));
                        }
                    }
                    else
                    {
                        forwardCurve_.Add(new ForwardRateCurve(item));
                    }
                }
            }
            
        
            XmlNode discountFactorCurveNode = xmlNode.SelectSingleNode("discountFactorCurve");
            
            if (discountFactorCurveNode != null)
            {
                if (discountFactorCurveNode.Attributes["href"] != null || discountFactorCurveNode.Attributes["id"] != null) 
                {
                    if (discountFactorCurveNode.Attributes["id"] != null) 
                    {
                        discountFactorCurveIDRef_ = discountFactorCurveNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(discountFactorCurveNode);
                        IDManager.SetID(discountFactorCurveIDRef_, ob);
                    }
                    else if (discountFactorCurveNode.Attributes["href"] != null)
                    {
                        discountFactorCurveIDRef_ = discountFactorCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountFactorCurve_ = new TermCurve(discountFactorCurveNode);
                    }
                }
                else
                {
                    discountFactorCurve_ = new TermCurve(discountFactorCurveNode);
                }
            }
            
        
        }
        
    
        #region Inputs_
        private QuotedAssetSet inputs_;
        public QuotedAssetSet Inputs_
        {
            get
            {
                if (this.inputs_ != null)
                {
                    return this.inputs_; 
                }
                else if (this.inputsIDRef_ != null)
                {
                    inputs_ = IDManager.getID(inputsIDRef_) as QuotedAssetSet;
                    return this.inputs_; 
                }
                else
                {
                      return this.inputs_; 
                }
            }
            set
            {
                if (this.inputs_ != value)
                {
                    this.inputs_ = value;
                }
            }
        }
        #endregion
        
        public string inputsIDRef_ { get; set; }
        #region ZeroCurve_
        private ZeroRateCurve zeroCurve_;
        public ZeroRateCurve ZeroCurve_
        {
            get
            {
                if (this.zeroCurve_ != null)
                {
                    return this.zeroCurve_; 
                }
                else if (this.zeroCurveIDRef_ != null)
                {
                    zeroCurve_ = IDManager.getID(zeroCurveIDRef_) as ZeroRateCurve;
                    return this.zeroCurve_; 
                }
                else
                {
                      return this.zeroCurve_; 
                }
            }
            set
            {
                if (this.zeroCurve_ != value)
                {
                    this.zeroCurve_ = value;
                }
            }
        }
        #endregion
        
        public string zeroCurveIDRef_ { get; set; }
        #region ForwardCurve_
        private List<ForwardRateCurve> forwardCurve_;
        public List<ForwardRateCurve> ForwardCurve_
        {
            get
            {
                if (this.forwardCurve_ != null)
                {
                    return this.forwardCurve_; 
                }
                else if (this.forwardCurveIDRef_ != null)
                {
                    return this.forwardCurve_; 
                }
                else
                {
                      return this.forwardCurve_; 
                }
            }
            set
            {
                if (this.forwardCurve_ != value)
                {
                    this.forwardCurve_ = value;
                }
            }
        }
        #endregion
        
        public string forwardCurveIDRef_ { get; set; }
        #region DiscountFactorCurve_
        private TermCurve discountFactorCurve_;
        public TermCurve DiscountFactorCurve_
        {
            get
            {
                if (this.discountFactorCurve_ != null)
                {
                    return this.discountFactorCurve_; 
                }
                else if (this.discountFactorCurveIDRef_ != null)
                {
                    discountFactorCurve_ = IDManager.getID(discountFactorCurveIDRef_) as TermCurve;
                    return this.discountFactorCurve_; 
                }
                else
                {
                      return this.discountFactorCurve_; 
                }
            }
            set
            {
                if (this.discountFactorCurve_ != value)
                {
                    this.discountFactorCurve_ = value;
                }
            }
        }
        #endregion
        
        public string discountFactorCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

