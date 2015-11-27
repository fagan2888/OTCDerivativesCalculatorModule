using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ForwardModel : ISerialized
    {
        public ForwardModel() { }
        public ForwardModel(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode currentValueNode = xmlNode.SelectSingleNode("currentValue");
            
            if (currentValueNode != null)
            {
                if (currentValueNode.Attributes["href"] != null || currentValueNode.Attributes["id"] != null) 
                {
                    if (currentValueNode.Attributes["id"] != null) 
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(currentValueNode);
                        IDManager.SetID(currentValueIDRef_, ob);
                    }
                    else if (currentValueNode.Attributes["href"] != null)
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentValue_ = new XsdTypeDouble(currentValueNode);
                    }
                }
                else
                {
                    currentValue_ = new XsdTypeDouble(currentValueNode);
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
        
    
        #region CurrentValue_
        private XsdTypeDouble currentValue_;
        public XsdTypeDouble CurrentValue_
        {
            get
            {
                if (this.currentValue_ != null)
                {
                    return this.currentValue_; 
                }
                else if (this.currentValueIDRef_ != null)
                {
                    currentValue_ = IDManager.getID(currentValueIDRef_) as XsdTypeDouble;
                    return this.currentValue_; 
                }
                else
                {
                    throw new Exception( "currentValue_Node no exist!");
                }
            }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                }
            }
        }
        #endregion
        
        public string currentValueIDRef_ { get; set; }
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

