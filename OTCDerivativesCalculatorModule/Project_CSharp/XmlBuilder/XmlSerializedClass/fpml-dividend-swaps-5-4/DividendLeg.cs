using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendLeg : DirectionalLegUnderlyer
    {
        public DividendLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode declaredCashDividendPercentageNode = xmlNode.SelectSingleNode("declaredCashDividendPercentage");
            
            if (declaredCashDividendPercentageNode != null)
            {
                if (declaredCashDividendPercentageNode.Attributes["href"] != null || declaredCashDividendPercentageNode.Attributes["id"] != null) 
                {
                    if (declaredCashDividendPercentageNode.Attributes["id"] != null) 
                    {
                        declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                        IDManager.SetID(declaredCashDividendPercentageIDRef_, ob);
                    }
                    else if (declaredCashDividendPercentageNode.Attributes["href"] != null)
                    {
                        declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        declaredCashDividendPercentage_ = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                    }
                }
                else
                {
                    declaredCashDividendPercentage_ = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                }
            }
            
        
            XmlNode declaredCashEquivalentDividendPercentageNode = xmlNode.SelectSingleNode("declaredCashEquivalentDividendPercentage");
            
            if (declaredCashEquivalentDividendPercentageNode != null)
            {
                if (declaredCashEquivalentDividendPercentageNode.Attributes["href"] != null || declaredCashEquivalentDividendPercentageNode.Attributes["id"] != null) 
                {
                    if (declaredCashEquivalentDividendPercentageNode.Attributes["id"] != null) 
                    {
                        declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                        IDManager.SetID(declaredCashEquivalentDividendPercentageIDRef_, ob);
                    }
                    else if (declaredCashEquivalentDividendPercentageNode.Attributes["href"] != null)
                    {
                        declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        declaredCashEquivalentDividendPercentage_ = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                    }
                }
                else
                {
                    declaredCashEquivalentDividendPercentage_ = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                }
            }
            
        
            XmlNodeList dividendPeriodNodeList = xmlNode.SelectNodes("dividendPeriod");
            
            if (dividendPeriodNodeList != null)
            {
                this.dividendPeriod_ = new List<DividendPeriodPayment>();
                foreach (XmlNode item in dividendPeriodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dividendPeriodIDRef_ = item.Attributes["id"].Value;
                            dividendPeriod_.Add(new DividendPeriodPayment(item));
                            IDManager.SetID(dividendPeriodIDRef_, dividendPeriod_[dividendPeriod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dividendPeriodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dividendPeriod_.Add(new DividendPeriodPayment(item));
                        }
                    }
                    else
                    {
                        dividendPeriod_.Add(new DividendPeriodPayment(item));
                    }
                }
            }
            
        
            XmlNode specialDividendsNode = xmlNode.SelectSingleNode("specialDividends");
            
            if (specialDividendsNode != null)
            {
                if (specialDividendsNode.Attributes["href"] != null || specialDividendsNode.Attributes["id"] != null) 
                {
                    if (specialDividendsNode.Attributes["id"] != null) 
                    {
                        specialDividendsIDRef_ = specialDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(specialDividendsNode);
                        IDManager.SetID(specialDividendsIDRef_, ob);
                    }
                    else if (specialDividendsNode.Attributes["href"] != null)
                    {
                        specialDividendsIDRef_ = specialDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specialDividends_ = new XsdTypeBoolean(specialDividendsNode);
                    }
                }
                else
                {
                    specialDividends_ = new XsdTypeBoolean(specialDividendsNode);
                }
            }
            
        
            XmlNode materialDividendNode = xmlNode.SelectSingleNode("materialDividend");
            
            if (materialDividendNode != null)
            {
                if (materialDividendNode.Attributes["href"] != null || materialDividendNode.Attributes["id"] != null) 
                {
                    if (materialDividendNode.Attributes["id"] != null) 
                    {
                        materialDividendIDRef_ = materialDividendNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(materialDividendNode);
                        IDManager.SetID(materialDividendIDRef_, ob);
                    }
                    else if (materialDividendNode.Attributes["href"] != null)
                    {
                        materialDividendIDRef_ = materialDividendNode.Attributes["href"].Value;
                    }
                    else
                    {
                        materialDividend_ = new XsdTypeBoolean(materialDividendNode);
                    }
                }
                else
                {
                    materialDividend_ = new XsdTypeBoolean(materialDividendNode);
                }
            }
            
        
        }
        
    
        #region DeclaredCashDividendPercentage_
        private NonNegativeDecimal declaredCashDividendPercentage_;
        public NonNegativeDecimal DeclaredCashDividendPercentage_
        {
            get
            {
                if (this.declaredCashDividendPercentage_ != null)
                {
                    return this.declaredCashDividendPercentage_; 
                }
                else if (this.declaredCashDividendPercentageIDRef_ != null)
                {
                    declaredCashDividendPercentage_ = IDManager.getID(declaredCashDividendPercentageIDRef_) as NonNegativeDecimal;
                    return this.declaredCashDividendPercentage_; 
                }
                else
                {
                      return this.declaredCashDividendPercentage_; 
                }
            }
            set
            {
                if (this.declaredCashDividendPercentage_ != value)
                {
                    this.declaredCashDividendPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string declaredCashDividendPercentageIDRef_ { get; set; }
        #region DeclaredCashEquivalentDividendPercentage_
        private NonNegativeDecimal declaredCashEquivalentDividendPercentage_;
        public NonNegativeDecimal DeclaredCashEquivalentDividendPercentage_
        {
            get
            {
                if (this.declaredCashEquivalentDividendPercentage_ != null)
                {
                    return this.declaredCashEquivalentDividendPercentage_; 
                }
                else if (this.declaredCashEquivalentDividendPercentageIDRef_ != null)
                {
                    declaredCashEquivalentDividendPercentage_ = IDManager.getID(declaredCashEquivalentDividendPercentageIDRef_) as NonNegativeDecimal;
                    return this.declaredCashEquivalentDividendPercentage_; 
                }
                else
                {
                      return this.declaredCashEquivalentDividendPercentage_; 
                }
            }
            set
            {
                if (this.declaredCashEquivalentDividendPercentage_ != value)
                {
                    this.declaredCashEquivalentDividendPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string declaredCashEquivalentDividendPercentageIDRef_ { get; set; }
        #region DividendPeriod_
        private List<DividendPeriodPayment> dividendPeriod_;
        public List<DividendPeriodPayment> DividendPeriod_
        {
            get
            {
                if (this.dividendPeriod_ != null)
                {
                    return this.dividendPeriod_; 
                }
                else if (this.dividendPeriodIDRef_ != null)
                {
                    return this.dividendPeriod_; 
                }
                else
                {
                      return this.dividendPeriod_; 
                }
            }
            set
            {
                if (this.dividendPeriod_ != value)
                {
                    this.dividendPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPeriodIDRef_ { get; set; }
        #region SpecialDividends_
        private XsdTypeBoolean specialDividends_;
        public XsdTypeBoolean SpecialDividends_
        {
            get
            {
                if (this.specialDividends_ != null)
                {
                    return this.specialDividends_; 
                }
                else if (this.specialDividendsIDRef_ != null)
                {
                    specialDividends_ = IDManager.getID(specialDividendsIDRef_) as XsdTypeBoolean;
                    return this.specialDividends_; 
                }
                else
                {
                      return this.specialDividends_; 
                }
            }
            set
            {
                if (this.specialDividends_ != value)
                {
                    this.specialDividends_ = value;
                }
            }
        }
        #endregion
        
        public string specialDividendsIDRef_ { get; set; }
        #region MaterialDividend_
        private XsdTypeBoolean materialDividend_;
        public XsdTypeBoolean MaterialDividend_
        {
            get
            {
                if (this.materialDividend_ != null)
                {
                    return this.materialDividend_; 
                }
                else if (this.materialDividendIDRef_ != null)
                {
                    materialDividend_ = IDManager.getID(materialDividendIDRef_) as XsdTypeBoolean;
                    return this.materialDividend_; 
                }
                else
                {
                      return this.materialDividend_; 
                }
            }
            set
            {
                if (this.materialDividend_ != value)
                {
                    this.materialDividend_ = value;
                }
            }
        }
        #endregion
        
        public string materialDividendIDRef_ { get; set; }
        
    
        
    
    }
    
}

