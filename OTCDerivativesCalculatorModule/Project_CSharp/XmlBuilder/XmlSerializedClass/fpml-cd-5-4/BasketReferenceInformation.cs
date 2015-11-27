using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BasketReferenceInformation : ISerialized
    {
        public BasketReferenceInformation(XmlNode xmlNode)
        {
            XmlNode basketNameNode = xmlNode.SelectSingleNode("basketName");
            
            if (basketNameNode != null)
            {
                if (basketNameNode.Attributes["href"] != null || basketNameNode.Attributes["id"] != null) 
                {
                    if (basketNameNode.Attributes["id"] != null) 
                    {
                        basketNameIDRef_ = basketNameNode.Attributes["id"].Value;
                        BasketName ob = new BasketName(basketNameNode);
                        IDManager.SetID(basketNameIDRef_, ob);
                    }
                    else if (basketNameNode.Attributes["href"] != null)
                    {
                        basketNameIDRef_ = basketNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketName_ = new BasketName(basketNameNode);
                    }
                }
                else
                {
                    basketName_ = new BasketName(basketNameNode);
                }
            }
            
        
            XmlNodeList basketIdNodeList = xmlNode.SelectNodes("basketId");
            
            if (basketIdNodeList != null)
            {
                this.basketId_ = new List<BasketId>();
                foreach (XmlNode item in basketIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            basketIdIDRef_ = item.Attributes["id"].Value;
                            basketId_.Add(new BasketId(item));
                            IDManager.SetID(basketIdIDRef_, basketId_[basketId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            basketIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        basketId_.Add(new BasketId(item));
                        }
                    }
                    else
                    {
                        basketId_.Add(new BasketId(item));
                    }
                }
            }
            
        
            XmlNode referencePoolNode = xmlNode.SelectSingleNode("referencePool");
            
            if (referencePoolNode != null)
            {
                if (referencePoolNode.Attributes["href"] != null || referencePoolNode.Attributes["id"] != null) 
                {
                    if (referencePoolNode.Attributes["id"] != null) 
                    {
                        referencePoolIDRef_ = referencePoolNode.Attributes["id"].Value;
                        ReferencePool ob = new ReferencePool(referencePoolNode);
                        IDManager.SetID(referencePoolIDRef_, ob);
                    }
                    else if (referencePoolNode.Attributes["href"] != null)
                    {
                        referencePoolIDRef_ = referencePoolNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referencePool_ = new ReferencePool(referencePoolNode);
                    }
                }
                else
                {
                    referencePool_ = new ReferencePool(referencePoolNode);
                }
            }
            
        
            XmlNode nthToDefaultNode = xmlNode.SelectSingleNode("nthToDefault");
            
            if (nthToDefaultNode != null)
            {
                if (nthToDefaultNode.Attributes["href"] != null || nthToDefaultNode.Attributes["id"] != null) 
                {
                    if (nthToDefaultNode.Attributes["id"] != null) 
                    {
                        nthToDefaultIDRef_ = nthToDefaultNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(nthToDefaultNode);
                        IDManager.SetID(nthToDefaultIDRef_, ob);
                    }
                    else if (nthToDefaultNode.Attributes["href"] != null)
                    {
                        nthToDefaultIDRef_ = nthToDefaultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nthToDefault_ = new XsdTypePositiveInteger(nthToDefaultNode);
                    }
                }
                else
                {
                    nthToDefault_ = new XsdTypePositiveInteger(nthToDefaultNode);
                }
            }
            
        
            XmlNode mthToDefaultNode = xmlNode.SelectSingleNode("mthToDefault");
            
            if (mthToDefaultNode != null)
            {
                if (mthToDefaultNode.Attributes["href"] != null || mthToDefaultNode.Attributes["id"] != null) 
                {
                    if (mthToDefaultNode.Attributes["id"] != null) 
                    {
                        mthToDefaultIDRef_ = mthToDefaultNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(mthToDefaultNode);
                        IDManager.SetID(mthToDefaultIDRef_, ob);
                    }
                    else if (mthToDefaultNode.Attributes["href"] != null)
                    {
                        mthToDefaultIDRef_ = mthToDefaultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mthToDefault_ = new XsdTypePositiveInteger(mthToDefaultNode);
                    }
                }
                else
                {
                    mthToDefault_ = new XsdTypePositiveInteger(mthToDefaultNode);
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
            
        
        }
        
    
        #region BasketName_
        private BasketName basketName_;
        public BasketName BasketName_
        {
            get
            {
                if (this.basketName_ != null)
                {
                    return this.basketName_; 
                }
                else if (this.basketNameIDRef_ != null)
                {
                    basketName_ = IDManager.getID(basketNameIDRef_) as BasketName;
                    return this.basketName_; 
                }
                else
                {
                      return this.basketName_; 
                }
            }
            set
            {
                if (this.basketName_ != value)
                {
                    this.basketName_ = value;
                }
            }
        }
        #endregion
        
        public string basketNameIDRef_ { get; set; }
        #region BasketId_
        private List<BasketId> basketId_;
        public List<BasketId> BasketId_
        {
            get
            {
                if (this.basketId_ != null)
                {
                    return this.basketId_; 
                }
                else if (this.basketIdIDRef_ != null)
                {
                    return this.basketId_; 
                }
                else
                {
                      return this.basketId_; 
                }
            }
            set
            {
                if (this.basketId_ != value)
                {
                    this.basketId_ = value;
                }
            }
        }
        #endregion
        
        public string basketIdIDRef_ { get; set; }
        #region ReferencePool_
        private ReferencePool referencePool_;
        public ReferencePool ReferencePool_
        {
            get
            {
                if (this.referencePool_ != null)
                {
                    return this.referencePool_; 
                }
                else if (this.referencePoolIDRef_ != null)
                {
                    referencePool_ = IDManager.getID(referencePoolIDRef_) as ReferencePool;
                    return this.referencePool_; 
                }
                else
                {
                      return this.referencePool_; 
                }
            }
            set
            {
                if (this.referencePool_ != value)
                {
                    this.referencePool_ = value;
                }
            }
        }
        #endregion
        
        public string referencePoolIDRef_ { get; set; }
        #region NthToDefault_
        private XsdTypePositiveInteger nthToDefault_;
        public XsdTypePositiveInteger NthToDefault_
        {
            get
            {
                if (this.nthToDefault_ != null)
                {
                    return this.nthToDefault_; 
                }
                else if (this.nthToDefaultIDRef_ != null)
                {
                    nthToDefault_ = IDManager.getID(nthToDefaultIDRef_) as XsdTypePositiveInteger;
                    return this.nthToDefault_; 
                }
                else
                {
                      return this.nthToDefault_; 
                }
            }
            set
            {
                if (this.nthToDefault_ != value)
                {
                    this.nthToDefault_ = value;
                }
            }
        }
        #endregion
        
        public string nthToDefaultIDRef_ { get; set; }
        #region MthToDefault_
        private XsdTypePositiveInteger mthToDefault_;
        public XsdTypePositiveInteger MthToDefault_
        {
            get
            {
                if (this.mthToDefault_ != null)
                {
                    return this.mthToDefault_; 
                }
                else if (this.mthToDefaultIDRef_ != null)
                {
                    mthToDefault_ = IDManager.getID(mthToDefaultIDRef_) as XsdTypePositiveInteger;
                    return this.mthToDefault_; 
                }
                else
                {
                      return this.mthToDefault_; 
                }
            }
            set
            {
                if (this.mthToDefault_ != value)
                {
                    this.mthToDefault_ = value;
                }
            }
        }
        #endregion
        
        public string mthToDefaultIDRef_ { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

