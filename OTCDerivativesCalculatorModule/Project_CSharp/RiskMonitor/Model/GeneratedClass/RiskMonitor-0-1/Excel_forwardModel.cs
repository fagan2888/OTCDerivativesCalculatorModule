using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_forwardModel : ISerialized
    {
        public Excel_forwardModel() { }
        public Excel_forwardModel(XmlNode xmlNode)
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

