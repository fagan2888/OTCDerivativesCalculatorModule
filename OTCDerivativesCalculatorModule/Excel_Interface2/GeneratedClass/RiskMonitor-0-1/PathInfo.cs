using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PathInfo : ISerialized
    {
        public PathInfo() { }
        public PathInfo(XmlNode xmlNode)
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
            
        
            XmlNode urlNode = xmlNode.SelectSingleNode("url");
            
            if (urlNode != null)
            {
                if (urlNode.Attributes["href"] != null || urlNode.Attributes["id"] != null) 
                {
                    if (urlNode.Attributes["id"] != null) 
                    {
                        urlIDRef_ = urlNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(urlNode);
                        IDManager.SetID(urlIDRef_, ob);
                    }
                    else if (urlNode.Attributes["href"] != null)
                    {
                        urlIDRef_ = urlNode.Attributes["href"].Value;
                    }
                    else
                    {
                        url_ = new XsdTypeToken(urlNode);
                    }
                }
                else
                {
                    url_ = new XsdTypeToken(urlNode);
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
        #region Url_
        private XsdTypeToken url_;
        public XsdTypeToken Url_
        {
            get
            {
                if (this.url_ != null)
                {
                    return this.url_; 
                }
                else if (this.urlIDRef_ != null)
                {
                    url_ = IDManager.getID(urlIDRef_) as XsdTypeToken;
                    return this.url_; 
                }
                else
                {
                    throw new Exception( "url_Node no exist!");
                }
            }
            set
            {
                if (this.url_ != value)
                {
                    this.url_ = value;
                }
            }
        }
        #endregion
        
        public string urlIDRef_ { get; set; }
        
    
        
    
    }
    
}

