using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hullWhiteOneFactor : ISerialized
    {
        public Excel_hullWhiteOneFactor() { }
        public Excel_hullWhiteOneFactor(XmlNode xmlNode)
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
                        XsdTypeToken ob = new XsdTypeToken(currentValueNode);
                        IDManager.SetID(currentValueIDRef_, ob);
                    }
                    else if (currentValueNode.Attributes["href"] != null)
                    {
                        currentValueIDRef_ = currentValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currentValue_ = new XsdTypeToken(currentValueNode);
                    }
                }
                else
                {
                    currentValue_ = new XsdTypeToken(currentValueNode);
                }
            }
            
        
            XmlNode alphaNode = xmlNode.SelectSingleNode("alpha");
            
            if (alphaNode != null)
            {
                if (alphaNode.Attributes["href"] != null || alphaNode.Attributes["id"] != null) 
                {
                    if (alphaNode.Attributes["id"] != null) 
                    {
                        alphaIDRef_ = alphaNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(alphaNode);
                        IDManager.SetID(alphaIDRef_, ob);
                    }
                    else if (alphaNode.Attributes["href"] != null)
                    {
                        alphaIDRef_ = alphaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        alpha_ = new XsdTypeToken(alphaNode);
                    }
                }
                else
                {
                    alpha_ = new XsdTypeToken(alphaNode);
                }
            }
            
        
            XmlNode volatilityNode = xmlNode.SelectSingleNode("volatility");
            
            if (volatilityNode != null)
            {
                if (volatilityNode.Attributes["href"] != null || volatilityNode.Attributes["id"] != null) 
                {
                    if (volatilityNode.Attributes["id"] != null) 
                    {
                        volatilityIDRef_ = volatilityNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(volatilityNode);
                        IDManager.SetID(volatilityIDRef_, ob);
                    }
                    else if (volatilityNode.Attributes["href"] != null)
                    {
                        volatilityIDRef_ = volatilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatility_ = new XsdTypeToken(volatilityNode);
                    }
                }
                else
                {
                    volatility_ = new XsdTypeToken(volatilityNode);
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
                        XsdTypeToken ob = new XsdTypeToken(tenorNode);
                        IDManager.SetID(tenorIDRef_, ob);
                    }
                    else if (tenorNode.Attributes["href"] != null)
                    {
                        tenorIDRef_ = tenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenor_ = new XsdTypeToken(tenorNode);
                    }
                }
                else
                {
                    tenor_ = new XsdTypeToken(tenorNode);
                }
            }
            
        
            XmlNode fittingYieldCurveNameNode = xmlNode.SelectSingleNode("fittingYieldCurveName");
            
            if (fittingYieldCurveNameNode != null)
            {
                if (fittingYieldCurveNameNode.Attributes["href"] != null || fittingYieldCurveNameNode.Attributes["id"] != null) 
                {
                    if (fittingYieldCurveNameNode.Attributes["id"] != null) 
                    {
                        fittingYieldCurveNameIDRef_ = fittingYieldCurveNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fittingYieldCurveNameNode);
                        IDManager.SetID(fittingYieldCurveNameIDRef_, ob);
                    }
                    else if (fittingYieldCurveNameNode.Attributes["href"] != null)
                    {
                        fittingYieldCurveNameIDRef_ = fittingYieldCurveNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fittingYieldCurveName_ = new XsdTypeToken(fittingYieldCurveNameNode);
                    }
                }
                else
                {
                    fittingYieldCurveName_ = new XsdTypeToken(fittingYieldCurveNameNode);
                }
            }
            
        
        }
        
    
        #region CurrentValue_
        private XsdTypeToken currentValue_;
        public XsdTypeToken CurrentValue_
        {
            get
            {
                if (this.currentValue_ != null)
                {
                    return this.currentValue_; 
                }
                else if (this.currentValueIDRef_ != null)
                {
                    currentValue_ = IDManager.getID(currentValueIDRef_) as XsdTypeToken;
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
        #region Alpha_
        private XsdTypeToken alpha_;
        public XsdTypeToken Alpha_
        {
            get
            {
                if (this.alpha_ != null)
                {
                    return this.alpha_; 
                }
                else if (this.alphaIDRef_ != null)
                {
                    alpha_ = IDManager.getID(alphaIDRef_) as XsdTypeToken;
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
        #region Volatility_
        private XsdTypeToken volatility_;
        public XsdTypeToken Volatility_
        {
            get
            {
                if (this.volatility_ != null)
                {
                    return this.volatility_; 
                }
                else if (this.volatilityIDRef_ != null)
                {
                    volatility_ = IDManager.getID(volatilityIDRef_) as XsdTypeToken;
                    return this.volatility_; 
                }
                else
                {
                    throw new Exception( "volatility_Node no exist!");
                }
            }
            set
            {
                if (this.volatility_ != value)
                {
                    this.volatility_ = value;
                }
            }
        }
        #endregion
        
        public string volatilityIDRef_ { get; set; }
        #region Tenor_
        private XsdTypeToken tenor_;
        public XsdTypeToken Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    tenor_ = IDManager.getID(tenorIDRef_) as XsdTypeToken;
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
        #region FittingYieldCurveName_
        private XsdTypeToken fittingYieldCurveName_;
        public XsdTypeToken FittingYieldCurveName_
        {
            get
            {
                if (this.fittingYieldCurveName_ != null)
                {
                    return this.fittingYieldCurveName_; 
                }
                else if (this.fittingYieldCurveNameIDRef_ != null)
                {
                    fittingYieldCurveName_ = IDManager.getID(fittingYieldCurveNameIDRef_) as XsdTypeToken;
                    return this.fittingYieldCurveName_; 
                }
                else
                {
                    throw new Exception( "fittingYieldCurveName_Node no exist!");
                }
            }
            set
            {
                if (this.fittingYieldCurveName_ != value)
                {
                    this.fittingYieldCurveName_ = value;
                }
            }
        }
        #endregion
        
        public string fittingYieldCurveNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

