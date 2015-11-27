using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointProbabilityTrait : ISerialized
    {
        public JointProbabilityTrait() { }
        public JointProbabilityTrait(XmlNode xmlNode)
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
            
        
            XmlNode nthDefaultTraitNode = xmlNode.SelectSingleNode("nthDefaultTrait");
            
            if (nthDefaultTraitNode != null)
            {
                if (nthDefaultTraitNode.Attributes["href"] != null || nthDefaultTraitNode.Attributes["id"] != null) 
                {
                    if (nthDefaultTraitNode.Attributes["id"] != null) 
                    {
                        nthDefaultTraitIDRef_ = nthDefaultTraitNode.Attributes["id"].Value;
                        NthDefaultTrait ob = new NthDefaultTrait(nthDefaultTraitNode);
                        IDManager.SetID(nthDefaultTraitIDRef_, ob);
                    }
                    else if (nthDefaultTraitNode.Attributes["href"] != null)
                    {
                        nthDefaultTraitIDRef_ = nthDefaultTraitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nthDefaultTrait_ = new NthDefaultTrait(nthDefaultTraitNode);
                    }
                }
                else
                {
                    nthDefaultTrait_ = new NthDefaultTrait(nthDefaultTraitNode);
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
        #region NthDefaultTrait_
        private NthDefaultTrait nthDefaultTrait_;
        public NthDefaultTrait NthDefaultTrait_
        {
            get
            {
                if (this.nthDefaultTrait_ != null)
                {
                    return this.nthDefaultTrait_; 
                }
                else if (this.nthDefaultTraitIDRef_ != null)
                {
                    nthDefaultTrait_ = IDManager.getID(nthDefaultTraitIDRef_) as NthDefaultTrait;
                    return this.nthDefaultTrait_; 
                }
                else
                {
                    throw new Exception( "nthDefaultTrait_Node no exist!");
                }
            }
            set
            {
                if (this.nthDefaultTrait_ != value)
                {
                    this.nthDefaultTrait_ = value;
                }
            }
        }
        #endregion
        
        public string nthDefaultTraitIDRef_ { get; set; }
        public string choiceStr_jointType;
        
    
        
    
    }
    
}

