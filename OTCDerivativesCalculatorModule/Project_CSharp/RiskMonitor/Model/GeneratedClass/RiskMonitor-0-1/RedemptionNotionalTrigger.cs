using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RedemptionNotionalTrigger : ISerialized
    {
        public RedemptionNotionalTrigger() { }
        public RedemptionNotionalTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode redemptionAmountNode = xmlNode.SelectSingleNode("redemptionAmount");
            
            if (redemptionAmountNode != null)
            {
                if (redemptionAmountNode.Attributes["href"] != null || redemptionAmountNode.Attributes["id"] != null) 
                {
                    if (redemptionAmountNode.Attributes["id"] != null) 
                    {
                        redemptionAmountIDRef_ = redemptionAmountNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(redemptionAmountNode);
                        IDManager.SetID(redemptionAmountIDRef_, ob);
                    }
                    else if (redemptionAmountNode.Attributes["href"] != null)
                    {
                        redemptionAmountIDRef_ = redemptionAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        redemptionAmount_ = new XsdTypeDouble(redemptionAmountNode);
                    }
                }
                else
                {
                    redemptionAmount_ = new XsdTypeDouble(redemptionAmountNode);
                }
            }
            
        
        }
        
    
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
        #region RedemptionAmount_
        private XsdTypeDouble redemptionAmount_;
        public XsdTypeDouble RedemptionAmount_
        {
            get
            {
                if (this.redemptionAmount_ != null)
                {
                    return this.redemptionAmount_; 
                }
                else if (this.redemptionAmountIDRef_ != null)
                {
                    redemptionAmount_ = IDManager.getID(redemptionAmountIDRef_) as XsdTypeDouble;
                    return this.redemptionAmount_; 
                }
                else
                {
                    throw new Exception( "redemptionAmount_Node no exist!");
                }
            }
            set
            {
                if (this.redemptionAmount_ != value)
                {
                    this.redemptionAmount_ = value;
                }
            }
        }
        #endregion
        
        public string redemptionAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

