using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class UpperBound
    {
        public UpperBound(XmlNode xmlNode)
        {
            XmlNodeList maximumInclusiveNodeList = xmlNode.SelectNodes("maximumInclusive");
            if (maximumInclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumInclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumInclusiveIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(maximumInclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumInclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumInclusive = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList maximumExclusiveNodeList = xmlNode.SelectNodes("maximumExclusive");
            if (maximumExclusiveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumExclusiveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumExclusiveIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(maximumExclusiveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumExclusiveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumExclusive = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region MaximumInclusive
        private PositiveDecimal maximumInclusive;
        public PositiveDecimal MaximumInclusive
        {
            get
            {
                if (this.maximumInclusive != null)
                {
                    return this.maximumInclusive; 
                }
                else if (this.maximumInclusiveIDRef != null)
                {
                    maximumInclusive = IDManager.getID(maximumInclusiveIDRef) as PositiveDecimal;
                    return this.maximumInclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumInclusive != value)
                {
                    this.maximumInclusive = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region MaximumExclusive
        private PositiveDecimal maximumExclusive;
        public PositiveDecimal MaximumExclusive
        {
            get
            {
                if (this.maximumExclusive != null)
                {
                    return this.maximumExclusive; 
                }
                else if (this.maximumExclusiveIDRef != null)
                {
                    maximumExclusive = IDManager.getID(maximumExclusiveIDRef) as PositiveDecimal;
                    return this.maximumExclusive; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumExclusive != value)
                {
                    this.maximumExclusive = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

