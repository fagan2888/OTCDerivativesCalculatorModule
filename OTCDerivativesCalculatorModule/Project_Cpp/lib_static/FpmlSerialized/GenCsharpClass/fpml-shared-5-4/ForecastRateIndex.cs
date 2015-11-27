using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ForecastRateIndex
    {
        public ForecastRateIndex(XmlNode xmlNode)
        {
            XmlNodeList floatingRateIndexNodeList = xmlNode.SelectNodes("floatingRateIndex");
            if (floatingRateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef = item.Attributes["id"].Name;
                        FloatingRateIndex ob = FloatingRateIndex();
                        IDManager.SetID(floatingRateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateIndex = new FloatingRateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList indexTenorNodeList = xmlNode.SelectNodes("indexTenor");
            if (indexTenorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexTenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTenorIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(indexTenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexTenor = new Period(item);
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRateIndex
        private FloatingRateIndex floatingRateIndex;
        public FloatingRateIndex FloatingRateIndex
        {
            get
            {
                if (this.floatingRateIndex != null)
                {
                    return this.floatingRateIndex; 
                }
                else if (this.floatingRateIndexIDRef != null)
                {
                    floatingRateIndex = IDManager.getID(floatingRateIndexIDRef) as FloatingRateIndex;
                    return this.floatingRateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateIndex != value)
                {
                    this.floatingRateIndex = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIndexIDRef { get; set; }
        #region IndexTenor
        private Period indexTenor;
        public Period IndexTenor
        {
            get
            {
                if (this.indexTenor != null)
                {
                    return this.indexTenor; 
                }
                else if (this.indexTenorIDRef != null)
                {
                    indexTenor = IDManager.getID(indexTenorIDRef) as Period;
                    return this.indexTenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexTenor != value)
                {
                    this.indexTenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        
    
        
    
    }
    
}

