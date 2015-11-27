using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexAdjustmentEvents : ISerialized
    {
        public IndexAdjustmentEvents(XmlNode xmlNode)
        {
            XmlNode indexModificationNode = xmlNode.SelectSingleNode("indexModification");
            
            if (indexModificationNode != null)
            {
                if (indexModificationNode.Attributes["href"] != null || indexModificationNode.Attributes["id"] != null) 
                {
                    if (indexModificationNode.Attributes["id"] != null) 
                    {
                        indexModificationIDRef_ = indexModificationNode.Attributes["id"].Value;
                        IndexEventConsequenceEnum ob = new IndexEventConsequenceEnum(indexModificationNode);
                        IDManager.SetID(indexModificationIDRef_, ob);
                    }
                    else if (indexModificationNode.Attributes["href"] != null)
                    {
                        indexModificationIDRef_ = indexModificationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexModification_ = new IndexEventConsequenceEnum(indexModificationNode);
                    }
                }
                else
                {
                    indexModification_ = new IndexEventConsequenceEnum(indexModificationNode);
                }
            }
            
        
            XmlNode indexCancellationNode = xmlNode.SelectSingleNode("indexCancellation");
            
            if (indexCancellationNode != null)
            {
                if (indexCancellationNode.Attributes["href"] != null || indexCancellationNode.Attributes["id"] != null) 
                {
                    if (indexCancellationNode.Attributes["id"] != null) 
                    {
                        indexCancellationIDRef_ = indexCancellationNode.Attributes["id"].Value;
                        IndexEventConsequenceEnum ob = new IndexEventConsequenceEnum(indexCancellationNode);
                        IDManager.SetID(indexCancellationIDRef_, ob);
                    }
                    else if (indexCancellationNode.Attributes["href"] != null)
                    {
                        indexCancellationIDRef_ = indexCancellationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexCancellation_ = new IndexEventConsequenceEnum(indexCancellationNode);
                    }
                }
                else
                {
                    indexCancellation_ = new IndexEventConsequenceEnum(indexCancellationNode);
                }
            }
            
        
            XmlNode indexDisruptionNode = xmlNode.SelectSingleNode("indexDisruption");
            
            if (indexDisruptionNode != null)
            {
                if (indexDisruptionNode.Attributes["href"] != null || indexDisruptionNode.Attributes["id"] != null) 
                {
                    if (indexDisruptionNode.Attributes["id"] != null) 
                    {
                        indexDisruptionIDRef_ = indexDisruptionNode.Attributes["id"].Value;
                        IndexEventConsequenceEnum ob = new IndexEventConsequenceEnum(indexDisruptionNode);
                        IDManager.SetID(indexDisruptionIDRef_, ob);
                    }
                    else if (indexDisruptionNode.Attributes["href"] != null)
                    {
                        indexDisruptionIDRef_ = indexDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexDisruption_ = new IndexEventConsequenceEnum(indexDisruptionNode);
                    }
                }
                else
                {
                    indexDisruption_ = new IndexEventConsequenceEnum(indexDisruptionNode);
                }
            }
            
        
        }
        
    
        #region IndexModification_
        private IndexEventConsequenceEnum indexModification_;
        public IndexEventConsequenceEnum IndexModification_
        {
            get
            {
                if (this.indexModification_ != null)
                {
                    return this.indexModification_; 
                }
                else if (this.indexModificationIDRef_ != null)
                {
                    indexModification_ = IDManager.getID(indexModificationIDRef_) as IndexEventConsequenceEnum;
                    return this.indexModification_; 
                }
                else
                {
                      return this.indexModification_; 
                }
            }
            set
            {
                if (this.indexModification_ != value)
                {
                    this.indexModification_ = value;
                }
            }
        }
        #endregion
        
        public string indexModificationIDRef_ { get; set; }
        #region IndexCancellation_
        private IndexEventConsequenceEnum indexCancellation_;
        public IndexEventConsequenceEnum IndexCancellation_
        {
            get
            {
                if (this.indexCancellation_ != null)
                {
                    return this.indexCancellation_; 
                }
                else if (this.indexCancellationIDRef_ != null)
                {
                    indexCancellation_ = IDManager.getID(indexCancellationIDRef_) as IndexEventConsequenceEnum;
                    return this.indexCancellation_; 
                }
                else
                {
                      return this.indexCancellation_; 
                }
            }
            set
            {
                if (this.indexCancellation_ != value)
                {
                    this.indexCancellation_ = value;
                }
            }
        }
        #endregion
        
        public string indexCancellationIDRef_ { get; set; }
        #region IndexDisruption_
        private IndexEventConsequenceEnum indexDisruption_;
        public IndexEventConsequenceEnum IndexDisruption_
        {
            get
            {
                if (this.indexDisruption_ != null)
                {
                    return this.indexDisruption_; 
                }
                else if (this.indexDisruptionIDRef_ != null)
                {
                    indexDisruption_ = IDManager.getID(indexDisruptionIDRef_) as IndexEventConsequenceEnum;
                    return this.indexDisruption_; 
                }
                else
                {
                      return this.indexDisruption_; 
                }
            }
            set
            {
                if (this.indexDisruption_ != value)
                {
                    this.indexDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string indexDisruptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

