using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryFirm
    {
        public ElectricityDeliveryFirm(XmlNode xmlNode)
        {
            XmlNodeList forceMajeureNodeList = xmlNode.SelectNodes("forceMajeure");
            if (forceMajeureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forceMajeureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forceMajeureIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(forceMajeureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forceMajeureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forceMajeure = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ForceMajeure
        private XsdTypeBoolean forceMajeure;
        public XsdTypeBoolean ForceMajeure
        {
            get
            {
                if (this.forceMajeure != null)
                {
                    return this.forceMajeure; 
                }
                else if (this.forceMajeureIDRef != null)
                {
                    forceMajeure = IDManager.getID(forceMajeureIDRef) as XsdTypeBoolean;
                    return this.forceMajeure; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forceMajeure != value)
                {
                    this.forceMajeure = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

