using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class ReferenceEntityInfo : ISerialized
    {
        public ReferenceEntityInfo() { }
        public ReferenceEntityInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode curveListNode = xmlNode.SelectSingleNode("curveList");
            
            if (curveListNode != null)
            {
                if (curveListNode.Attributes["href"] != null || curveListNode.Attributes["id"] != null) 
                {
                    if (curveListNode.Attributes["id"] != null) 
                    {
                        curveListIDRef_ = curveListNode.Attributes["id"].Value;
                        CurveList ob = new CurveList(curveListNode);
                        IDManager.SetID(curveListIDRef_, ob);
                    }
                    else if (curveListNode.Attributes["href"] != null)
                    {
                        curveListIDRef_ = curveListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        curveList_ = new CurveList(curveListNode);
                    }
                }
                else
                {
                    curveList_ = new CurveList(curveListNode);
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
        
    
        #region CurveList_
        private CurveList curveList_;
        public CurveList CurveList_
        {
            get
            {
                if (this.curveList_ != null)
                {
                    return this.curveList_; 
                }
                else if (this.curveListIDRef_ != null)
                {
                    curveList_ = IDManager.getID(curveListIDRef_) as CurveList;
                    return this.curveList_; 
                }
                else
                {
                      return this.curveList_; 
                }
            }
            set
            {
                if (this.curveList_ != value)
                {
                    this.curveList_ = value;
                }
            }
        }
        #endregion
        
        public string curveListIDRef_ { get; set; }
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
                      return this.jointProbabilityTrait_; 
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

