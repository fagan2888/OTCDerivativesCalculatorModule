using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExternalDocument : ISerialized
    {
        public ExternalDocument(XmlNode xmlNode)
        {
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
            
        
            XmlNode attachmentReferenceNode = xmlNode.SelectSingleNode("attachmentReference");
            
            if (attachmentReferenceNode != null)
            {
                if (attachmentReferenceNode.Attributes["href"] != null || attachmentReferenceNode.Attributes["id"] != null) 
                {
                    if (attachmentReferenceNode.Attributes["id"] != null) 
                    {
                        attachmentReferenceIDRef_ = attachmentReferenceNode.Attributes["id"].Value;
                        HTTPAttachmentReference ob = new HTTPAttachmentReference(attachmentReferenceNode);
                        IDManager.SetID(attachmentReferenceIDRef_, ob);
                    }
                    else if (attachmentReferenceNode.Attributes["href"] != null)
                    {
                        attachmentReferenceIDRef_ = attachmentReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        attachmentReference_ = new HTTPAttachmentReference(attachmentReferenceNode);
                    }
                }
                else
                {
                    attachmentReference_ = new HTTPAttachmentReference(attachmentReferenceNode);
                }
            }
            
        
        }
        
    
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
        #region AttachmentReference_
        private HTTPAttachmentReference attachmentReference_;
        public HTTPAttachmentReference AttachmentReference_
        {
            get
            {
                if (this.attachmentReference_ != null)
                {
                    return this.attachmentReference_; 
                }
                else if (this.attachmentReferenceIDRef_ != null)
                {
                    attachmentReference_ = IDManager.getID(attachmentReferenceIDRef_) as HTTPAttachmentReference;
                    return this.attachmentReference_; 
                }
                else
                {
                      return this.attachmentReference_; 
                }
            }
            set
            {
                if (this.attachmentReference_ != value)
                {
                    this.attachmentReference_ = value;
                }
            }
        }
        #endregion
        
        public string attachmentReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

