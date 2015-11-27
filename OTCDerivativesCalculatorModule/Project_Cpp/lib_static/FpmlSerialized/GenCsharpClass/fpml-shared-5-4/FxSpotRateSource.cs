using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxSpotRateSource
    {
        public FxSpotRateSource(XmlNode xmlNode)
        {
            XmlNodeList primaryRateSourceNodeList = xmlNode.SelectNodes("primaryRateSource");
            if (primaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(primaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList secondaryRateSourceNodeList = xmlNode.SelectNodes("secondaryRateSource");
            if (secondaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in secondaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(secondaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        secondaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        secondaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList fixingTimeNodeList = xmlNode.SelectNodes("fixingTime");
            if (fixingTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(fixingTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region PrimaryRateSource
        private InformationSource primaryRateSource;
        public InformationSource PrimaryRateSource
        {
            get
            {
                if (this.primaryRateSource != null)
                {
                    return this.primaryRateSource; 
                }
                else if (this.primaryRateSourceIDRef != null)
                {
                    primaryRateSource = IDManager.getID(primaryRateSourceIDRef) as InformationSource;
                    return this.primaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryRateSource != value)
                {
                    this.primaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region SecondaryRateSource
        private InformationSource secondaryRateSource;
        public InformationSource SecondaryRateSource
        {
            get
            {
                if (this.secondaryRateSource != null)
                {
                    return this.secondaryRateSource; 
                }
                else if (this.secondaryRateSourceIDRef != null)
                {
                    secondaryRateSource = IDManager.getID(secondaryRateSourceIDRef) as InformationSource;
                    return this.secondaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.secondaryRateSource != value)
                {
                    this.secondaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region FixingTime
        private BusinessCenterTime fixingTime;
        public BusinessCenterTime FixingTime
        {
            get
            {
                if (this.fixingTime != null)
                {
                    return this.fixingTime; 
                }
                else if (this.fixingTimeIDRef != null)
                {
                    fixingTime = IDManager.getID(fixingTimeIDRef) as BusinessCenterTime;
                    return this.fixingTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingTime != value)
                {
                    this.fixingTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        
    
        
    
    }
    
}

