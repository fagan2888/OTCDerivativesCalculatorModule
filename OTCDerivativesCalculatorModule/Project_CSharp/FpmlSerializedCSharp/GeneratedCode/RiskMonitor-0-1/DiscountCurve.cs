using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class DiscountCurve : ISerialized
    {
        public DiscountCurve() { }
        public DiscountCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
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
        
    
        
    
    }
    
}

