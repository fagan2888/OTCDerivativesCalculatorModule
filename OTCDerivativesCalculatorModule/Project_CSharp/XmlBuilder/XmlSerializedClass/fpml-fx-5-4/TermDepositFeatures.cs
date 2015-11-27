using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TermDepositFeatures : ISerialized
    {
        public TermDepositFeatures(XmlNode xmlNode)
        {
            XmlNode dualCurrencyNode = xmlNode.SelectSingleNode("dualCurrency");
            
            if (dualCurrencyNode != null)
            {
                if (dualCurrencyNode.Attributes["href"] != null || dualCurrencyNode.Attributes["id"] != null) 
                {
                    if (dualCurrencyNode.Attributes["id"] != null) 
                    {
                        dualCurrencyIDRef_ = dualCurrencyNode.Attributes["id"].Value;
                        DualCurrencyFeature ob = new DualCurrencyFeature(dualCurrencyNode);
                        IDManager.SetID(dualCurrencyIDRef_, ob);
                    }
                    else if (dualCurrencyNode.Attributes["href"] != null)
                    {
                        dualCurrencyIDRef_ = dualCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dualCurrency_ = new DualCurrencyFeature(dualCurrencyNode);
                    }
                }
                else
                {
                    dualCurrency_ = new DualCurrencyFeature(dualCurrencyNode);
                }
            }
            
        
        }
        
    
        #region DualCurrency_
        private DualCurrencyFeature dualCurrency_;
        public DualCurrencyFeature DualCurrency_
        {
            get
            {
                if (this.dualCurrency_ != null)
                {
                    return this.dualCurrency_; 
                }
                else if (this.dualCurrencyIDRef_ != null)
                {
                    dualCurrency_ = IDManager.getID(dualCurrencyIDRef_) as DualCurrencyFeature;
                    return this.dualCurrency_; 
                }
                else
                {
                      return this.dualCurrency_; 
                }
            }
            set
            {
                if (this.dualCurrency_ != value)
                {
                    this.dualCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string dualCurrencyIDRef_ { get; set; }
        
    
        
    
    }
    
}

