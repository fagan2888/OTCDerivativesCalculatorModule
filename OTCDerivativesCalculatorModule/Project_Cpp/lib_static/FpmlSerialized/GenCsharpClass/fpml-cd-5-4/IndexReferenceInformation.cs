using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IndexReferenceInformation
    {
        public IndexReferenceInformation(XmlNode xmlNode)
        {
            XmlNodeList indexNameNodeList = xmlNode.SelectNodes("indexName");
            if (indexNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexNameIDRef = item.Attributes["id"].Name;
                        IndexName ob = IndexName();
                        IDManager.SetID(indexNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexName = new IndexName(item);
                    }
                }
            }
            
        
            XmlNodeList indexIdNodeList = xmlNode.SelectNodes("indexId");
            
            foreach (XmlNode item in indexIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexIdIDRef = item.Attributes["id"].Name;
                        List<IndexId> ob = new List<IndexId>();
                        ob.Add(new IndexId(item));
                        IDManager.SetID(indexIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    indexId.Add(new IndexId(item));
                    }
                }
            }
            
        
            XmlNodeList indexSeriesNodeList = xmlNode.SelectNodes("indexSeries");
            if (indexSeriesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexSeriesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexSeriesIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(indexSeriesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexSeriesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexSeries = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList indexAnnexVersionNodeList = xmlNode.SelectNodes("indexAnnexVersion");
            if (indexAnnexVersionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexAnnexVersionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexAnnexVersionIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(indexAnnexVersionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexAnnexVersionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexAnnexVersion = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList indexAnnexDateNodeList = xmlNode.SelectNodes("indexAnnexDate");
            if (indexAnnexDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexAnnexDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexAnnexDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(indexAnnexDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexAnnexDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexAnnexDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList indexAnnexSourceNodeList = xmlNode.SelectNodes("indexAnnexSource");
            if (indexAnnexSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexAnnexSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexAnnexSourceIDRef = item.Attributes["id"].Name;
                        IndexAnnexSource ob = IndexAnnexSource();
                        IDManager.SetID(indexAnnexSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexAnnexSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexAnnexSource = new IndexAnnexSource(item);
                    }
                }
            }
            
        
            XmlNodeList excludedReferenceEntityNodeList = xmlNode.SelectNodes("excludedReferenceEntity");
            
            foreach (XmlNode item in excludedReferenceEntityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        excludedReferenceEntityIDRef = item.Attributes["id"].Name;
                        List<LegalEntity> ob = new List<LegalEntity>();
                        ob.Add(new LegalEntity(item));
                        IDManager.SetID(excludedReferenceEntityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        excludedReferenceEntityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    excludedReferenceEntity.Add(new LegalEntity(item));
                    }
                }
            }
            
        
            XmlNodeList trancheNodeList = xmlNode.SelectNodes("tranche");
            if (trancheNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in trancheNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        trancheIDRef = item.Attributes["id"].Name;
                        Tranche ob = Tranche();
                        IDManager.SetID(trancheIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        trancheIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tranche = new Tranche(item);
                    }
                }
            }
            
        
            XmlNodeList settledEntityMatrixNodeList = xmlNode.SelectNodes("settledEntityMatrix");
            if (settledEntityMatrixNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settledEntityMatrixNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settledEntityMatrixIDRef = item.Attributes["id"].Name;
                        SettledEntityMatrix ob = SettledEntityMatrix();
                        IDManager.SetID(settledEntityMatrixIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settledEntityMatrixIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settledEntityMatrix = new SettledEntityMatrix(item);
                    }
                }
            }
            
        
        }
        
    
        #region IndexName
        private IndexName indexName;
        public IndexName IndexName
        {
            get
            {
                if (this.indexName != null)
                {
                    return this.indexName; 
                }
                else if (this.indexNameIDRef != null)
                {
                    indexName = IDManager.getID(indexNameIDRef) as IndexName;
                    return this.indexName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexName != value)
                {
                    this.indexName = value;
                }
            }
        }
        #endregion
        
        public string IndexNameIDRef { get; set; }
        #region IndexId
        private List<IndexId> indexId;
        public List<IndexId> IndexId
        {
            get
            {
                if (this.indexId != null)
                {
                    return this.indexId; 
                }
                else if (this.indexIdIDRef != null)
                {
                    indexId = IDManager.getID(indexIdIDRef) as List<IndexId>;
                    return this.indexId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexId != value)
                {
                    this.indexId = value;
                }
            }
        }
        #endregion
        
        public string IndexIdIDRef { get; set; }
        #region IndexSeries
        private XsdTypePositiveInteger indexSeries;
        public XsdTypePositiveInteger IndexSeries
        {
            get
            {
                if (this.indexSeries != null)
                {
                    return this.indexSeries; 
                }
                else if (this.indexSeriesIDRef != null)
                {
                    indexSeries = IDManager.getID(indexSeriesIDRef) as XsdTypePositiveInteger;
                    return this.indexSeries; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexSeries != value)
                {
                    this.indexSeries = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region IndexAnnexVersion
        private XsdTypePositiveInteger indexAnnexVersion;
        public XsdTypePositiveInteger IndexAnnexVersion
        {
            get
            {
                if (this.indexAnnexVersion != null)
                {
                    return this.indexAnnexVersion; 
                }
                else if (this.indexAnnexVersionIDRef != null)
                {
                    indexAnnexVersion = IDManager.getID(indexAnnexVersionIDRef) as XsdTypePositiveInteger;
                    return this.indexAnnexVersion; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexAnnexVersion != value)
                {
                    this.indexAnnexVersion = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region IndexAnnexDate
        private XsdTypeDate indexAnnexDate;
        public XsdTypeDate IndexAnnexDate
        {
            get
            {
                if (this.indexAnnexDate != null)
                {
                    return this.indexAnnexDate; 
                }
                else if (this.indexAnnexDateIDRef != null)
                {
                    indexAnnexDate = IDManager.getID(indexAnnexDateIDRef) as XsdTypeDate;
                    return this.indexAnnexDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexAnnexDate != value)
                {
                    this.indexAnnexDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region IndexAnnexSource
        private IndexAnnexSource indexAnnexSource;
        public IndexAnnexSource IndexAnnexSource
        {
            get
            {
                if (this.indexAnnexSource != null)
                {
                    return this.indexAnnexSource; 
                }
                else if (this.indexAnnexSourceIDRef != null)
                {
                    indexAnnexSource = IDManager.getID(indexAnnexSourceIDRef) as IndexAnnexSource;
                    return this.indexAnnexSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexAnnexSource != value)
                {
                    this.indexAnnexSource = value;
                }
            }
        }
        #endregion
        
        public string IndexAnnexSourceIDRef { get; set; }
        #region ExcludedReferenceEntity
        private List<LegalEntity> excludedReferenceEntity;
        public List<LegalEntity> ExcludedReferenceEntity
        {
            get
            {
                if (this.excludedReferenceEntity != null)
                {
                    return this.excludedReferenceEntity; 
                }
                else if (this.excludedReferenceEntityIDRef != null)
                {
                    excludedReferenceEntity = IDManager.getID(excludedReferenceEntityIDRef) as List<LegalEntity>;
                    return this.excludedReferenceEntity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.excludedReferenceEntity != value)
                {
                    this.excludedReferenceEntity = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region Tranche
        private Tranche tranche;
        public Tranche Tranche
        {
            get
            {
                if (this.tranche != null)
                {
                    return this.tranche; 
                }
                else if (this.trancheIDRef != null)
                {
                    tranche = IDManager.getID(trancheIDRef) as Tranche;
                    return this.tranche; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tranche != value)
                {
                    this.tranche = value;
                }
            }
        }
        #endregion
        
        public string TrancheIDRef { get; set; }
        #region SettledEntityMatrix
        private SettledEntityMatrix settledEntityMatrix;
        public SettledEntityMatrix SettledEntityMatrix
        {
            get
            {
                if (this.settledEntityMatrix != null)
                {
                    return this.settledEntityMatrix; 
                }
                else if (this.settledEntityMatrixIDRef != null)
                {
                    settledEntityMatrix = IDManager.getID(settledEntityMatrixIDRef) as SettledEntityMatrix;
                    return this.settledEntityMatrix; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settledEntityMatrix != value)
                {
                    this.settledEntityMatrix = value;
                }
            }
        }
        #endregion
        
        public string SettledEntityMatrixIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

