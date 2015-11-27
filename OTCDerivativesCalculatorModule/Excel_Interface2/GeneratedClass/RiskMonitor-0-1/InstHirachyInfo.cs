using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstHirachyInfo : ISerialized
    {
        public InstHirachyInfo() { }
        public InstHirachyInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode codeNode = xmlNode.SelectSingleNode("code");
            
            if (codeNode != null)
            {
                if (codeNode.Attributes["href"] != null || codeNode.Attributes["id"] != null) 
                {
                    if (codeNode.Attributes["id"] != null) 
                    {
                        codeIDRef_ = codeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(codeNode);
                        IDManager.SetID(codeIDRef_, ob);
                    }
                    else if (codeNode.Attributes["href"] != null)
                    {
                        codeIDRef_ = codeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        code_ = new XsdTypeToken(codeNode);
                    }
                }
                else
                {
                    code_ = new XsdTypeToken(codeNode);
                }
            }
            
        
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
            
        
            XmlNodeList instHirachyInfoNodeList = xmlNode.SelectNodes("instHirachyInfo");
            
            if (instHirachyInfoNodeList != null)
            {
                this.instHirachyInfo_ = new List<InstHirachyInfo>();
                foreach (XmlNode item in instHirachyInfoNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            instHirachyInfoIDRef_ = item.Attributes["id"].Value;
                            instHirachyInfo_.Add(new InstHirachyInfo(item));
                            IDManager.SetID(instHirachyInfoIDRef_, instHirachyInfo_[instHirachyInfo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            instHirachyInfoIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        instHirachyInfo_.Add(new InstHirachyInfo(item));
                        }
                    }
                    else
                    {
                        instHirachyInfo_.Add(new InstHirachyInfo(item));
                    }
                }
            }
            
        
        }
        
    
        #region Code_
        private XsdTypeToken code_;
        public XsdTypeToken Code_
        {
            get
            {
                if (this.code_ != null)
                {
                    return this.code_; 
                }
                else if (this.codeIDRef_ != null)
                {
                    code_ = IDManager.getID(codeIDRef_) as XsdTypeToken;
                    return this.code_; 
                }
                else
                {
                    throw new Exception( "code_Node no exist!");
                }
            }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                }
            }
        }
        #endregion
        
        public string codeIDRef_ { get; set; }
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
        #region InstHirachyInfo_
        private List<InstHirachyInfo> instHirachyInfo_;
        public List<InstHirachyInfo> InstHirachyInfo_
        {
            get
            {
                if (this.instHirachyInfo_ != null)
                {
                    return this.instHirachyInfo_; 
                }
                else if (this.instHirachyInfoIDRef_ != null)
                {
                    return this.instHirachyInfo_; 
                }
                else
                {
                    throw new Exception( "instHirachyInfo_Node no exist!");
                }
            }
            set
            {
                if (this.instHirachyInfo_ != value)
                {
                    this.instHirachyInfo_ = value;
                }
            }
        }
        #endregion
        
        public string instHirachyInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

