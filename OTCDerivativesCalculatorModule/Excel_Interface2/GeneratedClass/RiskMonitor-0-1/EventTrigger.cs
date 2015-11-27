using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventTrigger : ISerialized
    {
        public EventTrigger() { }
        public EventTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeDate(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeDate(eventDateNode);
                }
            }
            
        
            XmlNode autoTerminationTriggerNode = xmlNode.SelectSingleNode("autoTerminationTrigger");
            
            if (autoTerminationTriggerNode != null)
            {
                if (autoTerminationTriggerNode.Attributes["href"] != null || autoTerminationTriggerNode.Attributes["id"] != null) 
                {
                    if (autoTerminationTriggerNode.Attributes["id"] != null) 
                    {
                        autoTerminationTriggerIDRef_ = autoTerminationTriggerNode.Attributes["id"].Value;
                        AutoTerminationTrigger ob = new AutoTerminationTrigger(autoTerminationTriggerNode);
                        IDManager.SetID(autoTerminationTriggerIDRef_, ob);
                    }
                    else if (autoTerminationTriggerNode.Attributes["href"] != null)
                    {
                        autoTerminationTriggerIDRef_ = autoTerminationTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoTerminationTrigger_ = new AutoTerminationTrigger(autoTerminationTriggerNode);
                    }
                }
                else
                {
                    autoTerminationTrigger_ = new AutoTerminationTrigger(autoTerminationTriggerNode);
                }
            }
            
        
            XmlNode preEventCalculationNode = xmlNode.SelectSingleNode("preEventCalculation");
            
            if (preEventCalculationNode != null)
            {
                if (preEventCalculationNode.Attributes["href"] != null || preEventCalculationNode.Attributes["id"] != null) 
                {
                    if (preEventCalculationNode.Attributes["id"] != null) 
                    {
                        preEventCalculationIDRef_ = preEventCalculationNode.Attributes["id"].Value;
                        PreEventCalculation ob = new PreEventCalculation(preEventCalculationNode);
                        IDManager.SetID(preEventCalculationIDRef_, ob);
                    }
                    else if (preEventCalculationNode.Attributes["href"] != null)
                    {
                        preEventCalculationIDRef_ = preEventCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preEventCalculation_ = new PreEventCalculation(preEventCalculationNode);
                    }
                }
                else
                {
                    preEventCalculation_ = new PreEventCalculation(preEventCalculationNode);
                }
            }
            
        
            XmlNode preConditionEventNode = xmlNode.SelectSingleNode("preConditionEvent");
            
            if (preConditionEventNode != null)
            {
                if (preConditionEventNode.Attributes["href"] != null || preConditionEventNode.Attributes["id"] != null) 
                {
                    if (preConditionEventNode.Attributes["id"] != null) 
                    {
                        preConditionEventIDRef_ = preConditionEventNode.Attributes["id"].Value;
                        PreConditionEvent ob = new PreConditionEvent(preConditionEventNode);
                        IDManager.SetID(preConditionEventIDRef_, ob);
                    }
                    else if (preConditionEventNode.Attributes["href"] != null)
                    {
                        preConditionEventIDRef_ = preConditionEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preConditionEvent_ = new PreConditionEvent(preConditionEventNode);
                    }
                }
                else
                {
                    preConditionEvent_ = new PreConditionEvent(preConditionEventNode);
                }
            }
            
        
            XmlNode autoCallConstReturnTriggerNode = xmlNode.SelectSingleNode("autoCallConstReturnTrigger");
            
            if (autoCallConstReturnTriggerNode != null)
            {
                if (autoCallConstReturnTriggerNode.Attributes["href"] != null || autoCallConstReturnTriggerNode.Attributes["id"] != null) 
                {
                    if (autoCallConstReturnTriggerNode.Attributes["id"] != null) 
                    {
                        autoCallConstReturnTriggerIDRef_ = autoCallConstReturnTriggerNode.Attributes["id"].Value;
                        AutoCallConstReturnTrigger ob = new AutoCallConstReturnTrigger(autoCallConstReturnTriggerNode);
                        IDManager.SetID(autoCallConstReturnTriggerIDRef_, ob);
                    }
                    else if (autoCallConstReturnTriggerNode.Attributes["href"] != null)
                    {
                        autoCallConstReturnTriggerIDRef_ = autoCallConstReturnTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallConstReturnTrigger_ = new AutoCallConstReturnTrigger(autoCallConstReturnTriggerNode);
                    }
                }
                else
                {
                    autoCallConstReturnTrigger_ = new AutoCallConstReturnTrigger(autoCallConstReturnTriggerNode);
                }
            }
            
        
            XmlNode simpleRangeConstReturnTriggerNode = xmlNode.SelectSingleNode("simpleRangeConstReturnTrigger");
            
            if (simpleRangeConstReturnTriggerNode != null)
            {
                if (simpleRangeConstReturnTriggerNode.Attributes["href"] != null || simpleRangeConstReturnTriggerNode.Attributes["id"] != null) 
                {
                    if (simpleRangeConstReturnTriggerNode.Attributes["id"] != null) 
                    {
                        simpleRangeConstReturnTriggerIDRef_ = simpleRangeConstReturnTriggerNode.Attributes["id"].Value;
                        SimpleRangeConstReturnTrigger ob = new SimpleRangeConstReturnTrigger(simpleRangeConstReturnTriggerNode);
                        IDManager.SetID(simpleRangeConstReturnTriggerIDRef_, ob);
                    }
                    else if (simpleRangeConstReturnTriggerNode.Attributes["href"] != null)
                    {
                        simpleRangeConstReturnTriggerIDRef_ = simpleRangeConstReturnTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeConstReturnTrigger_ = new SimpleRangeConstReturnTrigger(simpleRangeConstReturnTriggerNode);
                    }
                }
                else
                {
                    simpleRangeConstReturnTrigger_ = new SimpleRangeConstReturnTrigger(simpleRangeConstReturnTriggerNode);
                }
            }
            
        
            XmlNode simpleRangeRateTriggerNode = xmlNode.SelectSingleNode("simpleRangeRateTrigger");
            
            if (simpleRangeRateTriggerNode != null)
            {
                if (simpleRangeRateTriggerNode.Attributes["href"] != null || simpleRangeRateTriggerNode.Attributes["id"] != null) 
                {
                    if (simpleRangeRateTriggerNode.Attributes["id"] != null) 
                    {
                        simpleRangeRateTriggerIDRef_ = simpleRangeRateTriggerNode.Attributes["id"].Value;
                        SimpleRangeRateTrigger ob = new SimpleRangeRateTrigger(simpleRangeRateTriggerNode);
                        IDManager.SetID(simpleRangeRateTriggerIDRef_, ob);
                    }
                    else if (simpleRangeRateTriggerNode.Attributes["href"] != null)
                    {
                        simpleRangeRateTriggerIDRef_ = simpleRangeRateTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeRateTrigger_ = new SimpleRangeRateTrigger(simpleRangeRateTriggerNode);
                    }
                }
                else
                {
                    simpleRangeRateTrigger_ = new SimpleRangeRateTrigger(simpleRangeRateTriggerNode);
                }
            }
            
        
            XmlNode simpleRangeAccrualRateTriggerNode = xmlNode.SelectSingleNode("simpleRangeAccrualRateTrigger");
            
            if (simpleRangeAccrualRateTriggerNode != null)
            {
                if (simpleRangeAccrualRateTriggerNode.Attributes["href"] != null || simpleRangeAccrualRateTriggerNode.Attributes["id"] != null) 
                {
                    if (simpleRangeAccrualRateTriggerNode.Attributes["id"] != null) 
                    {
                        simpleRangeAccrualRateTriggerIDRef_ = simpleRangeAccrualRateTriggerNode.Attributes["id"].Value;
                        SimpleRangeAccrualRateTrigger ob = new SimpleRangeAccrualRateTrigger(simpleRangeAccrualRateTriggerNode);
                        IDManager.SetID(simpleRangeAccrualRateTriggerIDRef_, ob);
                    }
                    else if (simpleRangeAccrualRateTriggerNode.Attributes["href"] != null)
                    {
                        simpleRangeAccrualRateTriggerIDRef_ = simpleRangeAccrualRateTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeAccrualRateTrigger_ = new SimpleRangeAccrualRateTrigger(simpleRangeAccrualRateTriggerNode);
                    }
                }
                else
                {
                    simpleRangeAccrualRateTrigger_ = new SimpleRangeAccrualRateTrigger(simpleRangeAccrualRateTriggerNode);
                }
            }
            
        
            XmlNode fixedRateTriggerNode = xmlNode.SelectSingleNode("fixedRateTrigger");
            
            if (fixedRateTriggerNode != null)
            {
                if (fixedRateTriggerNode.Attributes["href"] != null || fixedRateTriggerNode.Attributes["id"] != null) 
                {
                    if (fixedRateTriggerNode.Attributes["id"] != null) 
                    {
                        fixedRateTriggerIDRef_ = fixedRateTriggerNode.Attributes["id"].Value;
                        FixedRateTrigger ob = new FixedRateTrigger(fixedRateTriggerNode);
                        IDManager.SetID(fixedRateTriggerIDRef_, ob);
                    }
                    else if (fixedRateTriggerNode.Attributes["href"] != null)
                    {
                        fixedRateTriggerIDRef_ = fixedRateTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRateTrigger_ = new FixedRateTrigger(fixedRateTriggerNode);
                    }
                }
                else
                {
                    fixedRateTrigger_ = new FixedRateTrigger(fixedRateTriggerNode);
                }
            }
            
        
            XmlNode vanillaRateTriggerNode = xmlNode.SelectSingleNode("vanillaRateTrigger");
            
            if (vanillaRateTriggerNode != null)
            {
                if (vanillaRateTriggerNode.Attributes["href"] != null || vanillaRateTriggerNode.Attributes["id"] != null) 
                {
                    if (vanillaRateTriggerNode.Attributes["id"] != null) 
                    {
                        vanillaRateTriggerIDRef_ = vanillaRateTriggerNode.Attributes["id"].Value;
                        VanillaRateTrigger ob = new VanillaRateTrigger(vanillaRateTriggerNode);
                        IDManager.SetID(vanillaRateTriggerIDRef_, ob);
                    }
                    else if (vanillaRateTriggerNode.Attributes["href"] != null)
                    {
                        vanillaRateTriggerIDRef_ = vanillaRateTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaRateTrigger_ = new VanillaRateTrigger(vanillaRateTriggerNode);
                    }
                }
                else
                {
                    vanillaRateTrigger_ = new VanillaRateTrigger(vanillaRateTriggerNode);
                }
            }
            
        
            XmlNode redemptionNotionalTriggerNode = xmlNode.SelectSingleNode("redemptionNotionalTrigger");
            
            if (redemptionNotionalTriggerNode != null)
            {
                if (redemptionNotionalTriggerNode.Attributes["href"] != null || redemptionNotionalTriggerNode.Attributes["id"] != null) 
                {
                    if (redemptionNotionalTriggerNode.Attributes["id"] != null) 
                    {
                        redemptionNotionalTriggerIDRef_ = redemptionNotionalTriggerNode.Attributes["id"].Value;
                        RedemptionNotionalTrigger ob = new RedemptionNotionalTrigger(redemptionNotionalTriggerNode);
                        IDManager.SetID(redemptionNotionalTriggerIDRef_, ob);
                    }
                    else if (redemptionNotionalTriggerNode.Attributes["href"] != null)
                    {
                        redemptionNotionalTriggerIDRef_ = redemptionNotionalTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        redemptionNotionalTrigger_ = new RedemptionNotionalTrigger(redemptionNotionalTriggerNode);
                    }
                }
                else
                {
                    redemptionNotionalTrigger_ = new RedemptionNotionalTrigger(redemptionNotionalTriggerNode);
                }
            }
            
        
            XmlNode autoCallRangeReturnTriggerNode = xmlNode.SelectSingleNode("autoCallRangeReturnTrigger");
            
            if (autoCallRangeReturnTriggerNode != null)
            {
                if (autoCallRangeReturnTriggerNode.Attributes["href"] != null || autoCallRangeReturnTriggerNode.Attributes["id"] != null) 
                {
                    if (autoCallRangeReturnTriggerNode.Attributes["id"] != null) 
                    {
                        autoCallRangeReturnTriggerIDRef_ = autoCallRangeReturnTriggerNode.Attributes["id"].Value;
                        AutoCallRangeReturnTrigger ob = new AutoCallRangeReturnTrigger(autoCallRangeReturnTriggerNode);
                        IDManager.SetID(autoCallRangeReturnTriggerIDRef_, ob);
                    }
                    else if (autoCallRangeReturnTriggerNode.Attributes["href"] != null)
                    {
                        autoCallRangeReturnTriggerIDRef_ = autoCallRangeReturnTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallRangeReturnTrigger_ = new AutoCallRangeReturnTrigger(autoCallRangeReturnTriggerNode);
                    }
                }
                else
                {
                    autoCallRangeReturnTrigger_ = new AutoCallRangeReturnTrigger(autoCallRangeReturnTriggerNode);
                }
            }
            
        
            XmlNode vanillaCouponTriggerNode = xmlNode.SelectSingleNode("vanillaCouponTrigger");
            
            if (vanillaCouponTriggerNode != null)
            {
                if (vanillaCouponTriggerNode.Attributes["href"] != null || vanillaCouponTriggerNode.Attributes["id"] != null) 
                {
                    if (vanillaCouponTriggerNode.Attributes["id"] != null) 
                    {
                        vanillaCouponTriggerIDRef_ = vanillaCouponTriggerNode.Attributes["id"].Value;
                        VanillaCouponTrigger ob = new VanillaCouponTrigger(vanillaCouponTriggerNode);
                        IDManager.SetID(vanillaCouponTriggerIDRef_, ob);
                    }
                    else if (vanillaCouponTriggerNode.Attributes["href"] != null)
                    {
                        vanillaCouponTriggerIDRef_ = vanillaCouponTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaCouponTrigger_ = new VanillaCouponTrigger(vanillaCouponTriggerNode);
                    }
                }
                else
                {
                    vanillaCouponTrigger_ = new VanillaCouponTrigger(vanillaCouponTriggerNode);
                }
            }
            
        
            XmlNode simpleEventCouponTriggerNode = xmlNode.SelectSingleNode("simpleEventCouponTrigger");
            
            if (simpleEventCouponTriggerNode != null)
            {
                if (simpleEventCouponTriggerNode.Attributes["href"] != null || simpleEventCouponTriggerNode.Attributes["id"] != null) 
                {
                    if (simpleEventCouponTriggerNode.Attributes["id"] != null) 
                    {
                        simpleEventCouponTriggerIDRef_ = simpleEventCouponTriggerNode.Attributes["id"].Value;
                        SimpleEventCouponTrigger ob = new SimpleEventCouponTrigger(simpleEventCouponTriggerNode);
                        IDManager.SetID(simpleEventCouponTriggerIDRef_, ob);
                    }
                    else if (simpleEventCouponTriggerNode.Attributes["href"] != null)
                    {
                        simpleEventCouponTriggerIDRef_ = simpleEventCouponTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleEventCouponTrigger_ = new SimpleEventCouponTrigger(simpleEventCouponTriggerNode);
                    }
                }
                else
                {
                    simpleEventCouponTrigger_ = new SimpleEventCouponTrigger(simpleEventCouponTriggerNode);
                }
            }
            
        
            XmlNode postCalculationNode = xmlNode.SelectSingleNode("postCalculation");
            
            if (postCalculationNode != null)
            {
                if (postCalculationNode.Attributes["href"] != null || postCalculationNode.Attributes["id"] != null) 
                {
                    if (postCalculationNode.Attributes["id"] != null) 
                    {
                        postCalculationIDRef_ = postCalculationNode.Attributes["id"].Value;
                        PostCalculation ob = new PostCalculation(postCalculationNode);
                        IDManager.SetID(postCalculationIDRef_, ob);
                    }
                    else if (postCalculationNode.Attributes["href"] != null)
                    {
                        postCalculationIDRef_ = postCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        postCalculation_ = new PostCalculation(postCalculationNode);
                    }
                }
                else
                {
                    postCalculation_ = new PostCalculation(postCalculationNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region EventDate_
        private XsdTypeDate eventDate_;
        public XsdTypeDate EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeDate;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region AutoTerminationTrigger_
        private AutoTerminationTrigger autoTerminationTrigger_;
        public AutoTerminationTrigger AutoTerminationTrigger_
        {
            get
            {
                if (this.autoTerminationTrigger_ != null)
                {
                    return this.autoTerminationTrigger_; 
                }
                else if (this.autoTerminationTriggerIDRef_ != null)
                {
                    autoTerminationTrigger_ = IDManager.getID(autoTerminationTriggerIDRef_) as AutoTerminationTrigger;
                    return this.autoTerminationTrigger_; 
                }
                else
                {
                    throw new Exception( "autoTerminationTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.autoTerminationTrigger_ != value)
                {
                    this.autoTerminationTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string autoTerminationTriggerIDRef_ { get; set; }
        #region PreEventCalculation_
        private PreEventCalculation preEventCalculation_;
        public PreEventCalculation PreEventCalculation_
        {
            get
            {
                if (this.preEventCalculation_ != null)
                {
                    return this.preEventCalculation_; 
                }
                else if (this.preEventCalculationIDRef_ != null)
                {
                    preEventCalculation_ = IDManager.getID(preEventCalculationIDRef_) as PreEventCalculation;
                    return this.preEventCalculation_; 
                }
                else
                {
                    throw new Exception( "preEventCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.preEventCalculation_ != value)
                {
                    this.preEventCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string preEventCalculationIDRef_ { get; set; }
        #region PreConditionEvent_
        private PreConditionEvent preConditionEvent_;
        public PreConditionEvent PreConditionEvent_
        {
            get
            {
                if (this.preConditionEvent_ != null)
                {
                    return this.preConditionEvent_; 
                }
                else if (this.preConditionEventIDRef_ != null)
                {
                    preConditionEvent_ = IDManager.getID(preConditionEventIDRef_) as PreConditionEvent;
                    return this.preConditionEvent_; 
                }
                else
                {
                    throw new Exception( "preConditionEvent_Node no exist!");
                }
            }
            set
            {
                if (this.preConditionEvent_ != value)
                {
                    this.preConditionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string preConditionEventIDRef_ { get; set; }
        #region AutoCallConstReturnTrigger_
        private AutoCallConstReturnTrigger autoCallConstReturnTrigger_;
        public AutoCallConstReturnTrigger AutoCallConstReturnTrigger_
        {
            get
            {
                if (this.autoCallConstReturnTrigger_ != null)
                {
                    return this.autoCallConstReturnTrigger_; 
                }
                else if (this.autoCallConstReturnTriggerIDRef_ != null)
                {
                    autoCallConstReturnTrigger_ = IDManager.getID(autoCallConstReturnTriggerIDRef_) as AutoCallConstReturnTrigger;
                    return this.autoCallConstReturnTrigger_; 
                }
                else
                {
                    throw new Exception( "autoCallConstReturnTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallConstReturnTrigger_ != value)
                {
                    this.autoCallConstReturnTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallConstReturnTriggerIDRef_ { get; set; }
        #region SimpleRangeConstReturnTrigger_
        private SimpleRangeConstReturnTrigger simpleRangeConstReturnTrigger_;
        public SimpleRangeConstReturnTrigger SimpleRangeConstReturnTrigger_
        {
            get
            {
                if (this.simpleRangeConstReturnTrigger_ != null)
                {
                    return this.simpleRangeConstReturnTrigger_; 
                }
                else if (this.simpleRangeConstReturnTriggerIDRef_ != null)
                {
                    simpleRangeConstReturnTrigger_ = IDManager.getID(simpleRangeConstReturnTriggerIDRef_) as SimpleRangeConstReturnTrigger;
                    return this.simpleRangeConstReturnTrigger_; 
                }
                else
                {
                    throw new Exception( "simpleRangeConstReturnTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeConstReturnTrigger_ != value)
                {
                    this.simpleRangeConstReturnTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeConstReturnTriggerIDRef_ { get; set; }
        #region SimpleRangeRateTrigger_
        private SimpleRangeRateTrigger simpleRangeRateTrigger_;
        public SimpleRangeRateTrigger SimpleRangeRateTrigger_
        {
            get
            {
                if (this.simpleRangeRateTrigger_ != null)
                {
                    return this.simpleRangeRateTrigger_; 
                }
                else if (this.simpleRangeRateTriggerIDRef_ != null)
                {
                    simpleRangeRateTrigger_ = IDManager.getID(simpleRangeRateTriggerIDRef_) as SimpleRangeRateTrigger;
                    return this.simpleRangeRateTrigger_; 
                }
                else
                {
                    throw new Exception( "simpleRangeRateTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeRateTrigger_ != value)
                {
                    this.simpleRangeRateTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeRateTriggerIDRef_ { get; set; }
        #region SimpleRangeAccrualRateTrigger_
        private SimpleRangeAccrualRateTrigger simpleRangeAccrualRateTrigger_;
        public SimpleRangeAccrualRateTrigger SimpleRangeAccrualRateTrigger_
        {
            get
            {
                if (this.simpleRangeAccrualRateTrigger_ != null)
                {
                    return this.simpleRangeAccrualRateTrigger_; 
                }
                else if (this.simpleRangeAccrualRateTriggerIDRef_ != null)
                {
                    simpleRangeAccrualRateTrigger_ = IDManager.getID(simpleRangeAccrualRateTriggerIDRef_) as SimpleRangeAccrualRateTrigger;
                    return this.simpleRangeAccrualRateTrigger_; 
                }
                else
                {
                    throw new Exception( "simpleRangeAccrualRateTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeAccrualRateTrigger_ != value)
                {
                    this.simpleRangeAccrualRateTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeAccrualRateTriggerIDRef_ { get; set; }
        #region FixedRateTrigger_
        private FixedRateTrigger fixedRateTrigger_;
        public FixedRateTrigger FixedRateTrigger_
        {
            get
            {
                if (this.fixedRateTrigger_ != null)
                {
                    return this.fixedRateTrigger_; 
                }
                else if (this.fixedRateTriggerIDRef_ != null)
                {
                    fixedRateTrigger_ = IDManager.getID(fixedRateTriggerIDRef_) as FixedRateTrigger;
                    return this.fixedRateTrigger_; 
                }
                else
                {
                    throw new Exception( "fixedRateTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRateTrigger_ != value)
                {
                    this.fixedRateTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateTriggerIDRef_ { get; set; }
        #region VanillaRateTrigger_
        private VanillaRateTrigger vanillaRateTrigger_;
        public VanillaRateTrigger VanillaRateTrigger_
        {
            get
            {
                if (this.vanillaRateTrigger_ != null)
                {
                    return this.vanillaRateTrigger_; 
                }
                else if (this.vanillaRateTriggerIDRef_ != null)
                {
                    vanillaRateTrigger_ = IDManager.getID(vanillaRateTriggerIDRef_) as VanillaRateTrigger;
                    return this.vanillaRateTrigger_; 
                }
                else
                {
                    throw new Exception( "vanillaRateTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaRateTrigger_ != value)
                {
                    this.vanillaRateTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaRateTriggerIDRef_ { get; set; }
        #region RedemptionNotionalTrigger_
        private RedemptionNotionalTrigger redemptionNotionalTrigger_;
        public RedemptionNotionalTrigger RedemptionNotionalTrigger_
        {
            get
            {
                if (this.redemptionNotionalTrigger_ != null)
                {
                    return this.redemptionNotionalTrigger_; 
                }
                else if (this.redemptionNotionalTriggerIDRef_ != null)
                {
                    redemptionNotionalTrigger_ = IDManager.getID(redemptionNotionalTriggerIDRef_) as RedemptionNotionalTrigger;
                    return this.redemptionNotionalTrigger_; 
                }
                else
                {
                    throw new Exception( "redemptionNotionalTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.redemptionNotionalTrigger_ != value)
                {
                    this.redemptionNotionalTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string redemptionNotionalTriggerIDRef_ { get; set; }
        #region AutoCallRangeReturnTrigger_
        private AutoCallRangeReturnTrigger autoCallRangeReturnTrigger_;
        public AutoCallRangeReturnTrigger AutoCallRangeReturnTrigger_
        {
            get
            {
                if (this.autoCallRangeReturnTrigger_ != null)
                {
                    return this.autoCallRangeReturnTrigger_; 
                }
                else if (this.autoCallRangeReturnTriggerIDRef_ != null)
                {
                    autoCallRangeReturnTrigger_ = IDManager.getID(autoCallRangeReturnTriggerIDRef_) as AutoCallRangeReturnTrigger;
                    return this.autoCallRangeReturnTrigger_; 
                }
                else
                {
                    throw new Exception( "autoCallRangeReturnTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallRangeReturnTrigger_ != value)
                {
                    this.autoCallRangeReturnTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallRangeReturnTriggerIDRef_ { get; set; }
        #region VanillaCouponTrigger_
        private VanillaCouponTrigger vanillaCouponTrigger_;
        public VanillaCouponTrigger VanillaCouponTrigger_
        {
            get
            {
                if (this.vanillaCouponTrigger_ != null)
                {
                    return this.vanillaCouponTrigger_; 
                }
                else if (this.vanillaCouponTriggerIDRef_ != null)
                {
                    vanillaCouponTrigger_ = IDManager.getID(vanillaCouponTriggerIDRef_) as VanillaCouponTrigger;
                    return this.vanillaCouponTrigger_; 
                }
                else
                {
                    throw new Exception( "vanillaCouponTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaCouponTrigger_ != value)
                {
                    this.vanillaCouponTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaCouponTriggerIDRef_ { get; set; }
        #region SimpleEventCouponTrigger_
        private SimpleEventCouponTrigger simpleEventCouponTrigger_;
        public SimpleEventCouponTrigger SimpleEventCouponTrigger_
        {
            get
            {
                if (this.simpleEventCouponTrigger_ != null)
                {
                    return this.simpleEventCouponTrigger_; 
                }
                else if (this.simpleEventCouponTriggerIDRef_ != null)
                {
                    simpleEventCouponTrigger_ = IDManager.getID(simpleEventCouponTriggerIDRef_) as SimpleEventCouponTrigger;
                    return this.simpleEventCouponTrigger_; 
                }
                else
                {
                    throw new Exception( "simpleEventCouponTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.simpleEventCouponTrigger_ != value)
                {
                    this.simpleEventCouponTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string simpleEventCouponTriggerIDRef_ { get; set; }
        #region PostCalculation_
        private PostCalculation postCalculation_;
        public PostCalculation PostCalculation_
        {
            get
            {
                if (this.postCalculation_ != null)
                {
                    return this.postCalculation_; 
                }
                else if (this.postCalculationIDRef_ != null)
                {
                    postCalculation_ = IDManager.getID(postCalculationIDRef_) as PostCalculation;
                    return this.postCalculation_; 
                }
                else
                {
                    throw new Exception( "postCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.postCalculation_ != value)
                {
                    this.postCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string postCalculationIDRef_ { get; set; }
        public string choiceStr_eventTriggerType;
        
    
        
    
    }
    
}

