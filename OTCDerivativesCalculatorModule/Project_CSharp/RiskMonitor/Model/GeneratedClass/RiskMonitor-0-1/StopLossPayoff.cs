using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StopLossPayoff : ISerialized
    {
        public StopLossPayoff() { }
        public StopLossPayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventTriggerListNode = xmlNode.SelectSingleNode("eventTriggerList");
            
            if (eventTriggerListNode != null)
            {
                if (eventTriggerListNode.Attributes["href"] != null || eventTriggerListNode.Attributes["id"] != null) 
                {
                    if (eventTriggerListNode.Attributes["id"] != null) 
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["id"].Value;
                        EventTriggerList ob = new EventTriggerList(eventTriggerListNode);
                        IDManager.SetID(eventTriggerListIDRef_, ob);
                    }
                    else if (eventTriggerListNode.Attributes["href"] != null)
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                    }
                }
                else
                {
                    eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                }
            }
            
        
            XmlNode barrierInfoNode = xmlNode.SelectSingleNode("barrierInfo");
            
            if (barrierInfoNode != null)
            {
                if (barrierInfoNode.Attributes["href"] != null || barrierInfoNode.Attributes["id"] != null) 
                {
                    if (barrierInfoNode.Attributes["id"] != null) 
                    {
                        barrierInfoIDRef_ = barrierInfoNode.Attributes["id"].Value;
                        BarrierInfo ob = new BarrierInfo(barrierInfoNode);
                        IDManager.SetID(barrierInfoIDRef_, ob);
                    }
                    else if (barrierInfoNode.Attributes["href"] != null)
                    {
                        barrierInfoIDRef_ = barrierInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierInfo_ = new BarrierInfo(barrierInfoNode);
                    }
                }
                else
                {
                    barrierInfo_ = new BarrierInfo(barrierInfoNode);
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
            
        
        }
        
    
        #region EventTriggerList_
        private EventTriggerList eventTriggerList_;
        public EventTriggerList EventTriggerList_
        {
            get
            {
                if (this.eventTriggerList_ != null)
                {
                    return this.eventTriggerList_; 
                }
                else if (this.eventTriggerListIDRef_ != null)
                {
                    eventTriggerList_ = IDManager.getID(eventTriggerListIDRef_) as EventTriggerList;
                    return this.eventTriggerList_; 
                }
                else
                {
                    throw new Exception( "eventTriggerList_Node no exist!");
                }
            }
            set
            {
                if (this.eventTriggerList_ != value)
                {
                    this.eventTriggerList_ = value;
                }
            }
        }
        #endregion
        
        public string eventTriggerListIDRef_ { get; set; }
        #region BarrierInfo_
        private BarrierInfo barrierInfo_;
        public BarrierInfo BarrierInfo_
        {
            get
            {
                if (this.barrierInfo_ != null)
                {
                    return this.barrierInfo_; 
                }
                else if (this.barrierInfoIDRef_ != null)
                {
                    barrierInfo_ = IDManager.getID(barrierInfoIDRef_) as BarrierInfo;
                    return this.barrierInfo_; 
                }
                else
                {
                    throw new Exception( "barrierInfo_Node no exist!");
                }
            }
            set
            {
                if (this.barrierInfo_ != value)
                {
                    this.barrierInfo_ = value;
                }
            }
        }
        #endregion
        
        public string barrierInfoIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

