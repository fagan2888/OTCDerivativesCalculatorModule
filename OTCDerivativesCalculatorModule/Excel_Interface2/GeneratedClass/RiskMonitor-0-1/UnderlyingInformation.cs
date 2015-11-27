using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnderlyingInformation : ISerialized
    {
        public UnderlyingInformation() { }
        public UnderlyingInformation(XmlNode xmlNode)
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
            
        
            XmlNode indexUnderInfoNode = xmlNode.SelectSingleNode("indexUnderInfo");
            
            if (indexUnderInfoNode != null)
            {
                if (indexUnderInfoNode.Attributes["href"] != null || indexUnderInfoNode.Attributes["id"] != null) 
                {
                    if (indexUnderInfoNode.Attributes["id"] != null) 
                    {
                        indexUnderInfoIDRef_ = indexUnderInfoNode.Attributes["id"].Value;
                        IndexUnderInfo ob = new IndexUnderInfo(indexUnderInfoNode);
                        IDManager.SetID(indexUnderInfoIDRef_, ob);
                    }
                    else if (indexUnderInfoNode.Attributes["href"] != null)
                    {
                        indexUnderInfoIDRef_ = indexUnderInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexUnderInfo_ = new IndexUnderInfo(indexUnderInfoNode);
                    }
                }
                else
                {
                    indexUnderInfo_ = new IndexUnderInfo(indexUnderInfoNode);
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
        #region IndexUnderInfo_
        private IndexUnderInfo indexUnderInfo_;
        public IndexUnderInfo IndexUnderInfo_
        {
            get
            {
                if (this.indexUnderInfo_ != null)
                {
                    return this.indexUnderInfo_; 
                }
                else if (this.indexUnderInfoIDRef_ != null)
                {
                    indexUnderInfo_ = IDManager.getID(indexUnderInfoIDRef_) as IndexUnderInfo;
                    return this.indexUnderInfo_; 
                }
                else
                {
                    throw new Exception( "indexUnderInfo_Node no exist!");
                }
            }
            set
            {
                if (this.indexUnderInfo_ != value)
                {
                    this.indexUnderInfo_ = value;
                }
            }
        }
        #endregion
        
        public string indexUnderInfoIDRef_ { get; set; }
        public string choiceStr_underType;
        
    
        
    
    }
    
}

