using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PositiveMoney : MoneyBase
    {
        public PositiveMoney(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new PositiveDecimal(amountNode);
                    }
                }
                else
                {
                    amount_ = new PositiveDecimal(amountNode);
                }
            }
            
        
        }
        
    
        #region Amount_
        private PositiveDecimal amount_;
        public PositiveDecimal Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as PositiveDecimal;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        
    
        
    
    }
    
}

