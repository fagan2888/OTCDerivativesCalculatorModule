using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutoCallConstReturnTrigger : ISerialized
    {
        public AutoCallConstReturnTrigger() { }
        public AutoCallConstReturnTrigger(XmlNode xmlNode)
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
            
        
            XmlNode fixingDateInfoNode = xmlNode.SelectSingleNode("fixingDateInfo");
            
            if (fixingDateInfoNode != null)
            {
                if (fixingDateInfoNode.Attributes["href"] != null || fixingDateInfoNode.Attributes["id"] != null) 
                {
                    if (fixingDateInfoNode.Attributes["id"] != null) 
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["id"].Value;
                        FixingDateInfo ob = new FixingDateInfo(fixingDateInfoNode);
                        IDManager.SetID(fixingDateInfoIDRef_, ob);
                    }
                    else if (fixingDateInfoNode.Attributes["href"] != null)
                    {
                        fixingDateInfoIDRef_ = fixingDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
                    }
                }
                else
                {
                    fixingDateInfo_ = new FixingDateInfo(fixingDateInfoNode);
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
            
        
            XmlNode triggerNode = xmlNode.SelectSingleNode("trigger");
            
            if (triggerNode != null)
            {
                if (triggerNode.Attributes["href"] != null || triggerNode.Attributes["id"] != null) 
                {
                    if (triggerNode.Attributes["id"] != null) 
                    {
                        triggerIDRef_ = triggerNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(triggerNode);
                        IDManager.SetID(triggerIDRef_, ob);
                    }
                    else if (triggerNode.Attributes["href"] != null)
                    {
                        triggerIDRef_ = triggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trigger_ = new XsdTypeDouble(triggerNode);
                    }
                }
                else
                {
                    trigger_ = new XsdTypeDouble(triggerNode);
                }
            }
            
        
            XmlNode returnNode = xmlNode.SelectSingleNode("return");
            
            if (returnNode != null)
            {
                if (returnNode.Attributes["href"] != null || returnNode.Attributes["id"] != null) 
                {
                    if (returnNode.Attributes["id"] != null) 
                    {
                        returnIDRef_ = returnNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(returnNode);
                        IDManager.SetID(returnIDRef_, ob);
                    }
                    else if (returnNode.Attributes["href"] != null)
                    {
                        returnIDRef_ = returnNode.Attributes["href"].Value;
                    }
                    else
                    {
                        return_ = new XsdTypeDouble(returnNode);
                    }
                }
                else
                {
                    return_ = new XsdTypeDouble(returnNode);
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
        #region FixingDateInfo_
        private FixingDateInfo fixingDateInfo_;
        public FixingDateInfo FixingDateInfo_
        {
            get
            {
                if (this.fixingDateInfo_ != null)
                {
                    return this.fixingDateInfo_; 
                }
                else if (this.fixingDateInfoIDRef_ != null)
                {
                    fixingDateInfo_ = IDManager.getID(fixingDateInfoIDRef_) as FixingDateInfo;
                    return this.fixingDateInfo_; 
                }
                else
                {
                    throw new Exception( "fixingDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.fixingDateInfo_ != value)
                {
                    this.fixingDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateInfoIDRef_ { get; set; }
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
        #region Trigger_
        private XsdTypeDouble trigger_;
        public XsdTypeDouble Trigger_
        {
            get
            {
                if (this.trigger_ != null)
                {
                    return this.trigger_; 
                }
                else if (this.triggerIDRef_ != null)
                {
                    trigger_ = IDManager.getID(triggerIDRef_) as XsdTypeDouble;
                    return this.trigger_; 
                }
                else
                {
                    throw new Exception( "trigger_Node no exist!");
                }
            }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                }
            }
        }
        #endregion
        
        public string triggerIDRef_ { get; set; }
        #region Return_
        private XsdTypeDouble return_;
        public XsdTypeDouble Return_
        {
            get
            {
                if (this.return_ != null)
                {
                    return this.return_; 
                }
                else if (this.returnIDRef_ != null)
                {
                    return_ = IDManager.getID(returnIDRef_) as XsdTypeDouble;
                    return this.return_; 
                }
                else
                {
                    throw new Exception( "return_Node no exist!");
                }
            }
            set
            {
                if (this.return_ != value)
                {
                    this.return_ = value;
                }
            }
        }
        #endregion
        
        public string returnIDRef_ { get; set; }
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

