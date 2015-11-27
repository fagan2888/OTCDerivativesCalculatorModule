using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendLeg
    {
        public DividendLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList declaredCashDividendPercentageNodeList = xmlNode.SelectNodes("declaredCashDividendPercentage");
            if (declaredCashDividendPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in declaredCashDividendPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        declaredCashDividendPercentageIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(declaredCashDividendPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        declaredCashDividendPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        declaredCashDividendPercentage = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList declaredCashEquivalentDividendPercentageNodeList = xmlNode.SelectNodes("declaredCashEquivalentDividendPercentage");
            if (declaredCashEquivalentDividendPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in declaredCashEquivalentDividendPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        declaredCashEquivalentDividendPercentageIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(declaredCashEquivalentDividendPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        declaredCashEquivalentDividendPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        declaredCashEquivalentDividendPercentage = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPeriodNodeList = xmlNode.SelectNodes("dividendPeriod");
            
            foreach (XmlNode item in dividendPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPeriodIDRef = item.Attributes["id"].Name;
                        List<DividendPeriodPayment> ob = new List<DividendPeriodPayment>();
                        ob.Add(new DividendPeriodPayment(item));
                        IDManager.SetID(dividendPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dividendPeriod.Add(new DividendPeriodPayment(item));
                    }
                }
            }
            
        
            XmlNodeList specialDividendsNodeList = xmlNode.SelectNodes("specialDividends");
            if (specialDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specialDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specialDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(specialDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specialDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specialDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList materialDividendNodeList = xmlNode.SelectNodes("materialDividend");
            if (materialDividendNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in materialDividendNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        materialDividendIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(materialDividendIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        materialDividendIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        materialDividend = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region DeclaredCashDividendPercentage
        private NonNegativeDecimal declaredCashDividendPercentage;
        public NonNegativeDecimal DeclaredCashDividendPercentage
        {
            get
            {
                if (this.declaredCashDividendPercentage != null)
                {
                    return this.declaredCashDividendPercentage; 
                }
                else if (this.declaredCashDividendPercentageIDRef != null)
                {
                    declaredCashDividendPercentage = IDManager.getID(declaredCashDividendPercentageIDRef) as NonNegativeDecimal;
                    return this.declaredCashDividendPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.declaredCashDividendPercentage != value)
                {
                    this.declaredCashDividendPercentage = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region DeclaredCashEquivalentDividendPercentage
        private NonNegativeDecimal declaredCashEquivalentDividendPercentage;
        public NonNegativeDecimal DeclaredCashEquivalentDividendPercentage
        {
            get
            {
                if (this.declaredCashEquivalentDividendPercentage != null)
                {
                    return this.declaredCashEquivalentDividendPercentage; 
                }
                else if (this.declaredCashEquivalentDividendPercentageIDRef != null)
                {
                    declaredCashEquivalentDividendPercentage = IDManager.getID(declaredCashEquivalentDividendPercentageIDRef) as NonNegativeDecimal;
                    return this.declaredCashEquivalentDividendPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.declaredCashEquivalentDividendPercentage != value)
                {
                    this.declaredCashEquivalentDividendPercentage = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region DividendPeriod
        private List<DividendPeriodPayment> dividendPeriod;
        public List<DividendPeriodPayment> DividendPeriod
        {
            get
            {
                if (this.dividendPeriod != null)
                {
                    return this.dividendPeriod; 
                }
                else if (this.dividendPeriodIDRef != null)
                {
                    dividendPeriod = IDManager.getID(dividendPeriodIDRef) as List<DividendPeriodPayment>;
                    return this.dividendPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPeriod != value)
                {
                    this.dividendPeriod = value;
                }
            }
        }
        #endregion
        
        public string DividendPeriodPaymentIDRef { get; set; }
        #region SpecialDividends
        private XsdTypeBoolean specialDividends;
        public XsdTypeBoolean SpecialDividends
        {
            get
            {
                if (this.specialDividends != null)
                {
                    return this.specialDividends; 
                }
                else if (this.specialDividendsIDRef != null)
                {
                    specialDividends = IDManager.getID(specialDividendsIDRef) as XsdTypeBoolean;
                    return this.specialDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specialDividends != value)
                {
                    this.specialDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MaterialDividend
        private XsdTypeBoolean materialDividend;
        public XsdTypeBoolean MaterialDividend
        {
            get
            {
                if (this.materialDividend != null)
                {
                    return this.materialDividend; 
                }
                else if (this.materialDividendIDRef != null)
                {
                    materialDividend = IDManager.getID(materialDividendIDRef) as XsdTypeBoolean;
                    return this.materialDividend; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.materialDividend != value)
                {
                    this.materialDividend = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

