using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutoCallRangeReturnTrigger : ISerialized
    {
        public AutoCallRangeReturnTrigger() { }
        public AutoCallRangeReturnTrigger(XmlNode xmlNode)
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

