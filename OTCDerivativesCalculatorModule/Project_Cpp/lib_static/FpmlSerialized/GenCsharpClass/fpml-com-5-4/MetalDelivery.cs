using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MetalDelivery
    {
        public MetalDelivery(XmlNode xmlNode)
        {
            XmlNodeList deliveryLocationNodeList = xmlNode.SelectNodes("deliveryLocation");
            if (deliveryLocationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryLocationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryLocationIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryPoint ob = CommodityDeliveryPoint();
                        IDManager.SetID(deliveryLocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryLocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryLocation = new CommodityDeliveryPoint(item);
                    }
                }
            }
            
        
            XmlNodeList riskNodeList = xmlNode.SelectNodes("risk");
            if (riskNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in riskNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        riskIDRef = item.Attributes["id"].Name;
                        CommodityDeliveryRisk ob = CommodityDeliveryRisk();
                        IDManager.SetID(riskIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        riskIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        risk = new CommodityDeliveryRisk(item);
                    }
                }
            }
            
        
            XmlNodeList totalQuantityToleranceNodeList = xmlNode.SelectNodes("totalQuantityTolerance");
            if (totalQuantityToleranceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalQuantityToleranceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalQuantityToleranceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(totalQuantityToleranceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalQuantityToleranceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalQuantityTolerance = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList periodQuantityToleranceNodeList = xmlNode.SelectNodes("periodQuantityTolerance");
            if (periodQuantityToleranceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodQuantityToleranceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodQuantityToleranceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(periodQuantityToleranceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodQuantityToleranceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodQuantityTolerance = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList titleNodeList = xmlNode.SelectNodes("title");
            if (titleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in titleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        titleIDRef = item.Attributes["id"].Name;
                        MetalTitleEnum ob = MetalTitleEnum();
                        IDManager.SetID(titleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        titleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        title = new MetalTitleEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeliveryLocation
        private CommodityDeliveryPoint deliveryLocation;
        public CommodityDeliveryPoint DeliveryLocation
        {
            get
            {
                if (this.deliveryLocation != null)
                {
                    return this.deliveryLocation; 
                }
                else if (this.deliveryLocationIDRef != null)
                {
                    deliveryLocation = IDManager.getID(deliveryLocationIDRef) as CommodityDeliveryPoint;
                    return this.deliveryLocation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryLocation != value)
                {
                    this.deliveryLocation = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryPointIDRef { get; set; }
        #region Risk
        private CommodityDeliveryRisk risk;
        public CommodityDeliveryRisk Risk
        {
            get
            {
                if (this.risk != null)
                {
                    return this.risk; 
                }
                else if (this.riskIDRef != null)
                {
                    risk = IDManager.getID(riskIDRef) as CommodityDeliveryRisk;
                    return this.risk; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.risk != value)
                {
                    this.risk = value;
                }
            }
        }
        #endregion
        
        public string CommodityDeliveryRiskIDRef { get; set; }
        #region TotalQuantityTolerance
        private XsdTypeDecimal totalQuantityTolerance;
        public XsdTypeDecimal TotalQuantityTolerance
        {
            get
            {
                if (this.totalQuantityTolerance != null)
                {
                    return this.totalQuantityTolerance; 
                }
                else if (this.totalQuantityToleranceIDRef != null)
                {
                    totalQuantityTolerance = IDManager.getID(totalQuantityToleranceIDRef) as XsdTypeDecimal;
                    return this.totalQuantityTolerance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalQuantityTolerance != value)
                {
                    this.totalQuantityTolerance = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PeriodQuantityTolerance
        private XsdTypeDecimal periodQuantityTolerance;
        public XsdTypeDecimal PeriodQuantityTolerance
        {
            get
            {
                if (this.periodQuantityTolerance != null)
                {
                    return this.periodQuantityTolerance; 
                }
                else if (this.periodQuantityToleranceIDRef != null)
                {
                    periodQuantityTolerance = IDManager.getID(periodQuantityToleranceIDRef) as XsdTypeDecimal;
                    return this.periodQuantityTolerance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodQuantityTolerance != value)
                {
                    this.periodQuantityTolerance = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Title
        private MetalTitleEnum title;
        public MetalTitleEnum Title
        {
            get
            {
                if (this.title != null)
                {
                    return this.title; 
                }
                else if (this.titleIDRef != null)
                {
                    title = IDManager.getID(titleIDRef) as MetalTitleEnum;
                    return this.title; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                }
            }
        }
        #endregion
        
        public string MetalTitleEnumIDRef { get; set; }
        
    
        
    
    }
    
}

