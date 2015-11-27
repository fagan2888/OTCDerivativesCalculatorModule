using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LegIdentifier
    {
        public LegIdentifier(XmlNode xmlNode)
        {
            XmlNodeList legIdNodeList = xmlNode.SelectNodes("legId");
            if (legIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in legIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        legIdIDRef = item.Attributes["id"].Name;
                        LegId ob = LegId();
                        IDManager.SetID(legIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        legIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        legId = new LegId(item);
                    }
                }
            }
            
        
            XmlNodeList versionNodeList = xmlNode.SelectNodes("version");
            if (versionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in versionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(versionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        version = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region LegId
        private LegId legId;
        public LegId LegId
        {
            get
            {
                if (this.legId != null)
                {
                    return this.legId; 
                }
                else if (this.legIdIDRef != null)
                {
                    legId = IDManager.getID(legIdIDRef) as LegId;
                    return this.legId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.legId != value)
                {
                    this.legId = value;
                }
            }
        }
        #endregion
        
        public string LegIdIDRef { get; set; }
        #region Version
        private XsdTypeNonNegativeInteger version;
        public XsdTypeNonNegativeInteger Version
        {
            get
            {
                if (this.version != null)
                {
                    return this.version; 
                }
                else if (this.versionIDRef != null)
                {
                    version = IDManager.getID(versionIDRef) as XsdTypeNonNegativeInteger;
                    return this.version; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.version != value)
                {
                    this.version = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region EffectiveDate
        private IdentifiedDate effectiveDate;
        public IdentifiedDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as IdentifiedDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}

