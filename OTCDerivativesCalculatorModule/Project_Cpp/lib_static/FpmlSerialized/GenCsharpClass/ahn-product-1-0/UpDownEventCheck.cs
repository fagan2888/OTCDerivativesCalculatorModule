using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class UpDownEventCheck
    {
        public UpDownEventCheck(XmlNode xmlNode)
        {
            XmlNodeList checkValueNodeList = xmlNode.SelectNodes("checkValue");
            if (checkValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in checkValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        checkValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(checkValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        checkValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        checkValue = new XsdTypeDouble(item);
                    }
                }
            }
            
        
            XmlNodeList equalityNodeList = xmlNode.SelectNodes("equality");
            if (equalityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equalityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equalityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(equalityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equalityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equality = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region CheckValue
        private XsdTypeDouble checkValue;
        public XsdTypeDouble CheckValue
        {
            get
            {
                if (this.checkValue != null)
                {
                    return this.checkValue; 
                }
                else if (this.checkValueIDRef != null)
                {
                    checkValue = IDManager.getID(checkValueIDRef) as XsdTypeDouble;
                    return this.checkValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.checkValue != value)
                {
                    this.checkValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        #region Equality
        private XsdTypeBoolean equality;
        public XsdTypeBoolean Equality
        {
            get
            {
                if (this.equality != null)
                {
                    return this.equality; 
                }
                else if (this.equalityIDRef != null)
                {
                    equality = IDManager.getID(equalityIDRef) as XsdTypeBoolean;
                    return this.equality; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equality != value)
                {
                    this.equality = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

