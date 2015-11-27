using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexReferenceInformation : ISerialized
    {
        public IndexReferenceInformation(XmlNode xmlNode)
        {
            XmlNode indexNameNode = xmlNode.SelectSingleNode("indexName");
            
            if (indexNameNode != null)
            {
                if (indexNameNode.Attributes["href"] != null || indexNameNode.Attributes["id"] != null) 
                {
                    if (indexNameNode.Attributes["id"] != null) 
                    {
                        indexNameIDRef_ = indexNameNode.Attributes["id"].Value;
                        IndexName ob = new IndexName(indexNameNode);
                        IDManager.SetID(indexNameIDRef_, ob);
                    }
                    else if (indexNameNode.Attributes["href"] != null)
                    {
                        indexNameIDRef_ = indexNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexName_ = new IndexName(indexNameNode);
                    }
                }
                else
                {
                    indexName_ = new IndexName(indexNameNode);
                }
            }
            
        
            XmlNodeList indexIdNodeList = xmlNode.SelectNodes("indexId");
            
            if (indexIdNodeList != null)
            {
                this.indexId_ = new List<IndexId>();
                foreach (XmlNode item in indexIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            indexIdIDRef_ = item.Attributes["id"].Value;
                            indexId_.Add(new IndexId(item));
                            IDManager.SetID(indexIdIDRef_, indexId_[indexId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            indexIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        indexId_.Add(new IndexId(item));
                        }
                    }
                    else
                    {
                        indexId_.Add(new IndexId(item));
                    }
                }
            }
            
        
            XmlNode indexSeriesNode = xmlNode.SelectSingleNode("indexSeries");
            
            if (indexSeriesNode != null)
            {
                if (indexSeriesNode.Attributes["href"] != null || indexSeriesNode.Attributes["id"] != null) 
                {
                    if (indexSeriesNode.Attributes["id"] != null) 
                    {
                        indexSeriesIDRef_ = indexSeriesNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(indexSeriesNode);
                        IDManager.SetID(indexSeriesIDRef_, ob);
                    }
                    else if (indexSeriesNode.Attributes["href"] != null)
                    {
                        indexSeriesIDRef_ = indexSeriesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexSeries_ = new XsdTypePositiveInteger(indexSeriesNode);
                    }
                }
                else
                {
                    indexSeries_ = new XsdTypePositiveInteger(indexSeriesNode);
                }
            }
            
        
            XmlNode indexAnnexVersionNode = xmlNode.SelectSingleNode("indexAnnexVersion");
            
            if (indexAnnexVersionNode != null)
            {
                if (indexAnnexVersionNode.Attributes["href"] != null || indexAnnexVersionNode.Attributes["id"] != null) 
                {
                    if (indexAnnexVersionNode.Attributes["id"] != null) 
                    {
                        indexAnnexVersionIDRef_ = indexAnnexVersionNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(indexAnnexVersionNode);
                        IDManager.SetID(indexAnnexVersionIDRef_, ob);
                    }
                    else if (indexAnnexVersionNode.Attributes["href"] != null)
                    {
                        indexAnnexVersionIDRef_ = indexAnnexVersionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexAnnexVersion_ = new XsdTypePositiveInteger(indexAnnexVersionNode);
                    }
                }
                else
                {
                    indexAnnexVersion_ = new XsdTypePositiveInteger(indexAnnexVersionNode);
                }
            }
            
        
            XmlNode indexAnnexDateNode = xmlNode.SelectSingleNode("indexAnnexDate");
            
            if (indexAnnexDateNode != null)
            {
                if (indexAnnexDateNode.Attributes["href"] != null || indexAnnexDateNode.Attributes["id"] != null) 
                {
                    if (indexAnnexDateNode.Attributes["id"] != null) 
                    {
                        indexAnnexDateIDRef_ = indexAnnexDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(indexAnnexDateNode);
                        IDManager.SetID(indexAnnexDateIDRef_, ob);
                    }
                    else if (indexAnnexDateNode.Attributes["href"] != null)
                    {
                        indexAnnexDateIDRef_ = indexAnnexDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexAnnexDate_ = new XsdTypeDate(indexAnnexDateNode);
                    }
                }
                else
                {
                    indexAnnexDate_ = new XsdTypeDate(indexAnnexDateNode);
                }
            }
            
        
            XmlNode indexAnnexSourceNode = xmlNode.SelectSingleNode("indexAnnexSource");
            
            if (indexAnnexSourceNode != null)
            {
                if (indexAnnexSourceNode.Attributes["href"] != null || indexAnnexSourceNode.Attributes["id"] != null) 
                {
                    if (indexAnnexSourceNode.Attributes["id"] != null) 
                    {
                        indexAnnexSourceIDRef_ = indexAnnexSourceNode.Attributes["id"].Value;
                        IndexAnnexSource ob = new IndexAnnexSource(indexAnnexSourceNode);
                        IDManager.SetID(indexAnnexSourceIDRef_, ob);
                    }
                    else if (indexAnnexSourceNode.Attributes["href"] != null)
                    {
                        indexAnnexSourceIDRef_ = indexAnnexSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexAnnexSource_ = new IndexAnnexSource(indexAnnexSourceNode);
                    }
                }
                else
                {
                    indexAnnexSource_ = new IndexAnnexSource(indexAnnexSourceNode);
                }
            }
            
        
            XmlNodeList excludedReferenceEntityNodeList = xmlNode.SelectNodes("excludedReferenceEntity");
            
            if (excludedReferenceEntityNodeList != null)
            {
                this.excludedReferenceEntity_ = new List<LegalEntity>();
                foreach (XmlNode item in excludedReferenceEntityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excludedReferenceEntityIDRef_ = item.Attributes["id"].Value;
                            excludedReferenceEntity_.Add(new LegalEntity(item));
                            IDManager.SetID(excludedReferenceEntityIDRef_, excludedReferenceEntity_[excludedReferenceEntity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excludedReferenceEntityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excludedReferenceEntity_.Add(new LegalEntity(item));
                        }
                    }
                    else
                    {
                        excludedReferenceEntity_.Add(new LegalEntity(item));
                    }
                }
            }
            
        
            XmlNode trancheNode = xmlNode.SelectSingleNode("tranche");
            
            if (trancheNode != null)
            {
                if (trancheNode.Attributes["href"] != null || trancheNode.Attributes["id"] != null) 
                {
                    if (trancheNode.Attributes["id"] != null) 
                    {
                        trancheIDRef_ = trancheNode.Attributes["id"].Value;
                        Tranche ob = new Tranche(trancheNode);
                        IDManager.SetID(trancheIDRef_, ob);
                    }
                    else if (trancheNode.Attributes["href"] != null)
                    {
                        trancheIDRef_ = trancheNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tranche_ = new Tranche(trancheNode);
                    }
                }
                else
                {
                    tranche_ = new Tranche(trancheNode);
                }
            }
            
        
            XmlNode settledEntityMatrixNode = xmlNode.SelectSingleNode("settledEntityMatrix");
            
            if (settledEntityMatrixNode != null)
            {
                if (settledEntityMatrixNode.Attributes["href"] != null || settledEntityMatrixNode.Attributes["id"] != null) 
                {
                    if (settledEntityMatrixNode.Attributes["id"] != null) 
                    {
                        settledEntityMatrixIDRef_ = settledEntityMatrixNode.Attributes["id"].Value;
                        SettledEntityMatrix ob = new SettledEntityMatrix(settledEntityMatrixNode);
                        IDManager.SetID(settledEntityMatrixIDRef_, ob);
                    }
                    else if (settledEntityMatrixNode.Attributes["href"] != null)
                    {
                        settledEntityMatrixIDRef_ = settledEntityMatrixNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settledEntityMatrix_ = new SettledEntityMatrix(settledEntityMatrixNode);
                    }
                }
                else
                {
                    settledEntityMatrix_ = new SettledEntityMatrix(settledEntityMatrixNode);
                }
            }
            
        
        }
        
    
        #region IndexName_
        private IndexName indexName_;
        public IndexName IndexName_
        {
            get
            {
                if (this.indexName_ != null)
                {
                    return this.indexName_; 
                }
                else if (this.indexNameIDRef_ != null)
                {
                    indexName_ = IDManager.getID(indexNameIDRef_) as IndexName;
                    return this.indexName_; 
                }
                else
                {
                      return this.indexName_; 
                }
            }
            set
            {
                if (this.indexName_ != value)
                {
                    this.indexName_ = value;
                }
            }
        }
        #endregion
        
        public string indexNameIDRef_ { get; set; }
        #region IndexId_
        private List<IndexId> indexId_;
        public List<IndexId> IndexId_
        {
            get
            {
                if (this.indexId_ != null)
                {
                    return this.indexId_; 
                }
                else if (this.indexIdIDRef_ != null)
                {
                    return this.indexId_; 
                }
                else
                {
                      return this.indexId_; 
                }
            }
            set
            {
                if (this.indexId_ != value)
                {
                    this.indexId_ = value;
                }
            }
        }
        #endregion
        
        public string indexIdIDRef_ { get; set; }
        #region IndexSeries_
        private XsdTypePositiveInteger indexSeries_;
        public XsdTypePositiveInteger IndexSeries_
        {
            get
            {
                if (this.indexSeries_ != null)
                {
                    return this.indexSeries_; 
                }
                else if (this.indexSeriesIDRef_ != null)
                {
                    indexSeries_ = IDManager.getID(indexSeriesIDRef_) as XsdTypePositiveInteger;
                    return this.indexSeries_; 
                }
                else
                {
                      return this.indexSeries_; 
                }
            }
            set
            {
                if (this.indexSeries_ != value)
                {
                    this.indexSeries_ = value;
                }
            }
        }
        #endregion
        
        public string indexSeriesIDRef_ { get; set; }
        #region IndexAnnexVersion_
        private XsdTypePositiveInteger indexAnnexVersion_;
        public XsdTypePositiveInteger IndexAnnexVersion_
        {
            get
            {
                if (this.indexAnnexVersion_ != null)
                {
                    return this.indexAnnexVersion_; 
                }
                else if (this.indexAnnexVersionIDRef_ != null)
                {
                    indexAnnexVersion_ = IDManager.getID(indexAnnexVersionIDRef_) as XsdTypePositiveInteger;
                    return this.indexAnnexVersion_; 
                }
                else
                {
                      return this.indexAnnexVersion_; 
                }
            }
            set
            {
                if (this.indexAnnexVersion_ != value)
                {
                    this.indexAnnexVersion_ = value;
                }
            }
        }
        #endregion
        
        public string indexAnnexVersionIDRef_ { get; set; }
        #region IndexAnnexDate_
        private XsdTypeDate indexAnnexDate_;
        public XsdTypeDate IndexAnnexDate_
        {
            get
            {
                if (this.indexAnnexDate_ != null)
                {
                    return this.indexAnnexDate_; 
                }
                else if (this.indexAnnexDateIDRef_ != null)
                {
                    indexAnnexDate_ = IDManager.getID(indexAnnexDateIDRef_) as XsdTypeDate;
                    return this.indexAnnexDate_; 
                }
                else
                {
                      return this.indexAnnexDate_; 
                }
            }
            set
            {
                if (this.indexAnnexDate_ != value)
                {
                    this.indexAnnexDate_ = value;
                }
            }
        }
        #endregion
        
        public string indexAnnexDateIDRef_ { get; set; }
        #region IndexAnnexSource_
        private IndexAnnexSource indexAnnexSource_;
        public IndexAnnexSource IndexAnnexSource_
        {
            get
            {
                if (this.indexAnnexSource_ != null)
                {
                    return this.indexAnnexSource_; 
                }
                else if (this.indexAnnexSourceIDRef_ != null)
                {
                    indexAnnexSource_ = IDManager.getID(indexAnnexSourceIDRef_) as IndexAnnexSource;
                    return this.indexAnnexSource_; 
                }
                else
                {
                      return this.indexAnnexSource_; 
                }
            }
            set
            {
                if (this.indexAnnexSource_ != value)
                {
                    this.indexAnnexSource_ = value;
                }
            }
        }
        #endregion
        
        public string indexAnnexSourceIDRef_ { get; set; }
        #region ExcludedReferenceEntity_
        private List<LegalEntity> excludedReferenceEntity_;
        public List<LegalEntity> ExcludedReferenceEntity_
        {
            get
            {
                if (this.excludedReferenceEntity_ != null)
                {
                    return this.excludedReferenceEntity_; 
                }
                else if (this.excludedReferenceEntityIDRef_ != null)
                {
                    return this.excludedReferenceEntity_; 
                }
                else
                {
                      return this.excludedReferenceEntity_; 
                }
            }
            set
            {
                if (this.excludedReferenceEntity_ != value)
                {
                    this.excludedReferenceEntity_ = value;
                }
            }
        }
        #endregion
        
        public string excludedReferenceEntityIDRef_ { get; set; }
        #region Tranche_
        private Tranche tranche_;
        public Tranche Tranche_
        {
            get
            {
                if (this.tranche_ != null)
                {
                    return this.tranche_; 
                }
                else if (this.trancheIDRef_ != null)
                {
                    tranche_ = IDManager.getID(trancheIDRef_) as Tranche;
                    return this.tranche_; 
                }
                else
                {
                      return this.tranche_; 
                }
            }
            set
            {
                if (this.tranche_ != value)
                {
                    this.tranche_ = value;
                }
            }
        }
        #endregion
        
        public string trancheIDRef_ { get; set; }
        #region SettledEntityMatrix_
        private SettledEntityMatrix settledEntityMatrix_;
        public SettledEntityMatrix SettledEntityMatrix_
        {
            get
            {
                if (this.settledEntityMatrix_ != null)
                {
                    return this.settledEntityMatrix_; 
                }
                else if (this.settledEntityMatrixIDRef_ != null)
                {
                    settledEntityMatrix_ = IDManager.getID(settledEntityMatrixIDRef_) as SettledEntityMatrix;
                    return this.settledEntityMatrix_; 
                }
                else
                {
                      return this.settledEntityMatrix_; 
                }
            }
            set
            {
                if (this.settledEntityMatrix_ != value)
                {
                    this.settledEntityMatrix_ = value;
                }
            }
        }
        #endregion
        
        public string settledEntityMatrixIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

