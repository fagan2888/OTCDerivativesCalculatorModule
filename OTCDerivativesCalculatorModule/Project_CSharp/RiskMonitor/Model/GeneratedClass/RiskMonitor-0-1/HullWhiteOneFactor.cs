using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class HullWhiteOneFactor : ISerialized
    {
        public HullWhiteOneFactor() { }
        public HullWhiteOneFactor(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode alphaNode = xmlNode.SelectSingleNode("alpha");
            
            if (alphaNode != null)
            {
                if (alphaNode.Attributes["href"] != null || alphaNode.Attributes["id"] != null) 
                {
                    if (alphaNode.Attributes["id"] != null) 
                    {
                        alphaIDRef_ = alphaNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(alphaNode);
                        IDManager.SetID(alphaIDRef_, ob);
                    }
                    else if (alphaNode.Attributes["href"] != null)
                    {
                        alphaIDRef_ = alphaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        alpha_ = new XsdTypeDouble(alphaNode);
                    }
                }
                else
                {
                    alpha_ = new XsdTypeDouble(alphaNode);
                }
            }
            
        
            XmlNode sigmaNode = xmlNode.SelectSingleNode("sigma");
            
            if (sigmaNode != null)
            {
                if (sigmaNode.Attributes["href"] != null || sigmaNode.Attributes["id"] != null) 
                {
                    if (sigmaNode.Attributes["id"] != null) 
                    {
                        sigmaIDRef_ = sigmaNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(sigmaNode);
                        IDManager.SetID(sigmaIDRef_, ob);
                    }
                    else if (sigmaNode.Attributes["href"] != null)
                    {
                        sigmaIDRef_ = sigmaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sigma_ = new XsdTypeDouble(sigmaNode);
                    }
                }
                else
                {
                    sigma_ = new XsdTypeDouble(sigmaNode);
                }
            }
            
        
            XmlNode tenorNode = xmlNode.SelectSingleNode("tenor");
            
            if (tenorNode != null)
            {
                if (tenorNode.Attributes["href"] != null || tenorNode.Attributes["id"] != null) 
                {
                    if (tenorNode.Attributes["id"] != null) 
                    {
                        tenorIDRef_ = tenorNode.Attributes["id"].Value;
                        Tenor ob = new Tenor(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new Tenor(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new Tenor(tenorNode);
                }
            }
            
        
            XmlNode fittingYieldCurveNode = xmlNode.SelectSingleNode("fittingYieldCurve");
            
            if (fittingYieldCurveNode != null)
            {
                if (fittingYieldCurveNode.Attributes["href"] != null || fittingYieldCurveNode.Attributes["id"] != null) 
                {
                    if (fittingYieldCurveNode.Attributes["id"] != null) 
                    {
                        fittingYieldCurveIDRef_ = fittingYieldCurveNode.Attributes["id"].Value;
                        FittingYieldCurve ob = new FittingYieldCurve(fittingYieldCurveNode);
                        IDManager.SetID(fittingYieldCurveIDRef_, ob);
                    }
                    else if (fittingYieldCurveNode.Attributes["href"] != null)
                    {
                        fittingYieldCurveIDRef_ = fittingYieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fittingYieldCurve_ = new FittingYieldCurve(fittingYieldCurveNode);
                    }
                }
                else
                {
                    fittingYieldCurve_ = new FittingYieldCurve(fittingYieldCurveNode);
                }
            }
            
        
        }
        
    
        #region Alpha_
        private XsdTypeDouble alpha_;
        public XsdTypeDouble Alpha_
        {
            get
            {
                if (this.alpha_ != null)
                {
                    return this.alpha_; 
                }
                else if (this.alphaIDRef_ != null)
                {
                    alpha_ = IDManager.getID(alphaIDRef_) as XsdTypeDouble;
                    return this.alpha_; 
                }
                else
                {
                    throw new Exception( "alpha_Node no exist!");
                }
            }
            set
            {
                if (this.alpha_ != value)
                {
                    this.alpha_ = value;
                }
            }
        }
        #endregion
        
        public string alphaIDRef_ { get; set; }
        #region Sigma_
        private XsdTypeDouble sigma_;
        public XsdTypeDouble Sigma_
        {
            get
            {
                if (this.sigma_ != null)
                {
                    return this.sigma_; 
                }
                else if (this.sigmaIDRef_ != null)
                {
                    sigma_ = IDManager.getID(sigmaIDRef_) as XsdTypeDouble;
                    return this.sigma_; 
                }
                else
                {
                    throw new Exception( "sigma_Node no exist!");
                }
            }
            set
            {
                if (this.sigma_ != value)
                {
                    this.sigma_ = value;
                }
            }
        }
        #endregion
        
        public string sigmaIDRef_ { get; set; }
        #region Tenor_
        private Tenor tenor_;
        public Tenor Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as Tenor;
                    return this.tenor_; 
                }
                else
                {
                    throw new Exception( "tenor_Node no exist!");
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region FittingYieldCurve_
        private FittingYieldCurve fittingYieldCurve_;
        public FittingYieldCurve FittingYieldCurve_
        {
            get
            {
                if (this.fittingYieldCurve_ != null)
                {
                    return this.fittingYieldCurve_; 
                }
                else if (this.fittingYieldCurveIDRef_ != null)
                {
                    fittingYieldCurve_ = IDManager.getID(fittingYieldCurveIDRef_) as FittingYieldCurve;
                    return this.fittingYieldCurve_; 
                }
                else
                {
                    throw new Exception( "fittingYieldCurve_Node no exist!");
                }
            }
            set
            {
                if (this.fittingYieldCurve_ != value)
                {
                    this.fittingYieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string fittingYieldCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

