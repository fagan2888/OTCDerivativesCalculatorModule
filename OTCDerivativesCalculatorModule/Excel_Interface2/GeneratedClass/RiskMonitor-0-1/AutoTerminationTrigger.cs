using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutoTerminationTrigger : ISerialized
    {
        public AutoTerminationTrigger() { }
        public AutoTerminationTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventCalculationInfoNode = xmlNode.SelectSingleNode("eventCalculationInfo");
            
            if (eventCalculationInfoNode != null)
            {
                if (eventCalculationInfoNode.Attributes["href"] != null || eventCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (eventCalculationInfoNode.Attributes["id"] != null) 
                    {
                        eventCalculationInfoIDRef_ = eventCalculationInfoNode.Attributes["id"].Value;
                        EventCalculationInfo ob = new EventCalculationInfo(eventCalculationInfoNode);
                        IDManager.SetID(eventCalculationInfoIDRef_, ob);
                    }
                    else if (eventCalculationInfoNode.Attributes["href"] != null)
                    {
                        eventCalculationInfoIDRef_ = eventCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventCalculationInfo_ = new EventCalculationInfo(eventCalculationInfoNode);
                    }
                }
                else
                {
                    eventCalculationInfo_ = new EventCalculationInfo(eventCalculationInfoNode);
                }
            }
            
        
            XmlNode returnCalculationInfoNode = xmlNode.SelectSingleNode("returnCalculationInfo");
            
            if (returnCalculationInfoNode != null)
            {
                if (returnCalculationInfoNode.Attributes["href"] != null || returnCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (returnCalculationInfoNode.Attributes["id"] != null) 
                    {
                        returnCalculationInfoIDRef_ = returnCalculationInfoNode.Attributes["id"].Value;
                        ReturnCalculationInfo ob = new ReturnCalculationInfo(returnCalculationInfoNode);
                        IDManager.SetID(returnCalculationInfoIDRef_, ob);
                    }
                    else if (returnCalculationInfoNode.Attributes["href"] != null)
                    {
                        returnCalculationInfoIDRef_ = returnCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnCalculationInfo_ = new ReturnCalculationInfo(returnCalculationInfoNode);
                    }
                }
                else
                {
                    returnCalculationInfo_ = new ReturnCalculationInfo(returnCalculationInfoNode);
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
        
    
        #region EventCalculationInfo_
        private EventCalculationInfo eventCalculationInfo_;
        public EventCalculationInfo EventCalculationInfo_
        {
            get
            {
                if (this.eventCalculationInfo_ != null)
                {
                    return this.eventCalculationInfo_; 
                }
                else if (this.eventCalculationInfoIDRef_ != null)
                {
                    eventCalculationInfo_ = IDManager.getID(eventCalculationInfoIDRef_) as EventCalculationInfo;
                    return this.eventCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "eventCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.eventCalculationInfo_ != value)
                {
                    this.eventCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string eventCalculationInfoIDRef_ { get; set; }
        #region ReturnCalculationInfo_
        private ReturnCalculationInfo returnCalculationInfo_;
        public ReturnCalculationInfo ReturnCalculationInfo_
        {
            get
            {
                if (this.returnCalculationInfo_ != null)
                {
                    return this.returnCalculationInfo_; 
                }
                else if (this.returnCalculationInfoIDRef_ != null)
                {
                    returnCalculationInfo_ = IDManager.getID(returnCalculationInfoIDRef_) as ReturnCalculationInfo;
                    return this.returnCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "returnCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.returnCalculationInfo_ != value)
                {
                    this.returnCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string returnCalculationInfoIDRef_ { get; set; }
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

