using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class JointProbabilityTrait : ISerialized
    {
        public JointProbabilityTrait() { }
        public JointProbabilityTrait(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode nthDefaultNode = xmlNode.SelectSingleNode("nthDefault");
            
            if (nthDefaultNode != null)
            {
                if (nthDefaultNode.Attributes["href"] != null || nthDefaultNode.Attributes["id"] != null) 
                {
                    if (nthDefaultNode.Attributes["id"] != null) 
                    {
                        nthDefaultIDRef_ = nthDefaultNode.Attributes["id"].Value;
                        NthDefault ob = new NthDefault(nthDefaultNode);
                        IDManager.SetID(nthDefaultIDRef_, ob);
                    }
                    else if (nthDefaultNode.Attributes["href"] != null)
                    {
                        nthDefaultIDRef_ = nthDefaultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nthDefault_ = new NthDefault(nthDefaultNode);
                    }
                }
                else
                {
                    nthDefault_ = new NthDefault(nthDefaultNode);
                }
            }
            
        
        }
        
    
        #region NthDefault_
        private NthDefault nthDefault_;
        public NthDefault NthDefault_
        {
            get
            {
                if (this.nthDefault_ != null)
                {
                    return this.nthDefault_; 
                }
                else if (this.nthDefaultIDRef_ != null)
                {
                    nthDefault_ = IDManager.getID(nthDefaultIDRef_) as NthDefault;
                    return this.nthDefault_; 
                }
                else
                {
                      return this.nthDefault_; 
                }
            }
            set
            {
                if (this.nthDefault_ != value)
                {
                    this.nthDefault_ = value;
                }
            }
        }
        #endregion
        
        public string nthDefaultIDRef_ { get; set; }
        public string choiceStr_jointType;
        
    
        
    
    }
    
}

