using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BasketReferenceInformation
    {
        public BasketReferenceInformation(XmlNode xmlNode)
        {
            XmlNodeList basketNameNodeList = xmlNode.SelectNodes("basketName");
            if (basketNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketNameIDRef = item.Attributes["id"].Name;
                        BasketName ob = BasketName();
                        IDManager.SetID(basketNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketName = new BasketName(item);
                    }
                }
            }
            
        
            XmlNodeList basketIdNodeList = xmlNode.SelectNodes("basketId");
            
            foreach (XmlNode item in basketIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketIdIDRef = item.Attributes["id"].Name;
                        List<BasketId> ob = new List<BasketId>();
                        ob.Add(new BasketId(item));
                        IDManager.SetID(basketIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    basketId.Add(new BasketId(item));
                    }
                }
            }
            
        
            XmlNodeList referencePoolNodeList = xmlNode.SelectNodes("referencePool");
            if (referencePoolNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referencePoolNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referencePoolIDRef = item.Attributes["id"].Name;
                        ReferencePool ob = ReferencePool();
                        IDManager.SetID(referencePoolIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referencePoolIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referencePool = new ReferencePool(item);
                    }
                }
            }
            
        
            XmlNodeList nthToDefaultNodeList = xmlNode.SelectNodes("nthToDefault");
            if (nthToDefaultNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nthToDefaultNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nthToDefaultIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(nthToDefaultIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nthToDefaultIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nthToDefault = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList mthToDefaultNodeList = xmlNode.SelectNodes("mthToDefault");
            if (mthToDefaultNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mthToDefaultNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mthToDefaultIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(mthToDefaultIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mthToDefaultIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mthToDefault = new XsdTypePositiveInteger(item);
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
            
        
        }
        
    
        #region BasketName
        private BasketName basketName;
        public BasketName BasketName
        {
            get
            {
                if (this.basketName != null)
                {
                    return this.basketName; 
                }
                else if (this.basketNameIDRef != null)
                {
                    basketName = IDManager.getID(basketNameIDRef) as BasketName;
                    return this.basketName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketName != value)
                {
                    this.basketName = value;
                }
            }
        }
        #endregion
        
        public string BasketNameIDRef { get; set; }
        #region BasketId
        private List<BasketId> basketId;
        public List<BasketId> BasketId
        {
            get
            {
                if (this.basketId != null)
                {
                    return this.basketId; 
                }
                else if (this.basketIdIDRef != null)
                {
                    basketId = IDManager.getID(basketIdIDRef) as List<BasketId>;
                    return this.basketId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketId != value)
                {
                    this.basketId = value;
                }
            }
        }
        #endregion
        
        public string BasketIdIDRef { get; set; }
        #region ReferencePool
        private ReferencePool referencePool;
        public ReferencePool ReferencePool
        {
            get
            {
                if (this.referencePool != null)
                {
                    return this.referencePool; 
                }
                else if (this.referencePoolIDRef != null)
                {
                    referencePool = IDManager.getID(referencePoolIDRef) as ReferencePool;
                    return this.referencePool; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referencePool != value)
                {
                    this.referencePool = value;
                }
            }
        }
        #endregion
        
        public string ReferencePoolIDRef { get; set; }
        #region NthToDefault
        private XsdTypePositiveInteger nthToDefault;
        public XsdTypePositiveInteger NthToDefault
        {
            get
            {
                if (this.nthToDefault != null)
                {
                    return this.nthToDefault; 
                }
                else if (this.nthToDefaultIDRef != null)
                {
                    nthToDefault = IDManager.getID(nthToDefaultIDRef) as XsdTypePositiveInteger;
                    return this.nthToDefault; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nthToDefault != value)
                {
                    this.nthToDefault = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region MthToDefault
        private XsdTypePositiveInteger mthToDefault;
        public XsdTypePositiveInteger MthToDefault
        {
            get
            {
                if (this.mthToDefault != null)
                {
                    return this.mthToDefault; 
                }
                else if (this.mthToDefaultIDRef != null)
                {
                    mthToDefault = IDManager.getID(mthToDefaultIDRef) as XsdTypePositiveInteger;
                    return this.mthToDefault; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mthToDefault != value)
                {
                    this.mthToDefault = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

