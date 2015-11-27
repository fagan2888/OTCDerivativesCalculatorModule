using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MetalDelivery : ISerialized
    {
        public MetalDelivery(XmlNode xmlNode)
        {
            XmlNode deliveryLocationNode = xmlNode.SelectSingleNode("deliveryLocation");
            
            if (deliveryLocationNode != null)
            {
                if (deliveryLocationNode.Attributes["href"] != null || deliveryLocationNode.Attributes["id"] != null) 
                {
                    if (deliveryLocationNode.Attributes["id"] != null) 
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["id"].Value;
                        CommodityDeliveryPoint ob = new CommodityDeliveryPoint(deliveryLocationNode);
                        IDManager.SetID(deliveryLocationIDRef_, ob);
                    }
                    else if (deliveryLocationNode.Attributes["href"] != null)
                    {
                        deliveryLocationIDRef_ = deliveryLocationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryLocation_ = new CommodityDeliveryPoint(deliveryLocationNode);
                    }
                }
                else
                {
                    deliveryLocation_ = new CommodityDeliveryPoint(deliveryLocationNode);
                }
            }
            
        
            XmlNode riskNode = xmlNode.SelectSingleNode("risk");
            
            if (riskNode != null)
            {
                if (riskNode.Attributes["href"] != null || riskNode.Attributes["id"] != null) 
                {
                    if (riskNode.Attributes["id"] != null) 
                    {
                        riskIDRef_ = riskNode.Attributes["id"].Value;
                        CommodityDeliveryRisk ob = new CommodityDeliveryRisk(riskNode);
                        IDManager.SetID(riskIDRef_, ob);
                    }
                    else if (riskNode.Attributes["href"] != null)
                    {
                        riskIDRef_ = riskNode.Attributes["href"].Value;
                    }
                    else
                    {
                        risk_ = new CommodityDeliveryRisk(riskNode);
                    }
                }
                else
                {
                    risk_ = new CommodityDeliveryRisk(riskNode);
                }
            }
            
        
            XmlNode totalQuantityToleranceNode = xmlNode.SelectSingleNode("totalQuantityTolerance");
            
            if (totalQuantityToleranceNode != null)
            {
                if (totalQuantityToleranceNode.Attributes["href"] != null || totalQuantityToleranceNode.Attributes["id"] != null) 
                {
                    if (totalQuantityToleranceNode.Attributes["id"] != null) 
                    {
                        totalQuantityToleranceIDRef_ = totalQuantityToleranceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(totalQuantityToleranceNode);
                        IDManager.SetID(totalQuantityToleranceIDRef_, ob);
                    }
                    else if (totalQuantityToleranceNode.Attributes["href"] != null)
                    {
                        totalQuantityToleranceIDRef_ = totalQuantityToleranceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalQuantityTolerance_ = new XsdTypeDecimal(totalQuantityToleranceNode);
                    }
                }
                else
                {
                    totalQuantityTolerance_ = new XsdTypeDecimal(totalQuantityToleranceNode);
                }
            }
            
        
            XmlNode periodQuantityToleranceNode = xmlNode.SelectSingleNode("periodQuantityTolerance");
            
            if (periodQuantityToleranceNode != null)
            {
                if (periodQuantityToleranceNode.Attributes["href"] != null || periodQuantityToleranceNode.Attributes["id"] != null) 
                {
                    if (periodQuantityToleranceNode.Attributes["id"] != null) 
                    {
                        periodQuantityToleranceIDRef_ = periodQuantityToleranceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(periodQuantityToleranceNode);
                        IDManager.SetID(periodQuantityToleranceIDRef_, ob);
                    }
                    else if (periodQuantityToleranceNode.Attributes["href"] != null)
                    {
                        periodQuantityToleranceIDRef_ = periodQuantityToleranceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodQuantityTolerance_ = new XsdTypeDecimal(periodQuantityToleranceNode);
                    }
                }
                else
                {
                    periodQuantityTolerance_ = new XsdTypeDecimal(periodQuantityToleranceNode);
                }
            }
            
        
            XmlNode titleNode = xmlNode.SelectSingleNode("title");
            
            if (titleNode != null)
            {
                if (titleNode.Attributes["href"] != null || titleNode.Attributes["id"] != null) 
                {
                    if (titleNode.Attributes["id"] != null) 
                    {
                        titleIDRef_ = titleNode.Attributes["id"].Value;
                        MetalTitleEnum ob = new MetalTitleEnum(titleNode);
                        IDManager.SetID(titleIDRef_, ob);
                    }
                    else if (titleNode.Attributes["href"] != null)
                    {
                        titleIDRef_ = titleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        title_ = new MetalTitleEnum(titleNode);
                    }
                }
                else
                {
                    title_ = new MetalTitleEnum(titleNode);
                }
            }
            
        
        }
        
    
        #region DeliveryLocation_
        private CommodityDeliveryPoint deliveryLocation_;
        public CommodityDeliveryPoint DeliveryLocation_
        {
            get
            {
                if (this.deliveryLocation_ != null)
                {
                    return this.deliveryLocation_; 
                }
                else if (this.deliveryLocationIDRef_ != null)
                {
                    deliveryLocation_ = IDManager.getID(deliveryLocationIDRef_) as CommodityDeliveryPoint;
                    return this.deliveryLocation_; 
                }
                else
                {
                      return this.deliveryLocation_; 
                }
            }
            set
            {
                if (this.deliveryLocation_ != value)
                {
                    this.deliveryLocation_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryLocationIDRef_ { get; set; }
        #region Risk_
        private CommodityDeliveryRisk risk_;
        public CommodityDeliveryRisk Risk_
        {
            get
            {
                if (this.risk_ != null)
                {
                    return this.risk_; 
                }
                else if (this.riskIDRef_ != null)
                {
                    risk_ = IDManager.getID(riskIDRef_) as CommodityDeliveryRisk;
                    return this.risk_; 
                }
                else
                {
                      return this.risk_; 
                }
            }
            set
            {
                if (this.risk_ != value)
                {
                    this.risk_ = value;
                }
            }
        }
        #endregion
        
        public string riskIDRef_ { get; set; }
        #region TotalQuantityTolerance_
        private XsdTypeDecimal totalQuantityTolerance_;
        public XsdTypeDecimal TotalQuantityTolerance_
        {
            get
            {
                if (this.totalQuantityTolerance_ != null)
                {
                    return this.totalQuantityTolerance_; 
                }
                else if (this.totalQuantityToleranceIDRef_ != null)
                {
                    totalQuantityTolerance_ = IDManager.getID(totalQuantityToleranceIDRef_) as XsdTypeDecimal;
                    return this.totalQuantityTolerance_; 
                }
                else
                {
                      return this.totalQuantityTolerance_; 
                }
            }
            set
            {
                if (this.totalQuantityTolerance_ != value)
                {
                    this.totalQuantityTolerance_ = value;
                }
            }
        }
        #endregion
        
        public string totalQuantityToleranceIDRef_ { get; set; }
        #region PeriodQuantityTolerance_
        private XsdTypeDecimal periodQuantityTolerance_;
        public XsdTypeDecimal PeriodQuantityTolerance_
        {
            get
            {
                if (this.periodQuantityTolerance_ != null)
                {
                    return this.periodQuantityTolerance_; 
                }
                else if (this.periodQuantityToleranceIDRef_ != null)
                {
                    periodQuantityTolerance_ = IDManager.getID(periodQuantityToleranceIDRef_) as XsdTypeDecimal;
                    return this.periodQuantityTolerance_; 
                }
                else
                {
                      return this.periodQuantityTolerance_; 
                }
            }
            set
            {
                if (this.periodQuantityTolerance_ != value)
                {
                    this.periodQuantityTolerance_ = value;
                }
            }
        }
        #endregion
        
        public string periodQuantityToleranceIDRef_ { get; set; }
        #region Title_
        private MetalTitleEnum title_;
        public MetalTitleEnum Title_
        {
            get
            {
                if (this.title_ != null)
                {
                    return this.title_; 
                }
                else if (this.titleIDRef_ != null)
                {
                    title_ = IDManager.getID(titleIDRef_) as MetalTitleEnum;
                    return this.title_; 
                }
                else
                {
                      return this.title_; 
                }
            }
            set
            {
                if (this.title_ != value)
                {
                    this.title_ = value;
                }
            }
        }
        #endregion
        
        public string titleIDRef_ { get; set; }
        
    
        
    
    }
    
}

