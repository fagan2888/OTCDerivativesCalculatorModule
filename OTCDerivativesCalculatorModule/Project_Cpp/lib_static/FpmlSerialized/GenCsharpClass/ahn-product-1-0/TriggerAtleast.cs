using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TriggerAtleast
    {
        public TriggerAtleast(XmlNode xmlNode)
        {
            XmlNodeList countNodeList = xmlNode.SelectNodes("count");
            if (countNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in countNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        countIDRef = item.Attributes["id"].Name;
                        XsdTypeDouble ob = XsdTypeDouble();
                        IDManager.SetID(countIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        countIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        count = new XsdTypeDouble(item);
                    }
                }
            }
            
        
        }
        
    
        #region Count
        private XsdTypeDouble count;
        public XsdTypeDouble Count
        {
            get
            {
                if (this.count != null)
                {
                    return this.count; 
                }
                else if (this.countIDRef != null)
                {
                    count = IDManager.getID(countIDRef) as XsdTypeDouble;
                    return this.count; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.count != value)
                {
                    this.count = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDoubleIDRef { get; set; }
        
    
        
    
    }
    
}

