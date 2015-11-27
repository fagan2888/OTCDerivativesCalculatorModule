using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionOper1D : ISerialized
    {
        public AdditionOper1D() { }
        public AdditionOper1D(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode constValueNode = xmlNode.SelectSingleNode("constValue");
            
            if (constValueNode != null)
            {
                if (constValueNode.Attributes["href"] != null || constValueNode.Attributes["id"] != null) 
                {
                    if (constValueNode.Attributes["id"] != null) 
                    {
                        constValueIDRef_ = constValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(constValueNode);
                        IDManager.SetID(constValueIDRef_, ob);
                    }
                    else if (constValueNode.Attributes["href"] != null)
                    {
                        constValueIDRef_ = constValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constValue_ = new XsdTypeToken(constValueNode);
                    }
                }
                else
                {
                    constValue_ = new XsdTypeToken(constValueNode);
                }
            }
            
        
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
        
    
        #region ConstValue_
        private XsdTypeToken constValue_;
        public XsdTypeToken ConstValue_
        {
            get
            {
                if (this.constValue_ != null)
                {
                    return this.constValue_; 
                }
                else if (this.constValueIDRef_ != null)
                {
                    constValue_ = IDManager.getID(constValueIDRef_) as XsdTypeToken;
                    return this.constValue_; 
                }
                else
                {
                    throw new Exception( "constValue_Node no exist!");
                }
            }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                }
            }
        }
        #endregion
        
        public string constValueIDRef_ { get; set; }
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

