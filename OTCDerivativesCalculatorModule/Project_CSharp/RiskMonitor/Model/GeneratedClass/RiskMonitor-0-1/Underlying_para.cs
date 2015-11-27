using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Underlying_para : ISerialized
    {
        public Underlying_para() { }
        public Underlying_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode underNameNode = xmlNode.SelectSingleNode("underName");
            
            if (underNameNode != null)
            {
                if (underNameNode.Attributes["href"] != null || underNameNode.Attributes["id"] != null) 
                {
                    if (underNameNode.Attributes["id"] != null) 
                    {
                        underNameIDRef_ = underNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underNameNode);
                        IDManager.SetID(underNameIDRef_, ob);
                    }
                    else if (underNameNode.Attributes["href"] != null)
                    {
                        underNameIDRef_ = underNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underName_ = new XsdTypeToken(underNameNode);
                    }
                }
                else
                {
                    underName_ = new XsdTypeToken(underNameNode);
                }
            }
            
        
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeToken(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeToken(valueNode);
                }
            }
            
        
            XmlNode geometricBMNode = xmlNode.SelectSingleNode("geometricBM");
            
            if (geometricBMNode != null)
            {
                if (geometricBMNode.Attributes["href"] != null || geometricBMNode.Attributes["id"] != null) 
                {
                    if (geometricBMNode.Attributes["id"] != null) 
                    {
                        geometricBMIDRef_ = geometricBMNode.Attributes["id"].Value;
                        GeometricBM ob = new GeometricBM(geometricBMNode);
                        IDManager.SetID(geometricBMIDRef_, ob);
                    }
                    else if (geometricBMNode.Attributes["href"] != null)
                    {
                        geometricBMIDRef_ = geometricBMNode.Attributes["href"].Value;
                    }
                    else
                    {
                        geometricBM_ = new GeometricBM(geometricBMNode);
                    }
                }
                else
                {
                    geometricBM_ = new GeometricBM(geometricBMNode);
                }
            }
            
        
            XmlNode hullWhiteOneFactorNode = xmlNode.SelectSingleNode("hullWhiteOneFactor");
            
            if (hullWhiteOneFactorNode != null)
            {
                if (hullWhiteOneFactorNode.Attributes["href"] != null || hullWhiteOneFactorNode.Attributes["id"] != null) 
                {
                    if (hullWhiteOneFactorNode.Attributes["id"] != null) 
                    {
                        hullWhiteOneFactorIDRef_ = hullWhiteOneFactorNode.Attributes["id"].Value;
                        HullWhiteOneFactor ob = new HullWhiteOneFactor(hullWhiteOneFactorNode);
                        IDManager.SetID(hullWhiteOneFactorIDRef_, ob);
                    }
                    else if (hullWhiteOneFactorNode.Attributes["href"] != null)
                    {
                        hullWhiteOneFactorIDRef_ = hullWhiteOneFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hullWhiteOneFactor_ = new HullWhiteOneFactor(hullWhiteOneFactorNode);
                    }
                }
                else
                {
                    hullWhiteOneFactor_ = new HullWhiteOneFactor(hullWhiteOneFactorNode);
                }
            }
            
        
            XmlNode forwardModelNode = xmlNode.SelectSingleNode("forwardModel");
            
            if (forwardModelNode != null)
            {
                if (forwardModelNode.Attributes["href"] != null || forwardModelNode.Attributes["id"] != null) 
                {
                    if (forwardModelNode.Attributes["id"] != null) 
                    {
                        forwardModelIDRef_ = forwardModelNode.Attributes["id"].Value;
                        ForwardModel ob = new ForwardModel(forwardModelNode);
                        IDManager.SetID(forwardModelIDRef_, ob);
                    }
                    else if (forwardModelNode.Attributes["href"] != null)
                    {
                        forwardModelIDRef_ = forwardModelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardModel_ = new ForwardModel(forwardModelNode);
                    }
                }
                else
                {
                    forwardModel_ = new ForwardModel(forwardModelNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region UnderName_
        private XsdTypeToken underName_;
        public XsdTypeToken UnderName_
        {
            get
            {
                if (this.underName_ != null)
                {
                    return this.underName_; 
                }
                else if (this.underNameIDRef_ != null)
                {
                    underName_ = IDManager.getID(underNameIDRef_) as XsdTypeToken;
                    return this.underName_; 
                }
                else
                {
                    throw new Exception( "underName_Node no exist!");
                }
            }
            set
            {
                if (this.underName_ != value)
                {
                    this.underName_ = value;
                }
            }
        }
        #endregion
        
        public string underNameIDRef_ { get; set; }
        #region Value_
        private XsdTypeToken value_;
        public XsdTypeToken Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeToken;
                    return this.value_; 
                }
                else
                {
                    throw new Exception( "value_Node no exist!");
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        #region GeometricBM_
        private GeometricBM geometricBM_;
        public GeometricBM GeometricBM_
        {
            get
            {
                if (this.geometricBM_ != null)
                {
                    return this.geometricBM_; 
                }
                else if (this.geometricBMIDRef_ != null)
                {
                    geometricBM_ = IDManager.getID(geometricBMIDRef_) as GeometricBM;
                    return this.geometricBM_; 
                }
                else
                {
                    throw new Exception( "geometricBM_Node no exist!");
                }
            }
            set
            {
                if (this.geometricBM_ != value)
                {
                    this.geometricBM_ = value;
                }
            }
        }
        #endregion
        
        public string geometricBMIDRef_ { get; set; }
        #region HullWhiteOneFactor_
        private HullWhiteOneFactor hullWhiteOneFactor_;
        public HullWhiteOneFactor HullWhiteOneFactor_
        {
            get
            {
                if (this.hullWhiteOneFactor_ != null)
                {
                    return this.hullWhiteOneFactor_; 
                }
                else if (this.hullWhiteOneFactorIDRef_ != null)
                {
                    hullWhiteOneFactor_ = IDManager.getID(hullWhiteOneFactorIDRef_) as HullWhiteOneFactor;
                    return this.hullWhiteOneFactor_; 
                }
                else
                {
                    throw new Exception( "hullWhiteOneFactor_Node no exist!");
                }
            }
            set
            {
                if (this.hullWhiteOneFactor_ != value)
                {
                    this.hullWhiteOneFactor_ = value;
                }
            }
        }
        #endregion
        
        public string hullWhiteOneFactorIDRef_ { get; set; }
        #region ForwardModel_
        private ForwardModel forwardModel_;
        public ForwardModel ForwardModel_
        {
            get
            {
                if (this.forwardModel_ != null)
                {
                    return this.forwardModel_; 
                }
                else if (this.forwardModelIDRef_ != null)
                {
                    forwardModel_ = IDManager.getID(forwardModelIDRef_) as ForwardModel;
                    return this.forwardModel_; 
                }
                else
                {
                    throw new Exception( "forwardModel_Node no exist!");
                }
            }
            set
            {
                if (this.forwardModel_ != value)
                {
                    this.forwardModel_ = value;
                }
            }
        }
        #endregion
        
        public string forwardModelIDRef_ { get; set; }
        public string choiceStr_underParaType;
        
    
        
    
    }
    
}

