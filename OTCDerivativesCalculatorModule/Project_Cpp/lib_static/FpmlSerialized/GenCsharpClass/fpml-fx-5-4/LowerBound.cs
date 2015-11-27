using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LowerBound
    {
        public LowerBound(XmlNode xmlNode)
        {
            XmlNodeList minimumInclusiveNodeList = xmlNode.SelectNodes("minimumInclusive");
            if (minimumInclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumInclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumInclusiveIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(minimumInclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumInclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumInclusive = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList minimumExclusiveNodeList = xmlNode.SelectNodes("minimumExclusive");
            if (minimumExclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumExclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumExclusiveIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(minimumExclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumExclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumExclusive = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region MinimumInclusive
        private PositiveDecimal minimumInclusive;
        public PositiveDecimal MinimumInclusive
        {
            get
            {
                if (this.minimumInclusive != null)
                {
                    return this.minimumInclusive; 
                }
                else if (this.minimumInclusiveIDRef != null)
                {
                    minimumInclusive = IDManager.getID(minimumInclusiveIDRef) as PositiveDecimal;
                    return this.minimumInclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumInclusive != value)
                {
                    this.minimumInclusive = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region MinimumExclusive
        private PositiveDecimal minimumExclusive;
        public PositiveDecimal MinimumExclusive
        {
            get
            {
                if (this.minimumExclusive != null)
                {
                    return this.minimumExclusive; 
                }
                else if (this.minimumExclusiveIDRef != null)
                {
                    minimumExclusive = IDManager.getID(minimumExclusiveIDRef) as PositiveDecimal;
                    return this.minimumExclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumExclusive != value)
                {
                    this.minimumExclusive = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

