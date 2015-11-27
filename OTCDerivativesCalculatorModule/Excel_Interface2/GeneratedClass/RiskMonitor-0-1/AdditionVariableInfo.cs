using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionVariableInfo : ISerialized
    {
        public AdditionVariableInfo() { }
        public AdditionVariableInfo(XmlNode xmlNode)
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
            
        
            XmlNode saveNode = xmlNode.SelectSingleNode("save");
            
            if (saveNode != null)
            {
                if (saveNode.Attributes["href"] != null || saveNode.Attributes["id"] != null) 
                {
                    if (saveNode.Attributes["id"] != null) 
                    {
                        saveIDRef_ = saveNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(saveNode);
                        IDManager.SetID(saveIDRef_, ob);
                    }
                    else if (saveNode.Attributes["href"] != null)
                    {
                        saveIDRef_ = saveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        save_ = new XsdTypeBoolean(saveNode);
                    }
                }
                else
                {
                    save_ = new XsdTypeBoolean(saveNode);
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
        #region Save_
        private XsdTypeBoolean save_;
        public XsdTypeBoolean Save_
        {
            get
            {
                if (this.save_ != null)
                {
                    return this.save_; 
                }
                else if (this.saveIDRef_ != null)
                {
                    save_ = IDManager.getID(saveIDRef_) as XsdTypeBoolean;
                    return this.save_; 
                }
                else
                {
                    throw new Exception( "save_Node no exist!");
                }
            }
            set
            {
                if (this.save_ != value)
                {
                    this.save_ = value;
                }
            }
        }
        #endregion
        
        public string saveIDRef_ { get; set; }
        
    
        
    
    }
    
}

