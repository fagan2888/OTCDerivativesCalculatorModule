using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditDefaultSwapOption : OptionBaseExtended
    {
        public CreditDefaultSwapOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        CreditOptionStrike ob = new CreditOptionStrike(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new CreditOptionStrike(strikeNode);
                    }
                }
                else
                {
                    strike_ = new CreditOptionStrike(strikeNode);
                }
            }
            
        
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
        
    
        #region Strike_
        private CreditOptionStrike strike_;
        public CreditOptionStrike Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as CreditOptionStrike;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
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
                      return this.creditDefaultSwap_; 
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

