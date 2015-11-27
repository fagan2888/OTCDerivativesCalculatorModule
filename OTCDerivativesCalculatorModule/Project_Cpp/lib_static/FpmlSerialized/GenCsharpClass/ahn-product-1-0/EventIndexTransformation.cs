using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventIndexTransformation
    {
        public EventIndexTransformation(XmlNode xmlNode)
        {
            XmlNodeList indexCalculationNodeList = xmlNode.SelectNodes("indexCalculation");
            
            foreach (XmlNode item in indexCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexCalculationIDRef = item.Attributes["id"].Name;
                        List<IndexCalculation> ob = new List<IndexCalculation>();
                        ob.Add(new IndexCalculation(item));
                        IDManager.SetID(indexCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    indexCalculation.Add(new IndexCalculation(item));
                    }
                }
            }
            
        
        }
        
    
        #region IndexCalculation
        private List<IndexCalculation> indexCalculation;
        public List<IndexCalculation> IndexCalculation
        {
            get
            {
                if (this.indexCalculation != null)
                {
                    return this.indexCalculation; 
                }
                else if (this.indexCalculationIDRef != null)
                {
                    indexCalculation = IDManager.getID(indexCalculationIDRef) as List<IndexCalculation>;
                    return this.indexCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexCalculation != value)
                {
                    this.indexCalculation = value;
                }
            }
        }
        #endregion
        
        public string IndexCalculationIDRef { get; set; }
        
    
        
    
    }
    
}

