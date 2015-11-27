using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxMultipleExercise
    {
        public FxMultipleExercise(XmlNode xmlNode)
        {
            XmlNodeList minimumNotionalAmountNodeList = xmlNode.SelectNodes("minimumNotionalAmount");
            if (minimumNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumNotionalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(minimumNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumNotionalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList maximumNotionalAmountNodeList = xmlNode.SelectNodes("maximumNotionalAmount");
            if (maximumNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumNotionalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(maximumNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumNotionalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region MinimumNotionalAmount
        private NonNegativeMoney minimumNotionalAmount;
        public NonNegativeMoney MinimumNotionalAmount
        {
            get
            {
                if (this.minimumNotionalAmount != null)
                {
                    return this.minimumNotionalAmount; 
                }
                else if (this.minimumNotionalAmountIDRef != null)
                {
                    minimumNotionalAmount = IDManager.getID(minimumNotionalAmountIDRef) as NonNegativeMoney;
                    return this.minimumNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumNotionalAmount != value)
                {
                    this.minimumNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region MaximumNotionalAmount
        private NonNegativeMoney maximumNotionalAmount;
        public NonNegativeMoney MaximumNotionalAmount
        {
            get
            {
                if (this.maximumNotionalAmount != null)
                {
                    return this.maximumNotionalAmount; 
                }
                else if (this.maximumNotionalAmountIDRef != null)
                {
                    maximumNotionalAmount = IDManager.getID(maximumNotionalAmountIDRef) as NonNegativeMoney;
                    return this.maximumNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumNotionalAmount != value)
                {
                    this.maximumNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        
    
        
    
    }
    
}

