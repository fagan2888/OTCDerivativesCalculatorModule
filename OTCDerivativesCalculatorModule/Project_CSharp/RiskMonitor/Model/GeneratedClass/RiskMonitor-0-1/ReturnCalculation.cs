using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnCalculation : ISerialized
    {
        public ReturnCalculation() { }
        public ReturnCalculation(XmlNode xmlNode)
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
            
        
            XmlNode preCalculationNode = xmlNode.SelectSingleNode("preCalculation");
            
            if (preCalculationNode != null)
            {
                if (preCalculationNode.Attributes["href"] != null || preCalculationNode.Attributes["id"] != null) 
                {
                    if (preCalculationNode.Attributes["id"] != null) 
                    {
                        preCalculationIDRef_ = preCalculationNode.Attributes["id"].Value;
                        PreCalculation ob = new PreCalculation(preCalculationNode);
                        IDManager.SetID(preCalculationIDRef_, ob);
                    }
                    else if (preCalculationNode.Attributes["href"] != null)
                    {
                        preCalculationIDRef_ = preCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preCalculation_ = new PreCalculation(preCalculationNode);
                    }
                }
                else
                {
                    preCalculation_ = new PreCalculation(preCalculationNode);
                }
            }
            
        
            XmlNode stopLossReturnCalNode = xmlNode.SelectSingleNode("stopLossReturnCal");
            
            if (stopLossReturnCalNode != null)
            {
                if (stopLossReturnCalNode.Attributes["href"] != null || stopLossReturnCalNode.Attributes["id"] != null) 
                {
                    if (stopLossReturnCalNode.Attributes["id"] != null) 
                    {
                        stopLossReturnCalIDRef_ = stopLossReturnCalNode.Attributes["id"].Value;
                        StopLossReturnCal ob = new StopLossReturnCal(stopLossReturnCalNode);
                        IDManager.SetID(stopLossReturnCalIDRef_, ob);
                    }
                    else if (stopLossReturnCalNode.Attributes["href"] != null)
                    {
                        stopLossReturnCalIDRef_ = stopLossReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stopLossReturnCal_ = new StopLossReturnCal(stopLossReturnCalNode);
                    }
                }
                else
                {
                    stopLossReturnCal_ = new StopLossReturnCal(stopLossReturnCalNode);
                }
            }
            
        
            XmlNode constReturnCalNode = xmlNode.SelectSingleNode("constReturnCal");
            
            if (constReturnCalNode != null)
            {
                if (constReturnCalNode.Attributes["href"] != null || constReturnCalNode.Attributes["id"] != null) 
                {
                    if (constReturnCalNode.Attributes["id"] != null) 
                    {
                        constReturnCalIDRef_ = constReturnCalNode.Attributes["id"].Value;
                        ConstReturnCal ob = new ConstReturnCal(constReturnCalNode);
                        IDManager.SetID(constReturnCalIDRef_, ob);
                    }
                    else if (constReturnCalNode.Attributes["href"] != null)
                    {
                        constReturnCalIDRef_ = constReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constReturnCal_ = new ConstReturnCal(constReturnCalNode);
                    }
                }
                else
                {
                    constReturnCal_ = new ConstReturnCal(constReturnCalNode);
                }
            }
            
        
            XmlNode vanillaReturnCalNode = xmlNode.SelectSingleNode("vanillaReturnCal");
            
            if (vanillaReturnCalNode != null)
            {
                if (vanillaReturnCalNode.Attributes["href"] != null || vanillaReturnCalNode.Attributes["id"] != null) 
                {
                    if (vanillaReturnCalNode.Attributes["id"] != null) 
                    {
                        vanillaReturnCalIDRef_ = vanillaReturnCalNode.Attributes["id"].Value;
                        VanillaReturnCal ob = new VanillaReturnCal(vanillaReturnCalNode);
                        IDManager.SetID(vanillaReturnCalIDRef_, ob);
                    }
                    else if (vanillaReturnCalNode.Attributes["href"] != null)
                    {
                        vanillaReturnCalIDRef_ = vanillaReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaReturnCal_ = new VanillaReturnCal(vanillaReturnCalNode);
                    }
                }
                else
                {
                    vanillaReturnCal_ = new VanillaReturnCal(vanillaReturnCalNode);
                }
            }
            
        
            XmlNode complex1DReturnCalNode = xmlNode.SelectSingleNode("complex1DReturnCal");
            
            if (complex1DReturnCalNode != null)
            {
                if (complex1DReturnCalNode.Attributes["href"] != null || complex1DReturnCalNode.Attributes["id"] != null) 
                {
                    if (complex1DReturnCalNode.Attributes["id"] != null) 
                    {
                        complex1DReturnCalIDRef_ = complex1DReturnCalNode.Attributes["id"].Value;
                        Complex1DReturnCal ob = new Complex1DReturnCal(complex1DReturnCalNode);
                        IDManager.SetID(complex1DReturnCalIDRef_, ob);
                    }
                    else if (complex1DReturnCalNode.Attributes["href"] != null)
                    {
                        complex1DReturnCalIDRef_ = complex1DReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        complex1DReturnCal_ = new Complex1DReturnCal(complex1DReturnCalNode);
                    }
                }
                else
                {
                    complex1DReturnCal_ = new Complex1DReturnCal(complex1DReturnCalNode);
                }
            }
            
        
            XmlNode complexNDReturnCalNode = xmlNode.SelectSingleNode("complexNDReturnCal");
            
            if (complexNDReturnCalNode != null)
            {
                if (complexNDReturnCalNode.Attributes["href"] != null || complexNDReturnCalNode.Attributes["id"] != null) 
                {
                    if (complexNDReturnCalNode.Attributes["id"] != null) 
                    {
                        complexNDReturnCalIDRef_ = complexNDReturnCalNode.Attributes["id"].Value;
                        ComplexNDReturnCal ob = new ComplexNDReturnCal(complexNDReturnCalNode);
                        IDManager.SetID(complexNDReturnCalIDRef_, ob);
                    }
                    else if (complexNDReturnCalNode.Attributes["href"] != null)
                    {
                        complexNDReturnCalIDRef_ = complexNDReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        complexNDReturnCal_ = new ComplexNDReturnCal(complexNDReturnCalNode);
                    }
                }
                else
                {
                    complexNDReturnCal_ = new ComplexNDReturnCal(complexNDReturnCalNode);
                }
            }
            
        
            XmlNode zeroReturnCalNode = xmlNode.SelectSingleNode("zeroReturnCal");
            
            if (zeroReturnCalNode != null)
            {
                if (zeroReturnCalNode.Attributes["href"] != null || zeroReturnCalNode.Attributes["id"] != null) 
                {
                    if (zeroReturnCalNode.Attributes["id"] != null) 
                    {
                        zeroReturnCalIDRef_ = zeroReturnCalNode.Attributes["id"].Value;
                        ZeroReturnCal ob = new ZeroReturnCal(zeroReturnCalNode);
                        IDManager.SetID(zeroReturnCalIDRef_, ob);
                    }
                    else if (zeroReturnCalNode.Attributes["href"] != null)
                    {
                        zeroReturnCalIDRef_ = zeroReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        zeroReturnCal_ = new ZeroReturnCal(zeroReturnCalNode);
                    }
                }
                else
                {
                    zeroReturnCal_ = new ZeroReturnCal(zeroReturnCalNode);
                }
            }
            
        
            XmlNode callPutCompositeReturnCalNode = xmlNode.SelectSingleNode("callPutCompositeReturnCal");
            
            if (callPutCompositeReturnCalNode != null)
            {
                if (callPutCompositeReturnCalNode.Attributes["href"] != null || callPutCompositeReturnCalNode.Attributes["id"] != null) 
                {
                    if (callPutCompositeReturnCalNode.Attributes["id"] != null) 
                    {
                        callPutCompositeReturnCalIDRef_ = callPutCompositeReturnCalNode.Attributes["id"].Value;
                        CallPutCompositeReturnCal ob = new CallPutCompositeReturnCal(callPutCompositeReturnCalNode);
                        IDManager.SetID(callPutCompositeReturnCalIDRef_, ob);
                    }
                    else if (callPutCompositeReturnCalNode.Attributes["href"] != null)
                    {
                        callPutCompositeReturnCalIDRef_ = callPutCompositeReturnCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        callPutCompositeReturnCal_ = new CallPutCompositeReturnCal(callPutCompositeReturnCalNode);
                    }
                }
                else
                {
                    callPutCompositeReturnCal_ = new CallPutCompositeReturnCal(callPutCompositeReturnCalNode);
                }
            }
            
        
            XmlNode postCalculationNode = xmlNode.SelectSingleNode("postCalculation");
            
            if (postCalculationNode != null)
            {
                if (postCalculationNode.Attributes["href"] != null || postCalculationNode.Attributes["id"] != null) 
                {
                    if (postCalculationNode.Attributes["id"] != null) 
                    {
                        postCalculationIDRef_ = postCalculationNode.Attributes["id"].Value;
                        PostCalculation ob = new PostCalculation(postCalculationNode);
                        IDManager.SetID(postCalculationIDRef_, ob);
                    }
                    else if (postCalculationNode.Attributes["href"] != null)
                    {
                        postCalculationIDRef_ = postCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        postCalculation_ = new PostCalculation(postCalculationNode);
                    }
                }
                else
                {
                    postCalculation_ = new PostCalculation(postCalculationNode);
                }
            }
            
        
            XmlNode refVariable_returnValueNode = xmlNode.SelectSingleNode("refVariable_returnValue");
            
            if (refVariable_returnValueNode != null)
            {
                if (refVariable_returnValueNode.Attributes["href"] != null || refVariable_returnValueNode.Attributes["id"] != null) 
                {
                    if (refVariable_returnValueNode.Attributes["id"] != null) 
                    {
                        refVariable_returnValueIDRef_ = refVariable_returnValueNode.Attributes["id"].Value;
                        RefVariable_returnValue ob = new RefVariable_returnValue(refVariable_returnValueNode);
                        IDManager.SetID(refVariable_returnValueIDRef_, ob);
                    }
                    else if (refVariable_returnValueNode.Attributes["href"] != null)
                    {
                        refVariable_returnValueIDRef_ = refVariable_returnValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariable_returnValue_ = new RefVariable_returnValue(refVariable_returnValueNode);
                    }
                }
                else
                {
                    refVariable_returnValue_ = new RefVariable_returnValue(refVariable_returnValueNode);
                }
            }
            
        
            XmlNode resetVariableInfoNode = xmlNode.SelectSingleNode("resetVariableInfo");
            
            if (resetVariableInfoNode != null)
            {
                if (resetVariableInfoNode.Attributes["href"] != null || resetVariableInfoNode.Attributes["id"] != null) 
                {
                    if (resetVariableInfoNode.Attributes["id"] != null) 
                    {
                        resetVariableInfoIDRef_ = resetVariableInfoNode.Attributes["id"].Value;
                        ResetVariableInfo ob = new ResetVariableInfo(resetVariableInfoNode);
                        IDManager.SetID(resetVariableInfoIDRef_, ob);
                    }
                    else if (resetVariableInfoNode.Attributes["href"] != null)
                    {
                        resetVariableInfoIDRef_ = resetVariableInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetVariableInfo_ = new ResetVariableInfo(resetVariableInfoNode);
                    }
                }
                else
                {
                    resetVariableInfo_ = new ResetVariableInfo(resetVariableInfoNode);
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
        #region PreCalculation_
        private PreCalculation preCalculation_;
        public PreCalculation PreCalculation_
        {
            get
            {
                if (this.preCalculation_ != null)
                {
                    return this.preCalculation_; 
                }
                else if (this.preCalculationIDRef_ != null)
                {
                    preCalculation_ = IDManager.getID(preCalculationIDRef_) as PreCalculation;
                    return this.preCalculation_; 
                }
                else
                {
                    throw new Exception( "preCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.preCalculation_ != value)
                {
                    this.preCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string preCalculationIDRef_ { get; set; }
        #region StopLossReturnCal_
        private StopLossReturnCal stopLossReturnCal_;
        public StopLossReturnCal StopLossReturnCal_
        {
            get
            {
                if (this.stopLossReturnCal_ != null)
                {
                    return this.stopLossReturnCal_; 
                }
                else if (this.stopLossReturnCalIDRef_ != null)
                {
                    stopLossReturnCal_ = IDManager.getID(stopLossReturnCalIDRef_) as StopLossReturnCal;
                    return this.stopLossReturnCal_; 
                }
                else
                {
                    throw new Exception( "stopLossReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.stopLossReturnCal_ != value)
                {
                    this.stopLossReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string stopLossReturnCalIDRef_ { get; set; }
        #region ConstReturnCal_
        private ConstReturnCal constReturnCal_;
        public ConstReturnCal ConstReturnCal_
        {
            get
            {
                if (this.constReturnCal_ != null)
                {
                    return this.constReturnCal_; 
                }
                else if (this.constReturnCalIDRef_ != null)
                {
                    constReturnCal_ = IDManager.getID(constReturnCalIDRef_) as ConstReturnCal;
                    return this.constReturnCal_; 
                }
                else
                {
                    throw new Exception( "constReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.constReturnCal_ != value)
                {
                    this.constReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string constReturnCalIDRef_ { get; set; }
        #region VanillaReturnCal_
        private VanillaReturnCal vanillaReturnCal_;
        public VanillaReturnCal VanillaReturnCal_
        {
            get
            {
                if (this.vanillaReturnCal_ != null)
                {
                    return this.vanillaReturnCal_; 
                }
                else if (this.vanillaReturnCalIDRef_ != null)
                {
                    vanillaReturnCal_ = IDManager.getID(vanillaReturnCalIDRef_) as VanillaReturnCal;
                    return this.vanillaReturnCal_; 
                }
                else
                {
                    throw new Exception( "vanillaReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaReturnCal_ != value)
                {
                    this.vanillaReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaReturnCalIDRef_ { get; set; }
        #region Complex1DReturnCal_
        private Complex1DReturnCal complex1DReturnCal_;
        public Complex1DReturnCal Complex1DReturnCal_
        {
            get
            {
                if (this.complex1DReturnCal_ != null)
                {
                    return this.complex1DReturnCal_; 
                }
                else if (this.complex1DReturnCalIDRef_ != null)
                {
                    complex1DReturnCal_ = IDManager.getID(complex1DReturnCalIDRef_) as Complex1DReturnCal;
                    return this.complex1DReturnCal_; 
                }
                else
                {
                    throw new Exception( "complex1DReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.complex1DReturnCal_ != value)
                {
                    this.complex1DReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string complex1DReturnCalIDRef_ { get; set; }
        #region ComplexNDReturnCal_
        private ComplexNDReturnCal complexNDReturnCal_;
        public ComplexNDReturnCal ComplexNDReturnCal_
        {
            get
            {
                if (this.complexNDReturnCal_ != null)
                {
                    return this.complexNDReturnCal_; 
                }
                else if (this.complexNDReturnCalIDRef_ != null)
                {
                    complexNDReturnCal_ = IDManager.getID(complexNDReturnCalIDRef_) as ComplexNDReturnCal;
                    return this.complexNDReturnCal_; 
                }
                else
                {
                    throw new Exception( "complexNDReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.complexNDReturnCal_ != value)
                {
                    this.complexNDReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string complexNDReturnCalIDRef_ { get; set; }
        #region ZeroReturnCal_
        private ZeroReturnCal zeroReturnCal_;
        public ZeroReturnCal ZeroReturnCal_
        {
            get
            {
                if (this.zeroReturnCal_ != null)
                {
                    return this.zeroReturnCal_; 
                }
                else if (this.zeroReturnCalIDRef_ != null)
                {
                    zeroReturnCal_ = IDManager.getID(zeroReturnCalIDRef_) as ZeroReturnCal;
                    return this.zeroReturnCal_; 
                }
                else
                {
                    throw new Exception( "zeroReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.zeroReturnCal_ != value)
                {
                    this.zeroReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string zeroReturnCalIDRef_ { get; set; }
        #region CallPutCompositeReturnCal_
        private CallPutCompositeReturnCal callPutCompositeReturnCal_;
        public CallPutCompositeReturnCal CallPutCompositeReturnCal_
        {
            get
            {
                if (this.callPutCompositeReturnCal_ != null)
                {
                    return this.callPutCompositeReturnCal_; 
                }
                else if (this.callPutCompositeReturnCalIDRef_ != null)
                {
                    callPutCompositeReturnCal_ = IDManager.getID(callPutCompositeReturnCalIDRef_) as CallPutCompositeReturnCal;
                    return this.callPutCompositeReturnCal_; 
                }
                else
                {
                    throw new Exception( "callPutCompositeReturnCal_Node no exist!");
                }
            }
            set
            {
                if (this.callPutCompositeReturnCal_ != value)
                {
                    this.callPutCompositeReturnCal_ = value;
                }
            }
        }
        #endregion
        
        public string callPutCompositeReturnCalIDRef_ { get; set; }
        #region PostCalculation_
        private PostCalculation postCalculation_;
        public PostCalculation PostCalculation_
        {
            get
            {
                if (this.postCalculation_ != null)
                {
                    return this.postCalculation_; 
                }
                else if (this.postCalculationIDRef_ != null)
                {
                    postCalculation_ = IDManager.getID(postCalculationIDRef_) as PostCalculation;
                    return this.postCalculation_; 
                }
                else
                {
                    throw new Exception( "postCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.postCalculation_ != value)
                {
                    this.postCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string postCalculationIDRef_ { get; set; }
        #region RefVariable_returnValue_
        private RefVariable_returnValue refVariable_returnValue_;
        public RefVariable_returnValue RefVariable_returnValue_
        {
            get
            {
                if (this.refVariable_returnValue_ != null)
                {
                    return this.refVariable_returnValue_; 
                }
                else if (this.refVariable_returnValueIDRef_ != null)
                {
                    refVariable_returnValue_ = IDManager.getID(refVariable_returnValueIDRef_) as RefVariable_returnValue;
                    return this.refVariable_returnValue_; 
                }
                else
                {
                    throw new Exception( "refVariable_returnValue_Node no exist!");
                }
            }
            set
            {
                if (this.refVariable_returnValue_ != value)
                {
                    this.refVariable_returnValue_ = value;
                }
            }
        }
        #endregion
        
        public string refVariable_returnValueIDRef_ { get; set; }
        #region ResetVariableInfo_
        private ResetVariableInfo resetVariableInfo_;
        public ResetVariableInfo ResetVariableInfo_
        {
            get
            {
                if (this.resetVariableInfo_ != null)
                {
                    return this.resetVariableInfo_; 
                }
                else if (this.resetVariableInfoIDRef_ != null)
                {
                    resetVariableInfo_ = IDManager.getID(resetVariableInfoIDRef_) as ResetVariableInfo;
                    return this.resetVariableInfo_; 
                }
                else
                {
                    throw new Exception( "resetVariableInfo_Node no exist!");
                }
            }
            set
            {
                if (this.resetVariableInfo_ != value)
                {
                    this.resetVariableInfo_ = value;
                }
            }
        }
        #endregion
        
        public string resetVariableInfoIDRef_ { get; set; }
        public string choiceStr_returnCalType;
        
    
        
    
    }
    
}

