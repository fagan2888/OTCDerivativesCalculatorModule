using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeReturnTrigger : ISerialized
    {
        public SimpleRangeReturnTrigger() { }
        public SimpleRangeReturnTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode simpleRangeEventCalNode = xmlNode.SelectSingleNode("simpleRangeEventCal");
            
            if (simpleRangeEventCalNode != null)
            {
                if (simpleRangeEventCalNode.Attributes["href"] != null || simpleRangeEventCalNode.Attributes["id"] != null) 
                {
                    if (simpleRangeEventCalNode.Attributes["id"] != null) 
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["id"].Value;
                        SimpleRangeEventCal ob = new SimpleRangeEventCal(simpleRangeEventCalNode);
                        IDManager.SetID(simpleRangeEventCalIDRef_, ob);
                    }
                    else if (simpleRangeEventCalNode.Attributes["href"] != null)
                    {
                        simpleRangeEventCalIDRef_ = simpleRangeEventCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                    }
                }
                else
                {
                    simpleRangeEventCal_ = new SimpleRangeEventCal(simpleRangeEventCalNode);
                }
            }
            
        
            XmlNode autoCallFlagNode = xmlNode.SelectSingleNode("autoCallFlag");
            
            if (autoCallFlagNode != null)
            {
                if (autoCallFlagNode.Attributes["href"] != null || autoCallFlagNode.Attributes["id"] != null) 
                {
                    if (autoCallFlagNode.Attributes["id"] != null) 
                    {
                        autoCallFlagIDRef_ = autoCallFlagNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(autoCallFlagNode);
                        IDManager.SetID(autoCallFlagIDRef_, ob);
                    }
                    else if (autoCallFlagNode.Attributes["href"] != null)
                    {
                        autoCallFlagIDRef_ = autoCallFlagNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallFlag_ = new XsdTypeBoolean(autoCallFlagNode);
                    }
                }
                else
                {
                    autoCallFlag_ = new XsdTypeBoolean(autoCallFlagNode);
                }
            }
            
        
            XmlNode expiredNode = xmlNode.SelectSingleNode("expired");
            
            if (expiredNode != null)
            {
                if (expiredNode.Attributes["href"] != null || expiredNode.Attributes["id"] != null) 
                {
                    if (expiredNode.Attributes["id"] != null) 
                    {
                        expiredIDRef_ = expiredNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(expiredNode);
                        IDManager.SetID(expiredIDRef_, ob);
                    }
                    else if (expiredNode.Attributes["href"] != null)
                    {
                        expiredIDRef_ = expiredNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expired_ = new XsdTypeBoolean(expiredNode);
                    }
                }
                else
                {
                    expired_ = new XsdTypeBoolean(expiredNode);
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
            
        
        }
        
    
        #region SimpleRangeEventCal_
        private SimpleRangeEventCal simpleRangeEventCal_;
        public SimpleRangeEventCal SimpleRangeEventCal_
        {
            get
            {
                if (this.simpleRangeEventCal_ != null)
                {
                    return this.simpleRangeEventCal_; 
                }
                else if (this.simpleRangeEventCalIDRef_ != null)
                {
                    simpleRangeEventCal_ = IDManager.getID(simpleRangeEventCalIDRef_) as SimpleRangeEventCal;
                    return this.simpleRangeEventCal_; 
                }
                else
                {
                    throw new Exception( "simpleRangeEventCal_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeEventCal_ != value)
                {
                    this.simpleRangeEventCal_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeEventCalIDRef_ { get; set; }
        #region AutoCallFlag_
        private XsdTypeBoolean autoCallFlag_;
        public XsdTypeBoolean AutoCallFlag_
        {
            get
            {
                if (this.autoCallFlag_ != null)
                {
                    return this.autoCallFlag_; 
                }
                else if (this.autoCallFlagIDRef_ != null)
                {
                    autoCallFlag_ = IDManager.getID(autoCallFlagIDRef_) as XsdTypeBoolean;
                    return this.autoCallFlag_; 
                }
                else
                {
                    throw new Exception( "autoCallFlag_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallFlag_ != value)
                {
                    this.autoCallFlag_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallFlagIDRef_ { get; set; }
        #region Expired_
        private XsdTypeBoolean expired_;
        public XsdTypeBoolean Expired_
        {
            get
            {
                if (this.expired_ != null)
                {
                    return this.expired_; 
                }
                else if (this.expiredIDRef_ != null)
                {
                    expired_ = IDManager.getID(expiredIDRef_) as XsdTypeBoolean;
                    return this.expired_; 
                }
                else
                {
                    throw new Exception( "expired_Node no exist!");
                }
            }
            set
            {
                if (this.expired_ != value)
                {
                    this.expired_ = value;
                }
            }
        }
        #endregion
        
        public string expiredIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

