using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxBoundary
    {
        public FxBoundary(XmlNode xmlNode)
        {
            XmlNodeList inclusiveNodeList = xmlNode.SelectNodes("inclusive");
            if (inclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inclusiveIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(inclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inclusive = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList exclusiveNodeList = xmlNode.SelectNodes("exclusive");
            if (exclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exclusiveIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(exclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exclusive = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region Inclusive
        private XsdTypeBoolean inclusive;
        public XsdTypeBoolean Inclusive
        {
            get
            {
                if (this.inclusive != null)
                {
                    return this.inclusive; 
                }
                else if (this.inclusiveIDRef != null)
                {
                    inclusive = IDManager.getID(inclusiveIDRef) as XsdTypeBoolean;
                    return this.inclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inclusive != value)
                {
                    this.inclusive = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Exclusive
        private XsdTypeBoolean exclusive;
        public XsdTypeBoolean Exclusive
        {
            get
            {
                if (this.exclusive != null)
                {
                    return this.exclusive; 
                }
                else if (this.exclusiveIDRef != null)
                {
                    exclusive = IDManager.getID(exclusiveIDRef) as XsdTypeBoolean;
                    return this.exclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exclusive != value)
                {
                    this.exclusive = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

