using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Collateral
    {
        public Collateral(XmlNode xmlNode)
        {
            XmlNodeList independentAmountNodeList = xmlNode.SelectNodes("independentAmount");
            if (independentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in independentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        independentAmountIDRef = item.Attributes["id"].Name;
                        IndependentAmount ob = IndependentAmount();
                        IDManager.SetID(independentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        independentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        independentAmount = new IndependentAmount(item);
                    }
                }
            }
            
        
        }
        
    
        #region IndependentAmount
        private IndependentAmount independentAmount;
        public IndependentAmount IndependentAmount
        {
            get
            {
                if (this.independentAmount != null)
                {
                    return this.independentAmount; 
                }
                else if (this.independentAmountIDRef != null)
                {
                    independentAmount = IDManager.getID(independentAmountIDRef) as IndependentAmount;
                    return this.independentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.independentAmount != value)
                {
                    this.independentAmount = value;
                }
            }
        }
        #endregion
        
        public string IndependentAmountIDRef { get; set; }
        
    
        
    
    }
    
}

