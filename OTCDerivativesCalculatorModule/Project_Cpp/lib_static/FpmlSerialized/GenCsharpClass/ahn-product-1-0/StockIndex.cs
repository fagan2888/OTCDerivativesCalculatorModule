using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StockIndex
    {
        public StockIndex(XmlNode xmlNode)
        {
            XmlNodeList codeNodeList = xmlNode.SelectNodes("code");
            if (codeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in codeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        codeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(codeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        codeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        code = new XsdTypeToken(item);
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
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList indexTypeNodeList = xmlNode.SelectNodes("indexType");
            if (indexTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTypeIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(indexTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexType = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList businessDayConventionNodeList = xmlNode.SelectNodes("businessDayConvention");
            if (businessDayConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDayConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDayConventionIDRef = item.Attributes["id"].Name;
                        BusinessDayConventionEnum ob = BusinessDayConventionEnum();
                        IDManager.SetID(businessDayConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDayConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDayConvention = new BusinessDayConventionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList endOfMonthNodeList = xmlNode.SelectNodes("endOfMonth");
            if (endOfMonthNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endOfMonthNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endOfMonthIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(endOfMonthIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endOfMonthIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endOfMonth = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList dayCounterNodeList = xmlNode.SelectNodes("dayCounter");
            if (dayCounterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCounterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCounterIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(dayCounterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCounterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCounter = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region Code
        private XsdTypeToken code;
        public XsdTypeToken Code
        {
            get
            {
                if (this.code != null)
                {
                    return this.code; 
                }
                else if (this.codeIDRef != null)
                {
                    code = IDManager.getID(codeIDRef) as XsdTypeToken;
                    return this.code; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.code != value)
                {
                    this.code = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Name
        private XsdTypeToken name;
        public XsdTypeToken Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeToken;
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
        
        public string XsdTypeTokenIDRef { get; set; }
        #region IndexType
        private XsdTypeToken indexType;
        public XsdTypeToken IndexType
        {
            get
            {
                if (this.indexType != null)
                {
                    return this.indexType; 
                }
                else if (this.indexTypeIDRef != null)
                {
                    indexType = IDManager.getID(indexTypeIDRef) as XsdTypeToken;
                    return this.indexType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexType != value)
                {
                    this.indexType = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region BusinessDayConvention
        private BusinessDayConventionEnum businessDayConvention;
        public BusinessDayConventionEnum BusinessDayConvention
        {
            get
            {
                if (this.businessDayConvention != null)
                {
                    return this.businessDayConvention; 
                }
                else if (this.businessDayConventionIDRef != null)
                {
                    businessDayConvention = IDManager.getID(businessDayConventionIDRef) as BusinessDayConventionEnum;
                    return this.businessDayConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDayConvention != value)
                {
                    this.businessDayConvention = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayConventionEnumIDRef { get; set; }
        #region EndOfMonth
        private XsdTypeBoolean endOfMonth;
        public XsdTypeBoolean EndOfMonth
        {
            get
            {
                if (this.endOfMonth != null)
                {
                    return this.endOfMonth; 
                }
                else if (this.endOfMonthIDRef != null)
                {
                    endOfMonth = IDManager.getID(endOfMonthIDRef) as XsdTypeBoolean;
                    return this.endOfMonth; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endOfMonth != value)
                {
                    this.endOfMonth = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DayCounter
        private XsdTypeToken dayCounter;
        public XsdTypeToken DayCounter
        {
            get
            {
                if (this.dayCounter != null)
                {
                    return this.dayCounter; 
                }
                else if (this.dayCounterIDRef != null)
                {
                    dayCounter = IDManager.getID(dayCounterIDRef) as XsdTypeToken;
                    return this.dayCounter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCounter != value)
                {
                    this.dayCounter = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        
    
        
    
    }
    
}

