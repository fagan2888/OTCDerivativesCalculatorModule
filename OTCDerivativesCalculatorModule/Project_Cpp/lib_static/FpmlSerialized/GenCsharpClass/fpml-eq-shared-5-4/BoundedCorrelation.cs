using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BoundedCorrelation
    {
        public BoundedCorrelation(XmlNode xmlNode)
        {
            XmlNodeList minimumBoundaryPercentNodeList = xmlNode.SelectNodes("minimumBoundaryPercent");
            if (minimumBoundaryPercentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumBoundaryPercentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumBoundaryPercentIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(minimumBoundaryPercentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumBoundaryPercentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumBoundaryPercent = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList maximumBoundaryPercentNodeList = xmlNode.SelectNodes("maximumBoundaryPercent");
            if (maximumBoundaryPercentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumBoundaryPercentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumBoundaryPercentIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(maximumBoundaryPercentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumBoundaryPercentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumBoundaryPercent = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region MinimumBoundaryPercent
        private XsdTypeDecimal minimumBoundaryPercent;
        public XsdTypeDecimal MinimumBoundaryPercent
        {
            get
            {
                if (this.minimumBoundaryPercent != null)
                {
                    return this.minimumBoundaryPercent; 
                }
                else if (this.minimumBoundaryPercentIDRef != null)
                {
                    minimumBoundaryPercent = IDManager.getID(minimumBoundaryPercentIDRef) as XsdTypeDecimal;
                    return this.minimumBoundaryPercent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumBoundaryPercent != value)
                {
                    this.minimumBoundaryPercent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region MaximumBoundaryPercent
        private XsdTypeDecimal maximumBoundaryPercent;
        public XsdTypeDecimal MaximumBoundaryPercent
        {
            get
            {
                if (this.maximumBoundaryPercent != null)
                {
                    return this.maximumBoundaryPercent; 
                }
                else if (this.maximumBoundaryPercentIDRef != null)
                {
                    maximumBoundaryPercent = IDManager.getID(maximumBoundaryPercentIDRef) as XsdTypeDecimal;
                    return this.maximumBoundaryPercent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumBoundaryPercent != value)
                {
                    this.maximumBoundaryPercent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

