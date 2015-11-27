using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceCalculationInfo : ISerialized
    {
        public ReferenceCalculationInfo() { }
        public ReferenceCalculationInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList referenceCalculationNodeList = xmlNode.SelectNodes("referenceCalculation");
            
            if (referenceCalculationNodeList != null)
            {
                this.referenceCalculation_ = new List<ReferenceCalculation>();
                foreach (XmlNode item in referenceCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            referenceCalculationIDRef_ = item.Attributes["id"].Value;
                            referenceCalculation_.Add(new ReferenceCalculation(item));
                            IDManager.SetID(referenceCalculationIDRef_, referenceCalculation_[referenceCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            referenceCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        referenceCalculation_.Add(new ReferenceCalculation(item));
                        }
                    }
                    else
                    {
                        referenceCalculation_.Add(new ReferenceCalculation(item));
                    }
                }
            }
            
        
            XmlNode operatorNDNode = xmlNode.SelectSingleNode("operatorND");
            
            if (operatorNDNode != null)
            {
                if (operatorNDNode.Attributes["href"] != null || operatorNDNode.Attributes["id"] != null) 
                {
                    if (operatorNDNode.Attributes["id"] != null) 
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["id"].Value;
                        OperatorND ob = new OperatorND(operatorNDNode);
                        IDManager.SetID(operatorNDIDRef_, ob);
                    }
                    else if (operatorNDNode.Attributes["href"] != null)
                    {
                        operatorNDIDRef_ = operatorNDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        operatorND_ = new OperatorND(operatorNDNode);
                    }
                }
                else
                {
                    operatorND_ = new OperatorND(operatorNDNode);
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
        #region ReferenceCalculation_
        private List<ReferenceCalculation> referenceCalculation_;
        public List<ReferenceCalculation> ReferenceCalculation_
        {
            get
            {
                if (this.referenceCalculation_ != null)
                {
                    return this.referenceCalculation_; 
                }
                else if (this.referenceCalculationIDRef_ != null)
                {
                    return this.referenceCalculation_; 
                }
                else
                {
                    throw new Exception( "referenceCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculation_ != value)
                {
                    this.referenceCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationIDRef_ { get; set; }
        #region OperatorND_
        private OperatorND operatorND_;
        public OperatorND OperatorND_
        {
            get
            {
                if (this.operatorND_ != null)
                {
                    return this.operatorND_; 
                }
                else if (this.operatorNDIDRef_ != null)
                {
                    operatorND_ = IDManager.getID(operatorNDIDRef_) as OperatorND;
                    return this.operatorND_; 
                }
                else
                {
                    throw new Exception( "operatorND_Node no exist!");
                }
            }
            set
            {
                if (this.operatorND_ != value)
                {
                    this.operatorND_ = value;
                }
            }
        }
        #endregion
        
        public string operatorNDIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

