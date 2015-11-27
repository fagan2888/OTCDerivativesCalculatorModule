using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StopLossReturnCal : ISerialized
    {
        public StopLossReturnCal() { }
        public StopLossReturnCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode powerNode = xmlNode.SelectSingleNode("power");
            
            if (powerNode != null)
            {
                if (powerNode.Attributes["href"] != null || powerNode.Attributes["id"] != null) 
                {
                    if (powerNode.Attributes["id"] != null) 
                    {
                        powerIDRef_ = powerNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(powerNode);
                        IDManager.SetID(powerIDRef_, ob);
                    }
                    else if (powerNode.Attributes["href"] != null)
                    {
                        powerIDRef_ = powerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        power_ = new XsdTypeToken(powerNode);
                    }
                }
                else
                {
                    power_ = new XsdTypeToken(powerNode);
                }
            }
            
        
            XmlNode lossTriggerNode = xmlNode.SelectSingleNode("lossTrigger");
            
            if (lossTriggerNode != null)
            {
                if (lossTriggerNode.Attributes["href"] != null || lossTriggerNode.Attributes["id"] != null) 
                {
                    if (lossTriggerNode.Attributes["id"] != null) 
                    {
                        lossTriggerIDRef_ = lossTriggerNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(lossTriggerNode);
                        IDManager.SetID(lossTriggerIDRef_, ob);
                    }
                    else if (lossTriggerNode.Attributes["href"] != null)
                    {
                        lossTriggerIDRef_ = lossTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lossTrigger_ = new XsdTypeToken(lossTriggerNode);
                    }
                }
                else
                {
                    lossTrigger_ = new XsdTypeToken(lossTriggerNode);
                }
            }
            
        
            XmlNode maximumLossNode = xmlNode.SelectSingleNode("maximumLoss");
            
            if (maximumLossNode != null)
            {
                if (maximumLossNode.Attributes["href"] != null || maximumLossNode.Attributes["id"] != null) 
                {
                    if (maximumLossNode.Attributes["id"] != null) 
                    {
                        maximumLossIDRef_ = maximumLossNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(maximumLossNode);
                        IDManager.SetID(maximumLossIDRef_, ob);
                    }
                    else if (maximumLossNode.Attributes["href"] != null)
                    {
                        maximumLossIDRef_ = maximumLossNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumLoss_ = new XsdTypeToken(maximumLossNode);
                    }
                }
                else
                {
                    maximumLoss_ = new XsdTypeToken(maximumLossNode);
                }
            }
            
        
            XmlNode referenceCalculationInfoNode = xmlNode.SelectSingleNode("referenceCalculationInfo");
            
            if (referenceCalculationInfoNode != null)
            {
                if (referenceCalculationInfoNode.Attributes["href"] != null || referenceCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (referenceCalculationInfoNode.Attributes["id"] != null) 
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["id"].Value;
                        ReferenceCalculationInfo ob = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                        IDManager.SetID(referenceCalculationInfoIDRef_, ob);
                    }
                    else if (referenceCalculationInfoNode.Attributes["href"] != null)
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                    }
                }
                else
                {
                    referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                }
            }
            
        
            XmlNode withNotionalNode = xmlNode.SelectSingleNode("withNotional");
            
            if (withNotionalNode != null)
            {
                if (withNotionalNode.Attributes["href"] != null || withNotionalNode.Attributes["id"] != null) 
                {
                    if (withNotionalNode.Attributes["id"] != null) 
                    {
                        withNotionalIDRef_ = withNotionalNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(withNotionalNode);
                        IDManager.SetID(withNotionalIDRef_, ob);
                    }
                    else if (withNotionalNode.Attributes["href"] != null)
                    {
                        withNotionalIDRef_ = withNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        withNotional_ = new XsdTypeBoolean(withNotionalNode);
                    }
                }
                else
                {
                    withNotional_ = new XsdTypeBoolean(withNotionalNode);
                }
            }
            
        
            XmlNode isExpiredNode = xmlNode.SelectSingleNode("isExpired");
            
            if (isExpiredNode != null)
            {
                if (isExpiredNode.Attributes["href"] != null || isExpiredNode.Attributes["id"] != null) 
                {
                    if (isExpiredNode.Attributes["id"] != null) 
                    {
                        isExpiredIDRef_ = isExpiredNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(isExpiredNode);
                        IDManager.SetID(isExpiredIDRef_, ob);
                    }
                    else if (isExpiredNode.Attributes["href"] != null)
                    {
                        isExpiredIDRef_ = isExpiredNode.Attributes["href"].Value;
                    }
                    else
                    {
                        isExpired_ = new XsdTypeBoolean(isExpiredNode);
                    }
                }
                else
                {
                    isExpired_ = new XsdTypeBoolean(isExpiredNode);
                }
            }
            
        
        }
        
    
        #region Power_
        private XsdTypeToken power_;
        public XsdTypeToken Power_
        {
            get
            {
                if (this.power_ != null)
                {
                    return this.power_; 
                }
                else if (this.powerIDRef_ != null)
                {
                    power_ = IDManager.getID(powerIDRef_) as XsdTypeToken;
                    return this.power_; 
                }
                else
                {
                    throw new Exception( "power_Node no exist!");
                }
            }
            set
            {
                if (this.power_ != value)
                {
                    this.power_ = value;
                }
            }
        }
        #endregion
        
        public string powerIDRef_ { get; set; }
        #region LossTrigger_
        private XsdTypeToken lossTrigger_;
        public XsdTypeToken LossTrigger_
        {
            get
            {
                if (this.lossTrigger_ != null)
                {
                    return this.lossTrigger_; 
                }
                else if (this.lossTriggerIDRef_ != null)
                {
                    lossTrigger_ = IDManager.getID(lossTriggerIDRef_) as XsdTypeToken;
                    return this.lossTrigger_; 
                }
                else
                {
                    throw new Exception( "lossTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.lossTrigger_ != value)
                {
                    this.lossTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string lossTriggerIDRef_ { get; set; }
        #region MaximumLoss_
        private XsdTypeToken maximumLoss_;
        public XsdTypeToken MaximumLoss_
        {
            get
            {
                if (this.maximumLoss_ != null)
                {
                    return this.maximumLoss_; 
                }
                else if (this.maximumLossIDRef_ != null)
                {
                    maximumLoss_ = IDManager.getID(maximumLossIDRef_) as XsdTypeToken;
                    return this.maximumLoss_; 
                }
                else
                {
                    throw new Exception( "maximumLoss_Node no exist!");
                }
            }
            set
            {
                if (this.maximumLoss_ != value)
                {
                    this.maximumLoss_ = value;
                }
            }
        }
        #endregion
        
        public string maximumLossIDRef_ { get; set; }
        #region ReferenceCalculationInfo_
        private ReferenceCalculationInfo referenceCalculationInfo_;
        public ReferenceCalculationInfo ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
                    referenceCalculationInfo_ = IDManager.getID(referenceCalculationInfoIDRef_) as ReferenceCalculationInfo;
                    return this.referenceCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "referenceCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculationInfo_ != value)
                {
                    this.referenceCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationInfoIDRef_ { get; set; }
        #region WithNotional_
        private XsdTypeBoolean withNotional_;
        public XsdTypeBoolean WithNotional_
        {
            get
            {
                if (this.withNotional_ != null)
                {
                    return this.withNotional_; 
                }
                else if (this.withNotionalIDRef_ != null)
                {
                    withNotional_ = IDManager.getID(withNotionalIDRef_) as XsdTypeBoolean;
                    return this.withNotional_; 
                }
                else
                {
                    throw new Exception( "withNotional_Node no exist!");
                }
            }
            set
            {
                if (this.withNotional_ != value)
                {
                    this.withNotional_ = value;
                }
            }
        }
        #endregion
        
        public string withNotionalIDRef_ { get; set; }
        #region IsExpired_
        private XsdTypeBoolean isExpired_;
        public XsdTypeBoolean IsExpired_
        {
            get
            {
                if (this.isExpired_ != null)
                {
                    return this.isExpired_; 
                }
                else if (this.isExpiredIDRef_ != null)
                {
                    isExpired_ = IDManager.getID(isExpiredIDRef_) as XsdTypeBoolean;
                    return this.isExpired_; 
                }
                else
                {
                    throw new Exception( "isExpired_Node no exist!");
                }
            }
            set
            {
                if (this.isExpired_ != value)
                {
                    this.isExpired_ = value;
                }
            }
        }
        #endregion
        
        public string isExpiredIDRef_ { get; set; }
        
    
        
    
    }
    
}

