using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StreetAddress
    {
        public StreetAddress(XmlNode xmlNode)
        {
            XmlNodeList streetLineNodeList = xmlNode.SelectNodes("streetLine");
            
            foreach (XmlNode item in streetLineNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        streetLineIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(streetLineIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        streetLineIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    streetLine.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
        }
        
    
        #region StreetLine
        private XsdTypeString streetLine;
        public XsdTypeString StreetLine
        {
            get
            {
                if (this.streetLine != null)
                {
                    return this.streetLine; 
                }
                else if (this.streetLineIDRef != null)
                {
                    streetLine = IDManager.getID(streetLineIDRef) as XsdTypeString;
                    return this.streetLine; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.streetLine != value)
                {
                    this.streetLine = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

