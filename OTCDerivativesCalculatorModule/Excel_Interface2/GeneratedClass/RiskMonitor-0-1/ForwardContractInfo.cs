using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ForwardContractInfo : ISerialized
    {
        public ForwardContractInfo() { }
        public ForwardContractInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationDateNode = xmlNode.SelectSingleNode("calculationDate");
            
            if (calculationDateNode != null)
            {
                if (calculationDateNode.Attributes["href"] != null || calculationDateNode.Attributes["id"] != null) 
                {
                    if (calculationDateNode.Attributes["id"] != null) 
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(calculationDateNode);
                        IDManager.SetID(calculationDateIDRef_, ob);
                    }
                    else if (calculationDateNode.Attributes["href"] != null)
                    {
                        calculationDateIDRef_ = calculationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDate_ = new XsdTypeToken(calculationDateNode);
                    }
                }
                else
                {
                    calculationDate_ = new XsdTypeToken(calculationDateNode);
                }
            }
            
        
            XmlNode settlementDaysNode = xmlNode.SelectSingleNode("settlementDays");
            
            if (settlementDaysNode != null)
            {
                if (settlementDaysNode.Attributes["href"] != null || settlementDaysNode.Attributes["id"] != null) 
                {
                    if (settlementDaysNode.Attributes["id"] != null) 
                    {
                        settlementDaysIDRef_ = settlementDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(settlementDaysNode);
                        IDManager.SetID(settlementDaysIDRef_, ob);
                    }
                    else if (settlementDaysNode.Attributes["href"] != null)
                    {
                        settlementDaysIDRef_ = settlementDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDays_ = new XsdTypeToken(settlementDaysNode);
                    }
                }
                else
                {
                    settlementDays_ = new XsdTypeToken(settlementDaysNode);
                }
            }
            
        
            XmlNode settlementDateNode = xmlNode.SelectSingleNode("settlementDate");
            
            if (settlementDateNode != null)
            {
                if (settlementDateNode.Attributes["href"] != null || settlementDateNode.Attributes["id"] != null) 
                {
                    if (settlementDateNode.Attributes["id"] != null) 
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(settlementDateNode);
                        IDManager.SetID(settlementDateIDRef_, ob);
                    }
                    else if (settlementDateNode.Attributes["href"] != null)
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDate_ = new XsdTypeToken(settlementDateNode);
                    }
                }
                else
                {
                    settlementDate_ = new XsdTypeToken(settlementDateNode);
                }
            }
            
        
            XmlNode forwardPointNode = xmlNode.SelectSingleNode("forwardPoint");
            
            if (forwardPointNode != null)
            {
                if (forwardPointNode.Attributes["href"] != null || forwardPointNode.Attributes["id"] != null) 
                {
                    if (forwardPointNode.Attributes["id"] != null) 
                    {
                        forwardPointIDRef_ = forwardPointNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(forwardPointNode);
                        IDManager.SetID(forwardPointIDRef_, ob);
                    }
                    else if (forwardPointNode.Attributes["href"] != null)
                    {
                        forwardPointIDRef_ = forwardPointNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forwardPoint_ = new XsdTypeToken(forwardPointNode);
                    }
                }
                else
                {
                    forwardPoint_ = new XsdTypeToken(forwardPointNode);
                }
            }
            
        
        }
        
    
        #region CalculationDate_
        private XsdTypeToken calculationDate_;
        public XsdTypeToken CalculationDate_
        {
            get
            {
                if (this.calculationDate_ != null)
                {
                    return this.calculationDate_; 
                }
                else if (this.calculationDateIDRef_ != null)
                {
                    calculationDate_ = IDManager.getID(calculationDateIDRef_) as XsdTypeToken;
                    return this.calculationDate_; 
                }
                else
                {
                    throw new Exception( "calculationDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDateIDRef_ { get; set; }
        #region SettlementDays_
        private XsdTypeToken settlementDays_;
        public XsdTypeToken SettlementDays_
        {
            get
            {
                if (this.settlementDays_ != null)
                {
                    return this.settlementDays_; 
                }
                else if (this.settlementDaysIDRef_ != null)
                {
                    settlementDays_ = IDManager.getID(settlementDaysIDRef_) as XsdTypeToken;
                    return this.settlementDays_; 
                }
                else
                {
                    throw new Exception( "settlementDays_Node no exist!");
                }
            }
            set
            {
                if (this.settlementDays_ != value)
                {
                    this.settlementDays_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDaysIDRef_ { get; set; }
        #region SettlementDate_
        private XsdTypeToken settlementDate_;
        public XsdTypeToken SettlementDate_
        {
            get
            {
                if (this.settlementDate_ != null)
                {
                    return this.settlementDate_; 
                }
                else if (this.settlementDateIDRef_ != null)
                {
                    settlementDate_ = IDManager.getID(settlementDateIDRef_) as XsdTypeToken;
                    return this.settlementDate_; 
                }
                else
                {
                    throw new Exception( "settlementDate_Node no exist!");
                }
            }
            set
            {
                if (this.settlementDate_ != value)
                {
                    this.settlementDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDateIDRef_ { get; set; }
        #region ForwardPoint_
        private XsdTypeToken forwardPoint_;
        public XsdTypeToken ForwardPoint_
        {
            get
            {
                if (this.forwardPoint_ != null)
                {
                    return this.forwardPoint_; 
                }
                else if (this.forwardPointIDRef_ != null)
                {
                    forwardPoint_ = IDManager.getID(forwardPointIDRef_) as XsdTypeToken;
                    return this.forwardPoint_; 
                }
                else
                {
                    throw new Exception( "forwardPoint_Node no exist!");
                }
            }
            set
            {
                if (this.forwardPoint_ != value)
                {
                    this.forwardPoint_ = value;
                }
            }
        }
        #endregion
        
        public string forwardPointIDRef_ { get; set; }
        
    
        
    
    }
    
}

