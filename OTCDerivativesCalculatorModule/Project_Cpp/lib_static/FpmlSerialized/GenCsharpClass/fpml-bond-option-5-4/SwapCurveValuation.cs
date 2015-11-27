using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SwapCurveValuation
    {
        public SwapCurveValuation(XmlNode xmlNode)
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
            
        
            XmlNodeList spreadNodeList = xmlNode.SelectNodes("spread");
            if (spreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spread = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList sideNodeList = xmlNode.SelectNodes("side");
            if (sideNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sideNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sideIDRef = item.Attributes["id"].Name;
                        QuotationSideEnum ob = QuotationSideEnum();
                        IDManager.SetID(sideIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sideIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        side = new QuotationSideEnum(item);
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
        #region Spread
        private XsdTypeDecimal spread;
        public XsdTypeDecimal Spread
        {
            get
            {
                if (this.spread != null)
                {
                    return this.spread; 
                }
                else if (this.spreadIDRef != null)
                {
                    spread = IDManager.getID(spreadIDRef) as XsdTypeDecimal;
                    return this.spread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spread != value)
                {
                    this.spread = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Side
        private QuotationSideEnum side;
        public QuotationSideEnum Side
        {
            get
            {
                if (this.side != null)
                {
                    return this.side; 
                }
                else if (this.sideIDRef != null)
                {
                    side = IDManager.getID(sideIDRef) as QuotationSideEnum;
                    return this.side; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.side != value)
                {
                    this.side = value;
                }
            }
        }
        #endregion
        
        public string QuotationSideEnumIDRef { get; set; }
        
    
        
    
    }
    
}

