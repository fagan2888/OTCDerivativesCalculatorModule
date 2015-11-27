using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdditionalData
    {
        public AdditionalData(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList originalMessageNodeList = xmlNode.SelectNodes("originalMessage");
            if (originalMessageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originalMessageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originalMessageIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(originalMessageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originalMessageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originalMessage = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region OriginalMessage
        private XsdTypeBoolean originalMessage;
        public XsdTypeBoolean OriginalMessage
        {
            get
            {
                if (this.originalMessage != null)
                {
                    return this.originalMessage; 
                }
                else if (this.originalMessageIDRef != null)
                {
                    originalMessage = IDManager.getID(originalMessageIDRef) as XsdTypeBoolean;
                    return this.originalMessage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originalMessage != value)
                {
                    this.originalMessage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

