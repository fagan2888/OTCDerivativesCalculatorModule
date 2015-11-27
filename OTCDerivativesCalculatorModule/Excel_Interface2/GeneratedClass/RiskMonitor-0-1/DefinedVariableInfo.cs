using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DefinedVariableInfo : ISerialized
    {
        public DefinedVariableInfo() { }
        public DefinedVariableInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode refInstanceNameNode = xmlNode.SelectSingleNode("refInstanceName");
            
            if (refInstanceNameNode != null)
            {
                if (refInstanceNameNode.Attributes["href"] != null || refInstanceNameNode.Attributes["id"] != null) 
                {
                    if (refInstanceNameNode.Attributes["id"] != null) 
                    {
                        refInstanceNameIDRef_ = refInstanceNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refInstanceNameNode);
                        IDManager.SetID(refInstanceNameIDRef_, ob);
                    }
                    else if (refInstanceNameNode.Attributes["href"] != null)
                    {
                        refInstanceNameIDRef_ = refInstanceNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refInstanceName_ = new XsdTypeToken(refInstanceNameNode);
                    }
                }
                else
                {
                    refInstanceName_ = new XsdTypeToken(refInstanceNameNode);
                }
            }
            
        
        }
        
    
        #region RefInstanceName_
        private XsdTypeToken refInstanceName_;
        public XsdTypeToken RefInstanceName_
        {
            get
            {
                if (this.refInstanceName_ != null)
                {
                    return this.refInstanceName_; 
                }
                else if (this.refInstanceNameIDRef_ != null)
                {
                    refInstanceName_ = IDManager.getID(refInstanceNameIDRef_) as XsdTypeToken;
                    return this.refInstanceName_; 
                }
                else
                {
                    throw new Exception( "refInstanceName_Node no exist!");
                }
            }
            set
            {
                if (this.refInstanceName_ != value)
                {
                    this.refInstanceName_ = value;
                }
            }
        }
        #endregion
        
        public string refInstanceNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

