using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ZeroRateCurve : ISerialized
    {
        public ZeroRateCurve(XmlNode xmlNode)
        {
            XmlNode compoundingFrequencyNode = xmlNode.SelectSingleNode("compoundingFrequency");
            
            if (compoundingFrequencyNode != null)
            {
                if (compoundingFrequencyNode.Attributes["href"] != null || compoundingFrequencyNode.Attributes["id"] != null) 
                {
                    if (compoundingFrequencyNode.Attributes["id"] != null) 
                    {
                        compoundingFrequencyIDRef_ = compoundingFrequencyNode.Attributes["id"].Value;
                        CompoundingFrequency ob = new CompoundingFrequency(compoundingFrequencyNode);
                        IDManager.SetID(compoundingFrequencyIDRef_, ob);
                    }
                    else if (compoundingFrequencyNode.Attributes["href"] != null)
                    {
                        compoundingFrequencyIDRef_ = compoundingFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingFrequency_ = new CompoundingFrequency(compoundingFrequencyNode);
                    }
                }
                else
                {
                    compoundingFrequency_ = new CompoundingFrequency(compoundingFrequencyNode);
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
        
    
        #region CompoundingFrequency_
        private CompoundingFrequency compoundingFrequency_;
        public CompoundingFrequency CompoundingFrequency_
        {
            get
            {
                if (this.compoundingFrequency_ != null)
                {
                    return this.compoundingFrequency_; 
                }
                else if (this.compoundingFrequencyIDRef_ != null)
                {
                    compoundingFrequency_ = IDManager.getID(compoundingFrequencyIDRef_) as CompoundingFrequency;
                    return this.compoundingFrequency_; 
                }
                else
                {
                      return this.compoundingFrequency_; 
                }
            }
            set
            {
                if (this.compoundingFrequency_ != value)
                {
                    this.compoundingFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingFrequencyIDRef_ { get; set; }
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

