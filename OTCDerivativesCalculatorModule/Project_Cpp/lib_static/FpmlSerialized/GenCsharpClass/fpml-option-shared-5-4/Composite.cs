using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Composite
    {
        public Composite(XmlNode xmlNode)
        {
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList relativeDateNodeList = xmlNode.SelectNodes("relativeDate");
            if (relativeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativeDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(relativeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativeDate = new RelativeDateOffset(item);
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
        
    
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region RelativeDate
        private RelativeDateOffset relativeDate;
        public RelativeDateOffset RelativeDate
        {
            get
            {
                if (this.relativeDate != null)
                {
                    return this.relativeDate; 
                }
                else if (this.relativeDateIDRef != null)
                {
                    relativeDate = IDManager.getID(relativeDateIDRef) as RelativeDateOffset;
                    return this.relativeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativeDate != value)
                {
                    this.relativeDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
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

