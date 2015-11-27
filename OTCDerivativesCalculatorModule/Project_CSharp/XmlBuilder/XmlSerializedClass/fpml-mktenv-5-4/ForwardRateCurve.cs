using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ForwardRateCurve : ISerialized
    {
        public ForwardRateCurve(XmlNode xmlNode)
        {
            XmlNode assetReferenceNode = xmlNode.SelectSingleNode("assetReference");
            
            if (assetReferenceNode != null)
            {
                if (assetReferenceNode.Attributes["href"] != null || assetReferenceNode.Attributes["id"] != null) 
                {
                    if (assetReferenceNode.Attributes["id"] != null) 
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["id"].Value;
                        AssetReference ob = new AssetReference(assetReferenceNode);
                        IDManager.SetID(assetReferenceIDRef_, ob);
                    }
                    else if (assetReferenceNode.Attributes["href"] != null)
                    {
                        assetReferenceIDRef_ = assetReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        assetReference_ = new AssetReference(assetReferenceNode);
                    }
                }
                else
                {
                    assetReference_ = new AssetReference(assetReferenceNode);
                }
            }
            
        
            XmlNode rateCurveNode = xmlNode.SelectSingleNode("rateCurve");
            
            if (rateCurveNode != null)
            {
                if (rateCurveNode.Attributes["href"] != null || rateCurveNode.Attributes["id"] != null) 
                {
                    if (rateCurveNode.Attributes["id"] != null) 
                    {
                        rateCurveIDRef_ = rateCurveNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(rateCurveNode);
                        IDManager.SetID(rateCurveIDRef_, ob);
                    }
                    else if (rateCurveNode.Attributes["href"] != null)
                    {
                        rateCurveIDRef_ = rateCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateCurve_ = new TermCurve(rateCurveNode);
                    }
                }
                else
                {
                    rateCurve_ = new TermCurve(rateCurveNode);
                }
            }
            
        
        }
        
    
        #region AssetReference_
        private AssetReference assetReference_;
        public AssetReference AssetReference_
        {
            get
            {
                if (this.assetReference_ != null)
                {
                    return this.assetReference_; 
                }
                else if (this.assetReferenceIDRef_ != null)
                {
                    assetReference_ = IDManager.getID(assetReferenceIDRef_) as AssetReference;
                    return this.assetReference_; 
                }
                else
                {
                      return this.assetReference_; 
                }
            }
            set
            {
                if (this.assetReference_ != value)
                {
                    this.assetReference_ = value;
                }
            }
        }
        #endregion
        
        public string assetReferenceIDRef_ { get; set; }
        #region RateCurve_
        private TermCurve rateCurve_;
        public TermCurve RateCurve_
        {
            get
            {
                if (this.rateCurve_ != null)
                {
                    return this.rateCurve_; 
                }
                else if (this.rateCurveIDRef_ != null)
                {
                    rateCurve_ = IDManager.getID(rateCurveIDRef_) as TermCurve;
                    return this.rateCurve_; 
                }
                else
                {
                      return this.rateCurve_; 
                }
            }
            set
            {
                if (this.rateCurve_ != value)
                {
                    this.rateCurve_ = value;
                }
            }
        }
        #endregion
        
        public string rateCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

