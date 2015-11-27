using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalProduct
    {
        public CoalProduct(XmlNode xmlNode)
        {
            XmlNodeList typeNodeList = xmlNode.SelectNodes("type");
            if (typeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in typeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        typeIDRef = item.Attributes["id"].Name;
                        CoalProductType ob = CoalProductType();
                        IDManager.SetID(typeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        typeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        type = new CoalProductType(item);
                    }
                }
            }
            
        
            XmlNodeList coalProductSpecificationsNodeList = xmlNode.SelectNodes("coalProductSpecifications");
            if (coalProductSpecificationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coalProductSpecificationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coalProductSpecificationsIDRef = item.Attributes["id"].Name;
                        CoalProductSpecifications ob = CoalProductSpecifications();
                        IDManager.SetID(coalProductSpecificationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coalProductSpecificationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coalProductSpecifications = new CoalProductSpecifications(item);
                    }
                }
            }
            
        
            XmlNodeList sourceNodeList = xmlNode.SelectNodes("source");
            
            foreach (XmlNode item in sourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sourceIDRef = item.Attributes["id"].Name;
                        List<CoalProductSource> ob = new List<CoalProductSource>();
                        ob.Add(new CoalProductSource(item));
                        IDManager.SetID(sourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    source.Add(new CoalProductSource(item));
                    }
                }
            }
            
        
            XmlNodeList sCoTASpecificationsNodeList = xmlNode.SelectNodes("sCoTASpecifications");
            if (sCoTASpecificationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sCoTASpecificationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sCoTASpecificationsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(sCoTASpecificationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sCoTASpecificationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sCoTASpecifications = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList btuQualityAdjustmentNodeList = xmlNode.SelectNodes("btuQualityAdjustment");
            if (btuQualityAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in btuQualityAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        btuQualityAdjustmentIDRef = item.Attributes["id"].Name;
                        CoalQualityAdjustments ob = CoalQualityAdjustments();
                        IDManager.SetID(btuQualityAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        btuQualityAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        btuQualityAdjustment = new CoalQualityAdjustments(item);
                    }
                }
            }
            
        
            XmlNodeList so2QualityAdjustmentNodeList = xmlNode.SelectNodes("so2QualityAdjustment");
            if (so2QualityAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in so2QualityAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        so2QualityAdjustmentIDRef = item.Attributes["id"].Name;
                        CoalQualityAdjustments ob = CoalQualityAdjustments();
                        IDManager.SetID(so2QualityAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        so2QualityAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        so2QualityAdjustment = new CoalQualityAdjustments(item);
                    }
                }
            }
            
        
        }
        
    
        #region Type
        private CoalProductType type;
        public CoalProductType Type
        {
            get
            {
                if (this.type != null)
                {
                    return this.type; 
                }
                else if (this.typeIDRef != null)
                {
                    type = IDManager.getID(typeIDRef) as CoalProductType;
                    return this.type; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }
        #endregion
        
        public string CoalProductTypeIDRef { get; set; }
        #region CoalProductSpecifications
        private CoalProductSpecifications coalProductSpecifications;
        public CoalProductSpecifications CoalProductSpecifications
        {
            get
            {
                if (this.coalProductSpecifications != null)
                {
                    return this.coalProductSpecifications; 
                }
                else if (this.coalProductSpecificationsIDRef != null)
                {
                    coalProductSpecifications = IDManager.getID(coalProductSpecificationsIDRef) as CoalProductSpecifications;
                    return this.coalProductSpecifications; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coalProductSpecifications != value)
                {
                    this.coalProductSpecifications = value;
                }
            }
        }
        #endregion
        
        public string CoalProductSpecificationsIDRef { get; set; }
        #region Source
        private List<CoalProductSource> source;
        public List<CoalProductSource> Source
        {
            get
            {
                if (this.source != null)
                {
                    return this.source; 
                }
                else if (this.sourceIDRef != null)
                {
                    source = IDManager.getID(sourceIDRef) as List<CoalProductSource>;
                    return this.source; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.source != value)
                {
                    this.source = value;
                }
            }
        }
        #endregion
        
        public string CoalProductSourceIDRef { get; set; }
        #region SCoTASpecifications
        private XsdTypeBoolean sCoTASpecifications;
        public XsdTypeBoolean SCoTASpecifications
        {
            get
            {
                if (this.sCoTASpecifications != null)
                {
                    return this.sCoTASpecifications; 
                }
                else if (this.sCoTASpecificationsIDRef != null)
                {
                    sCoTASpecifications = IDManager.getID(sCoTASpecificationsIDRef) as XsdTypeBoolean;
                    return this.sCoTASpecifications; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sCoTASpecifications != value)
                {
                    this.sCoTASpecifications = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region BtuQualityAdjustment
        private CoalQualityAdjustments btuQualityAdjustment;
        public CoalQualityAdjustments BtuQualityAdjustment
        {
            get
            {
                if (this.btuQualityAdjustment != null)
                {
                    return this.btuQualityAdjustment; 
                }
                else if (this.btuQualityAdjustmentIDRef != null)
                {
                    btuQualityAdjustment = IDManager.getID(btuQualityAdjustmentIDRef) as CoalQualityAdjustments;
                    return this.btuQualityAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.btuQualityAdjustment != value)
                {
                    this.btuQualityAdjustment = value;
                }
            }
        }
        #endregion
        
        public string CoalQualityAdjustmentsIDRef { get; set; }
        #region So2QualityAdjustment
        private CoalQualityAdjustments so2QualityAdjustment;
        public CoalQualityAdjustments So2QualityAdjustment
        {
            get
            {
                if (this.so2QualityAdjustment != null)
                {
                    return this.so2QualityAdjustment; 
                }
                else if (this.so2QualityAdjustmentIDRef != null)
                {
                    so2QualityAdjustment = IDManager.getID(so2QualityAdjustmentIDRef) as CoalQualityAdjustments;
                    return this.so2QualityAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.so2QualityAdjustment != value)
                {
                    this.so2QualityAdjustment = value;
                }
            }
        }
        #endregion
        
        public string CoalQualityAdjustmentsIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

