using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeDifference : ISerialized
    {
        public TradeDifference(XmlNode xmlNode)
        {
            XmlNode differenceTypeNode = xmlNode.SelectSingleNode("differenceType");
            
            if (differenceTypeNode != null)
            {
                if (differenceTypeNode.Attributes["href"] != null || differenceTypeNode.Attributes["id"] != null) 
                {
                    if (differenceTypeNode.Attributes["id"] != null) 
                    {
                        differenceTypeIDRef_ = differenceTypeNode.Attributes["id"].Value;
                        DifferenceTypeEnum ob = new DifferenceTypeEnum(differenceTypeNode);
                        IDManager.SetID(differenceTypeIDRef_, ob);
                    }
                    else if (differenceTypeNode.Attributes["href"] != null)
                    {
                        differenceTypeIDRef_ = differenceTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        differenceType_ = new DifferenceTypeEnum(differenceTypeNode);
                    }
                }
                else
                {
                    differenceType_ = new DifferenceTypeEnum(differenceTypeNode);
                }
            }
            
        
            XmlNode differenceSeverityNode = xmlNode.SelectSingleNode("differenceSeverity");
            
            if (differenceSeverityNode != null)
            {
                if (differenceSeverityNode.Attributes["href"] != null || differenceSeverityNode.Attributes["id"] != null) 
                {
                    if (differenceSeverityNode.Attributes["id"] != null) 
                    {
                        differenceSeverityIDRef_ = differenceSeverityNode.Attributes["id"].Value;
                        DifferenceSeverityEnum ob = new DifferenceSeverityEnum(differenceSeverityNode);
                        IDManager.SetID(differenceSeverityIDRef_, ob);
                    }
                    else if (differenceSeverityNode.Attributes["href"] != null)
                    {
                        differenceSeverityIDRef_ = differenceSeverityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        differenceSeverity_ = new DifferenceSeverityEnum(differenceSeverityNode);
                    }
                }
                else
                {
                    differenceSeverity_ = new DifferenceSeverityEnum(differenceSeverityNode);
                }
            }
            
        
            XmlNode elementNode = xmlNode.SelectSingleNode("element");
            
            if (elementNode != null)
            {
                if (elementNode.Attributes["href"] != null || elementNode.Attributes["id"] != null) 
                {
                    if (elementNode.Attributes["id"] != null) 
                    {
                        elementIDRef_ = elementNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(elementNode);
                        IDManager.SetID(elementIDRef_, ob);
                    }
                    else if (elementNode.Attributes["href"] != null)
                    {
                        elementIDRef_ = elementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        element_ = new XsdTypeString(elementNode);
                    }
                }
                else
                {
                    element_ = new XsdTypeString(elementNode);
                }
            }
            
        
            XmlNode basePathNode = xmlNode.SelectSingleNode("basePath");
            
            if (basePathNode != null)
            {
                if (basePathNode.Attributes["href"] != null || basePathNode.Attributes["id"] != null) 
                {
                    if (basePathNode.Attributes["id"] != null) 
                    {
                        basePathIDRef_ = basePathNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(basePathNode);
                        IDManager.SetID(basePathIDRef_, ob);
                    }
                    else if (basePathNode.Attributes["href"] != null)
                    {
                        basePathIDRef_ = basePathNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basePath_ = new XsdTypeString(basePathNode);
                    }
                }
                else
                {
                    basePath_ = new XsdTypeString(basePathNode);
                }
            }
            
        
            XmlNode baseValueNode = xmlNode.SelectSingleNode("baseValue");
            
            if (baseValueNode != null)
            {
                if (baseValueNode.Attributes["href"] != null || baseValueNode.Attributes["id"] != null) 
                {
                    if (baseValueNode.Attributes["id"] != null) 
                    {
                        baseValueIDRef_ = baseValueNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(baseValueNode);
                        IDManager.SetID(baseValueIDRef_, ob);
                    }
                    else if (baseValueNode.Attributes["href"] != null)
                    {
                        baseValueIDRef_ = baseValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseValue_ = new XsdTypeString(baseValueNode);
                    }
                }
                else
                {
                    baseValue_ = new XsdTypeString(baseValueNode);
                }
            }
            
        
            XmlNode otherPathNode = xmlNode.SelectSingleNode("otherPath");
            
            if (otherPathNode != null)
            {
                if (otherPathNode.Attributes["href"] != null || otherPathNode.Attributes["id"] != null) 
                {
                    if (otherPathNode.Attributes["id"] != null) 
                    {
                        otherPathIDRef_ = otherPathNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(otherPathNode);
                        IDManager.SetID(otherPathIDRef_, ob);
                    }
                    else if (otherPathNode.Attributes["href"] != null)
                    {
                        otherPathIDRef_ = otherPathNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherPath_ = new XsdTypeString(otherPathNode);
                    }
                }
                else
                {
                    otherPath_ = new XsdTypeString(otherPathNode);
                }
            }
            
        
            XmlNode otherValueNode = xmlNode.SelectSingleNode("otherValue");
            
            if (otherValueNode != null)
            {
                if (otherValueNode.Attributes["href"] != null || otherValueNode.Attributes["id"] != null) 
                {
                    if (otherValueNode.Attributes["id"] != null) 
                    {
                        otherValueIDRef_ = otherValueNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(otherValueNode);
                        IDManager.SetID(otherValueIDRef_, ob);
                    }
                    else if (otherValueNode.Attributes["href"] != null)
                    {
                        otherValueIDRef_ = otherValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherValue_ = new XsdTypeString(otherValueNode);
                    }
                }
                else
                {
                    otherValue_ = new XsdTypeString(otherValueNode);
                }
            }
            
        
            XmlNodeList missingElementNodeList = xmlNode.SelectNodes("missingElement");
            
            if (missingElementNodeList != null)
            {
                this.missingElement_ = new List<XsdTypeString>();
                foreach (XmlNode item in missingElementNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            missingElementIDRef_ = item.Attributes["id"].Value;
                            missingElement_.Add(new XsdTypeString(item));
                            IDManager.SetID(missingElementIDRef_, missingElement_[missingElement_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            missingElementIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        missingElement_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        missingElement_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNodeList extraElementNodeList = xmlNode.SelectNodes("extraElement");
            
            if (extraElementNodeList != null)
            {
                this.extraElement_ = new List<XsdTypeString>();
                foreach (XmlNode item in extraElementNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            extraElementIDRef_ = item.Attributes["id"].Value;
                            extraElement_.Add(new XsdTypeString(item));
                            IDManager.SetID(extraElementIDRef_, extraElement_[extraElement_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            extraElementIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        extraElement_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        extraElement_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNode messageNode = xmlNode.SelectSingleNode("message");
            
            if (messageNode != null)
            {
                if (messageNode.Attributes["href"] != null || messageNode.Attributes["id"] != null) 
                {
                    if (messageNode.Attributes["id"] != null) 
                    {
                        messageIDRef_ = messageNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(messageNode);
                        IDManager.SetID(messageIDRef_, ob);
                    }
                    else if (messageNode.Attributes["href"] != null)
                    {
                        messageIDRef_ = messageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        message_ = new XsdTypeString(messageNode);
                    }
                }
                else
                {
                    message_ = new XsdTypeString(messageNode);
                }
            }
            
        
        }
        
    
        #region DifferenceType_
        private DifferenceTypeEnum differenceType_;
        public DifferenceTypeEnum DifferenceType_
        {
            get
            {
                if (this.differenceType_ != null)
                {
                    return this.differenceType_; 
                }
                else if (this.differenceTypeIDRef_ != null)
                {
                    differenceType_ = IDManager.getID(differenceTypeIDRef_) as DifferenceTypeEnum;
                    return this.differenceType_; 
                }
                else
                {
                      return this.differenceType_; 
                }
            }
            set
            {
                if (this.differenceType_ != value)
                {
                    this.differenceType_ = value;
                }
            }
        }
        #endregion
        
        public string differenceTypeIDRef_ { get; set; }
        #region DifferenceSeverity_
        private DifferenceSeverityEnum differenceSeverity_;
        public DifferenceSeverityEnum DifferenceSeverity_
        {
            get
            {
                if (this.differenceSeverity_ != null)
                {
                    return this.differenceSeverity_; 
                }
                else if (this.differenceSeverityIDRef_ != null)
                {
                    differenceSeverity_ = IDManager.getID(differenceSeverityIDRef_) as DifferenceSeverityEnum;
                    return this.differenceSeverity_; 
                }
                else
                {
                      return this.differenceSeverity_; 
                }
            }
            set
            {
                if (this.differenceSeverity_ != value)
                {
                    this.differenceSeverity_ = value;
                }
            }
        }
        #endregion
        
        public string differenceSeverityIDRef_ { get; set; }
        #region Element_
        private XsdTypeString element_;
        public XsdTypeString Element_
        {
            get
            {
                if (this.element_ != null)
                {
                    return this.element_; 
                }
                else if (this.elementIDRef_ != null)
                {
                    element_ = IDManager.getID(elementIDRef_) as XsdTypeString;
                    return this.element_; 
                }
                else
                {
                      return this.element_; 
                }
            }
            set
            {
                if (this.element_ != value)
                {
                    this.element_ = value;
                }
            }
        }
        #endregion
        
        public string elementIDRef_ { get; set; }
        #region BasePath_
        private XsdTypeString basePath_;
        public XsdTypeString BasePath_
        {
            get
            {
                if (this.basePath_ != null)
                {
                    return this.basePath_; 
                }
                else if (this.basePathIDRef_ != null)
                {
                    basePath_ = IDManager.getID(basePathIDRef_) as XsdTypeString;
                    return this.basePath_; 
                }
                else
                {
                      return this.basePath_; 
                }
            }
            set
            {
                if (this.basePath_ != value)
                {
                    this.basePath_ = value;
                }
            }
        }
        #endregion
        
        public string basePathIDRef_ { get; set; }
        #region BaseValue_
        private XsdTypeString baseValue_;
        public XsdTypeString BaseValue_
        {
            get
            {
                if (this.baseValue_ != null)
                {
                    return this.baseValue_; 
                }
                else if (this.baseValueIDRef_ != null)
                {
                    baseValue_ = IDManager.getID(baseValueIDRef_) as XsdTypeString;
                    return this.baseValue_; 
                }
                else
                {
                      return this.baseValue_; 
                }
            }
            set
            {
                if (this.baseValue_ != value)
                {
                    this.baseValue_ = value;
                }
            }
        }
        #endregion
        
        public string baseValueIDRef_ { get; set; }
        #region OtherPath_
        private XsdTypeString otherPath_;
        public XsdTypeString OtherPath_
        {
            get
            {
                if (this.otherPath_ != null)
                {
                    return this.otherPath_; 
                }
                else if (this.otherPathIDRef_ != null)
                {
                    otherPath_ = IDManager.getID(otherPathIDRef_) as XsdTypeString;
                    return this.otherPath_; 
                }
                else
                {
                      return this.otherPath_; 
                }
            }
            set
            {
                if (this.otherPath_ != value)
                {
                    this.otherPath_ = value;
                }
            }
        }
        #endregion
        
        public string otherPathIDRef_ { get; set; }
        #region OtherValue_
        private XsdTypeString otherValue_;
        public XsdTypeString OtherValue_
        {
            get
            {
                if (this.otherValue_ != null)
                {
                    return this.otherValue_; 
                }
                else if (this.otherValueIDRef_ != null)
                {
                    otherValue_ = IDManager.getID(otherValueIDRef_) as XsdTypeString;
                    return this.otherValue_; 
                }
                else
                {
                      return this.otherValue_; 
                }
            }
            set
            {
                if (this.otherValue_ != value)
                {
                    this.otherValue_ = value;
                }
            }
        }
        #endregion
        
        public string otherValueIDRef_ { get; set; }
        #region MissingElement_
        private List<XsdTypeString> missingElement_;
        public List<XsdTypeString> MissingElement_
        {
            get
            {
                if (this.missingElement_ != null)
                {
                    return this.missingElement_; 
                }
                else if (this.missingElementIDRef_ != null)
                {
                    return this.missingElement_; 
                }
                else
                {
                      return this.missingElement_; 
                }
            }
            set
            {
                if (this.missingElement_ != value)
                {
                    this.missingElement_ = value;
                }
            }
        }
        #endregion
        
        public string missingElementIDRef_ { get; set; }
        #region ExtraElement_
        private List<XsdTypeString> extraElement_;
        public List<XsdTypeString> ExtraElement_
        {
            get
            {
                if (this.extraElement_ != null)
                {
                    return this.extraElement_; 
                }
                else if (this.extraElementIDRef_ != null)
                {
                    return this.extraElement_; 
                }
                else
                {
                      return this.extraElement_; 
                }
            }
            set
            {
                if (this.extraElement_ != value)
                {
                    this.extraElement_ = value;
                }
            }
        }
        #endregion
        
        public string extraElementIDRef_ { get; set; }
        #region Message_
        private XsdTypeString message_;
        public XsdTypeString Message_
        {
            get
            {
                if (this.message_ != null)
                {
                    return this.message_; 
                }
                else if (this.messageIDRef_ != null)
                {
                    message_ = IDManager.getID(messageIDRef_) as XsdTypeString;
                    return this.message_; 
                }
                else
                {
                      return this.message_; 
                }
            }
            set
            {
                if (this.message_ != value)
                {
                    this.message_ = value;
                }
            }
        }
        #endregion
        
        public string messageIDRef_ { get; set; }
        
    
        
    
    }
    
}

