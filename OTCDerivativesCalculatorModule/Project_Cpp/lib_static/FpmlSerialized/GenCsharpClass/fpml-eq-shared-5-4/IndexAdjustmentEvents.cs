using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IndexAdjustmentEvents
    {
        public IndexAdjustmentEvents(XmlNode xmlNode)
        {
            XmlNodeList indexModificationNodeList = xmlNode.SelectNodes("indexModification");
            if (indexModificationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexModificationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexModificationIDRef = item.Attributes["id"].Name;
                        IndexEventConsequenceEnum ob = IndexEventConsequenceEnum();
                        IDManager.SetID(indexModificationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexModificationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexModification = new IndexEventConsequenceEnum(item);
                    }
                }
            }
            
        
            XmlNodeList indexCancellationNodeList = xmlNode.SelectNodes("indexCancellation");
            if (indexCancellationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexCancellationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexCancellationIDRef = item.Attributes["id"].Name;
                        IndexEventConsequenceEnum ob = IndexEventConsequenceEnum();
                        IDManager.SetID(indexCancellationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexCancellationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexCancellation = new IndexEventConsequenceEnum(item);
                    }
                }
            }
            
        
            XmlNodeList indexDisruptionNodeList = xmlNode.SelectNodes("indexDisruption");
            if (indexDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexDisruptionIDRef = item.Attributes["id"].Name;
                        IndexEventConsequenceEnum ob = IndexEventConsequenceEnum();
                        IDManager.SetID(indexDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexDisruption = new IndexEventConsequenceEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region IndexModification
        private IndexEventConsequenceEnum indexModification;
        public IndexEventConsequenceEnum IndexModification
        {
            get
            {
                if (this.indexModification != null)
                {
                    return this.indexModification; 
                }
                else if (this.indexModificationIDRef != null)
                {
                    indexModification = IDManager.getID(indexModificationIDRef) as IndexEventConsequenceEnum;
                    return this.indexModification; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexModification != value)
                {
                    this.indexModification = value;
                }
            }
        }
        #endregion
        
        public string IndexEventConsequenceEnumIDRef { get; set; }
        #region IndexCancellation
        private IndexEventConsequenceEnum indexCancellation;
        public IndexEventConsequenceEnum IndexCancellation
        {
            get
            {
                if (this.indexCancellation != null)
                {
                    return this.indexCancellation; 
                }
                else if (this.indexCancellationIDRef != null)
                {
                    indexCancellation = IDManager.getID(indexCancellationIDRef) as IndexEventConsequenceEnum;
                    return this.indexCancellation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexCancellation != value)
                {
                    this.indexCancellation = value;
                }
            }
        }
        #endregion
        
        public string IndexEventConsequenceEnumIDRef { get; set; }
        #region IndexDisruption
        private IndexEventConsequenceEnum indexDisruption;
        public IndexEventConsequenceEnum IndexDisruption
        {
            get
            {
                if (this.indexDisruption != null)
                {
                    return this.indexDisruption; 
                }
                else if (this.indexDisruptionIDRef != null)
                {
                    indexDisruption = IDManager.getID(indexDisruptionIDRef) as IndexEventConsequenceEnum;
                    return this.indexDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexDisruption != value)
                {
                    this.indexDisruption = value;
                }
            }
        }
        #endregion
        
        public string IndexEventConsequenceEnumIDRef { get; set; }
        
    
        
    
    }
    
}

