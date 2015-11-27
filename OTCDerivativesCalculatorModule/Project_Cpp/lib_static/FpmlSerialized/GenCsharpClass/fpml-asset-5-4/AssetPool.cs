using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AssetPool
    {
        public AssetPool(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList initialFactorNodeList = xmlNode.SelectNodes("initialFactor");
            if (initialFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(initialFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList currentFactorNodeList = xmlNode.SelectNodes("currentFactor");
            if (currentFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currentFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currentFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(currentFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currentFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currentFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region InitialFactor
        private XsdTypeDecimal initialFactor;
        public XsdTypeDecimal InitialFactor
        {
            get
            {
                if (this.initialFactor != null)
                {
                    return this.initialFactor; 
                }
                else if (this.initialFactorIDRef != null)
                {
                    initialFactor = IDManager.getID(initialFactorIDRef) as XsdTypeDecimal;
                    return this.initialFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialFactor != value)
                {
                    this.initialFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region CurrentFactor
        private XsdTypeDecimal currentFactor;
        public XsdTypeDecimal CurrentFactor
        {
            get
            {
                if (this.currentFactor != null)
                {
                    return this.currentFactor; 
                }
                else if (this.currentFactorIDRef != null)
                {
                    currentFactor = IDManager.getID(currentFactorIDRef) as XsdTypeDecimal;
                    return this.currentFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currentFactor != value)
                {
                    this.currentFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

