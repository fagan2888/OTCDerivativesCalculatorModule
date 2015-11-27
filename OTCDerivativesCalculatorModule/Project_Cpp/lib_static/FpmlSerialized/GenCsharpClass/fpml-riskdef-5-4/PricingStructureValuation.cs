using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingStructureValuation
    {
        public PricingStructureValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList baseDateNodeList = xmlNode.SelectNodes("baseDate");
            if (baseDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(baseDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList spotDateNodeList = xmlNode.SelectNodes("spotDate");
            if (spotDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(spotDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList inputDataDateNodeList = xmlNode.SelectNodes("inputDataDate");
            if (inputDataDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inputDataDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inputDataDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(inputDataDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inputDataDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inputDataDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList endDateNodeList = xmlNode.SelectNodes("endDate");
            if (endDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(endDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList buildDateTimeNodeList = xmlNode.SelectNodes("buildDateTime");
            if (buildDateTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buildDateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buildDateTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(buildDateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buildDateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buildDateTime = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region BaseDate
        private IdentifiedDate baseDate;
        public IdentifiedDate BaseDate
        {
            get
            {
                if (this.baseDate != null)
                {
                    return this.baseDate; 
                }
                else if (this.baseDateIDRef != null)
                {
                    baseDate = IDManager.getID(baseDateIDRef) as IdentifiedDate;
                    return this.baseDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseDate != value)
                {
                    this.baseDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region SpotDate
        private IdentifiedDate spotDate;
        public IdentifiedDate SpotDate
        {
            get
            {
                if (this.spotDate != null)
                {
                    return this.spotDate; 
                }
                else if (this.spotDateIDRef != null)
                {
                    spotDate = IDManager.getID(spotDateIDRef) as IdentifiedDate;
                    return this.spotDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotDate != value)
                {
                    this.spotDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region InputDataDate
        private IdentifiedDate inputDataDate;
        public IdentifiedDate InputDataDate
        {
            get
            {
                if (this.inputDataDate != null)
                {
                    return this.inputDataDate; 
                }
                else if (this.inputDataDateIDRef != null)
                {
                    inputDataDate = IDManager.getID(inputDataDateIDRef) as IdentifiedDate;
                    return this.inputDataDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inputDataDate != value)
                {
                    this.inputDataDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region EndDate
        private IdentifiedDate endDate;
        public IdentifiedDate EndDate
        {
            get
            {
                if (this.endDate != null)
                {
                    return this.endDate; 
                }
                else if (this.endDateIDRef != null)
                {
                    endDate = IDManager.getID(endDateIDRef) as IdentifiedDate;
                    return this.endDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endDate != value)
                {
                    this.endDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region BuildDateTime
        private XsdTypeDateTime buildDateTime;
        public XsdTypeDateTime BuildDateTime
        {
            get
            {
                if (this.buildDateTime != null)
                {
                    return this.buildDateTime; 
                }
                else if (this.buildDateTimeIDRef != null)
                {
                    buildDateTime = IDManager.getID(buildDateTimeIDRef) as XsdTypeDateTime;
                    return this.buildDateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buildDateTime != value)
                {
                    this.buildDateTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        
    
        
    
    }
    
}

