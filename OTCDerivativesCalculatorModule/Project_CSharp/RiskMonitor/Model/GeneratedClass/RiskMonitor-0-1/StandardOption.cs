using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StandardOption : ISerialized
    {
        public StandardOption() { }
        public StandardOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode unitNode = xmlNode.SelectSingleNode("unit");
            
            if (unitNode != null)
            {
                if (unitNode.Attributes["href"] != null || unitNode.Attributes["id"] != null) 
                {
                    if (unitNode.Attributes["id"] != null) 
                    {
                        unitIDRef_ = unitNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(unitNode);
                        IDManager.SetID(unitIDRef_, ob);
                    }
                    else if (unitNode.Attributes["href"] != null)
                    {
                        unitIDRef_ = unitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unit_ = new XsdTypeDouble(unitNode);
                    }
                }
                else
                {
                    unit_ = new XsdTypeDouble(unitNode);
                }
            }
            
        
            XmlNode baseCouponNode = xmlNode.SelectSingleNode("baseCoupon");
            
            if (baseCouponNode != null)
            {
                if (baseCouponNode.Attributes["href"] != null || baseCouponNode.Attributes["id"] != null) 
                {
                    if (baseCouponNode.Attributes["id"] != null) 
                    {
                        baseCouponIDRef_ = baseCouponNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(baseCouponNode);
                        IDManager.SetID(baseCouponIDRef_, ob);
                    }
                    else if (baseCouponNode.Attributes["href"] != null)
                    {
                        baseCouponIDRef_ = baseCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseCoupon_ = new XsdTypeDouble(baseCouponNode);
                    }
                }
                else
                {
                    baseCoupon_ = new XsdTypeDouble(baseCouponNode);
                }
            }
            
        
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
            
        
            XmlNode singleBarrierNode = xmlNode.SelectSingleNode("singleBarrier");
            
            if (singleBarrierNode != null)
            {
                if (singleBarrierNode.Attributes["href"] != null || singleBarrierNode.Attributes["id"] != null) 
                {
                    if (singleBarrierNode.Attributes["id"] != null) 
                    {
                        singleBarrierIDRef_ = singleBarrierNode.Attributes["id"].Value;
                        SingleBarrier ob = new SingleBarrier(singleBarrierNode);
                        IDManager.SetID(singleBarrierIDRef_, ob);
                    }
                    else if (singleBarrierNode.Attributes["href"] != null)
                    {
                        singleBarrierIDRef_ = singleBarrierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        singleBarrier_ = new SingleBarrier(singleBarrierNode);
                    }
                }
                else
                {
                    singleBarrier_ = new SingleBarrier(singleBarrierNode);
                }
            }
            
        
            XmlNode vanillaCallOptionNode = xmlNode.SelectSingleNode("vanillaCallOption");
            
            if (vanillaCallOptionNode != null)
            {
                if (vanillaCallOptionNode.Attributes["href"] != null || vanillaCallOptionNode.Attributes["id"] != null) 
                {
                    if (vanillaCallOptionNode.Attributes["id"] != null) 
                    {
                        vanillaCallOptionIDRef_ = vanillaCallOptionNode.Attributes["id"].Value;
                        VanillaCallOption ob = new VanillaCallOption(vanillaCallOptionNode);
                        IDManager.SetID(vanillaCallOptionIDRef_, ob);
                    }
                    else if (vanillaCallOptionNode.Attributes["href"] != null)
                    {
                        vanillaCallOptionIDRef_ = vanillaCallOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaCallOption_ = new VanillaCallOption(vanillaCallOptionNode);
                    }
                }
                else
                {
                    vanillaCallOption_ = new VanillaCallOption(vanillaCallOptionNode);
                }
            }
            
        
            XmlNode vanillaPutOptionNode = xmlNode.SelectSingleNode("vanillaPutOption");
            
            if (vanillaPutOptionNode != null)
            {
                if (vanillaPutOptionNode.Attributes["href"] != null || vanillaPutOptionNode.Attributes["id"] != null) 
                {
                    if (vanillaPutOptionNode.Attributes["id"] != null) 
                    {
                        vanillaPutOptionIDRef_ = vanillaPutOptionNode.Attributes["id"].Value;
                        VanillaPutOption ob = new VanillaPutOption(vanillaPutOptionNode);
                        IDManager.SetID(vanillaPutOptionIDRef_, ob);
                    }
                    else if (vanillaPutOptionNode.Attributes["href"] != null)
                    {
                        vanillaPutOptionIDRef_ = vanillaPutOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaPutOption_ = new VanillaPutOption(vanillaPutOptionNode);
                    }
                }
                else
                {
                    vanillaPutOption_ = new VanillaPutOption(vanillaPutOptionNode);
                }
            }
            
        
            XmlNode barrierWithConstRebateCallOptionNode = xmlNode.SelectSingleNode("barrierWithConstRebateCallOption");
            
            if (barrierWithConstRebateCallOptionNode != null)
            {
                if (barrierWithConstRebateCallOptionNode.Attributes["href"] != null || barrierWithConstRebateCallOptionNode.Attributes["id"] != null) 
                {
                    if (barrierWithConstRebateCallOptionNode.Attributes["id"] != null) 
                    {
                        barrierWithConstRebateCallOptionIDRef_ = barrierWithConstRebateCallOptionNode.Attributes["id"].Value;
                        BarrierWithConstRebateCallOption ob = new BarrierWithConstRebateCallOption(barrierWithConstRebateCallOptionNode);
                        IDManager.SetID(barrierWithConstRebateCallOptionIDRef_, ob);
                    }
                    else if (barrierWithConstRebateCallOptionNode.Attributes["href"] != null)
                    {
                        barrierWithConstRebateCallOptionIDRef_ = barrierWithConstRebateCallOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierWithConstRebateCallOption_ = new BarrierWithConstRebateCallOption(barrierWithConstRebateCallOptionNode);
                    }
                }
                else
                {
                    barrierWithConstRebateCallOption_ = new BarrierWithConstRebateCallOption(barrierWithConstRebateCallOptionNode);
                }
            }
            
        
            XmlNode barrierWithConstRebatePutOptionNode = xmlNode.SelectSingleNode("barrierWithConstRebatePutOption");
            
            if (barrierWithConstRebatePutOptionNode != null)
            {
                if (barrierWithConstRebatePutOptionNode.Attributes["href"] != null || barrierWithConstRebatePutOptionNode.Attributes["id"] != null) 
                {
                    if (barrierWithConstRebatePutOptionNode.Attributes["id"] != null) 
                    {
                        barrierWithConstRebatePutOptionIDRef_ = barrierWithConstRebatePutOptionNode.Attributes["id"].Value;
                        BarrierWithConstRebatePutOption ob = new BarrierWithConstRebatePutOption(barrierWithConstRebatePutOptionNode);
                        IDManager.SetID(barrierWithConstRebatePutOptionIDRef_, ob);
                    }
                    else if (barrierWithConstRebatePutOptionNode.Attributes["href"] != null)
                    {
                        barrierWithConstRebatePutOptionIDRef_ = barrierWithConstRebatePutOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierWithConstRebatePutOption_ = new BarrierWithConstRebatePutOption(barrierWithConstRebatePutOptionNode);
                    }
                }
                else
                {
                    barrierWithConstRebatePutOption_ = new BarrierWithConstRebatePutOption(barrierWithConstRebatePutOptionNode);
                }
            }
            
        
        }
        
    
        #region Unit_
        private XsdTypeDouble unit_;
        public XsdTypeDouble Unit_
        {
            get
            {
                if (this.unit_ != null)
                {
                    return this.unit_; 
                }
                else if (this.unitIDRef_ != null)
                {
                    unit_ = IDManager.getID(unitIDRef_) as XsdTypeDouble;
                    return this.unit_; 
                }
                else
                {
                    throw new Exception( "unit_Node no exist!");
                }
            }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                }
            }
        }
        #endregion
        
        public string unitIDRef_ { get; set; }
        #region BaseCoupon_
        private XsdTypeDouble baseCoupon_;
        public XsdTypeDouble BaseCoupon_
        {
            get
            {
                if (this.baseCoupon_ != null)
                {
                    return this.baseCoupon_; 
                }
                else if (this.baseCouponIDRef_ != null)
                {
                    baseCoupon_ = IDManager.getID(baseCouponIDRef_) as XsdTypeDouble;
                    return this.baseCoupon_; 
                }
                else
                {
                    throw new Exception( "baseCoupon_Node no exist!");
                }
            }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string baseCouponIDRef_ { get; set; }
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
        #region SingleBarrier_
        private SingleBarrier singleBarrier_;
        public SingleBarrier SingleBarrier_
        {
            get
            {
                if (this.singleBarrier_ != null)
                {
                    return this.singleBarrier_; 
                }
                else if (this.singleBarrierIDRef_ != null)
                {
                    singleBarrier_ = IDManager.getID(singleBarrierIDRef_) as SingleBarrier;
                    return this.singleBarrier_; 
                }
                else
                {
                    throw new Exception( "singleBarrier_Node no exist!");
                }
            }
            set
            {
                if (this.singleBarrier_ != value)
                {
                    this.singleBarrier_ = value;
                }
            }
        }
        #endregion
        
        public string singleBarrierIDRef_ { get; set; }
        #region VanillaCallOption_
        private VanillaCallOption vanillaCallOption_;
        public VanillaCallOption VanillaCallOption_
        {
            get
            {
                if (this.vanillaCallOption_ != null)
                {
                    return this.vanillaCallOption_; 
                }
                else if (this.vanillaCallOptionIDRef_ != null)
                {
                    vanillaCallOption_ = IDManager.getID(vanillaCallOptionIDRef_) as VanillaCallOption;
                    return this.vanillaCallOption_; 
                }
                else
                {
                    throw new Exception( "vanillaCallOption_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaCallOption_ != value)
                {
                    this.vanillaCallOption_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaCallOptionIDRef_ { get; set; }
        #region VanillaPutOption_
        private VanillaPutOption vanillaPutOption_;
        public VanillaPutOption VanillaPutOption_
        {
            get
            {
                if (this.vanillaPutOption_ != null)
                {
                    return this.vanillaPutOption_; 
                }
                else if (this.vanillaPutOptionIDRef_ != null)
                {
                    vanillaPutOption_ = IDManager.getID(vanillaPutOptionIDRef_) as VanillaPutOption;
                    return this.vanillaPutOption_; 
                }
                else
                {
                    throw new Exception( "vanillaPutOption_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaPutOption_ != value)
                {
                    this.vanillaPutOption_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaPutOptionIDRef_ { get; set; }
        #region BarrierWithConstRebateCallOption_
        private BarrierWithConstRebateCallOption barrierWithConstRebateCallOption_;
        public BarrierWithConstRebateCallOption BarrierWithConstRebateCallOption_
        {
            get
            {
                if (this.barrierWithConstRebateCallOption_ != null)
                {
                    return this.barrierWithConstRebateCallOption_; 
                }
                else if (this.barrierWithConstRebateCallOptionIDRef_ != null)
                {
                    barrierWithConstRebateCallOption_ = IDManager.getID(barrierWithConstRebateCallOptionIDRef_) as BarrierWithConstRebateCallOption;
                    return this.barrierWithConstRebateCallOption_; 
                }
                else
                {
                    throw new Exception( "barrierWithConstRebateCallOption_Node no exist!");
                }
            }
            set
            {
                if (this.barrierWithConstRebateCallOption_ != value)
                {
                    this.barrierWithConstRebateCallOption_ = value;
                }
            }
        }
        #endregion
        
        public string barrierWithConstRebateCallOptionIDRef_ { get; set; }
        #region BarrierWithConstRebatePutOption_
        private BarrierWithConstRebatePutOption barrierWithConstRebatePutOption_;
        public BarrierWithConstRebatePutOption BarrierWithConstRebatePutOption_
        {
            get
            {
                if (this.barrierWithConstRebatePutOption_ != null)
                {
                    return this.barrierWithConstRebatePutOption_; 
                }
                else if (this.barrierWithConstRebatePutOptionIDRef_ != null)
                {
                    barrierWithConstRebatePutOption_ = IDManager.getID(barrierWithConstRebatePutOptionIDRef_) as BarrierWithConstRebatePutOption;
                    return this.barrierWithConstRebatePutOption_; 
                }
                else
                {
                    throw new Exception( "barrierWithConstRebatePutOption_Node no exist!");
                }
            }
            set
            {
                if (this.barrierWithConstRebatePutOption_ != value)
                {
                    this.barrierWithConstRebatePutOption_ = value;
                }
            }
        }
        #endregion
        
        public string barrierWithConstRebatePutOptionIDRef_ { get; set; }
        public string choiceStr_standardOptionType;
        
    
        
    
    }
    
}

