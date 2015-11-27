using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityMultipleExercise
    {
        public CommodityMultipleExercise(XmlNode xmlNode)
        {
            XmlNodeList integralMultipleQuantityNodeList = xmlNode.SelectNodes("integralMultipleQuantity");
            if (integralMultipleQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in integralMultipleQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        integralMultipleQuantityIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantity ob = CommodityNotionalQuantity();
                        IDManager.SetID(integralMultipleQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        integralMultipleQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        integralMultipleQuantity = new CommodityNotionalQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList minimumNotionalQuantityNodeList = xmlNode.SelectNodes("minimumNotionalQuantity");
            if (minimumNotionalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumNotionalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumNotionalQuantityIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantity ob = CommodityNotionalQuantity();
                        IDManager.SetID(minimumNotionalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumNotionalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumNotionalQuantity = new CommodityNotionalQuantity(item);
                    }
                }
            }
            
        
        }
        
    
        #region IntegralMultipleQuantity
        private CommodityNotionalQuantity integralMultipleQuantity;
        public CommodityNotionalQuantity IntegralMultipleQuantity
        {
            get
            {
                if (this.integralMultipleQuantity != null)
                {
                    return this.integralMultipleQuantity; 
                }
                else if (this.integralMultipleQuantityIDRef != null)
                {
                    integralMultipleQuantity = IDManager.getID(integralMultipleQuantityIDRef) as CommodityNotionalQuantity;
                    return this.integralMultipleQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.integralMultipleQuantity != value)
                {
                    this.integralMultipleQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region MinimumNotionalQuantity
        private CommodityNotionalQuantity minimumNotionalQuantity;
        public CommodityNotionalQuantity MinimumNotionalQuantity
        {
            get
            {
                if (this.minimumNotionalQuantity != null)
                {
                    return this.minimumNotionalQuantity; 
                }
                else if (this.minimumNotionalQuantityIDRef != null)
                {
                    minimumNotionalQuantity = IDManager.getID(minimumNotionalQuantityIDRef) as CommodityNotionalQuantity;
                    return this.minimumNotionalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumNotionalQuantity != value)
                {
                    this.minimumNotionalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        
    
        
    
    }
    
}

