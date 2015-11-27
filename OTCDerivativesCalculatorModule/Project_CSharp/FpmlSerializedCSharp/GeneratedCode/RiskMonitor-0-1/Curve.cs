using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Curve : ISerialized
    {
        public Curve() { }
        public Curve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode cdsSpreadTermstructureNode = xmlNode.SelectSingleNode("cdsSpreadTermstructure");
            
            if (cdsSpreadTermstructureNode != null)
            {
                if (cdsSpreadTermstructureNode.Attributes["href"] != null || cdsSpreadTermstructureNode.Attributes["id"] != null) 
                {
                    if (cdsSpreadTermstructureNode.Attributes["id"] != null) 
                    {
                        cdsSpreadTermstructureIDRef_ = cdsSpreadTermstructureNode.Attributes["id"].Value;
                        CDSSpreadTermstructure ob = new CDSSpreadTermstructure(cdsSpreadTermstructureNode);
                        IDManager.SetID(cdsSpreadTermstructureIDRef_, ob);
                    }
                    else if (cdsSpreadTermstructureNode.Attributes["href"] != null)
                    {
                        cdsSpreadTermstructureIDRef_ = cdsSpreadTermstructureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cdsSpreadTermstructure_ = new CDSSpreadTermstructure(cdsSpreadTermstructureNode);
                    }
                }
                else
                {
                    cdsSpreadTermstructure_ = new CDSSpreadTermstructure(cdsSpreadTermstructureNode);
                }
            }
            
        
            XmlNode yieldTermstructureNode = xmlNode.SelectSingleNode("yieldTermstructure");
            
            if (yieldTermstructureNode != null)
            {
                if (yieldTermstructureNode.Attributes["href"] != null || yieldTermstructureNode.Attributes["id"] != null) 
                {
                    if (yieldTermstructureNode.Attributes["id"] != null) 
                    {
                        yieldTermstructureIDRef_ = yieldTermstructureNode.Attributes["id"].Value;
                        YieldTermstructure ob = new YieldTermstructure(yieldTermstructureNode);
                        IDManager.SetID(yieldTermstructureIDRef_, ob);
                    }
                    else if (yieldTermstructureNode.Attributes["href"] != null)
                    {
                        yieldTermstructureIDRef_ = yieldTermstructureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        yieldTermstructure_ = new YieldTermstructure(yieldTermstructureNode);
                    }
                }
                else
                {
                    yieldTermstructure_ = new YieldTermstructure(yieldTermstructureNode);
                }
            }
            
        
        }
        
    
        #region CdsSpreadTermstructure_
        private CDSSpreadTermstructure cdsSpreadTermstructure_;
        public CDSSpreadTermstructure CdsSpreadTermstructure_
        {
            get
            {
                if (this.cdsSpreadTermstructure_ != null)
                {
                    return this.cdsSpreadTermstructure_; 
                }
                else if (this.cdsSpreadTermstructureIDRef_ != null)
                {
                    cdsSpreadTermstructure_ = IDManager.getID(cdsSpreadTermstructureIDRef_) as CDSSpreadTermstructure;
                    return this.cdsSpreadTermstructure_; 
                }
                else
                {
                      return this.cdsSpreadTermstructure_; 
                }
            }
            set
            {
                if (this.cdsSpreadTermstructure_ != value)
                {
                    this.cdsSpreadTermstructure_ = value;
                }
            }
        }
        #endregion
        
        public string cdsSpreadTermstructureIDRef_ { get; set; }
        #region YieldTermstructure_
        private YieldTermstructure yieldTermstructure_;
        public YieldTermstructure YieldTermstructure_
        {
            get
            {
                if (this.yieldTermstructure_ != null)
                {
                    return this.yieldTermstructure_; 
                }
                else if (this.yieldTermstructureIDRef_ != null)
                {
                    yieldTermstructure_ = IDManager.getID(yieldTermstructureIDRef_) as YieldTermstructure;
                    return this.yieldTermstructure_; 
                }
                else
                {
                      return this.yieldTermstructure_; 
                }
            }
            set
            {
                if (this.yieldTermstructure_ != value)
                {
                    this.yieldTermstructure_ = value;
                }
            }
        }
        #endregion
        
        public string yieldTermstructureIDRef_ { get; set; }
        public string choiceStr_tsType;
        
    
        
    
    }
    
}

