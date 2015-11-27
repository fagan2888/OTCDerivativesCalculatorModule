using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_jointProbabilityTrait : ISerialized
    {
        public Excel_jointProbabilityTrait() { }
        public Excel_jointProbabilityTrait(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode nthNode = xmlNode.SelectSingleNode("nth");
            
            if (nthNode != null)
            {
                if (nthNode.Attributes["href"] != null || nthNode.Attributes["id"] != null) 
                {
                    if (nthNode.Attributes["id"] != null) 
                    {
                        nthIDRef_ = nthNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nthNode);
                        IDManager.SetID(nthIDRef_, ob);
                    }
                    else if (nthNode.Attributes["href"] != null)
                    {
                        nthIDRef_ = nthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nth_ = new XsdTypeToken(nthNode);
                    }
                }
                else
                {
                    nth_ = new XsdTypeToken(nthNode);
                }
            }
            
        
        }
        
    
        #region Nth_
        private XsdTypeToken nth_;
        public XsdTypeToken Nth_
        {
            get
            {
                if (this.nth_ != null)
                {
                    return this.nth_; 
                }
                else if (this.nthIDRef_ != null)
                {
                    nth_ = IDManager.getID(nthIDRef_) as XsdTypeToken;
                    return this.nth_; 
                }
                else
                {
                    throw new Exception( "nth_Node no exist!");
                }
            }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                }
            }
        }
        #endregion
        
        public string nthIDRef_ { get; set; }
        
    
        
    
    }
    
}

