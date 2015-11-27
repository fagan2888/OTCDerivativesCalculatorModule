using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ForecastRateIndex : ISerialized
    {
        public ForecastRateIndex(XmlNode xmlNode)
        {
            XmlNode floatingRateIndexNode = xmlNode.SelectSingleNode("floatingRateIndex");
            
            if (floatingRateIndexNode != null)
            {
                if (floatingRateIndexNode.Attributes["href"] != null || floatingRateIndexNode.Attributes["id"] != null) 
                {
                    if (floatingRateIndexNode.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["id"].Value;
                        FloatingRateIndex ob = new FloatingRateIndex(floatingRateIndexNode);
                        IDManager.SetID(floatingRateIndexIDRef_, ob);
                    }
                    else if (floatingRateIndexNode.Attributes["href"] != null)
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                    }
                }
                else
                {
                    floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                }
            }
            
        
            XmlNode indexTenorNode = xmlNode.SelectSingleNode("indexTenor");
            
            if (indexTenorNode != null)
            {
                if (indexTenorNode.Attributes["href"] != null || indexTenorNode.Attributes["id"] != null) 
                {
                    if (indexTenorNode.Attributes["id"] != null) 
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["id"].Value;
                        Period ob = new Period(indexTenorNode);
                        IDManager.SetID(indexTenorIDRef_, ob);
                    }
                    else if (indexTenorNode.Attributes["href"] != null)
                    {
                        indexTenorIDRef_ = indexTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexTenor_ = new Period(indexTenorNode);
                    }
                }
                else
                {
                    indexTenor_ = new Period(indexTenorNode);
                }
            }
            
        
        }
        
    
        #region FloatingRateIndex_
        private FloatingRateIndex floatingRateIndex_;
        public FloatingRateIndex FloatingRateIndex_
        {
            get
            {
                if (this.floatingRateIndex_ != null)
                {
                    return this.floatingRateIndex_; 
                }
                else if (this.floatingRateIndexIDRef_ != null)
                {
                    floatingRateIndex_ = IDManager.getID(floatingRateIndexIDRef_) as FloatingRateIndex;
                    return this.floatingRateIndex_; 
                }
                else
                {
                      return this.floatingRateIndex_; 
                }
            }
            set
            {
                if (this.floatingRateIndex_ != value)
                {
                    this.floatingRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIndexIDRef_ { get; set; }
        #region IndexTenor_
        private Period indexTenor_;
        public Period IndexTenor_
        {
            get
            {
                if (this.indexTenor_ != null)
                {
                    return this.indexTenor_; 
                }
                else if (this.indexTenorIDRef_ != null)
                {
                    indexTenor_ = IDManager.getID(indexTenorIDRef_) as Period;
                    return this.indexTenor_; 
                }
                else
                {
                      return this.indexTenor_; 
                }
            }
            set
            {
                if (this.indexTenor_ != value)
                {
                    this.indexTenor_ = value;
                }
            }
        }
        #endregion
        
        public string indexTenorIDRef_ { get; set; }
        
    
        
    
    }
    
}

