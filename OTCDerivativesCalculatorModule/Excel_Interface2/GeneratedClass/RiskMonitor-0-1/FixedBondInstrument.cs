using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedBondInstrument : ISerialized
    {
        public FixedBondInstrument() { }
        public FixedBondInstrument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode bondInformationNode = xmlNode.SelectSingleNode("bondInformation");
            
            if (bondInformationNode != null)
            {
                if (bondInformationNode.Attributes["href"] != null || bondInformationNode.Attributes["id"] != null) 
                {
                    if (bondInformationNode.Attributes["id"] != null) 
                    {
                        bondInformationIDRef_ = bondInformationNode.Attributes["id"].Value;
                        BondInformation ob = new BondInformation(bondInformationNode);
                        IDManager.SetID(bondInformationIDRef_, ob);
                    }
                    else if (bondInformationNode.Attributes["href"] != null)
                    {
                        bondInformationIDRef_ = bondInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bondInformation_ = new BondInformation(bondInformationNode);
                    }
                }
                else
                {
                    bondInformation_ = new BondInformation(bondInformationNode);
                }
            }
            
        
            XmlNode bondCouponInfoNode = xmlNode.SelectSingleNode("bondCouponInfo");
            
            if (bondCouponInfoNode != null)
            {
                if (bondCouponInfoNode.Attributes["href"] != null || bondCouponInfoNode.Attributes["id"] != null) 
                {
                    if (bondCouponInfoNode.Attributes["id"] != null) 
                    {
                        bondCouponInfoIDRef_ = bondCouponInfoNode.Attributes["id"].Value;
                        BondCouponInfo ob = new BondCouponInfo(bondCouponInfoNode);
                        IDManager.SetID(bondCouponInfoIDRef_, ob);
                    }
                    else if (bondCouponInfoNode.Attributes["href"] != null)
                    {
                        bondCouponInfoIDRef_ = bondCouponInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bondCouponInfo_ = new BondCouponInfo(bondCouponInfoNode);
                    }
                }
                else
                {
                    bondCouponInfo_ = new BondCouponInfo(bondCouponInfoNode);
                }
            }
            
        
            XmlNode payoffInfoAnalyticNode = xmlNode.SelectSingleNode("payoffInfoAnalytic");
            
            if (payoffInfoAnalyticNode != null)
            {
                if (payoffInfoAnalyticNode.Attributes["href"] != null || payoffInfoAnalyticNode.Attributes["id"] != null) 
                {
                    if (payoffInfoAnalyticNode.Attributes["id"] != null) 
                    {
                        payoffInfoAnalyticIDRef_ = payoffInfoAnalyticNode.Attributes["id"].Value;
                        PayoffInfoAnalytic ob = new PayoffInfoAnalytic(payoffInfoAnalyticNode);
                        IDManager.SetID(payoffInfoAnalyticIDRef_, ob);
                    }
                    else if (payoffInfoAnalyticNode.Attributes["href"] != null)
                    {
                        payoffInfoAnalyticIDRef_ = payoffInfoAnalyticNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffInfoAnalytic_ = new PayoffInfoAnalytic(payoffInfoAnalyticNode);
                    }
                }
                else
                {
                    payoffInfoAnalytic_ = new PayoffInfoAnalytic(payoffInfoAnalyticNode);
                }
            }
            
        
        }
        
    
        #region BondInformation_
        private BondInformation bondInformation_;
        public BondInformation BondInformation_
        {
            get
            {
                if (this.bondInformation_ != null)
                {
                    return this.bondInformation_; 
                }
                else if (this.bondInformationIDRef_ != null)
                {
                    bondInformation_ = IDManager.getID(bondInformationIDRef_) as BondInformation;
                    return this.bondInformation_; 
                }
                else
                {
                    throw new Exception( "bondInformation_Node no exist!");
                }
            }
            set
            {
                if (this.bondInformation_ != value)
                {
                    this.bondInformation_ = value;
                }
            }
        }
        #endregion
        
        public string bondInformationIDRef_ { get; set; }
        #region BondCouponInfo_
        private BondCouponInfo bondCouponInfo_;
        public BondCouponInfo BondCouponInfo_
        {
            get
            {
                if (this.bondCouponInfo_ != null)
                {
                    return this.bondCouponInfo_; 
                }
                else if (this.bondCouponInfoIDRef_ != null)
                {
                    bondCouponInfo_ = IDManager.getID(bondCouponInfoIDRef_) as BondCouponInfo;
                    return this.bondCouponInfo_; 
                }
                else
                {
                    throw new Exception( "bondCouponInfo_Node no exist!");
                }
            }
            set
            {
                if (this.bondCouponInfo_ != value)
                {
                    this.bondCouponInfo_ = value;
                }
            }
        }
        #endregion
        
        public string bondCouponInfoIDRef_ { get; set; }
        #region PayoffInfoAnalytic_
        private PayoffInfoAnalytic payoffInfoAnalytic_;
        public PayoffInfoAnalytic PayoffInfoAnalytic_
        {
            get
            {
                if (this.payoffInfoAnalytic_ != null)
                {
                    return this.payoffInfoAnalytic_; 
                }
                else if (this.payoffInfoAnalyticIDRef_ != null)
                {
                    payoffInfoAnalytic_ = IDManager.getID(payoffInfoAnalyticIDRef_) as PayoffInfoAnalytic;
                    return this.payoffInfoAnalytic_; 
                }
                else
                {
                    throw new Exception( "payoffInfoAnalytic_Node no exist!");
                }
            }
            set
            {
                if (this.payoffInfoAnalytic_ != value)
                {
                    this.payoffInfoAnalytic_ = value;
                }
            }
        }
        #endregion
        
        public string payoffInfoAnalyticIDRef_ { get; set; }
        
    
        
    
    }
    
}

