using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Resource : ISerialized
    {
        public Resource(XmlNode xmlNode)
        {
            XmlNode resourceIdNode = xmlNode.SelectSingleNode("resourceId");
            
            if (resourceIdNode != null)
            {
                if (resourceIdNode.Attributes["href"] != null || resourceIdNode.Attributes["id"] != null) 
                {
                    if (resourceIdNode.Attributes["id"] != null) 
                    {
                        resourceIdIDRef_ = resourceIdNode.Attributes["id"].Value;
                        ResourceId ob = new ResourceId(resourceIdNode);
                        IDManager.SetID(resourceIdIDRef_, ob);
                    }
                    else if (resourceIdNode.Attributes["href"] != null)
                    {
                        resourceIdIDRef_ = resourceIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resourceId_ = new ResourceId(resourceIdNode);
                    }
                }
                else
                {
                    resourceId_ = new ResourceId(resourceIdNode);
                }
            }
            
        
            XmlNode resourceTypeNode = xmlNode.SelectSingleNode("resourceType");
            
            if (resourceTypeNode != null)
            {
                if (resourceTypeNode.Attributes["href"] != null || resourceTypeNode.Attributes["id"] != null) 
                {
                    if (resourceTypeNode.Attributes["id"] != null) 
                    {
                        resourceTypeIDRef_ = resourceTypeNode.Attributes["id"].Value;
                        ResourceType ob = new ResourceType(resourceTypeNode);
                        IDManager.SetID(resourceTypeIDRef_, ob);
                    }
                    else if (resourceTypeNode.Attributes["href"] != null)
                    {
                        resourceTypeIDRef_ = resourceTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resourceType_ = new ResourceType(resourceTypeNode);
                    }
                }
                else
                {
                    resourceType_ = new ResourceType(resourceTypeNode);
                }
            }
            
        
            XmlNode languageNode = xmlNode.SelectSingleNode("language");
            
            if (languageNode != null)
            {
                if (languageNode.Attributes["href"] != null || languageNode.Attributes["id"] != null) 
                {
                    if (languageNode.Attributes["id"] != null) 
                    {
                        languageIDRef_ = languageNode.Attributes["id"].Value;
                        Language ob = new Language(languageNode);
                        IDManager.SetID(languageIDRef_, ob);
                    }
                    else if (languageNode.Attributes["href"] != null)
                    {
                        languageIDRef_ = languageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        language_ = new Language(languageNode);
                    }
                }
                else
                {
                    language_ = new Language(languageNode);
                }
            }
            
        
            XmlNode sizeInBytesNode = xmlNode.SelectSingleNode("sizeInBytes");
            
            if (sizeInBytesNode != null)
            {
                if (sizeInBytesNode.Attributes["href"] != null || sizeInBytesNode.Attributes["id"] != null) 
                {
                    if (sizeInBytesNode.Attributes["id"] != null) 
                    {
                        sizeInBytesIDRef_ = sizeInBytesNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(sizeInBytesNode);
                        IDManager.SetID(sizeInBytesIDRef_, ob);
                    }
                    else if (sizeInBytesNode.Attributes["href"] != null)
                    {
                        sizeInBytesIDRef_ = sizeInBytesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sizeInBytes_ = new XsdTypeDecimal(sizeInBytesNode);
                    }
                }
                else
                {
                    sizeInBytes_ = new XsdTypeDecimal(sizeInBytesNode);
                }
            }
            
        
            XmlNode lengthNode = xmlNode.SelectSingleNode("length");
            
            if (lengthNode != null)
            {
                if (lengthNode.Attributes["href"] != null || lengthNode.Attributes["id"] != null) 
                {
                    if (lengthNode.Attributes["id"] != null) 
                    {
                        lengthIDRef_ = lengthNode.Attributes["id"].Value;
                        ResourceLength ob = new ResourceLength(lengthNode);
                        IDManager.SetID(lengthIDRef_, ob);
                    }
                    else if (lengthNode.Attributes["href"] != null)
                    {
                        lengthIDRef_ = lengthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        length_ = new ResourceLength(lengthNode);
                    }
                }
                else
                {
                    length_ = new ResourceLength(lengthNode);
                }
            }
            
        
            XmlNode mimeTypeNode = xmlNode.SelectSingleNode("mimeType");
            
            if (mimeTypeNode != null)
            {
                if (mimeTypeNode.Attributes["href"] != null || mimeTypeNode.Attributes["id"] != null) 
                {
                    if (mimeTypeNode.Attributes["id"] != null) 
                    {
                        mimeTypeIDRef_ = mimeTypeNode.Attributes["id"].Value;
                        MimeType ob = new MimeType(mimeTypeNode);
                        IDManager.SetID(mimeTypeIDRef_, ob);
                    }
                    else if (mimeTypeNode.Attributes["href"] != null)
                    {
                        mimeTypeIDRef_ = mimeTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mimeType_ = new MimeType(mimeTypeNode);
                    }
                }
                else
                {
                    mimeType_ = new MimeType(mimeTypeNode);
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
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeNormalizedString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeNormalizedString(nameNode);
                }
            }
            
        
            XmlNode commentsNode = xmlNode.SelectSingleNode("comments");
            
            if (commentsNode != null)
            {
                if (commentsNode.Attributes["href"] != null || commentsNode.Attributes["id"] != null) 
                {
                    if (commentsNode.Attributes["id"] != null) 
                    {
                        commentsIDRef_ = commentsNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(commentsNode);
                        IDManager.SetID(commentsIDRef_, ob);
                    }
                    else if (commentsNode.Attributes["href"] != null)
                    {
                        commentsIDRef_ = commentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        comments_ = new XsdTypeString(commentsNode);
                    }
                }
                else
                {
                    comments_ = new XsdTypeString(commentsNode);
                }
            }
            
        
            XmlNode stringNode = xmlNode.SelectSingleNode("string");
            
            if (stringNode != null)
            {
                if (stringNode.Attributes["href"] != null || stringNode.Attributes["id"] != null) 
                {
                    if (stringNode.Attributes["id"] != null) 
                    {
                        stringIDRef_ = stringNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(stringNode);
                        IDManager.SetID(stringIDRef_, ob);
                    }
                    else if (stringNode.Attributes["href"] != null)
                    {
                        stringIDRef_ = stringNode.Attributes["href"].Value;
                    }
                    else
                    {
                        string_ = new XsdTypeString(stringNode);
                    }
                }
                else
                {
                    string_ = new XsdTypeString(stringNode);
                }
            }
            
        
            XmlNode hexadecimalBinaryNode = xmlNode.SelectSingleNode("hexadecimalBinary");
            
            if (hexadecimalBinaryNode != null)
            {
                if (hexadecimalBinaryNode.Attributes["href"] != null || hexadecimalBinaryNode.Attributes["id"] != null) 
                {
                    if (hexadecimalBinaryNode.Attributes["id"] != null) 
                    {
                        hexadecimalBinaryIDRef_ = hexadecimalBinaryNode.Attributes["id"].Value;
                        XsdTypeHexBinary ob = new XsdTypeHexBinary(hexadecimalBinaryNode);
                        IDManager.SetID(hexadecimalBinaryIDRef_, ob);
                    }
                    else if (hexadecimalBinaryNode.Attributes["href"] != null)
                    {
                        hexadecimalBinaryIDRef_ = hexadecimalBinaryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hexadecimalBinary_ = new XsdTypeHexBinary(hexadecimalBinaryNode);
                    }
                }
                else
                {
                    hexadecimalBinary_ = new XsdTypeHexBinary(hexadecimalBinaryNode);
                }
            }
            
        
            XmlNode base64BinaryNode = xmlNode.SelectSingleNode("base64Binary");
            
            if (base64BinaryNode != null)
            {
                if (base64BinaryNode.Attributes["href"] != null || base64BinaryNode.Attributes["id"] != null) 
                {
                    if (base64BinaryNode.Attributes["id"] != null) 
                    {
                        base64BinaryIDRef_ = base64BinaryNode.Attributes["id"].Value;
                        XsdTypeBase64Binary ob = new XsdTypeBase64Binary(base64BinaryNode);
                        IDManager.SetID(base64BinaryIDRef_, ob);
                    }
                    else if (base64BinaryNode.Attributes["href"] != null)
                    {
                        base64BinaryIDRef_ = base64BinaryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        base64Binary_ = new XsdTypeBase64Binary(base64BinaryNode);
                    }
                }
                else
                {
                    base64Binary_ = new XsdTypeBase64Binary(base64BinaryNode);
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
                        XsdTypeAnyURI ob = new XsdTypeAnyURI(urlNode);
                        IDManager.SetID(urlIDRef_, ob);
                    }
                    else if (urlNode.Attributes["href"] != null)
                    {
                        urlIDRef_ = urlNode.Attributes["href"].Value;
                    }
                    else
                    {
                        url_ = new XsdTypeAnyURI(urlNode);
                    }
                }
                else
                {
                    url_ = new XsdTypeAnyURI(urlNode);
                }
            }
            
        
        }
        
    
        #region ResourceId_
        private ResourceId resourceId_;
        public ResourceId ResourceId_
        {
            get
            {
                if (this.resourceId_ != null)
                {
                    return this.resourceId_; 
                }
                else if (this.resourceIdIDRef_ != null)
                {
                    resourceId_ = IDManager.getID(resourceIdIDRef_) as ResourceId;
                    return this.resourceId_; 
                }
                else
                {
                      return this.resourceId_; 
                }
            }
            set
            {
                if (this.resourceId_ != value)
                {
                    this.resourceId_ = value;
                }
            }
        }
        #endregion
        
        public string resourceIdIDRef_ { get; set; }
        #region ResourceType_
        private ResourceType resourceType_;
        public ResourceType ResourceType_
        {
            get
            {
                if (this.resourceType_ != null)
                {
                    return this.resourceType_; 
                }
                else if (this.resourceTypeIDRef_ != null)
                {
                    resourceType_ = IDManager.getID(resourceTypeIDRef_) as ResourceType;
                    return this.resourceType_; 
                }
                else
                {
                      return this.resourceType_; 
                }
            }
            set
            {
                if (this.resourceType_ != value)
                {
                    this.resourceType_ = value;
                }
            }
        }
        #endregion
        
        public string resourceTypeIDRef_ { get; set; }
        #region Language_
        private Language language_;
        public Language Language_
        {
            get
            {
                if (this.language_ != null)
                {
                    return this.language_; 
                }
                else if (this.languageIDRef_ != null)
                {
                    language_ = IDManager.getID(languageIDRef_) as Language;
                    return this.language_; 
                }
                else
                {
                      return this.language_; 
                }
            }
            set
            {
                if (this.language_ != value)
                {
                    this.language_ = value;
                }
            }
        }
        #endregion
        
        public string languageIDRef_ { get; set; }
        #region SizeInBytes_
        private XsdTypeDecimal sizeInBytes_;
        public XsdTypeDecimal SizeInBytes_
        {
            get
            {
                if (this.sizeInBytes_ != null)
                {
                    return this.sizeInBytes_; 
                }
                else if (this.sizeInBytesIDRef_ != null)
                {
                    sizeInBytes_ = IDManager.getID(sizeInBytesIDRef_) as XsdTypeDecimal;
                    return this.sizeInBytes_; 
                }
                else
                {
                      return this.sizeInBytes_; 
                }
            }
            set
            {
                if (this.sizeInBytes_ != value)
                {
                    this.sizeInBytes_ = value;
                }
            }
        }
        #endregion
        
        public string sizeInBytesIDRef_ { get; set; }
        #region Length_
        private ResourceLength length_;
        public ResourceLength Length_
        {
            get
            {
                if (this.length_ != null)
                {
                    return this.length_; 
                }
                else if (this.lengthIDRef_ != null)
                {
                    length_ = IDManager.getID(lengthIDRef_) as ResourceLength;
                    return this.length_; 
                }
                else
                {
                      return this.length_; 
                }
            }
            set
            {
                if (this.length_ != value)
                {
                    this.length_ = value;
                }
            }
        }
        #endregion
        
        public string lengthIDRef_ { get; set; }
        #region MimeType_
        private MimeType mimeType_;
        public MimeType MimeType_
        {
            get
            {
                if (this.mimeType_ != null)
                {
                    return this.mimeType_; 
                }
                else if (this.mimeTypeIDRef_ != null)
                {
                    mimeType_ = IDManager.getID(mimeTypeIDRef_) as MimeType;
                    return this.mimeType_; 
                }
                else
                {
                      return this.mimeType_; 
                }
            }
            set
            {
                if (this.mimeType_ != value)
                {
                    this.mimeType_ = value;
                }
            }
        }
        #endregion
        
        public string mimeTypeIDRef_ { get; set; }
        #region Name_
        private XsdTypeNormalizedString name_;
        public XsdTypeNormalizedString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeNormalizedString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
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
        #region Comments_
        private XsdTypeString comments_;
        public XsdTypeString Comments_
        {
            get
            {
                if (this.comments_ != null)
                {
                    return this.comments_; 
                }
                else if (this.commentsIDRef_ != null)
                {
                    comments_ = IDManager.getID(commentsIDRef_) as XsdTypeString;
                    return this.comments_; 
                }
                else
                {
                      return this.comments_; 
                }
            }
            set
            {
                if (this.comments_ != value)
                {
                    this.comments_ = value;
                }
            }
        }
        #endregion
        
        public string commentsIDRef_ { get; set; }
        #region String_
        private XsdTypeString string_;
        public XsdTypeString String_
        {
            get
            {
                if (this.string_ != null)
                {
                    return this.string_; 
                }
                else if (this.stringIDRef_ != null)
                {
                    string_ = IDManager.getID(stringIDRef_) as XsdTypeString;
                    return this.string_; 
                }
                else
                {
                      return this.string_; 
                }
            }
            set
            {
                if (this.string_ != value)
                {
                    this.string_ = value;
                }
            }
        }
        #endregion
        
        public string stringIDRef_ { get; set; }
        #region HexadecimalBinary_
        private XsdTypeHexBinary hexadecimalBinary_;
        public XsdTypeHexBinary HexadecimalBinary_
        {
            get
            {
                if (this.hexadecimalBinary_ != null)
                {
                    return this.hexadecimalBinary_; 
                }
                else if (this.hexadecimalBinaryIDRef_ != null)
                {
                    hexadecimalBinary_ = IDManager.getID(hexadecimalBinaryIDRef_) as XsdTypeHexBinary;
                    return this.hexadecimalBinary_; 
                }
                else
                {
                      return this.hexadecimalBinary_; 
                }
            }
            set
            {
                if (this.hexadecimalBinary_ != value)
                {
                    this.hexadecimalBinary_ = value;
                }
            }
        }
        #endregion
        
        public string hexadecimalBinaryIDRef_ { get; set; }
        #region Base64Binary_
        private XsdTypeBase64Binary base64Binary_;
        public XsdTypeBase64Binary Base64Binary_
        {
            get
            {
                if (this.base64Binary_ != null)
                {
                    return this.base64Binary_; 
                }
                else if (this.base64BinaryIDRef_ != null)
                {
                    base64Binary_ = IDManager.getID(base64BinaryIDRef_) as XsdTypeBase64Binary;
                    return this.base64Binary_; 
                }
                else
                {
                      return this.base64Binary_; 
                }
            }
            set
            {
                if (this.base64Binary_ != value)
                {
                    this.base64Binary_ = value;
                }
            }
        }
        #endregion
        
        public string base64BinaryIDRef_ { get; set; }
        #region Url_
        private XsdTypeAnyURI url_;
        public XsdTypeAnyURI Url_
        {
            get
            {
                if (this.url_ != null)
                {
                    return this.url_; 
                }
                else if (this.urlIDRef_ != null)
                {
                    url_ = IDManager.getID(urlIDRef_) as XsdTypeAnyURI;
                    return this.url_; 
                }
                else
                {
                      return this.url_; 
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

