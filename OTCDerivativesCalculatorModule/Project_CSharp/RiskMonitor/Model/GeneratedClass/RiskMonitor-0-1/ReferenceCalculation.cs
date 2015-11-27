using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceCalculation : ISerialized
    {
        public ReferenceCalculation() { }
        public ReferenceCalculation(XmlNode xmlNode)
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
            
        
            XmlNode fixingInformationNode = xmlNode.SelectSingleNode("fixingInformation");
            
            if (fixingInformationNode != null)
            {
                if (fixingInformationNode.Attributes["href"] != null || fixingInformationNode.Attributes["id"] != null) 
                {
                    if (fixingInformationNode.Attributes["id"] != null) 
                    {
                        fixingInformationIDRef_ = fixingInformationNode.Attributes["id"].Value;
                        FixingInformation ob = new FixingInformation(fixingInformationNode);
                        IDManager.SetID(fixingInformationIDRef_, ob);
                    }
                    else if (fixingInformationNode.Attributes["href"] != null)
                    {
                        fixingInformationIDRef_ = fixingInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingInformation_ = new FixingInformation(fixingInformationNode);
                    }
                }
                else
                {
                    fixingInformation_ = new FixingInformation(fixingInformationNode);
                }
            }
            
        
            XmlNode choiceReferenceCalNode = xmlNode.SelectSingleNode("choiceReferenceCal");
            
            if (choiceReferenceCalNode != null)
            {
                if (choiceReferenceCalNode.Attributes["href"] != null || choiceReferenceCalNode.Attributes["id"] != null) 
                {
                    if (choiceReferenceCalNode.Attributes["id"] != null) 
                    {
                        choiceReferenceCalIDRef_ = choiceReferenceCalNode.Attributes["id"].Value;
                        ChoiceReferenceCal ob = new ChoiceReferenceCal(choiceReferenceCalNode);
                        IDManager.SetID(choiceReferenceCalIDRef_, ob);
                    }
                    else if (choiceReferenceCalNode.Attributes["href"] != null)
                    {
                        choiceReferenceCalIDRef_ = choiceReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        choiceReferenceCal_ = new ChoiceReferenceCal(choiceReferenceCalNode);
                    }
                }
                else
                {
                    choiceReferenceCal_ = new ChoiceReferenceCal(choiceReferenceCalNode);
                }
            }
            
        
            XmlNode identityReferenceCalNode = xmlNode.SelectSingleNode("identityReferenceCal");
            
            if (identityReferenceCalNode != null)
            {
                if (identityReferenceCalNode.Attributes["href"] != null || identityReferenceCalNode.Attributes["id"] != null) 
                {
                    if (identityReferenceCalNode.Attributes["id"] != null) 
                    {
                        identityReferenceCalIDRef_ = identityReferenceCalNode.Attributes["id"].Value;
                        IdentityReferenceCal ob = new IdentityReferenceCal(identityReferenceCalNode);
                        IDManager.SetID(identityReferenceCalIDRef_, ob);
                    }
                    else if (identityReferenceCalNode.Attributes["href"] != null)
                    {
                        identityReferenceCalIDRef_ = identityReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        identityReferenceCal_ = new IdentityReferenceCal(identityReferenceCalNode);
                    }
                }
                else
                {
                    identityReferenceCal_ = new IdentityReferenceCal(identityReferenceCalNode);
                }
            }
            
        
            XmlNode maximumReferenceCalNode = xmlNode.SelectSingleNode("maximumReferenceCal");
            
            if (maximumReferenceCalNode != null)
            {
                if (maximumReferenceCalNode.Attributes["href"] != null || maximumReferenceCalNode.Attributes["id"] != null) 
                {
                    if (maximumReferenceCalNode.Attributes["id"] != null) 
                    {
                        maximumReferenceCalIDRef_ = maximumReferenceCalNode.Attributes["id"].Value;
                        MaximumReferenceCal ob = new MaximumReferenceCal(maximumReferenceCalNode);
                        IDManager.SetID(maximumReferenceCalIDRef_, ob);
                    }
                    else if (maximumReferenceCalNode.Attributes["href"] != null)
                    {
                        maximumReferenceCalIDRef_ = maximumReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumReferenceCal_ = new MaximumReferenceCal(maximumReferenceCalNode);
                    }
                }
                else
                {
                    maximumReferenceCal_ = new MaximumReferenceCal(maximumReferenceCalNode);
                }
            }
            
        
            XmlNode minimumReferenceCalNode = xmlNode.SelectSingleNode("minimumReferenceCal");
            
            if (minimumReferenceCalNode != null)
            {
                if (minimumReferenceCalNode.Attributes["href"] != null || minimumReferenceCalNode.Attributes["id"] != null) 
                {
                    if (minimumReferenceCalNode.Attributes["id"] != null) 
                    {
                        minimumReferenceCalIDRef_ = minimumReferenceCalNode.Attributes["id"].Value;
                        MinimumReferenceCal ob = new MinimumReferenceCal(minimumReferenceCalNode);
                        IDManager.SetID(minimumReferenceCalIDRef_, ob);
                    }
                    else if (minimumReferenceCalNode.Attributes["href"] != null)
                    {
                        minimumReferenceCalIDRef_ = minimumReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumReferenceCal_ = new MinimumReferenceCal(minimumReferenceCalNode);
                    }
                }
                else
                {
                    minimumReferenceCal_ = new MinimumReferenceCal(minimumReferenceCalNode);
                }
            }
            
        
            XmlNode refVariableReferenceCalNode = xmlNode.SelectSingleNode("refVariableReferenceCal");
            
            if (refVariableReferenceCalNode != null)
            {
                if (refVariableReferenceCalNode.Attributes["href"] != null || refVariableReferenceCalNode.Attributes["id"] != null) 
                {
                    if (refVariableReferenceCalNode.Attributes["id"] != null) 
                    {
                        refVariableReferenceCalIDRef_ = refVariableReferenceCalNode.Attributes["id"].Value;
                        RefVariableReferenceCal ob = new RefVariableReferenceCal(refVariableReferenceCalNode);
                        IDManager.SetID(refVariableReferenceCalIDRef_, ob);
                    }
                    else if (refVariableReferenceCalNode.Attributes["href"] != null)
                    {
                        refVariableReferenceCalIDRef_ = refVariableReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariableReferenceCal_ = new RefVariableReferenceCal(refVariableReferenceCalNode);
                    }
                }
                else
                {
                    refVariableReferenceCal_ = new RefVariableReferenceCal(refVariableReferenceCalNode);
                }
            }
            
        
            XmlNode dailyReturnReferenceCalNode = xmlNode.SelectSingleNode("dailyReturnReferenceCal");
            
            if (dailyReturnReferenceCalNode != null)
            {
                if (dailyReturnReferenceCalNode.Attributes["href"] != null || dailyReturnReferenceCalNode.Attributes["id"] != null) 
                {
                    if (dailyReturnReferenceCalNode.Attributes["id"] != null) 
                    {
                        dailyReturnReferenceCalIDRef_ = dailyReturnReferenceCalNode.Attributes["id"].Value;
                        DailyReturnReferenceCal ob = new DailyReturnReferenceCal(dailyReturnReferenceCalNode);
                        IDManager.SetID(dailyReturnReferenceCalIDRef_, ob);
                    }
                    else if (dailyReturnReferenceCalNode.Attributes["href"] != null)
                    {
                        dailyReturnReferenceCalIDRef_ = dailyReturnReferenceCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dailyReturnReferenceCal_ = new DailyReturnReferenceCal(dailyReturnReferenceCalNode);
                    }
                }
                else
                {
                    dailyReturnReferenceCal_ = new DailyReturnReferenceCal(dailyReturnReferenceCalNode);
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
            
        
            XmlNode refVariable_referenceValueNode = xmlNode.SelectSingleNode("refVariable_referenceValue");
            
            if (refVariable_referenceValueNode != null)
            {
                if (refVariable_referenceValueNode.Attributes["href"] != null || refVariable_referenceValueNode.Attributes["id"] != null) 
                {
                    if (refVariable_referenceValueNode.Attributes["id"] != null) 
                    {
                        refVariable_referenceValueIDRef_ = refVariable_referenceValueNode.Attributes["id"].Value;
                        RefVariable_referenceValue ob = new RefVariable_referenceValue(refVariable_referenceValueNode);
                        IDManager.SetID(refVariable_referenceValueIDRef_, ob);
                    }
                    else if (refVariable_referenceValueNode.Attributes["href"] != null)
                    {
                        refVariable_referenceValueIDRef_ = refVariable_referenceValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refVariable_referenceValue_ = new RefVariable_referenceValue(refVariable_referenceValueNode);
                    }
                }
                else
                {
                    refVariable_referenceValue_ = new RefVariable_referenceValue(refVariable_referenceValueNode);
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
        #region FixingInformation_
        private FixingInformation fixingInformation_;
        public FixingInformation FixingInformation_
        {
            get
            {
                if (this.fixingInformation_ != null)
                {
                    return this.fixingInformation_; 
                }
                else if (this.fixingInformationIDRef_ != null)
                {
                    fixingInformation_ = IDManager.getID(fixingInformationIDRef_) as FixingInformation;
                    return this.fixingInformation_; 
                }
                else
                {
                    throw new Exception( "fixingInformation_Node no exist!");
                }
            }
            set
            {
                if (this.fixingInformation_ != value)
                {
                    this.fixingInformation_ = value;
                }
            }
        }
        #endregion
        
        public string fixingInformationIDRef_ { get; set; }
        #region ChoiceReferenceCal_
        private ChoiceReferenceCal choiceReferenceCal_;
        public ChoiceReferenceCal ChoiceReferenceCal_
        {
            get
            {
                if (this.choiceReferenceCal_ != null)
                {
                    return this.choiceReferenceCal_; 
                }
                else if (this.choiceReferenceCalIDRef_ != null)
                {
                    choiceReferenceCal_ = IDManager.getID(choiceReferenceCalIDRef_) as ChoiceReferenceCal;
                    return this.choiceReferenceCal_; 
                }
                else
                {
                    throw new Exception( "choiceReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.choiceReferenceCal_ != value)
                {
                    this.choiceReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string choiceReferenceCalIDRef_ { get; set; }
        #region IdentityReferenceCal_
        private IdentityReferenceCal identityReferenceCal_;
        public IdentityReferenceCal IdentityReferenceCal_
        {
            get
            {
                if (this.identityReferenceCal_ != null)
                {
                    return this.identityReferenceCal_; 
                }
                else if (this.identityReferenceCalIDRef_ != null)
                {
                    identityReferenceCal_ = IDManager.getID(identityReferenceCalIDRef_) as IdentityReferenceCal;
                    return this.identityReferenceCal_; 
                }
                else
                {
                    throw new Exception( "identityReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.identityReferenceCal_ != value)
                {
                    this.identityReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string identityReferenceCalIDRef_ { get; set; }
        #region MaximumReferenceCal_
        private MaximumReferenceCal maximumReferenceCal_;
        public MaximumReferenceCal MaximumReferenceCal_
        {
            get
            {
                if (this.maximumReferenceCal_ != null)
                {
                    return this.maximumReferenceCal_; 
                }
                else if (this.maximumReferenceCalIDRef_ != null)
                {
                    maximumReferenceCal_ = IDManager.getID(maximumReferenceCalIDRef_) as MaximumReferenceCal;
                    return this.maximumReferenceCal_; 
                }
                else
                {
                    throw new Exception( "maximumReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.maximumReferenceCal_ != value)
                {
                    this.maximumReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string maximumReferenceCalIDRef_ { get; set; }
        #region MinimumReferenceCal_
        private MinimumReferenceCal minimumReferenceCal_;
        public MinimumReferenceCal MinimumReferenceCal_
        {
            get
            {
                if (this.minimumReferenceCal_ != null)
                {
                    return this.minimumReferenceCal_; 
                }
                else if (this.minimumReferenceCalIDRef_ != null)
                {
                    minimumReferenceCal_ = IDManager.getID(minimumReferenceCalIDRef_) as MinimumReferenceCal;
                    return this.minimumReferenceCal_; 
                }
                else
                {
                    throw new Exception( "minimumReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.minimumReferenceCal_ != value)
                {
                    this.minimumReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string minimumReferenceCalIDRef_ { get; set; }
        #region RefVariableReferenceCal_
        private RefVariableReferenceCal refVariableReferenceCal_;
        public RefVariableReferenceCal RefVariableReferenceCal_
        {
            get
            {
                if (this.refVariableReferenceCal_ != null)
                {
                    return this.refVariableReferenceCal_; 
                }
                else if (this.refVariableReferenceCalIDRef_ != null)
                {
                    refVariableReferenceCal_ = IDManager.getID(refVariableReferenceCalIDRef_) as RefVariableReferenceCal;
                    return this.refVariableReferenceCal_; 
                }
                else
                {
                    throw new Exception( "refVariableReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.refVariableReferenceCal_ != value)
                {
                    this.refVariableReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string refVariableReferenceCalIDRef_ { get; set; }
        #region DailyReturnReferenceCal_
        private DailyReturnReferenceCal dailyReturnReferenceCal_;
        public DailyReturnReferenceCal DailyReturnReferenceCal_
        {
            get
            {
                if (this.dailyReturnReferenceCal_ != null)
                {
                    return this.dailyReturnReferenceCal_; 
                }
                else if (this.dailyReturnReferenceCalIDRef_ != null)
                {
                    dailyReturnReferenceCal_ = IDManager.getID(dailyReturnReferenceCalIDRef_) as DailyReturnReferenceCal;
                    return this.dailyReturnReferenceCal_; 
                }
                else
                {
                    throw new Exception( "dailyReturnReferenceCal_Node no exist!");
                }
            }
            set
            {
                if (this.dailyReturnReferenceCal_ != value)
                {
                    this.dailyReturnReferenceCal_ = value;
                }
            }
        }
        #endregion
        
        public string dailyReturnReferenceCalIDRef_ { get; set; }
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
        #region RefVariable_referenceValue_
        private RefVariable_referenceValue refVariable_referenceValue_;
        public RefVariable_referenceValue RefVariable_referenceValue_
        {
            get
            {
                if (this.refVariable_referenceValue_ != null)
                {
                    return this.refVariable_referenceValue_; 
                }
                else if (this.refVariable_referenceValueIDRef_ != null)
                {
                    refVariable_referenceValue_ = IDManager.getID(refVariable_referenceValueIDRef_) as RefVariable_referenceValue;
                    return this.refVariable_referenceValue_; 
                }
                else
                {
                    throw new Exception( "refVariable_referenceValue_Node no exist!");
                }
            }
            set
            {
                if (this.refVariable_referenceValue_ != value)
                {
                    this.refVariable_referenceValue_ = value;
                }
            }
        }
        #endregion
        
        public string refVariable_referenceValueIDRef_ { get; set; }
        public string choiceStr_referenceCalType;
        
    
        
    
    }
    
}

