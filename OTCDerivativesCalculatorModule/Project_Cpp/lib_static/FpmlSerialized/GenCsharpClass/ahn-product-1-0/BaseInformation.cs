using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BaseInformation
    {
        public BaseInformation(XmlNode xmlNode)
        {
            XmlNodeList baseIndexesNodeList = xmlNode.SelectNodes("baseIndexes");
            if (baseIndexesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseIndexesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseIndexesIDRef = item.Attributes["id"].Name;
                        BaseIndexes ob = BaseIndexes();
                        IDManager.SetID(baseIndexesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseIndexesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseIndexes = new BaseIndexes(item);
                    }
                }
            }
            
        
            XmlNodeList conventionSetNodeList = xmlNode.SelectNodes("conventionSet");
            if (conventionSetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in conventionSetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        conventionSetIDRef = item.Attributes["id"].Name;
                        ConventionSet ob = ConventionSet();
                        IDManager.SetID(conventionSetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        conventionSetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        conventionSet = new ConventionSet(item);
                    }
                }
            }
            
        
        }
        
    
        #region BaseIndexes
        private BaseIndexes baseIndexes;
        public BaseIndexes BaseIndexes
        {
            get
            {
                if (this.baseIndexes != null)
                {
                    return this.baseIndexes; 
                }
                else if (this.baseIndexesIDRef != null)
                {
                    baseIndexes = IDManager.getID(baseIndexesIDRef) as BaseIndexes;
                    return this.baseIndexes; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseIndexes != value)
                {
                    this.baseIndexes = value;
                }
            }
        }
        #endregion
        
        public string BaseIndexesIDRef { get; set; }
        #region ConventionSet
        private ConventionSet conventionSet;
        public ConventionSet ConventionSet
        {
            get
            {
                if (this.conventionSet != null)
                {
                    return this.conventionSet; 
                }
                else if (this.conventionSetIDRef != null)
                {
                    conventionSet = IDManager.getID(conventionSetIDRef) as ConventionSet;
                    return this.conventionSet; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.conventionSet != value)
                {
                    this.conventionSet = value;
                }
            }
        }
        #endregion
        
        public string ConventionSetIDRef { get; set; }
        
    
        
    
    }
    
}

