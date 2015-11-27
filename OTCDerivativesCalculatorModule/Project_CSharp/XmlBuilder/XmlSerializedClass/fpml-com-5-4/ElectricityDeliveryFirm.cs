using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryFirm : ISerialized
    {
        public ElectricityDeliveryFirm(XmlNode xmlNode)
        {
            XmlNode forceMajeureNode = xmlNode.SelectSingleNode("forceMajeure");
            
            if (forceMajeureNode != null)
            {
                if (forceMajeureNode.Attributes["href"] != null || forceMajeureNode.Attributes["id"] != null) 
                {
                    if (forceMajeureNode.Attributes["id"] != null) 
                    {
                        forceMajeureIDRef_ = forceMajeureNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(forceMajeureNode);
                        IDManager.SetID(forceMajeureIDRef_, ob);
                    }
                    else if (forceMajeureNode.Attributes["href"] != null)
                    {
                        forceMajeureIDRef_ = forceMajeureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forceMajeure_ = new XsdTypeBoolean(forceMajeureNode);
                    }
                }
                else
                {
                    forceMajeure_ = new XsdTypeBoolean(forceMajeureNode);
                }
            }
            
        
        }
        
    
        #region ForceMajeure_
        private XsdTypeBoolean forceMajeure_;
        public XsdTypeBoolean ForceMajeure_
        {
            get
            {
                if (this.forceMajeure_ != null)
                {
                    return this.forceMajeure_; 
                }
                else if (this.forceMajeureIDRef_ != null)
                {
                    forceMajeure_ = IDManager.getID(forceMajeureIDRef_) as XsdTypeBoolean;
                    return this.forceMajeure_; 
                }
                else
                {
                      return this.forceMajeure_; 
                }
            }
            set
            {
                if (this.forceMajeure_ != value)
                {
                    this.forceMajeure_ = value;
                }
            }
        }
        #endregion
        
        public string forceMajeureIDRef_ { get; set; }
        
    
        
    
    }
    
}

