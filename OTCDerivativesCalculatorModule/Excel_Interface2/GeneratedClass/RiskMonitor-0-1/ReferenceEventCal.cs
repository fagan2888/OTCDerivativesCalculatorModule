using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceEventCal : ISerialized
    {
        public ReferenceEventCal() { }
        public ReferenceEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode refNameNode = xmlNode.SelectSingleNode("refName");
            
            if (refNameNode != null)
            {
                if (refNameNode.Attributes["href"] != null || refNameNode.Attributes["id"] != null) 
                {
                    if (refNameNode.Attributes["id"] != null) 
                    {
                        refNameIDRef_ = refNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refNameNode);
                        IDManager.SetID(refNameIDRef_, ob);
                    }
                    else if (refNameNode.Attributes["href"] != null)
                    {
                        refNameIDRef_ = refNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refName_ = new XsdTypeToken(refNameNode);
                    }
                }
                else
                {
                    refName_ = new XsdTypeToken(refNameNode);
                }
            }
            
        
        }
        
    
        #region RefName_
        private XsdTypeToken refName_;
        public XsdTypeToken RefName_
        {
            get
            {
                if (this.refName_ != null)
                {
                    return this.refName_; 
                }
                else if (this.refNameIDRef_ != null)
                {
                    refName_ = IDManager.getID(refNameIDRef_) as XsdTypeToken;
                    return this.refName_; 
                }
                else
                {
                    throw new Exception( "refName_Node no exist!");
                }
            }
            set
            {
                if (this.refName_ != value)
                {
                    this.refName_ = value;
                }
            }
        }
        #endregion
        
        public string refNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

