using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryType
    {
        public ElectricityDeliveryType(XmlNode xmlNode)
        {
            XmlNodeList firmNodeList = xmlNode.SelectNodes("firm");
            if (firmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firmIDRef = item.Attributes["id"].Name;
                        ElectricityDeliveryFirm ob = ElectricityDeliveryFirm();
                        IDManager.SetID(firmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firm = new ElectricityDeliveryFirm(item);
                    }
                }
            }
            
        
            XmlNodeList nonFirmNodeList = xmlNode.SelectNodes("nonFirm");
            if (nonFirmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonFirmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonFirmIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(nonFirmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonFirmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonFirm = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList systemFirmNodeList = xmlNode.SelectNodes("systemFirm");
            if (systemFirmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in systemFirmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        systemFirmIDRef = item.Attributes["id"].Name;
                        ElectricityDeliverySystemFirm ob = ElectricityDeliverySystemFirm();
                        IDManager.SetID(systemFirmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        systemFirmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        systemFirm = new ElectricityDeliverySystemFirm(item);
                    }
                }
            }
            
        
            XmlNodeList unitFirmNodeList = xmlNode.SelectNodes("unitFirm");
            if (unitFirmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unitFirmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitFirmIDRef = item.Attributes["id"].Name;
                        ElectricityDeliveryUnitFirm ob = ElectricityDeliveryUnitFirm();
                        IDManager.SetID(unitFirmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitFirmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unitFirm = new ElectricityDeliveryUnitFirm(item);
                    }
                }
            }
            
        
        }
        
    
        #region Firm
        private ElectricityDeliveryFirm firm;
        public ElectricityDeliveryFirm Firm
        {
            get
            {
                if (this.firm != null)
                {
                    return this.firm; 
                }
                else if (this.firmIDRef != null)
                {
                    firm = IDManager.getID(firmIDRef) as ElectricityDeliveryFirm;
                    return this.firm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firm != value)
                {
                    this.firm = value;
                }
            }
        }
        #endregion
        
        public string ElectricityDeliveryFirmIDRef { get; set; }
        #region NonFirm
        private XsdTypeBoolean nonFirm;
        public XsdTypeBoolean NonFirm
        {
            get
            {
                if (this.nonFirm != null)
                {
                    return this.nonFirm; 
                }
                else if (this.nonFirmIDRef != null)
                {
                    nonFirm = IDManager.getID(nonFirmIDRef) as XsdTypeBoolean;
                    return this.nonFirm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonFirm != value)
                {
                    this.nonFirm = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SystemFirm
        private ElectricityDeliverySystemFirm systemFirm;
        public ElectricityDeliverySystemFirm SystemFirm
        {
            get
            {
                if (this.systemFirm != null)
                {
                    return this.systemFirm; 
                }
                else if (this.systemFirmIDRef != null)
                {
                    systemFirm = IDManager.getID(systemFirmIDRef) as ElectricityDeliverySystemFirm;
                    return this.systemFirm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.systemFirm != value)
                {
                    this.systemFirm = value;
                }
            }
        }
        #endregion
        
        public string ElectricityDeliverySystemFirmIDRef { get; set; }
        #region UnitFirm
        private ElectricityDeliveryUnitFirm unitFirm;
        public ElectricityDeliveryUnitFirm UnitFirm
        {
            get
            {
                if (this.unitFirm != null)
                {
                    return this.unitFirm; 
                }
                else if (this.unitFirmIDRef != null)
                {
                    unitFirm = IDManager.getID(unitFirmIDRef) as ElectricityDeliveryUnitFirm;
                    return this.unitFirm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unitFirm != value)
                {
                    this.unitFirm = value;
                }
            }
        }
        #endregion
        
        public string ElectricityDeliveryUnitFirmIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

