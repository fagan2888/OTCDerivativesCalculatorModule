using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeNotionalChange : TradeChangeBase
    {
        public TradeNotionalChange(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList changeInNotionalAmountNodeList = xmlNode.SelectNodes("changeInNotionalAmount");
            
            if (changeInNotionalAmountNodeList != null)
            {
                this.changeInNotionalAmount_ = new List<NonNegativeMoney>();
                foreach (XmlNode item in changeInNotionalAmountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            changeInNotionalAmountIDRef_ = item.Attributes["id"].Value;
                            changeInNotionalAmount_.Add(new NonNegativeMoney(item));
                            IDManager.SetID(changeInNotionalAmountIDRef_, changeInNotionalAmount_[changeInNotionalAmount_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            changeInNotionalAmountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        changeInNotionalAmount_.Add(new NonNegativeMoney(item));
                        }
                    }
                    else
                    {
                        changeInNotionalAmount_.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNodeList outstandingNotionalAmountNodeList = xmlNode.SelectNodes("outstandingNotionalAmount");
            
            if (outstandingNotionalAmountNodeList != null)
            {
                this.outstandingNotionalAmount_ = new List<NonNegativeMoney>();
                foreach (XmlNode item in outstandingNotionalAmountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            outstandingNotionalAmountIDRef_ = item.Attributes["id"].Value;
                            outstandingNotionalAmount_.Add(new NonNegativeMoney(item));
                            IDManager.SetID(outstandingNotionalAmountIDRef_, outstandingNotionalAmount_[outstandingNotionalAmount_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            outstandingNotionalAmountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        outstandingNotionalAmount_.Add(new NonNegativeMoney(item));
                        }
                    }
                    else
                    {
                        outstandingNotionalAmount_.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNode changeInNumberOfOptionsNode = xmlNode.SelectSingleNode("changeInNumberOfOptions");
            
            if (changeInNumberOfOptionsNode != null)
            {
                if (changeInNumberOfOptionsNode.Attributes["href"] != null || changeInNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (changeInNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        changeInNumberOfOptionsIDRef_ = changeInNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(changeInNumberOfOptionsNode);
                        IDManager.SetID(changeInNumberOfOptionsIDRef_, ob);
                    }
                    else if (changeInNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        changeInNumberOfOptionsIDRef_ = changeInNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        changeInNumberOfOptions_ = new XsdTypeDecimal(changeInNumberOfOptionsNode);
                    }
                }
                else
                {
                    changeInNumberOfOptions_ = new XsdTypeDecimal(changeInNumberOfOptionsNode);
                }
            }
            
        
            XmlNode outstandingNumberOfOptionsNode = xmlNode.SelectSingleNode("outstandingNumberOfOptions");
            
            if (outstandingNumberOfOptionsNode != null)
            {
                if (outstandingNumberOfOptionsNode.Attributes["href"] != null || outstandingNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (outstandingNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                        IDManager.SetID(outstandingNumberOfOptionsIDRef_, ob);
                    }
                    else if (outstandingNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outstandingNumberOfOptions_ = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                    }
                }
                else
                {
                    outstandingNumberOfOptions_ = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                }
            }
            
        
            XmlNode changeInNumberOfUnitsNode = xmlNode.SelectSingleNode("changeInNumberOfUnits");
            
            if (changeInNumberOfUnitsNode != null)
            {
                if (changeInNumberOfUnitsNode.Attributes["href"] != null || changeInNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (changeInNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        changeInNumberOfUnitsIDRef_ = changeInNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(changeInNumberOfUnitsNode);
                        IDManager.SetID(changeInNumberOfUnitsIDRef_, ob);
                    }
                    else if (changeInNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        changeInNumberOfUnitsIDRef_ = changeInNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        changeInNumberOfUnits_ = new XsdTypeDecimal(changeInNumberOfUnitsNode);
                    }
                }
                else
                {
                    changeInNumberOfUnits_ = new XsdTypeDecimal(changeInNumberOfUnitsNode);
                }
            }
            
        
            XmlNode outstandingNumberOfUnitsNode = xmlNode.SelectSingleNode("outstandingNumberOfUnits");
            
            if (outstandingNumberOfUnitsNode != null)
            {
                if (outstandingNumberOfUnitsNode.Attributes["href"] != null || outstandingNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (outstandingNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
                        IDManager.SetID(outstandingNumberOfUnitsIDRef_, ob);
                    }
                    else if (outstandingNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outstandingNumberOfUnits_ = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
                    }
                }
                else
                {
                    outstandingNumberOfUnits_ = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
                }
            }
            
        
        }
        
    
        #region ChangeInNotionalAmount_
        private List<NonNegativeMoney> changeInNotionalAmount_;
        public List<NonNegativeMoney> ChangeInNotionalAmount_
        {
            get
            {
                if (this.changeInNotionalAmount_ != null)
                {
                    return this.changeInNotionalAmount_; 
                }
                else if (this.changeInNotionalAmountIDRef_ != null)
                {
                    return this.changeInNotionalAmount_; 
                }
                else
                {
                      return this.changeInNotionalAmount_; 
                }
            }
            set
            {
                if (this.changeInNotionalAmount_ != value)
                {
                    this.changeInNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string changeInNotionalAmountIDRef_ { get; set; }
        #region OutstandingNotionalAmount_
        private List<NonNegativeMoney> outstandingNotionalAmount_;
        public List<NonNegativeMoney> OutstandingNotionalAmount_
        {
            get
            {
                if (this.outstandingNotionalAmount_ != null)
                {
                    return this.outstandingNotionalAmount_; 
                }
                else if (this.outstandingNotionalAmountIDRef_ != null)
                {
                    return this.outstandingNotionalAmount_; 
                }
                else
                {
                      return this.outstandingNotionalAmount_; 
                }
            }
            set
            {
                if (this.outstandingNotionalAmount_ != value)
                {
                    this.outstandingNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNotionalAmountIDRef_ { get; set; }
        #region ChangeInNumberOfOptions_
        private XsdTypeDecimal changeInNumberOfOptions_;
        public XsdTypeDecimal ChangeInNumberOfOptions_
        {
            get
            {
                if (this.changeInNumberOfOptions_ != null)
                {
                    return this.changeInNumberOfOptions_; 
                }
                else if (this.changeInNumberOfOptionsIDRef_ != null)
                {
                    changeInNumberOfOptions_ = IDManager.getID(changeInNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.changeInNumberOfOptions_; 
                }
                else
                {
                      return this.changeInNumberOfOptions_; 
                }
            }
            set
            {
                if (this.changeInNumberOfOptions_ != value)
                {
                    this.changeInNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string changeInNumberOfOptionsIDRef_ { get; set; }
        #region OutstandingNumberOfOptions_
        private XsdTypeDecimal outstandingNumberOfOptions_;
        public XsdTypeDecimal OutstandingNumberOfOptions_
        {
            get
            {
                if (this.outstandingNumberOfOptions_ != null)
                {
                    return this.outstandingNumberOfOptions_; 
                }
                else if (this.outstandingNumberOfOptionsIDRef_ != null)
                {
                    outstandingNumberOfOptions_ = IDManager.getID(outstandingNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.outstandingNumberOfOptions_; 
                }
                else
                {
                      return this.outstandingNumberOfOptions_; 
                }
            }
            set
            {
                if (this.outstandingNumberOfOptions_ != value)
                {
                    this.outstandingNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNumberOfOptionsIDRef_ { get; set; }
        #region ChangeInNumberOfUnits_
        private XsdTypeDecimal changeInNumberOfUnits_;
        public XsdTypeDecimal ChangeInNumberOfUnits_
        {
            get
            {
                if (this.changeInNumberOfUnits_ != null)
                {
                    return this.changeInNumberOfUnits_; 
                }
                else if (this.changeInNumberOfUnitsIDRef_ != null)
                {
                    changeInNumberOfUnits_ = IDManager.getID(changeInNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.changeInNumberOfUnits_; 
                }
                else
                {
                      return this.changeInNumberOfUnits_; 
                }
            }
            set
            {
                if (this.changeInNumberOfUnits_ != value)
                {
                    this.changeInNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string changeInNumberOfUnitsIDRef_ { get; set; }
        #region OutstandingNumberOfUnits_
        private XsdTypeDecimal outstandingNumberOfUnits_;
        public XsdTypeDecimal OutstandingNumberOfUnits_
        {
            get
            {
                if (this.outstandingNumberOfUnits_ != null)
                {
                    return this.outstandingNumberOfUnits_; 
                }
                else if (this.outstandingNumberOfUnitsIDRef_ != null)
                {
                    outstandingNumberOfUnits_ = IDManager.getID(outstandingNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.outstandingNumberOfUnits_; 
                }
                else
                {
                      return this.outstandingNumberOfUnits_; 
                }
            }
            set
            {
                if (this.outstandingNumberOfUnits_ != value)
                {
                    this.outstandingNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNumberOfUnitsIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

