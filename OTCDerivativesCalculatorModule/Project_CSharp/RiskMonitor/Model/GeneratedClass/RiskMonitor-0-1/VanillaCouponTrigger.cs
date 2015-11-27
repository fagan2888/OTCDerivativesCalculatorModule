using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaCouponTrigger : ISerialized
    {
        public VanillaCouponTrigger() { }
        public VanillaCouponTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode gearingNode = xmlNode.SelectSingleNode("gearing");
            
            if (gearingNode != null)
            {
                if (gearingNode.Attributes["href"] != null || gearingNode.Attributes["id"] != null) 
                {
                    if (gearingNode.Attributes["id"] != null) 
                    {
                        gearingIDRef_ = gearingNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeDouble(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeDouble(gearingNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeDouble(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeDouble(spreadNode);
                }
            }
            
        
            XmlNode returnCalculationNode = xmlNode.SelectSingleNode("returnCalculation");
            
            if (returnCalculationNode != null)
            {
                if (returnCalculationNode.Attributes["href"] != null || returnCalculationNode.Attributes["id"] != null) 
                {
                    if (returnCalculationNode.Attributes["id"] != null) 
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["id"].Value;
                        ReturnCalculation ob = new ReturnCalculation(returnCalculationNode);
                        IDManager.SetID(returnCalculationIDRef_, ob);
                    }
                    else if (returnCalculationNode.Attributes["href"] != null)
                    {
                        returnCalculationIDRef_ = returnCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                    }
                }
                else
                {
                    returnCalculation_ = new ReturnCalculation(returnCalculationNode);
                }
            }
            
        
            XmlNode payoffDateInfoNode = xmlNode.SelectSingleNode("payoffDateInfo");
            
            if (payoffDateInfoNode != null)
            {
                if (payoffDateInfoNode.Attributes["href"] != null || payoffDateInfoNode.Attributes["id"] != null) 
                {
                    if (payoffDateInfoNode.Attributes["id"] != null) 
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["id"].Value;
                        PayoffDateInfo ob = new PayoffDateInfo(payoffDateInfoNode);
                        IDManager.SetID(payoffDateInfoIDRef_, ob);
                    }
                    else if (payoffDateInfoNode.Attributes["href"] != null)
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                    }
                }
                else
                {
                    payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
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
        
    
        #region Gearing_
        private XsdTypeDouble gearing_;
        public XsdTypeDouble Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeDouble;
                    return this.gearing_; 
                }
                else
                {
                    throw new Exception( "gearing_Node no exist!");
                }
            }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                }
            }
        }
        #endregion
        
        public string gearingIDRef_ { get; set; }
        #region Spread_
        private XsdTypeDouble spread_;
        public XsdTypeDouble Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeDouble;
                    return this.spread_; 
                }
                else
                {
                    throw new Exception( "spread_Node no exist!");
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region ReturnCalculation_
        private ReturnCalculation returnCalculation_;
        public ReturnCalculation ReturnCalculation_
        {
            get
            {
                if (this.returnCalculation_ != null)
                {
                    return this.returnCalculation_; 
                }
                else if (this.returnCalculationIDRef_ != null)
                {
                    returnCalculation_ = IDManager.getID(returnCalculationIDRef_) as ReturnCalculation;
                    return this.returnCalculation_; 
                }
                else
                {
                    throw new Exception( "returnCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.returnCalculation_ != value)
                {
                    this.returnCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string returnCalculationIDRef_ { get; set; }
        #region PayoffDateInfo_
        private PayoffDateInfo payoffDateInfo_;
        public PayoffDateInfo PayoffDateInfo_
        {
            get
            {
                if (this.payoffDateInfo_ != null)
                {
                    return this.payoffDateInfo_; 
                }
                else if (this.payoffDateInfoIDRef_ != null)
                {
                    payoffDateInfo_ = IDManager.getID(payoffDateInfoIDRef_) as PayoffDateInfo;
                    return this.payoffDateInfo_; 
                }
                else
                {
                    throw new Exception( "payoffDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDateInfo_ != value)
                {
                    this.payoffDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateInfoIDRef_ { get; set; }
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

