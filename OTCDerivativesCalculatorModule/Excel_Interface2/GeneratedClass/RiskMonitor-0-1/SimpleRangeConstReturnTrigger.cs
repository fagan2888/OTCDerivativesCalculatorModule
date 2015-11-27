using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeConstReturnTrigger : ISerialized
    {
        public SimpleRangeConstReturnTrigger() { }
        public SimpleRangeConstReturnTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dateOrderNode = xmlNode.SelectSingleNode("dateOrder");
            
            if (dateOrderNode != null)
            {
                if (dateOrderNode.Attributes["href"] != null || dateOrderNode.Attributes["id"] != null) 
                {
                    if (dateOrderNode.Attributes["id"] != null) 
                    {
                        dateOrderIDRef_ = dateOrderNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(dateOrderNode);
                        IDManager.SetID(dateOrderIDRef_, ob);
                    }
                    else if (dateOrderNode.Attributes["href"] != null)
                    {
                        dateOrderIDRef_ = dateOrderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateOrder_ = new XsdTypeInteger(dateOrderNode);
                    }
                }
                else
                {
                    dateOrder_ = new XsdTypeInteger(dateOrderNode);
                }
            }
            
        
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
            
        
            XmlNode constReturnNode = xmlNode.SelectSingleNode("constReturn");
            
            if (constReturnNode != null)
            {
                if (constReturnNode.Attributes["href"] != null || constReturnNode.Attributes["id"] != null) 
                {
                    if (constReturnNode.Attributes["id"] != null) 
                    {
                        constReturnIDRef_ = constReturnNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(constReturnNode);
                        IDManager.SetID(constReturnIDRef_, ob);
                    }
                    else if (constReturnNode.Attributes["href"] != null)
                    {
                        constReturnIDRef_ = constReturnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constReturn_ = new XsdTypeDouble(constReturnNode);
                    }
                }
                else
                {
                    constReturn_ = new XsdTypeDouble(constReturnNode);
                }
            }
            
        
            XmlNode averageDaysNode = xmlNode.SelectSingleNode("averageDays");
            
            if (averageDaysNode != null)
            {
                if (averageDaysNode.Attributes["href"] != null || averageDaysNode.Attributes["id"] != null) 
                {
                    if (averageDaysNode.Attributes["id"] != null) 
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(averageDaysNode);
                        IDManager.SetID(averageDaysIDRef_, ob);
                    }
                    else if (averageDaysNode.Attributes["href"] != null)
                    {
                        averageDaysIDRef_ = averageDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averageDays_ = new XsdTypeInteger(averageDaysNode);
                    }
                }
                else
                {
                    averageDays_ = new XsdTypeInteger(averageDaysNode);
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
        
    
        #region DateOrder_
        private XsdTypeInteger dateOrder_;
        public XsdTypeInteger DateOrder_
        {
            get
            {
                if (this.dateOrder_ != null)
                {
                    return this.dateOrder_; 
                }
                else if (this.dateOrderIDRef_ != null)
                {
                    dateOrder_ = IDManager.getID(dateOrderIDRef_) as XsdTypeInteger;
                    return this.dateOrder_; 
                }
                else
                {
                    throw new Exception( "dateOrder_Node no exist!");
                }
            }
            set
            {
                if (this.dateOrder_ != value)
                {
                    this.dateOrder_ = value;
                }
            }
        }
        #endregion
        
        public string dateOrderIDRef_ { get; set; }
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
        #region ConstReturn_
        private XsdTypeDouble constReturn_;
        public XsdTypeDouble ConstReturn_
        {
            get
            {
                if (this.constReturn_ != null)
                {
                    return this.constReturn_; 
                }
                else if (this.constReturnIDRef_ != null)
                {
                    constReturn_ = IDManager.getID(constReturnIDRef_) as XsdTypeDouble;
                    return this.constReturn_; 
                }
                else
                {
                    throw new Exception( "constReturn_Node no exist!");
                }
            }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                }
            }
        }
        #endregion
        
        public string constReturnIDRef_ { get; set; }
        #region AverageDays_
        private XsdTypeInteger averageDays_;
        public XsdTypeInteger AverageDays_
        {
            get
            {
                if (this.averageDays_ != null)
                {
                    return this.averageDays_; 
                }
                else if (this.averageDaysIDRef_ != null)
                {
                    averageDays_ = IDManager.getID(averageDaysIDRef_) as XsdTypeInteger;
                    return this.averageDays_; 
                }
                else
                {
                    throw new Exception( "averageDays_Node no exist!");
                }
            }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                }
            }
        }
        #endregion
        
        public string averageDaysIDRef_ { get; set; }
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

