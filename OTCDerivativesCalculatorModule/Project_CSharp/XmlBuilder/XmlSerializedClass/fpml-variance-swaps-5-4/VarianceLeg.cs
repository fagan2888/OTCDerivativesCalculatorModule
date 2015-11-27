using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VarianceLeg : DirectionalLegUnderlyerValuation
    {
        public VarianceLeg(XmlNode xmlNode)
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
                        VarianceAmount ob = new VarianceAmount(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new VarianceAmount(amountNode);
                    }
                }
                else
                {
                    amount_ = new VarianceAmount(amountNode);
                }
            }
            
        
        }
        
    
        #region Amount_
        private VarianceAmount amount_;
        public VarianceAmount Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as VarianceAmount;
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
