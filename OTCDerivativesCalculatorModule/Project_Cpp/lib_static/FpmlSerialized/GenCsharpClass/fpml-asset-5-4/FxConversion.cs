using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxConversion
    {
        public FxConversion(XmlNode xmlNode)
        {
            XmlNodeList amountRelativeToNodeList = xmlNode.SelectNodes("amountRelativeTo");
            if (amountRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountRelativeToIDRef = item.Attributes["id"].Name;
                        AmountReference ob = AmountReference();
                        IDManager.SetID(amountRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amountRelativeTo = new AmountReference(item);
                    }
                }
            }
            
        
            XmlNodeList fxRateNodeList = xmlNode.SelectNodes("fxRate");
            
            foreach (XmlNode item in fxRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxRateIDRef = item.Attributes["id"].Name;
                        List<FxRate> ob = new List<FxRate>();
                        ob.Add(new FxRate(item));
                        IDManager.SetID(fxRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fxRate.Add(new FxRate(item));
                    }
                }
            }
            
        
        }
        
    
        #region AmountRelativeTo
        private AmountReference amountRelativeTo;
        public AmountReference AmountRelativeTo
        {
            get
            {
                if (this.amountRelativeTo != null)
                {
                    return this.amountRelativeTo; 
                }
                else if (this.amountRelativeToIDRef != null)
                {
                    amountRelativeTo = IDManager.getID(amountRelativeToIDRef) as AmountReference;
                    return this.amountRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amountRelativeTo != value)
                {
                    this.amountRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string AmountReferenceIDRef { get; set; }
        #region FxRate
        private List<FxRate> fxRate;
        public List<FxRate> FxRate
        {
            get
            {
                if (this.fxRate != null)
                {
                    return this.fxRate; 
                }
                else if (this.fxRateIDRef != null)
                {
                    fxRate = IDManager.getID(fxRateIDRef) as List<FxRate>;
                    return this.fxRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxRate != value)
                {
                    this.fxRate = value;
                }
            }
        }
        #endregion
        
        public string FxRateIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

