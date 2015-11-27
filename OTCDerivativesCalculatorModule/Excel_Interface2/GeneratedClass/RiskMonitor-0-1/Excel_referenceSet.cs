using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceSet : ISerialized
    {
        public Excel_referenceSet() { }
        public Excel_referenceSet(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode usingTFNode = xmlNode.SelectSingleNode("usingTF");
            
            if (usingTFNode != null)
            {
                if (usingTFNode.Attributes["href"] != null || usingTFNode.Attributes["id"] != null) 
                {
                    if (usingTFNode.Attributes["id"] != null) 
                    {
                        usingTFIDRef_ = usingTFNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(usingTFNode);
                        IDManager.SetID(usingTFIDRef_, ob);
                    }
                    else if (usingTFNode.Attributes["href"] != null)
                    {
                        usingTFIDRef_ = usingTFNode.Attributes["href"].Value;
                    }
                    else
                    {
                        usingTF_ = new XsdTypeToken(usingTFNode);
                    }
                }
                else
                {
                    usingTF_ = new XsdTypeToken(usingTFNode);
                }
            }
            
        
        }
        
    
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region UsingTF_
        private XsdTypeToken usingTF_;
        public XsdTypeToken UsingTF_
        {
            get
            {
                if (this.usingTF_ != null)
                {
                    return this.usingTF_; 
                }
                else if (this.usingTFIDRef_ != null)
                {
                    usingTF_ = IDManager.getID(usingTFIDRef_) as XsdTypeToken;
                    return this.usingTF_; 
                }
                else
                {
                    throw new Exception( "usingTF_Node no exist!");
                }
            }
            set
            {
                if (this.usingTF_ != value)
                {
                    this.usingTF_ = value;
                }
            }
        }
        #endregion
        
        public string usingTFIDRef_ { get; set; }
        
    
        
    
    }
    
}

