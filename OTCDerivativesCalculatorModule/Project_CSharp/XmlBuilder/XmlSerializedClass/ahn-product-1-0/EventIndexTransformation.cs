using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventIndexTransformation : ISerialized
    {
        public EventIndexTransformation(XmlNode xmlNode)
        {
            XmlNodeList indexCalculationNodeList = xmlNode.SelectNodes("indexCalculation");
            
            if (indexCalculationNodeList != null)
            {
                this.indexCalculation_ = new List<IndexCalculation>();
                foreach (XmlNode item in indexCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            indexCalculationIDRef_ = item.Attributes["id"].Value;
                            indexCalculation_.Add(new IndexCalculation(item));
                            IDManager.SetID(indexCalculationIDRef_, indexCalculation_[indexCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            indexCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        indexCalculation_.Add(new IndexCalculation(item));
                        }
                    }
                    else
                    {
                        indexCalculation_.Add(new IndexCalculation(item));
                    }
                }
            }
            
        
        }
        
    
        #region IndexCalculation_
        private List<IndexCalculation> indexCalculation_;
        public List<IndexCalculation> IndexCalculation_
        {
            get
            {
                if (this.indexCalculation_ != null)
                {
                    return this.indexCalculation_; 
                }
                else if (this.indexCalculationIDRef_ != null)
                {
                    return this.indexCalculation_; 
                }
                else
                {
                      return this.indexCalculation_; 
                }
            }
            set
            {
                if (this.indexCalculation_ != value)
                {
                    this.indexCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string indexCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

