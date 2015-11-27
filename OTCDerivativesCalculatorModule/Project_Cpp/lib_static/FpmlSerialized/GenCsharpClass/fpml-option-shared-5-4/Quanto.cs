using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Quanto
    {
        public Quanto(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList fxSpotRateSourceNodeList = xmlNode.SelectNodes("fxSpotRateSource");
            if (fxSpotRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxSpotRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef = item.Attributes["id"].Name;
                        FxSpotRateSource ob = FxSpotRateSource();
                        IDManager.SetID(fxSpotRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxSpotRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxSpotRateSource = new FxSpotRateSource(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region FxSpotRateSource
        private FxSpotRateSource fxSpotRateSource;
        public FxSpotRateSource FxSpotRateSource
        {
            get
            {
                if (this.fxSpotRateSource != null)
                {
                    return this.fxSpotRateSource; 
                }
                else if (this.fxSpotRateSourceIDRef != null)
                {
                    fxSpotRateSource = IDManager.getID(fxSpotRateSourceIDRef) as FxSpotRateSource;
                    return this.fxSpotRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxSpotRateSource != value)
                {
                    this.fxSpotRateSource = value;
                }
            }
        }
        #endregion
        
        public string FxSpotRateSourceIDRef { get; set; }
        
    
        
    
    }
    
}

