using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class Obligations : ISerialized
    {
        public Obligations() { }
        public Obligations(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode categoryNode = xmlNode.SelectSingleNode("category");
            
            if (categoryNode != null)
            {
                if (categoryNode.Attributes["href"] != null || categoryNode.Attributes["id"] != null) 
                {
                    if (categoryNode.Attributes["id"] != null) 
                    {
                        categoryIDRef_ = categoryNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(categoryNode);
                        IDManager.SetID(categoryIDRef_, ob);
                    }
                    else if (categoryNode.Attributes["href"] != null)
                    {
                        categoryIDRef_ = categoryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        category_ = new XsdTypeToken(categoryNode);
                    }
                }
                else
                {
                    category_ = new XsdTypeToken(categoryNode);
                }
            }
            
        
            XmlNode notSubordinatedNode = xmlNode.SelectSingleNode("notSubordinated");
            
            if (notSubordinatedNode != null)
            {
                if (notSubordinatedNode.Attributes["href"] != null || notSubordinatedNode.Attributes["id"] != null) 
                {
                    if (notSubordinatedNode.Attributes["id"] != null) 
                    {
                        notSubordinatedIDRef_ = notSubordinatedNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notSubordinatedNode);
                        IDManager.SetID(notSubordinatedIDRef_, ob);
                    }
                    else if (notSubordinatedNode.Attributes["href"] != null)
                    {
                        notSubordinatedIDRef_ = notSubordinatedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notSubordinated_ = new XsdTypeToken(notSubordinatedNode);
                    }
                }
                else
                {
                    notSubordinated_ = new XsdTypeToken(notSubordinatedNode);
                }
            }
            
        
            XmlNode notDomesticCurrencyNode = xmlNode.SelectSingleNode("notDomesticCurrency");
            
            if (notDomesticCurrencyNode != null)
            {
                if (notDomesticCurrencyNode.Attributes["href"] != null || notDomesticCurrencyNode.Attributes["id"] != null) 
                {
                    if (notDomesticCurrencyNode.Attributes["id"] != null) 
                    {
                        notDomesticCurrencyIDRef_ = notDomesticCurrencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notDomesticCurrencyNode);
                        IDManager.SetID(notDomesticCurrencyIDRef_, ob);
                    }
                    else if (notDomesticCurrencyNode.Attributes["href"] != null)
                    {
                        notDomesticCurrencyIDRef_ = notDomesticCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticCurrency_ = new XsdTypeToken(notDomesticCurrencyNode);
                    }
                }
                else
                {
                    notDomesticCurrency_ = new XsdTypeToken(notDomesticCurrencyNode);
                }
            }
            
        
            XmlNode notDomesticLawNode = xmlNode.SelectSingleNode("notDomesticLaw");
            
            if (notDomesticLawNode != null)
            {
                if (notDomesticLawNode.Attributes["href"] != null || notDomesticLawNode.Attributes["id"] != null) 
                {
                    if (notDomesticLawNode.Attributes["id"] != null) 
                    {
                        notDomesticLawIDRef_ = notDomesticLawNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notDomesticLawNode);
                        IDManager.SetID(notDomesticLawIDRef_, ob);
                    }
                    else if (notDomesticLawNode.Attributes["href"] != null)
                    {
                        notDomesticLawIDRef_ = notDomesticLawNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticLaw_ = new XsdTypeToken(notDomesticLawNode);
                    }
                }
                else
                {
                    notDomesticLaw_ = new XsdTypeToken(notDomesticLawNode);
                }
            }
            
        
            XmlNode notDomesticIssuanceNode = xmlNode.SelectSingleNode("notDomesticIssuance");
            
            if (notDomesticIssuanceNode != null)
            {
                if (notDomesticIssuanceNode.Attributes["href"] != null || notDomesticIssuanceNode.Attributes["id"] != null) 
                {
                    if (notDomesticIssuanceNode.Attributes["id"] != null) 
                    {
                        notDomesticIssuanceIDRef_ = notDomesticIssuanceNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notDomesticIssuanceNode);
                        IDManager.SetID(notDomesticIssuanceIDRef_, ob);
                    }
                    else if (notDomesticIssuanceNode.Attributes["href"] != null)
                    {
                        notDomesticIssuanceIDRef_ = notDomesticIssuanceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticIssuance_ = new XsdTypeToken(notDomesticIssuanceNode);
                    }
                }
                else
                {
                    notDomesticIssuance_ = new XsdTypeToken(notDomesticIssuanceNode);
                }
            }
            
        
        }
        
    
        #region Category_
        private XsdTypeToken category_;
        public XsdTypeToken Category_
        {
            get
            {
                if (this.category_ != null)
                {
                    return this.category_; 
                }
                else if (this.categoryIDRef_ != null)
                {
                    category_ = IDManager.getID(categoryIDRef_) as XsdTypeToken;
                    return this.category_; 
                }
                else
                {
                      return this.category_; 
                }
            }
            set
            {
                if (this.category_ != value)
                {
                    this.category_ = value;
                }
            }
        }
        #endregion
        
        public string categoryIDRef_ { get; set; }
        #region NotSubordinated_
        private XsdTypeToken notSubordinated_;
        public XsdTypeToken NotSubordinated_
        {
            get
            {
                if (this.notSubordinated_ != null)
                {
                    return this.notSubordinated_; 
                }
                else if (this.notSubordinatedIDRef_ != null)
                {
                    notSubordinated_ = IDManager.getID(notSubordinatedIDRef_) as XsdTypeToken;
                    return this.notSubordinated_; 
                }
                else
                {
                      return this.notSubordinated_; 
                }
            }
            set
            {
                if (this.notSubordinated_ != value)
                {
                    this.notSubordinated_ = value;
                }
            }
        }
        #endregion
        
        public string notSubordinatedIDRef_ { get; set; }
        #region NotDomesticCurrency_
        private XsdTypeToken notDomesticCurrency_;
        public XsdTypeToken NotDomesticCurrency_
        {
            get
            {
                if (this.notDomesticCurrency_ != null)
                {
                    return this.notDomesticCurrency_; 
                }
                else if (this.notDomesticCurrencyIDRef_ != null)
                {
                    notDomesticCurrency_ = IDManager.getID(notDomesticCurrencyIDRef_) as XsdTypeToken;
                    return this.notDomesticCurrency_; 
                }
                else
                {
                      return this.notDomesticCurrency_; 
                }
            }
            set
            {
                if (this.notDomesticCurrency_ != value)
                {
                    this.notDomesticCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticCurrencyIDRef_ { get; set; }
        #region NotDomesticLaw_
        private XsdTypeToken notDomesticLaw_;
        public XsdTypeToken NotDomesticLaw_
        {
            get
            {
                if (this.notDomesticLaw_ != null)
                {
                    return this.notDomesticLaw_; 
                }
                else if (this.notDomesticLawIDRef_ != null)
                {
                    notDomesticLaw_ = IDManager.getID(notDomesticLawIDRef_) as XsdTypeToken;
                    return this.notDomesticLaw_; 
                }
                else
                {
                      return this.notDomesticLaw_; 
                }
            }
            set
            {
                if (this.notDomesticLaw_ != value)
                {
                    this.notDomesticLaw_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticLawIDRef_ { get; set; }
        #region NotDomesticIssuance_
        private XsdTypeToken notDomesticIssuance_;
        public XsdTypeToken NotDomesticIssuance_
        {
            get
            {
                if (this.notDomesticIssuance_ != null)
                {
                    return this.notDomesticIssuance_; 
                }
                else if (this.notDomesticIssuanceIDRef_ != null)
                {
                    notDomesticIssuance_ = IDManager.getID(notDomesticIssuanceIDRef_) as XsdTypeToken;
                    return this.notDomesticIssuance_; 
                }
                else
                {
                      return this.notDomesticIssuance_; 
                }
            }
            set
            {
                if (this.notDomesticIssuance_ != value)
                {
                    this.notDomesticIssuance_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticIssuanceIDRef_ { get; set; }
        
    
        
    
    }
    
}

