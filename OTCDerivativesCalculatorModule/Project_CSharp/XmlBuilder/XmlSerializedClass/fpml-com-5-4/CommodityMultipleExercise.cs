using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityMultipleExercise : ISerialized
    {
        public CommodityMultipleExercise(XmlNode xmlNode)
        {
            XmlNode integralMultipleQuantityNode = xmlNode.SelectSingleNode("integralMultipleQuantity");
            
            if (integralMultipleQuantityNode != null)
            {
                if (integralMultipleQuantityNode.Attributes["href"] != null || integralMultipleQuantityNode.Attributes["id"] != null) 
                {
                    if (integralMultipleQuantityNode.Attributes["id"] != null) 
                    {
                        integralMultipleQuantityIDRef_ = integralMultipleQuantityNode.Attributes["id"].Value;
                        CommodityNotionalQuantity ob = new CommodityNotionalQuantity(integralMultipleQuantityNode);
                        IDManager.SetID(integralMultipleQuantityIDRef_, ob);
                    }
                    else if (integralMultipleQuantityNode.Attributes["href"] != null)
                    {
                        integralMultipleQuantityIDRef_ = integralMultipleQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        integralMultipleQuantity_ = new CommodityNotionalQuantity(integralMultipleQuantityNode);
                    }
                }
                else
                {
                    integralMultipleQuantity_ = new CommodityNotionalQuantity(integralMultipleQuantityNode);
                }
            }
            
        
            XmlNode minimumNotionalQuantityNode = xmlNode.SelectSingleNode("minimumNotionalQuantity");
            
            if (minimumNotionalQuantityNode != null)
            {
                if (minimumNotionalQuantityNode.Attributes["href"] != null || minimumNotionalQuantityNode.Attributes["id"] != null) 
                {
                    if (minimumNotionalQuantityNode.Attributes["id"] != null) 
                    {
                        minimumNotionalQuantityIDRef_ = minimumNotionalQuantityNode.Attributes["id"].Value;
                        CommodityNotionalQuantity ob = new CommodityNotionalQuantity(minimumNotionalQuantityNode);
                        IDManager.SetID(minimumNotionalQuantityIDRef_, ob);
                    }
                    else if (minimumNotionalQuantityNode.Attributes["href"] != null)
                    {
                        minimumNotionalQuantityIDRef_ = minimumNotionalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumNotionalQuantity_ = new CommodityNotionalQuantity(minimumNotionalQuantityNode);
                    }
                }
                else
                {
                    minimumNotionalQuantity_ = new CommodityNotionalQuantity(minimumNotionalQuantityNode);
                }
            }
            
        
        }
        
    
        #region IntegralMultipleQuantity_
        private CommodityNotionalQuantity integralMultipleQuantity_;
        public CommodityNotionalQuantity IntegralMultipleQuantity_
        {
            get
            {
                if (this.integralMultipleQuantity_ != null)
                {
                    return this.integralMultipleQuantity_; 
                }
                else if (this.integralMultipleQuantityIDRef_ != null)
                {
                    integralMultipleQuantity_ = IDManager.getID(integralMultipleQuantityIDRef_) as CommodityNotionalQuantity;
                    return this.integralMultipleQuantity_; 
                }
                else
                {
                      return this.integralMultipleQuantity_; 
                }
            }
            set
            {
                if (this.integralMultipleQuantity_ != value)
                {
                    this.integralMultipleQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string integralMultipleQuantityIDRef_ { get; set; }
        #region MinimumNotionalQuantity_
        private CommodityNotionalQuantity minimumNotionalQuantity_;
        public CommodityNotionalQuantity MinimumNotionalQuantity_
        {
            get
            {
                if (this.minimumNotionalQuantity_ != null)
                {
                    return this.minimumNotionalQuantity_; 
                }
                else if (this.minimumNotionalQuantityIDRef_ != null)
                {
                    minimumNotionalQuantity_ = IDManager.getID(minimumNotionalQuantityIDRef_) as CommodityNotionalQuantity;
                    return this.minimumNotionalQuantity_; 
                }
                else
                {
                      return this.minimumNotionalQuantity_; 
                }
            }
            set
            {
                if (this.minimumNotionalQuantity_ != value)
                {
                    this.minimumNotionalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string minimumNotionalQuantityIDRef_ { get; set; }
        
    
        
    
    }
    
}

