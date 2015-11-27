using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceEntityInfo_para : ISerialized
    {
        public ReferenceEntityInfo_para() { }
        public ReferenceEntityInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode referenceCurveListNode = xmlNode.SelectSingleNode("referenceCurveList");
            
            if (referenceCurveListNode != null)
            {
                if (referenceCurveListNode.Attributes["href"] != null || referenceCurveListNode.Attributes["id"] != null) 
                {
                    if (referenceCurveListNode.Attributes["id"] != null) 
                    {
                        referenceCurveListIDRef_ = referenceCurveListNode.Attributes["id"].Value;
                        ReferenceCurveList ob = new ReferenceCurveList(referenceCurveListNode);
                        IDManager.SetID(referenceCurveListIDRef_, ob);
                    }
                    else if (referenceCurveListNode.Attributes["href"] != null)
                    {
                        referenceCurveListIDRef_ = referenceCurveListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCurveList_ = new ReferenceCurveList(referenceCurveListNode);
                    }
                }
                else
                {
                    referenceCurveList_ = new ReferenceCurveList(referenceCurveListNode);
                }
            }
            
        
            XmlNode jointProbabilityTraitNode = xmlNode.SelectSingleNode("jointProbabilityTrait");
            
            if (jointProbabilityTraitNode != null)
            {
                if (jointProbabilityTraitNode.Attributes["href"] != null || jointProbabilityTraitNode.Attributes["id"] != null) 
                {
                    if (jointProbabilityTraitNode.Attributes["id"] != null) 
                    {
                        jointProbabilityTraitIDRef_ = jointProbabilityTraitNode.Attributes["id"].Value;
                        JointProbabilityTrait ob = new JointProbabilityTrait(jointProbabilityTraitNode);
                        IDManager.SetID(jointProbabilityTraitIDRef_, ob);
                    }
                    else if (jointProbabilityTraitNode.Attributes["href"] != null)
                    {
                        jointProbabilityTraitIDRef_ = jointProbabilityTraitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointProbabilityTrait_ = new JointProbabilityTrait(jointProbabilityTraitNode);
                    }
                }
                else
                {
                    jointProbabilityTrait_ = new JointProbabilityTrait(jointProbabilityTraitNode);
                }
            }
            
        
        }
        
    
        #region ReferenceCurveList_
        private ReferenceCurveList referenceCurveList_;
        public ReferenceCurveList ReferenceCurveList_
        {
            get
            {
                if (this.referenceCurveList_ != null)
                {
                    return this.referenceCurveList_; 
                }
                else if (this.referenceCurveListIDRef_ != null)
                {
                    referenceCurveList_ = IDManager.getID(referenceCurveListIDRef_) as ReferenceCurveList;
                    return this.referenceCurveList_; 
                }
                else
                {
                    throw new Exception( "referenceCurveList_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCurveList_ != value)
                {
                    this.referenceCurveList_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCurveListIDRef_ { get; set; }
        #region JointProbabilityTrait_
        private JointProbabilityTrait jointProbabilityTrait_;
        public JointProbabilityTrait JointProbabilityTrait_
        {
            get
            {
                if (this.jointProbabilityTrait_ != null)
                {
                    return this.jointProbabilityTrait_; 
                }
                else if (this.jointProbabilityTraitIDRef_ != null)
                {
                    jointProbabilityTrait_ = IDManager.getID(jointProbabilityTraitIDRef_) as JointProbabilityTrait;
                    return this.jointProbabilityTrait_; 
                }
                else
                {
                    throw new Exception( "jointProbabilityTrait_Node no exist!");
                }
            }
            set
            {
                if (this.jointProbabilityTrait_ != value)
                {
                    this.jointProbabilityTrait_ = value;
                }
            }
        }
        #endregion
        
        public string jointProbabilityTraitIDRef_ { get; set; }
        
    
        
    
    }
    
}

