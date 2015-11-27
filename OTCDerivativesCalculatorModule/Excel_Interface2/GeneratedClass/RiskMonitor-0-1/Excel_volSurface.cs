using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_volSurface : ISerialized
    {
        public Excel_volSurface() { }
        public Excel_volSurface(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode refDateNode = xmlNode.SelectSingleNode("refDate");
            
            if (refDateNode != null)
            {
                if (refDateNode.Attributes["href"] != null || refDateNode.Attributes["id"] != null) 
                {
                    if (refDateNode.Attributes["id"] != null) 
                    {
                        refDateIDRef_ = refDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(refDateNode);
                        IDManager.SetID(refDateIDRef_, ob);
                    }
                    else if (refDateNode.Attributes["href"] != null)
                    {
                        refDateIDRef_ = refDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        refDate_ = new XsdTypeToken(refDateNode);
                    }
                }
                else
                {
                    refDate_ = new XsdTypeToken(refDateNode);
                }
            }
            
        
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
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNodeList tenorNodeList = xmlNode.SelectNodes("tenor");
            
            if (tenorNodeList != null)
            {
                this.tenor_ = new List<XsdTypeToken>();
                foreach (XmlNode item in tenorNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tenorIDRef_ = item.Attributes["id"].Value;
                            tenor_.Add(new XsdTypeToken(item));
                            IDManager.SetID(tenorIDRef_, tenor_[tenor_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tenorIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tenor_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        tenor_.Add(new XsdTypeToken(item));
                    }
                }
            }
            
        
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            
            if (strikeNodeList != null)
            {
                this.strike_ = new List<XsdTypeToken>();
                foreach (XmlNode item in strikeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            strikeIDRef_ = item.Attributes["id"].Value;
                            strike_.Add(new XsdTypeToken(item));
                            IDManager.SetID(strikeIDRef_, strike_[strike_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            strikeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        strike_.Add(new XsdTypeToken(item));
                        }
                    }
                    else
                    {
                        strike_.Add(new XsdTypeToken(item));
                    }
                }
            }
            
        
        }
        
    
        #region RefDate_
        private XsdTypeToken refDate_;
        public XsdTypeToken RefDate_
        {
            get
            {
                if (this.refDate_ != null)
                {
                    return this.refDate_; 
                }
                else if (this.refDateIDRef_ != null)
                {
                    refDate_ = IDManager.getID(refDateIDRef_) as XsdTypeToken;
                    return this.refDate_; 
                }
                else
                {
                    throw new Exception( "refDate_Node no exist!");
                }
            }
            set
            {
                if (this.refDate_ != value)
                {
                    this.refDate_ = value;
                }
            }
        }
        #endregion
        
        public string refDateIDRef_ { get; set; }
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
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                    throw new Exception( "name_Node no exist!");
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region Tenor_
        private List<XsdTypeToken> tenor_;
        public List<XsdTypeToken> Tenor_
        {
            get
            {
                if (this.tenor_ != null)
                {
                    return this.tenor_; 
                }
                else if (this.tenorIDRef_ != null)
                {
                    return this.tenor_; 
                }
                else
                {
                    throw new Exception( "tenor_Node no exist!");
                }
            }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                }
            }
        }
        #endregion
        
        public string tenorIDRef_ { get; set; }
        #region Strike_
        private List<XsdTypeToken> strike_;
        public List<XsdTypeToken> Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    return this.strike_; 
                }
                else
                {
                    throw new Exception( "strike_Node no exist!");
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        
    
        
    
    }
    
}

