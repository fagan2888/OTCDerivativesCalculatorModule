using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffBase : ISerialized
    {
        public PayoffBase(XmlNode xmlNode)
        {
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNodeList payoffCalculationNodeList = xmlNode.SelectNodes("payoffCalculation");
            
            if (payoffCalculationNodeList != null)
            {
                this.payoffCalculation_ = new List<PayoffCalculation>();
                foreach (XmlNode item in payoffCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            payoffCalculationIDRef_ = item.Attributes["id"].Value;
                            payoffCalculation_.Add(new PayoffCalculation(item));
                            IDManager.SetID(payoffCalculationIDRef_, payoffCalculation_[payoffCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            payoffCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        payoffCalculation_.Add(new PayoffCalculation(item));
                        }
                    }
                    else
                    {
                        payoffCalculation_.Add(new PayoffCalculation(item));
                    }
                }
            }
            
        
        }
        
    
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                      return this.payoffDate_; 
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region PayoffCalculation_
        private List<PayoffCalculation> payoffCalculation_;
        public List<PayoffCalculation> PayoffCalculation_
        {
            get
            {
                if (this.payoffCalculation_ != null)
                {
                    return this.payoffCalculation_; 
                }
                else if (this.payoffCalculationIDRef_ != null)
                {
                    return this.payoffCalculation_; 
                }
                else
                {
                      return this.payoffCalculation_; 
                }
            }
            set
            {
                if (this.payoffCalculation_ != value)
                {
                    this.payoffCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string payoffCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

