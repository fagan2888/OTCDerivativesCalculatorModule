using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OverWriteVariableEventInfo : ISerialized
    {
        public OverWriteVariableEventInfo() { }
        public OverWriteVariableEventInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode usingRefVarNameNode = xmlNode.SelectSingleNode("usingRefVarName");
            
            if (usingRefVarNameNode != null)
            {
                if (usingRefVarNameNode.Attributes["href"] != null || usingRefVarNameNode.Attributes["id"] != null) 
                {
                    if (usingRefVarNameNode.Attributes["id"] != null) 
                    {
                        usingRefVarNameIDRef_ = usingRefVarNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(usingRefVarNameNode);
                        IDManager.SetID(usingRefVarNameIDRef_, ob);
                    }
                    else if (usingRefVarNameNode.Attributes["href"] != null)
                    {
                        usingRefVarNameIDRef_ = usingRefVarNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        usingRefVarName_ = new XsdTypeToken(usingRefVarNameNode);
                    }
                }
                else
                {
                    usingRefVarName_ = new XsdTypeToken(usingRefVarNameNode);
                }
            }
            
        
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
            
        
            XmlNode initialTFNode = xmlNode.SelectSingleNode("initialTF");
            
            if (initialTFNode != null)
            {
                if (initialTFNode.Attributes["href"] != null || initialTFNode.Attributes["id"] != null) 
                {
                    if (initialTFNode.Attributes["id"] != null) 
                    {
                        initialTFIDRef_ = initialTFNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(initialTFNode);
                        IDManager.SetID(initialTFIDRef_, ob);
                    }
                    else if (initialTFNode.Attributes["href"] != null)
                    {
                        initialTFIDRef_ = initialTFNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialTF_ = new XsdTypeToken(initialTFNode);
                    }
                }
                else
                {
                    initialTF_ = new XsdTypeToken(initialTFNode);
                }
            }
            
        
        }
        
    
        #region UsingRefVarName_
        private XsdTypeToken usingRefVarName_;
        public XsdTypeToken UsingRefVarName_
        {
            get
            {
                if (this.usingRefVarName_ != null)
                {
                    return this.usingRefVarName_; 
                }
                else if (this.usingRefVarNameIDRef_ != null)
                {
                    usingRefVarName_ = IDManager.getID(usingRefVarNameIDRef_) as XsdTypeToken;
                    return this.usingRefVarName_; 
                }
                else
                {
                    throw new Exception( "usingRefVarName_Node no exist!");
                }
            }
            set
            {
                if (this.usingRefVarName_ != value)
                {
                    this.usingRefVarName_ = value;
                }
            }
        }
        #endregion
        
        public string usingRefVarNameIDRef_ { get; set; }
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
        #region InitialTF_
        private XsdTypeToken initialTF_;
        public XsdTypeToken InitialTF_
        {
            get
            {
                if (this.initialTF_ != null)
                {
                    return this.initialTF_; 
                }
                else if (this.initialTFIDRef_ != null)
                {
                    initialTF_ = IDManager.getID(initialTFIDRef_) as XsdTypeToken;
                    return this.initialTF_; 
                }
                else
                {
                    throw new Exception( "initialTF_Node no exist!");
                }
            }
            set
            {
                if (this.initialTF_ != value)
                {
                    this.initialTF_ = value;
                }
            }
        }
        #endregion
        
        public string initialTFIDRef_ { get; set; }
        
    
        
    
    }
    
}

