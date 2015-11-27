using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Resource
    {
        public Resource(XmlNode xmlNode)
        {
            XmlNodeList resourceIdNodeList = xmlNode.SelectNodes("resourceId");
            if (resourceIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resourceIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resourceIdIDRef = item.Attributes["id"].Name;
                        ResourceId ob = ResourceId();
                        IDManager.SetID(resourceIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resourceIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resourceId = new ResourceId(item);
                    }
                }
            }
            
        
            XmlNodeList resourceTypeNodeList = xmlNode.SelectNodes("resourceType");
            if (resourceTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resourceTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resourceTypeIDRef = item.Attributes["id"].Name;
                        ResourceType ob = ResourceType();
                        IDManager.SetID(resourceTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resourceTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resourceType = new ResourceType(item);
                    }
                }
            }
            
        
            XmlNodeList languageNodeList = xmlNode.SelectNodes("language");
            if (languageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in languageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        languageIDRef = item.Attributes["id"].Name;
                        Language ob = Language();
                        IDManager.SetID(languageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        languageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        language = new Language(item);
                    }
                }
            }
            
        
            XmlNodeList sizeInBytesNodeList = xmlNode.SelectNodes("sizeInBytes");
            if (sizeInBytesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sizeInBytesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sizeInBytesIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(sizeInBytesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sizeInBytesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sizeInBytes = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList lengthNodeList = xmlNode.SelectNodes("length");
            if (lengthNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lengthNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lengthIDRef = item.Attributes["id"].Name;
                        ResourceLength ob = ResourceLength();
                        IDManager.SetID(lengthIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lengthIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        length = new ResourceLength(item);
                    }
                }
            }
            
        
            XmlNodeList mimeTypeNodeList = xmlNode.SelectNodes("mimeType");
            if (mimeTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mimeTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mimeTypeIDRef = item.Attributes["id"].Name;
                        MimeType ob = MimeType();
                        IDManager.SetID(mimeTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mimeTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mimeType = new MimeType(item);
                    }
                }
            }
            
        
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList commentsNodeList = xmlNode.SelectNodes("comments");
            if (commentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commentsIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(commentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        comments = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList stringNodeList = xmlNode.SelectNodes("string");
            if (stringNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stringNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stringIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(stringIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stringIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        string = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList hexadecimalBinaryNodeList = xmlNode.SelectNodes("hexadecimalBinary");
            if (hexadecimalBinaryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in hexadecimalBinaryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        hexadecimalBinaryIDRef = item.Attributes["id"].Name;
                        XsdTypeHexBinary ob = XsdTypeHexBinary();
                        IDManager.SetID(hexadecimalBinaryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        hexadecimalBinaryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        hexadecimalBinary = new XsdTypeHexBinary(item);
                    }
                }
            }
            
        
            XmlNodeList base64BinaryNodeList = xmlNode.SelectNodes("base64Binary");
            if (base64BinaryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in base64BinaryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        base64BinaryIDRef = item.Attributes["id"].Name;
                        XsdTypeBase64Binary ob = XsdTypeBase64Binary();
                        IDManager.SetID(base64BinaryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        base64BinaryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        base64Binary = new XsdTypeBase64Binary(item);
                    }
                }
            }
            
        
            XmlNodeList urlNodeList = xmlNode.SelectNodes("url");
            if (urlNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in urlNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        urlIDRef = item.Attributes["id"].Name;
                        XsdTypeAnyURI ob = XsdTypeAnyURI();
                        IDManager.SetID(urlIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        urlIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        url = new XsdTypeAnyURI(item);
                    }
                }
            }
            
        
        }
        
    
        #region ResourceId
        private ResourceId resourceId;
        public ResourceId ResourceId
        {
            get
            {
                if (this.resourceId != null)
                {
                    return this.resourceId; 
                }
                else if (this.resourceIdIDRef != null)
                {
                    resourceId = IDManager.getID(resourceIdIDRef) as ResourceId;
                    return this.resourceId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resourceId != value)
                {
                    this.resourceId = value;
                }
            }
        }
        #endregion
        
        public string ResourceIdIDRef { get; set; }
        #region ResourceType
        private ResourceType resourceType;
        public ResourceType ResourceType
        {
            get
            {
                if (this.resourceType != null)
                {
                    return this.resourceType; 
                }
                else if (this.resourceTypeIDRef != null)
                {
                    resourceType = IDManager.getID(resourceTypeIDRef) as ResourceType;
                    return this.resourceType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resourceType != value)
                {
                    this.resourceType = value;
                }
            }
        }
        #endregion
        
        public string ResourceTypeIDRef { get; set; }
        #region Language
        private Language language;
        public Language Language
        {
            get
            {
                if (this.language != null)
                {
                    return this.language; 
                }
                else if (this.languageIDRef != null)
                {
                    language = IDManager.getID(languageIDRef) as Language;
                    return this.language; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.language != value)
                {
                    this.language = value;
                }
            }
        }
        #endregion
        
        public string LanguageIDRef { get; set; }
        #region SizeInBytes
        private XsdTypeDecimal sizeInBytes;
        public XsdTypeDecimal SizeInBytes
        {
            get
            {
                if (this.sizeInBytes != null)
                {
                    return this.sizeInBytes; 
                }
                else if (this.sizeInBytesIDRef != null)
                {
                    sizeInBytes = IDManager.getID(sizeInBytesIDRef) as XsdTypeDecimal;
                    return this.sizeInBytes; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sizeInBytes != value)
                {
                    this.sizeInBytes = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Length
        private ResourceLength length;
        public ResourceLength Length
        {
            get
            {
                if (this.length != null)
                {
                    return this.length; 
                }
                else if (this.lengthIDRef != null)
                {
                    length = IDManager.getID(lengthIDRef) as ResourceLength;
                    return this.length; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.length != value)
                {
                    this.length = value;
                }
            }
        }
        #endregion
        
        public string ResourceLengthIDRef { get; set; }
        #region MimeType
        private MimeType mimeType;
        public MimeType MimeType
        {
            get
            {
                if (this.mimeType != null)
                {
                    return this.mimeType; 
                }
                else if (this.mimeTypeIDRef != null)
                {
                    mimeType = IDManager.getID(mimeTypeIDRef) as MimeType;
                    return this.mimeType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mimeType != value)
                {
                    this.mimeType = value;
                }
            }
        }
        #endregion
        
        public string MimeTypeIDRef { get; set; }
        #region Name
        private XsdTypeNormalizedString name;
        public XsdTypeNormalizedString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeNormalizedString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region Comments
        private XsdTypeString comments;
        public XsdTypeString Comments
        {
            get
            {
                if (this.comments != null)
                {
                    return this.comments; 
                }
                else if (this.commentsIDRef != null)
                {
                    comments = IDManager.getID(commentsIDRef) as XsdTypeString;
                    return this.comments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.comments != value)
                {
                    this.comments = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region String
        private XsdTypeString string;
        public XsdTypeString String
        {
            get
            {
                if (this.string != null)
                {
                    return this.string; 
                }
                else if (this.stringIDRef != null)
                {
                    string = IDManager.getID(stringIDRef) as XsdTypeString;
                    return this.string; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.string != value)
                {
                    this.string = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region HexadecimalBinary
        private XsdTypeHexBinary hexadecimalBinary;
        public XsdTypeHexBinary HexadecimalBinary
        {
            get
            {
                if (this.hexadecimalBinary != null)
                {
                    return this.hexadecimalBinary; 
                }
                else if (this.hexadecimalBinaryIDRef != null)
                {
                    hexadecimalBinary = IDManager.getID(hexadecimalBinaryIDRef) as XsdTypeHexBinary;
                    return this.hexadecimalBinary; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.hexadecimalBinary != value)
                {
                    this.hexadecimalBinary = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeHexBinaryIDRef { get; set; }
        #region Base64Binary
        private XsdTypeBase64Binary base64Binary;
        public XsdTypeBase64Binary Base64Binary
        {
            get
            {
                if (this.base64Binary != null)
                {
                    return this.base64Binary; 
                }
                else if (this.base64BinaryIDRef != null)
                {
                    base64Binary = IDManager.getID(base64BinaryIDRef) as XsdTypeBase64Binary;
                    return this.base64Binary; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.base64Binary != value)
                {
                    this.base64Binary = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBase64BinaryIDRef { get; set; }
        #region Url
        private XsdTypeAnyURI url;
        public XsdTypeAnyURI Url
        {
            get
            {
                if (this.url != null)
                {
                    return this.url; 
                }
                else if (this.urlIDRef != null)
                {
                    url = IDManager.getID(urlIDRef) as XsdTypeAnyURI;
                    return this.url; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.url != value)
                {
                    this.url = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeAnyURIIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

