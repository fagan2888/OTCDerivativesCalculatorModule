using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StepDownKIResult : ISerialized
    {
        public StepDownKIResult() { }
        public StepDownKIResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode underylingInfoResultNode = xmlNode.SelectSingleNode("underylingInfoResult");
            
            if (underylingInfoResultNode != null)
            {
                if (underylingInfoResultNode.Attributes["href"] != null || underylingInfoResultNode.Attributes["id"] != null) 
                {
                    if (underylingInfoResultNode.Attributes["id"] != null) 
                    {
                        underylingInfoResultIDRef_ = underylingInfoResultNode.Attributes["id"].Value;
                        UnderylingInfoResult ob = new UnderylingInfoResult(underylingInfoResultNode);
                        IDManager.SetID(underylingInfoResultIDRef_, ob);
                    }
                    else if (underylingInfoResultNode.Attributes["href"] != null)
                    {
                        underylingInfoResultIDRef_ = underylingInfoResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underylingInfoResult_ = new UnderylingInfoResult(underylingInfoResultNode);
                    }
                }
                else
                {
                    underylingInfoResult_ = new UnderylingInfoResult(underylingInfoResultNode);
                }
            }
            
        
            XmlNode cashFlowInfoResultNode = xmlNode.SelectSingleNode("cashFlowInfoResult");
            
            if (cashFlowInfoResultNode != null)
            {
                if (cashFlowInfoResultNode.Attributes["href"] != null || cashFlowInfoResultNode.Attributes["id"] != null) 
                {
                    if (cashFlowInfoResultNode.Attributes["id"] != null) 
                    {
                        cashFlowInfoResultIDRef_ = cashFlowInfoResultNode.Attributes["id"].Value;
                        CashFlowInfoResult ob = new CashFlowInfoResult(cashFlowInfoResultNode);
                        IDManager.SetID(cashFlowInfoResultIDRef_, ob);
                    }
                    else if (cashFlowInfoResultNode.Attributes["href"] != null)
                    {
                        cashFlowInfoResultIDRef_ = cashFlowInfoResultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashFlowInfoResult_ = new CashFlowInfoResult(cashFlowInfoResultNode);
                    }
                }
                else
                {
                    cashFlowInfoResult_ = new CashFlowInfoResult(cashFlowInfoResultNode);
                }
            }
            
        
            XmlNode thetaNode = xmlNode.SelectSingleNode("theta");
            
            if (thetaNode != null)
            {
                if (thetaNode.Attributes["href"] != null || thetaNode.Attributes["id"] != null) 
                {
                    if (thetaNode.Attributes["id"] != null) 
                    {
                        thetaIDRef_ = thetaNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(thetaNode);
                        IDManager.SetID(thetaIDRef_, ob);
                    }
                    else if (thetaNode.Attributes["href"] != null)
                    {
                        thetaIDRef_ = thetaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        theta_ = new XsdTypeDouble(thetaNode);
                    }
                }
                else
                {
                    theta_ = new XsdTypeDouble(thetaNode);
                }
            }
            
        
        }
        
    
        #region UnderylingInfoResult_
        private UnderylingInfoResult underylingInfoResult_;
        public UnderylingInfoResult UnderylingInfoResult_
        {
            get
            {
                if (this.underylingInfoResult_ != null)
                {
                    return this.underylingInfoResult_; 
                }
                else if (this.underylingInfoResultIDRef_ != null)
                {
                    underylingInfoResult_ = IDManager.getID(underylingInfoResultIDRef_) as UnderylingInfoResult;
                    return this.underylingInfoResult_; 
                }
                else
                {
                    throw new Exception( "underylingInfoResult_Node no exist!");
                }
            }
            set
            {
                if (this.underylingInfoResult_ != value)
                {
                    this.underylingInfoResult_ = value;
                }
            }
        }
        #endregion
        
        public string underylingInfoResultIDRef_ { get; set; }
        #region CashFlowInfoResult_
        private CashFlowInfoResult cashFlowInfoResult_;
        public CashFlowInfoResult CashFlowInfoResult_
        {
            get
            {
                if (this.cashFlowInfoResult_ != null)
                {
                    return this.cashFlowInfoResult_; 
                }
                else if (this.cashFlowInfoResultIDRef_ != null)
                {
                    cashFlowInfoResult_ = IDManager.getID(cashFlowInfoResultIDRef_) as CashFlowInfoResult;
                    return this.cashFlowInfoResult_; 
                }
                else
                {
                    throw new Exception( "cashFlowInfoResult_Node no exist!");
                }
            }
            set
            {
                if (this.cashFlowInfoResult_ != value)
                {
                    this.cashFlowInfoResult_ = value;
                }
            }
        }
        #endregion
        
        public string cashFlowInfoResultIDRef_ { get; set; }
        #region Theta_
        private XsdTypeDouble theta_;
        public XsdTypeDouble Theta_
        {
            get
            {
                if (this.theta_ != null)
                {
                    return this.theta_; 
                }
                else if (this.thetaIDRef_ != null)
                {
                    theta_ = IDManager.getID(thetaIDRef_) as XsdTypeDouble;
                    return this.theta_; 
                }
                else
                {
                    throw new Exception( "theta_Node no exist!");
                }
            }
            set
            {
                if (this.theta_ != value)
                {
                    this.theta_ = value;
                }
            }
        }
        #endregion
        
        public string thetaIDRef_ { get; set; }
        
    
        
    
    }
    
}

