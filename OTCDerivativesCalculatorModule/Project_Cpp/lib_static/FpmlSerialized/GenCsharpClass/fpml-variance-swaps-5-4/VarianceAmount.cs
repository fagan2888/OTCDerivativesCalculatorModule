using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VarianceAmount
    {
        public VarianceAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList varianceNodeList = xmlNode.SelectNodes("variance");
            if (varianceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceIDRef = item.Attributes["id"].Name;
                        Variance ob = Variance();
                        IDManager.SetID(varianceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        variance = new Variance(item);
                    }
                }
            }
            
        
        }
        
    
        #region Variance
        private Variance variance;
        public Variance Variance
        {
            get
            {
                if (this.variance != null)
                {
                    return this.variance; 
                }
                else if (this.varianceIDRef != null)
                {
                    variance = IDManager.getID(varianceIDRef) as Variance;
                    return this.variance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.variance != value)
                {
                    this.variance = value;
                }
            }
        }
        #endregion
        
        public string VarianceIDRef { get; set; }
        
    
        
    
    }
    
}

