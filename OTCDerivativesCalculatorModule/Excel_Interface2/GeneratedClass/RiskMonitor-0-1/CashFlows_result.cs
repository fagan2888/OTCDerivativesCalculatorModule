using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashFlows_result : ISerialized
    {
        public CashFlows_result() { }
        public CashFlows_result(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList cashFlow_resultNodeList = xmlNode.SelectNodes("cashFlow_result");
            
            if (cashFlow_resultNodeList != null)
            {
                this.cashFlow_result_ = new List<CashFlow_result>();
                foreach (XmlNode item in cashFlow_resultNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            cashFlow_resultIDRef_ = item.Attributes["id"].Value;
                            cashFlow_result_.Add(new CashFlow_result(item));
                            IDManager.SetID(cashFlow_resultIDRef_, cashFlow_result_[cashFlow_result_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            cashFlow_resultIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        cashFlow_result_.Add(new CashFlow_result(item));
                        }
                    }
                    else
                    {
                        cashFlow_result_.Add(new CashFlow_result(item));
                    }
                }
            }
            
        
        }
        
    
        #region CashFlow_result_
        private List<CashFlow_result> cashFlow_result_;
        public List<CashFlow_result> CashFlow_result_
        {
            get
            {
                if (this.cashFlow_result_ != null)
                {
                    return this.cashFlow_result_; 
                }
                else if (this.cashFlow_resultIDRef_ != null)
                {
                    return this.cashFlow_result_; 
                }
                else
                {
                    throw new Exception( "cashFlow_result_Node no exist!");
                }
            }
            set
            {
                if (this.cashFlow_result_ != value)
                {
                    this.cashFlow_result_ = value;
                }
            }
        }
        #endregion
        
        public string cashFlow_resultIDRef_ { get; set; }
        
    
        
    
    }
    
}

