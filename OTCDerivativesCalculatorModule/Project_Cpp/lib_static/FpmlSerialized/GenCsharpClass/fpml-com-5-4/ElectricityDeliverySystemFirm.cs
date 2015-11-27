using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliverySystemFirm
    {
        public ElectricityDeliverySystemFirm(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList systemNodeList = xmlNode.SelectNodes("system");
            if (systemNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in systemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        systemIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(systemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        systemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        system = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region System
        private CommodityDeliveryPoint system;
        public CommodityDeliveryPoint System
        {
            get
            {
                if (this.system != null)
                {
                    return this.system; 
                }
                else if (this.systemIDRef != null)
                {
                    system = IDManager.getID(systemIDRef) as CommodityDeliveryPoint;
                    return this.system; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.system != value)
                {
                    this.system = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        
    
        
    
    }
    
}

