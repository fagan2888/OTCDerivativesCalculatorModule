using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxConversion : ISerialized
    {
        public FxConversion(XmlNode xmlNode)
        {
            XmlNode amountRelativeToNode = xmlNode.SelectSingleNode("amountRelativeTo");
            
            if (amountRelativeToNode != null)
            {
                if (amountRelativeToNode.Attributes["href"] != null || amountRelativeToNode.Attributes["id"] != null) 
                {
                    if (amountRelativeToNode.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["id"].Value;
                        AmountReference ob = new AmountReference(amountRelativeToNode);
                        IDManager.SetID(amountRelativeToIDRef_, ob);
                    }
                    else if (amountRelativeToNode.Attributes["href"] != null)
                    {
                        amountRelativeToIDRef_ = amountRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                    }
                }
                else
                {
                    amountRelativeTo_ = new AmountReference(amountRelativeToNode);
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            if (fxRateNodeList != null)
            {
                this.fxRate_ = new List<FxRate>();
                foreach (XmlNode item in fxRateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fxRateIDRef_ = item.Attributes["id"].Value;
                            fxRate_.Add(new FxRate(item));
                            IDManager.SetID(fxRateIDRef_, fxRate_[fxRate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fxRateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fxRate_.Add(new FxRate(item));
                        }
                    }
                    else
                    {
                        fxRate_.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region AmountRelativeTo_
        private AmountReference amountRelativeTo_;
        public AmountReference AmountRelativeTo_
        {
            get
            {
                if (this.amountRelativeTo_ != null)
                {
                    return this.amountRelativeTo_; 
                }
                else if (this.amountRelativeToIDRef_ != null)
                {
                    amountRelativeTo_ = IDManager.getID(amountRelativeToIDRef_) as AmountReference;
                    return this.amountRelativeTo_; 
                }
                else
                {
                      return this.amountRelativeTo_; 
                }
            }
            set
            {
                if (this.amountRelativeTo_ != value)
                {
                    this.amountRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string amountRelativeToIDRef_ { get; set; }
        #region FxRate_
        private List<FxRate> fxRate_;
        public List<FxRate> FxRate_
        {
            get
            {
                if (this.fxRate_ != null)
                {
                    return this.fxRate_; 
                }
                else if (this.fxRateIDRef_ != null)
                {
                    return this.fxRate_; 
                }
                else
                {
                      return this.fxRate_; 
                }
            }
            set
            {
                if (this.fxRate_ != value)
                {
                    this.fxRate_ = value;
                }
            }
        }
        #endregion
        
        public string fxRateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

