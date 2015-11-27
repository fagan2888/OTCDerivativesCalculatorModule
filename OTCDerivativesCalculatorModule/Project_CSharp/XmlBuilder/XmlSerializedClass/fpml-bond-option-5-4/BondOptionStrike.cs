using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BondOptionStrike : ISerialized
    {
        public BondOptionStrike(XmlNode xmlNode)
        {
            XmlNode referenceSwapCurveNode = xmlNode.SelectSingleNode("referenceSwapCurve");
            
            if (referenceSwapCurveNode != null)
            {
                if (referenceSwapCurveNode.Attributes["href"] != null || referenceSwapCurveNode.Attributes["id"] != null) 
                {
                    if (referenceSwapCurveNode.Attributes["id"] != null) 
                    {
                        referenceSwapCurveIDRef_ = referenceSwapCurveNode.Attributes["id"].Value;
                        ReferenceSwapCurve ob = new ReferenceSwapCurve(referenceSwapCurveNode);
                        IDManager.SetID(referenceSwapCurveIDRef_, ob);
                    }
                    else if (referenceSwapCurveNode.Attributes["href"] != null)
                    {
                        referenceSwapCurveIDRef_ = referenceSwapCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceSwapCurve_ = new ReferenceSwapCurve(referenceSwapCurveNode);
                    }
                }
                else
                {
                    referenceSwapCurve_ = new ReferenceSwapCurve(referenceSwapCurveNode);
                }
            }
            
        
            XmlNode priceNode = xmlNode.SelectSingleNode("price");
            
            if (priceNode != null)
            {
                if (priceNode.Attributes["href"] != null || priceNode.Attributes["id"] != null) 
                {
                    if (priceNode.Attributes["id"] != null) 
                    {
                        priceIDRef_ = priceNode.Attributes["id"].Value;
                        OptionStrike ob = new OptionStrike(priceNode);
                        IDManager.SetID(priceIDRef_, ob);
                    }
                    else if (priceNode.Attributes["href"] != null)
                    {
                        priceIDRef_ = priceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        price_ = new OptionStrike(priceNode);
                    }
                }
                else
                {
                    price_ = new OptionStrike(priceNode);
                }
            }
            
        
        }
        
    
        #region ReferenceSwapCurve_
        private ReferenceSwapCurve referenceSwapCurve_;
        public ReferenceSwapCurve ReferenceSwapCurve_
        {
            get
            {
                if (this.referenceSwapCurve_ != null)
                {
                    return this.referenceSwapCurve_; 
                }
                else if (this.referenceSwapCurveIDRef_ != null)
                {
                    referenceSwapCurve_ = IDManager.getID(referenceSwapCurveIDRef_) as ReferenceSwapCurve;
                    return this.referenceSwapCurve_; 
                }
                else
                {
                      return this.referenceSwapCurve_; 
                }
            }
            set
            {
                if (this.referenceSwapCurve_ != value)
                {
                    this.referenceSwapCurve_ = value;
                }
            }
        }
        #endregion
        
        public string referenceSwapCurveIDRef_ { get; set; }
        #region Price_
        private OptionStrike price_;
        public OptionStrike Price_
        {
            get
            {
                if (this.price_ != null)
                {
                    return this.price_; 
                }
                else if (this.priceIDRef_ != null)
                {
                    price_ = IDManager.getID(priceIDRef_) as OptionStrike;
                    return this.price_; 
                }
                else
                {
                      return this.price_; 
                }
            }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                }
            }
        }
        #endregion
        
        public string priceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

