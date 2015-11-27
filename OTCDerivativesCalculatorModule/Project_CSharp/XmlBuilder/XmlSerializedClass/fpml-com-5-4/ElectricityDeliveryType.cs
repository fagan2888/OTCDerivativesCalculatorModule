using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryType : ISerialized
    {
        public ElectricityDeliveryType(XmlNode xmlNode)
        {
            XmlNode firmNode = xmlNode.SelectSingleNode("firm");
            
            if (firmNode != null)
            {
                if (firmNode.Attributes["href"] != null || firmNode.Attributes["id"] != null) 
                {
                    if (firmNode.Attributes["id"] != null) 
                    {
                        firmIDRef_ = firmNode.Attributes["id"].Value;
                        ElectricityDeliveryFirm ob = new ElectricityDeliveryFirm(firmNode);
                        IDManager.SetID(firmIDRef_, ob);
                    }
                    else if (firmNode.Attributes["href"] != null)
                    {
                        firmIDRef_ = firmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firm_ = new ElectricityDeliveryFirm(firmNode);
                    }
                }
                else
                {
                    firm_ = new ElectricityDeliveryFirm(firmNode);
                }
            }
            
        
            XmlNode nonFirmNode = xmlNode.SelectSingleNode("nonFirm");
            
            if (nonFirmNode != null)
            {
                if (nonFirmNode.Attributes["href"] != null || nonFirmNode.Attributes["id"] != null) 
                {
                    if (nonFirmNode.Attributes["id"] != null) 
                    {
                        nonFirmIDRef_ = nonFirmNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(nonFirmNode);
                        IDManager.SetID(nonFirmIDRef_, ob);
                    }
                    else if (nonFirmNode.Attributes["href"] != null)
                    {
                        nonFirmIDRef_ = nonFirmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonFirm_ = new XsdTypeBoolean(nonFirmNode);
                    }
                }
                else
                {
                    nonFirm_ = new XsdTypeBoolean(nonFirmNode);
                }
            }
            
        
            XmlNode systemFirmNode = xmlNode.SelectSingleNode("systemFirm");
            
            if (systemFirmNode != null)
            {
                if (systemFirmNode.Attributes["href"] != null || systemFirmNode.Attributes["id"] != null) 
                {
                    if (systemFirmNode.Attributes["id"] != null) 
                    {
                        systemFirmIDRef_ = systemFirmNode.Attributes["id"].Value;
                        ElectricityDeliverySystemFirm ob = new ElectricityDeliverySystemFirm(systemFirmNode);
                        IDManager.SetID(systemFirmIDRef_, ob);
                    }
                    else if (systemFirmNode.Attributes["href"] != null)
                    {
                        systemFirmIDRef_ = systemFirmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        systemFirm_ = new ElectricityDeliverySystemFirm(systemFirmNode);
                    }
                }
                else
                {
                    systemFirm_ = new ElectricityDeliverySystemFirm(systemFirmNode);
                }
            }
            
        
            XmlNode unitFirmNode = xmlNode.SelectSingleNode("unitFirm");
            
            if (unitFirmNode != null)
            {
                if (unitFirmNode.Attributes["href"] != null || unitFirmNode.Attributes["id"] != null) 
                {
                    if (unitFirmNode.Attributes["id"] != null) 
                    {
                        unitFirmIDRef_ = unitFirmNode.Attributes["id"].Value;
                        ElectricityDeliveryUnitFirm ob = new ElectricityDeliveryUnitFirm(unitFirmNode);
                        IDManager.SetID(unitFirmIDRef_, ob);
                    }
                    else if (unitFirmNode.Attributes["href"] != null)
                    {
                        unitFirmIDRef_ = unitFirmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unitFirm_ = new ElectricityDeliveryUnitFirm(unitFirmNode);
                    }
                }
                else
                {
                    unitFirm_ = new ElectricityDeliveryUnitFirm(unitFirmNode);
                }
            }
            
        
        }
        
    
        #region Firm_
        private ElectricityDeliveryFirm firm_;
        public ElectricityDeliveryFirm Firm_
        {
            get
            {
                if (this.firm_ != null)
                {
                    return this.firm_; 
                }
                else if (this.firmIDRef_ != null)
                {
                    firm_ = IDManager.getID(firmIDRef_) as ElectricityDeliveryFirm;
                    return this.firm_; 
                }
                else
                {
                      return this.firm_; 
                }
            }
            set
            {
                if (this.firm_ != value)
                {
                    this.firm_ = value;
                }
            }
        }
        #endregion
        
        public string firmIDRef_ { get; set; }
        #region NonFirm_
        private XsdTypeBoolean nonFirm_;
        public XsdTypeBoolean NonFirm_
        {
            get
            {
                if (this.nonFirm_ != null)
                {
                    return this.nonFirm_; 
                }
                else if (this.nonFirmIDRef_ != null)
                {
                    nonFirm_ = IDManager.getID(nonFirmIDRef_) as XsdTypeBoolean;
                    return this.nonFirm_; 
                }
                else
                {
                      return this.nonFirm_; 
                }
            }
            set
            {
                if (this.nonFirm_ != value)
                {
                    this.nonFirm_ = value;
                }
            }
        }
        #endregion
        
        public string nonFirmIDRef_ { get; set; }
        #region SystemFirm_
        private ElectricityDeliverySystemFirm systemFirm_;
        public ElectricityDeliverySystemFirm SystemFirm_
        {
            get
            {
                if (this.systemFirm_ != null)
                {
                    return this.systemFirm_; 
                }
                else if (this.systemFirmIDRef_ != null)
                {
                    systemFirm_ = IDManager.getID(systemFirmIDRef_) as ElectricityDeliverySystemFirm;
                    return this.systemFirm_; 
                }
                else
                {
                      return this.systemFirm_; 
                }
            }
            set
            {
                if (this.systemFirm_ != value)
                {
                    this.systemFirm_ = value;
                }
            }
        }
        #endregion
        
        public string systemFirmIDRef_ { get; set; }
        #region UnitFirm_
        private ElectricityDeliveryUnitFirm unitFirm_;
        public ElectricityDeliveryUnitFirm UnitFirm_
        {
            get
            {
                if (this.unitFirm_ != null)
                {
                    return this.unitFirm_; 
                }
                else if (this.unitFirmIDRef_ != null)
                {
                    unitFirm_ = IDManager.getID(unitFirmIDRef_) as ElectricityDeliveryUnitFirm;
                    return this.unitFirm_; 
                }
                else
                {
                      return this.unitFirm_; 
                }
            }
            set
            {
                if (this.unitFirm_ != value)
                {
                    this.unitFirm_ = value;
                }
            }
        }
        #endregion
        
        public string unitFirmIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

