using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RangeEventCheck
    {
        public RangeEventCheck(XmlNode xmlNode)
        {
            XmlNodeList highCheckValueNodeList = xmlNode.SelectNodes("highCheckValue");
            if (highCheckValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in highCheckValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        highCheckValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(highCheckValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        highCheckValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        highCheckValue = new XsdTypeDouble(item);
                    }
                }
            }
            
        
            XmlNodeList highEqualityNodeList = xmlNode.SelectNodes("highEquality");
            if (highEqualityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in highEqualityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        highEqualityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(highEqualityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        highEqualityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        highEquality = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList lowCheckValueNodeList = xmlNode.SelectNodes("lowCheckValue");
            if (lowCheckValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lowCheckValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lowCheckValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(lowCheckValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lowCheckValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lowCheckValue = new XsdTypeDouble(item);
                    }
                }
            }
            
        
            XmlNodeList lowEqualityNodeList = xmlNode.SelectNodes("lowEquality");
            if (lowEqualityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lowEqualityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lowEqualityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(lowEqualityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lowEqualityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lowEquality = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region HighCheckValue
        private XsdTypeDouble highCheckValue;
        public XsdTypeDouble HighCheckValue
        {
            get
            {
                if (this.highCheckValue != null)
                {
                    return this.highCheckValue; 
                }
                else if (this.highCheckValueIDRef != null)
                {
                    highCheckValue = IDManager.getID(highCheckValueIDRef) as XsdTypeDouble;
                    return this.highCheckValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.highCheckValue != value)
                {
                    this.highCheckValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        #region HighEquality
        private XsdTypeBoolean highEquality;
        public XsdTypeBoolean HighEquality
        {
            get
            {
                if (this.highEquality != null)
                {
                    return this.highEquality; 
                }
                else if (this.highEqualityIDRef != null)
                {
                    highEquality = IDManager.getID(highEqualityIDRef) as XsdTypeBoolean;
                    return this.highEquality; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.highEquality != value)
                {
                    this.highEquality = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region LowCheckValue
        private XsdTypeDouble lowCheckValue;
        public XsdTypeDouble LowCheckValue
        {
            get
            {
                if (this.lowCheckValue != null)
                {
                    return this.lowCheckValue; 
                }
                else if (this.lowCheckValueIDRef != null)
                {
                    lowCheckValue = IDManager.getID(lowCheckValueIDRef) as XsdTypeDouble;
                    return this.lowCheckValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lowCheckValue != value)
                {
                    this.lowCheckValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        #region LowEquality
        private XsdTypeBoolean lowEquality;
        public XsdTypeBoolean LowEquality
        {
            get
            {
                if (this.lowEquality != null)
                {
                    return this.lowEquality; 
                }
                else if (this.lowEqualityIDRef != null)
                {
                    lowEquality = IDManager.getID(lowEqualityIDRef) as XsdTypeBoolean;
                    return this.lowEquality; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lowEquality != value)
                {
                    this.lowEquality = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

