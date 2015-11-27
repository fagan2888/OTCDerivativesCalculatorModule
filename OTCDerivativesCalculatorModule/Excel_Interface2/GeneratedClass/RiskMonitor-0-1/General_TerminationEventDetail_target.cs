using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class General_TerminationEventDetail_target : ISerialized
    {
        public General_TerminationEventDetail_target() { }
        public General_TerminationEventDetail_target(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode targetNode = xmlNode.SelectSingleNode("target");
            
            if (targetNode != null)
            {
                if (targetNode.Attributes["href"] != null || targetNode.Attributes["id"] != null) 
                {
                    if (targetNode.Attributes["id"] != null) 
                    {
                        targetIDRef_ = targetNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(targetNode);
                        IDManager.SetID(targetIDRef_, ob);
                    }
                    else if (targetNode.Attributes["href"] != null)
                    {
                        targetIDRef_ = targetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        target_ = new XsdTypeToken(targetNode);
                    }
                }
                else
                {
                    target_ = new XsdTypeToken(targetNode);
                }
            }
            
        
        }
        
    
        #region Target_
        private XsdTypeToken target_;
        public XsdTypeToken Target_
        {
            get
            {
                if (this.target_ != null)
                {
                    return this.target_; 
                }
                else if (this.targetIDRef_ != null)
                {
                    target_ = IDManager.getID(targetIDRef_) as XsdTypeToken;
                    return this.target_; 
                }
                else
                {
                    throw new Exception( "target_Node no exist!");
                }
            }
            set
            {
                if (this.target_ != value)
                {
                    this.target_ = value;
                }
            }
        }
        #endregion
        
        public string targetIDRef_ { get; set; }
        
    
        
    
    }
    
}

