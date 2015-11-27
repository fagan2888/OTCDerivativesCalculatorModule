using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeDifference
    {
        public TradeDifference(XmlNode xmlNode)
        {
            XmlNodeList differenceTypeNodeList = xmlNode.SelectNodes("differenceType");
            if (differenceTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in differenceTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        differenceTypeIDRef = item.Attributes["id"].Name;
                        DifferenceTypeEnum ob = DifferenceTypeEnum();
                        IDManager.SetID(differenceTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        differenceTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        differenceType = new DifferenceTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList differenceSeverityNodeList = xmlNode.SelectNodes("differenceSeverity");
            if (differenceSeverityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in differenceSeverityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        differenceSeverityIDRef = item.Attributes["id"].Name;
                        DifferenceSeverityEnum ob = DifferenceSeverityEnum();
                        IDManager.SetID(differenceSeverityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        differenceSeverityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        differenceSeverity = new DifferenceSeverityEnum(item);
                    }
                }
            }
            
        
            XmlNodeList elementNodeList = xmlNode.SelectNodes("element");
            if (elementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in elementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        elementIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(elementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        elementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        element = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList basePathNodeList = xmlNode.SelectNodes("basePath");
            if (basePathNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basePathNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basePathIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(basePathIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basePathIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basePath = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList baseValueNodeList = xmlNode.SelectNodes("baseValue");
            if (baseValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseValueIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(baseValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseValue = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList otherPathNodeList = xmlNode.SelectNodes("otherPath");
            if (otherPathNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherPathNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherPathIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(otherPathIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherPathIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherPath = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList otherValueNodeList = xmlNode.SelectNodes("otherValue");
            if (otherValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherValueIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(otherValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherValue = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList missingElementNodeList = xmlNode.SelectNodes("missingElement");
            
            foreach (XmlNode item in missingElementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        missingElementIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(missingElementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        missingElementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    missingElement.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNodeList extraElementNodeList = xmlNode.SelectNodes("extraElement");
            
            foreach (XmlNode item in extraElementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extraElementIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(extraElementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extraElementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    extraElement.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNodeList messageNodeList = xmlNode.SelectNodes("message");
            if (messageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in messageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        messageIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(messageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        messageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        message = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region DifferenceType
        private DifferenceTypeEnum differenceType;
        public DifferenceTypeEnum DifferenceType
        {
            get
            {
                if (this.differenceType != null)
                {
                    return this.differenceType; 
                }
                else if (this.differenceTypeIDRef != null)
                {
                    differenceType = IDManager.getID(differenceTypeIDRef) as DifferenceTypeEnum;
                    return this.differenceType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.differenceType != value)
                {
                    this.differenceType = value;
                }
            }
        }
        #endregion
        
        public string DifferenceTypeEnumIDRef { get; set; }
        #region DifferenceSeverity
        private DifferenceSeverityEnum differenceSeverity;
        public DifferenceSeverityEnum DifferenceSeverity
        {
            get
            {
                if (this.differenceSeverity != null)
                {
                    return this.differenceSeverity; 
                }
                else if (this.differenceSeverityIDRef != null)
                {
                    differenceSeverity = IDManager.getID(differenceSeverityIDRef) as DifferenceSeverityEnum;
                    return this.differenceSeverity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.differenceSeverity != value)
                {
                    this.differenceSeverity = value;
                }
            }
        }
        #endregion
        
        public string DifferenceSeverityEnumIDRef { get; set; }
        #region Element
        private XsdTypeString element;
        public XsdTypeString Element
        {
            get
            {
                if (this.element != null)
                {
                    return this.element; 
                }
                else if (this.elementIDRef != null)
                {
                    element = IDManager.getID(elementIDRef) as XsdTypeString;
                    return this.element; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.element != value)
                {
                    this.element = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region BasePath
        private XsdTypeString basePath;
        public XsdTypeString BasePath
        {
            get
            {
                if (this.basePath != null)
                {
                    return this.basePath; 
                }
                else if (this.basePathIDRef != null)
                {
                    basePath = IDManager.getID(basePathIDRef) as XsdTypeString;
                    return this.basePath; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basePath != value)
                {
                    this.basePath = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region BaseValue
        private XsdTypeString baseValue;
        public XsdTypeString BaseValue
        {
            get
            {
                if (this.baseValue != null)
                {
                    return this.baseValue; 
                }
                else if (this.baseValueIDRef != null)
                {
                    baseValue = IDManager.getID(baseValueIDRef) as XsdTypeString;
                    return this.baseValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseValue != value)
                {
                    this.baseValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region OtherPath
        private XsdTypeString otherPath;
        public XsdTypeString OtherPath
        {
            get
            {
                if (this.otherPath != null)
                {
                    return this.otherPath; 
                }
                else if (this.otherPathIDRef != null)
                {
                    otherPath = IDManager.getID(otherPathIDRef) as XsdTypeString;
                    return this.otherPath; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherPath != value)
                {
                    this.otherPath = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region OtherValue
        private XsdTypeString otherValue;
        public XsdTypeString OtherValue
        {
            get
            {
                if (this.otherValue != null)
                {
                    return this.otherValue; 
                }
                else if (this.otherValueIDRef != null)
                {
                    otherValue = IDManager.getID(otherValueIDRef) as XsdTypeString;
                    return this.otherValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherValue != value)
                {
                    this.otherValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region MissingElement
        private XsdTypeString missingElement;
        public XsdTypeString MissingElement
        {
            get
            {
                if (this.missingElement != null)
                {
                    return this.missingElement; 
                }
                else if (this.missingElementIDRef != null)
                {
                    missingElement = IDManager.getID(missingElementIDRef) as XsdTypeString;
                    return this.missingElement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.missingElement != value)
                {
                    this.missingElement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ExtraElement
        private XsdTypeString extraElement;
        public XsdTypeString ExtraElement
        {
            get
            {
                if (this.extraElement != null)
                {
                    return this.extraElement; 
                }
                else if (this.extraElementIDRef != null)
                {
                    extraElement = IDManager.getID(extraElementIDRef) as XsdTypeString;
                    return this.extraElement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extraElement != value)
                {
                    this.extraElement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region Message
        private XsdTypeString message;
        public XsdTypeString Message
        {
            get
            {
                if (this.message != null)
                {
                    return this.message; 
                }
                else if (this.messageIDRef != null)
                {
                    message = IDManager.getID(messageIDRef) as XsdTypeString;
                    return this.message; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.message != value)
                {
                    this.message = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

