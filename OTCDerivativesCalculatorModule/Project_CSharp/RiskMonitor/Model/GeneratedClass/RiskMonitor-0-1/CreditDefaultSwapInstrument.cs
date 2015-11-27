using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditDefaultSwapInstrument : Instrument
    {
        public CreditDefaultSwapInstrument() { }
        public CreditDefaultSwapInstrument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode creditDefaultSwapNode = xmlNode.SelectSingleNode("creditDefaultSwap");
            
            if (creditDefaultSwapNode != null)
            {
                if (creditDefaultSwapNode.Attributes["href"] != null || creditDefaultSwapNode.Attributes["id"] != null) 
                {
                    if (creditDefaultSwapNode.Attributes["id"] != null) 
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["id"].Value;
                        CreditDefaultSwap ob = new CreditDefaultSwap(creditDefaultSwapNode);
                        IDManager.SetID(creditDefaultSwapIDRef_, ob);
                    }
                    else if (creditDefaultSwapNode.Attributes["href"] != null)
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                    }
                }
                else
                {
                    creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                }
            }
            
        
        }
        
    
        #region CreditDefaultSwap_
        private CreditDefaultSwap creditDefaultSwap_;
        public CreditDefaultSwap CreditDefaultSwap_
        {
            get
            {
                if (this.creditDefaultSwap_ != null)
                {
                    return this.creditDefaultSwap_; 
                }
                else if (this.creditDefaultSwapIDRef_ != null)
                {
                    creditDefaultSwap_ = IDManager.getID(creditDefaultSwapIDRef_) as CreditDefaultSwap;
                    return this.creditDefaultSwap_; 
                }
                else
                {
                    throw new Exception( "creditDefaultSwap_Node no exist!");
                }
            }
            set
            {
                if (this.creditDefaultSwap_ != value)
                {
                    this.creditDefaultSwap_ = value;
                }
            }
        }
        #endregion
        
        public string creditDefaultSwapIDRef_ { get; set; }
        
    
        
    
    }
    
}

