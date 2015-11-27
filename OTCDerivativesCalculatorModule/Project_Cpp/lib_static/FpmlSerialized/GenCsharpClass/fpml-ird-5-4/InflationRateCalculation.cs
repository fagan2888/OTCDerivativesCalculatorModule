using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InflationRateCalculation
    {
        public InflationRateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList inflationLagNodeList = xmlNode.SelectNodes("inflationLag");
            if (inflationLagNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inflationLagNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inflationLagIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(inflationLagIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inflationLagIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inflationLag = new Offset(item);
                    }
                }
            }
            
        
            XmlNodeList indexSourceNodeList = xmlNode.SelectNodes("indexSource");
            if (indexSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexSourceIDRef = item.Attributes["id"].Name;
                        RateSourcePage ob = RateSourcePage();
                        IDManager.SetID(indexSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexSource = new RateSourcePage(item);
                    }
                }
            }
            
        
            XmlNodeList mainPublicationNodeList = xmlNode.SelectNodes("mainPublication");
            if (mainPublicationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mainPublicationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mainPublicationIDRef = item.Attributes["id"].Name;
                        MainPublication ob = MainPublication();
                        IDManager.SetID(mainPublicationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mainPublicationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mainPublication = new MainPublication(item);
                    }
                }
            }
            
        
            XmlNodeList interpolationMethodNodeList = xmlNode.SelectNodes("interpolationMethod");
            if (interpolationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interpolationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef = item.Attributes["id"].Name;
                        InterpolationMethod ob = InterpolationMethod();
                        IDManager.SetID(interpolationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interpolationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interpolationMethod = new InterpolationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList initialIndexLevelNodeList = xmlNode.SelectNodes("initialIndexLevel");
            if (initialIndexLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialIndexLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialIndexLevelIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialIndexLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialIndexLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialIndexLevel = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fallbackBondApplicableNodeList = xmlNode.SelectNodes("fallbackBondApplicable");
            if (fallbackBondApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackBondApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackBondApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fallbackBondApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackBondApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallbackBondApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region InflationLag
        private Offset inflationLag;
        public Offset InflationLag
        {
            get
            {
                if (this.inflationLag != null)
                {
                    return this.inflationLag; 
                }
                else if (this.inflationLagIDRef != null)
                {
                    inflationLag = IDManager.getID(inflationLagIDRef) as Offset;
                    return this.inflationLag; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inflationLag != value)
                {
                    this.inflationLag = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        #region IndexSource
        private RateSourcePage indexSource;
        public RateSourcePage IndexSource
        {
            get
            {
                if (this.indexSource != null)
                {
                    return this.indexSource; 
                }
                else if (this.indexSourceIDRef != null)
                {
                    indexSource = IDManager.getID(indexSourceIDRef) as RateSourcePage;
                    return this.indexSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexSource != value)
                {
                    this.indexSource = value;
                }
            }
        }
        #endregion
        
        public string RateSourcePageIDRef { get; set; }
        #region MainPublication
        private MainPublication mainPublication;
        public MainPublication MainPublication
        {
            get
            {
                if (this.mainPublication != null)
                {
                    return this.mainPublication; 
                }
                else if (this.mainPublicationIDRef != null)
                {
                    mainPublication = IDManager.getID(mainPublicationIDRef) as MainPublication;
                    return this.mainPublication; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mainPublication != value)
                {
                    this.mainPublication = value;
                }
            }
        }
        #endregion
        
        public string MainPublicationIDRef { get; set; }
        #region InterpolationMethod
        private InterpolationMethod interpolationMethod;
        public InterpolationMethod InterpolationMethod
        {
            get
            {
                if (this.interpolationMethod != null)
                {
                    return this.interpolationMethod; 
                }
                else if (this.interpolationMethodIDRef != null)
                {
                    interpolationMethod = IDManager.getID(interpolationMethodIDRef) as InterpolationMethod;
                    return this.interpolationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interpolationMethod != value)
                {
                    this.interpolationMethod = value;
                }
            }
        }
        #endregion
        
        public string InterpolationMethodIDRef { get; set; }
        #region InitialIndexLevel
        private XsdTypeDecimal initialIndexLevel;
        public XsdTypeDecimal InitialIndexLevel
        {
            get
            {
                if (this.initialIndexLevel != null)
                {
                    return this.initialIndexLevel; 
                }
                else if (this.initialIndexLevelIDRef != null)
                {
                    initialIndexLevel = IDManager.getID(initialIndexLevelIDRef) as XsdTypeDecimal;
                    return this.initialIndexLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialIndexLevel != value)
                {
                    this.initialIndexLevel = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FallbackBondApplicable
        private XsdTypeBoolean fallbackBondApplicable;
        public XsdTypeBoolean FallbackBondApplicable
        {
            get
            {
                if (this.fallbackBondApplicable != null)
                {
                    return this.fallbackBondApplicable; 
                }
                else if (this.fallbackBondApplicableIDRef != null)
                {
                    fallbackBondApplicable = IDManager.getID(fallbackBondApplicableIDRef) as XsdTypeBoolean;
                    return this.fallbackBondApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackBondApplicable != value)
                {
                    this.fallbackBondApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

