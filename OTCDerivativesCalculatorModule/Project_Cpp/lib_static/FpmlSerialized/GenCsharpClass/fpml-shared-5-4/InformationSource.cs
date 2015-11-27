using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InformationSource
    {
        public InformationSource(XmlNode xmlNode)
        {
            XmlNodeList rateSourceNodeList = xmlNode.SelectNodes("rateSource");
            if (rateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateSourceIDRef = item.Attributes["id"].Name;
                        InformationProvider ob = InformationProvider();
                        IDManager.SetID(rateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateSource = new InformationProvider(item);
                    }
                }
            }
            
        
            XmlNodeList rateSourcePageNodeList = xmlNode.SelectNodes("rateSourcePage");
            if (rateSourcePageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateSourcePageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateSourcePageIDRef = item.Attributes["id"].Name;
                        RateSourcePage ob = RateSourcePage();
                        IDManager.SetID(rateSourcePageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateSourcePageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateSourcePage = new RateSourcePage(item);
                    }
                }
            }
            
        
            XmlNodeList rateSourcePageHeadingNodeList = xmlNode.SelectNodes("rateSourcePageHeading");
            if (rateSourcePageHeadingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateSourcePageHeadingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateSourcePageHeadingIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(rateSourcePageHeadingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateSourcePageHeadingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateSourcePageHeading = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region RateSource
        private InformationProvider rateSource;
        public InformationProvider RateSource
        {
            get
            {
                if (this.rateSource != null)
                {
                    return this.rateSource; 
                }
                else if (this.rateSourceIDRef != null)
                {
                    rateSource = IDManager.getID(rateSourceIDRef) as InformationProvider;
                    return this.rateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateSource != value)
                {
                    this.rateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationProviderIDRef { get; set; }
        #region RateSourcePage
        private RateSourcePage rateSourcePage;
        public RateSourcePage RateSourcePage
        {
            get
            {
                if (this.rateSourcePage != null)
                {
                    return this.rateSourcePage; 
                }
                else if (this.rateSourcePageIDRef != null)
                {
                    rateSourcePage = IDManager.getID(rateSourcePageIDRef) as RateSourcePage;
                    return this.rateSourcePage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateSourcePage != value)
                {
                    this.rateSourcePage = value;
                }
            }
        }
        #endregion
        
        public string RateSourcePageIDRef { get; set; }
        #region RateSourcePageHeading
        private XsdTypeString rateSourcePageHeading;
        public XsdTypeString RateSourcePageHeading
        {
            get
            {
                if (this.rateSourcePageHeading != null)
                {
                    return this.rateSourcePageHeading; 
                }
                else if (this.rateSourcePageHeadingIDRef != null)
                {
                    rateSourcePageHeading = IDManager.getID(rateSourcePageHeadingIDRef) as XsdTypeString;
                    return this.rateSourcePageHeading; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateSourcePageHeading != value)
                {
                    this.rateSourcePageHeading = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

