using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PreDefinedVariableInfo : ISerialized
    {
        public PreDefinedVariableInfo() { }
        public PreDefinedVariableInfo(XmlNode xmlNode)
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
            
        
            XmlNode fixingInformationNode = xmlNode.SelectSingleNode("fixingInformation");
            
            if (fixingInformationNode != null)
            {
                if (fixingInformationNode.Attributes["href"] != null || fixingInformationNode.Attributes["id"] != null) 
                {
                    if (fixingInformationNode.Attributes["id"] != null) 
                    {
                        fixingInformationIDRef_ = fixingInformationNode.Attributes["id"].Value;
                        FixingInformation ob = new FixingInformation(fixingInformationNode);
                        IDManager.SetID(fixingInformationIDRef_, ob);
                    }
                    else if (fixingInformationNode.Attributes["href"] != null)
                    {
                        fixingInformationIDRef_ = fixingInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingInformation_ = new FixingInformation(fixingInformationNode);
                    }
                }
                else
                {
                    fixingInformation_ = new FixingInformation(fixingInformationNode);
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
        #region FixingInformation_
        private FixingInformation fixingInformation_;
        public FixingInformation FixingInformation_
        {
            get
            {
                if (this.fixingInformation_ != null)
                {
                    return this.fixingInformation_; 
                }
                else if (this.fixingInformationIDRef_ != null)
                {
                    fixingInformation_ = IDManager.getID(fixingInformationIDRef_) as FixingInformation;
                    return this.fixingInformation_; 
                }
                else
                {
                    throw new Exception( "fixingInformation_Node no exist!");
                }
            }
            set
            {
                if (this.fixingInformation_ != value)
                {
                    this.fixingInformation_ = value;
                }
            }
        }
        #endregion
        
        public string fixingInformationIDRef_ { get; set; }
        
    
        
    
    }
    
}

