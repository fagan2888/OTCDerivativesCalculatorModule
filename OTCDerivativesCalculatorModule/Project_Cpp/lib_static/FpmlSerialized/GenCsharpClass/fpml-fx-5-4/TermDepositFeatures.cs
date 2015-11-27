using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TermDepositFeatures
    {
        public TermDepositFeatures(XmlNode xmlNode)
        {
            XmlNodeList dualCurrencyNodeList = xmlNode.SelectNodes("dualCurrency");
            if (dualCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dualCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dualCurrencyIDRef = item.Attributes["id"].Name;
                        DualCurrencyFeature ob = DualCurrencyFeature();
                        IDManager.SetID(dualCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dualCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dualCurrency = new DualCurrencyFeature(item);
                    }
                }
            }
            
        
        }
        
    
        #region DualCurrency
        private DualCurrencyFeature dualCurrency;
        public DualCurrencyFeature DualCurrency
        {
            get
            {
                if (this.dualCurrency != null)
                {
                    return this.dualCurrency; 
                }
                else if (this.dualCurrencyIDRef != null)
                {
                    dualCurrency = IDManager.getID(dualCurrencyIDRef) as DualCurrencyFeature;
                    return this.dualCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dualCurrency != value)
                {
                    this.dualCurrency = value;
                }
            }
        }
        #endregion
        
        public string DualCurrencyFeatureIDRef { get; set; }
        
    
        
    
    }
    
}

