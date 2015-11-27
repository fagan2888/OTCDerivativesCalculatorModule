using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class LimitedCreditDefaultSwap : ISerialized
    {
        public LimitedCreditDefaultSwap(XmlNode xmlNode)
        {
            XmlNode generalTermsNode = xmlNode.SelectSingleNode("generalTerms");
            
            if (generalTermsNode != null)
            {
                if (generalTermsNode.Attributes["href"] != null || generalTermsNode.Attributes["id"] != null) 
                {
                    if (generalTermsNode.Attributes["id"] != null) 
                    {
                        generalTermsIDRef_ = generalTermsNode.Attributes["id"].Value;
                        GeneralTerms ob = new GeneralTerms(generalTermsNode);
                        IDManager.SetID(generalTermsIDRef_, ob);
                    }
                    else if (generalTermsNode.Attributes["href"] != null)
                    {
                        generalTermsIDRef_ = generalTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generalTerms_ = new GeneralTerms(generalTermsNode);
                    }
                }
                else
                {
                    generalTerms_ = new GeneralTerms(generalTermsNode);
                }
            }
            
        
            XmlNode feeLegNode = xmlNode.SelectSingleNode("feeLeg");
            
            if (feeLegNode != null)
            {
                if (feeLegNode.Attributes["href"] != null || feeLegNode.Attributes["id"] != null) 
                {
                    if (feeLegNode.Attributes["id"] != null) 
                    {
                        feeLegIDRef_ = feeLegNode.Attributes["id"].Value;
                        FeeLeg ob = new FeeLeg(feeLegNode);
                        IDManager.SetID(feeLegIDRef_, ob);
                    }
                    else if (feeLegNode.Attributes["href"] != null)
                    {
                        feeLegIDRef_ = feeLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeLeg_ = new FeeLeg(feeLegNode);
                    }
                }
                else
                {
                    feeLeg_ = new FeeLeg(feeLegNode);
                }
            }
            
        
            XmlNodeList protectionTermsNodeList = xmlNode.SelectNodes("protectionTerms");
            
            if (protectionTermsNodeList != null)
            {
                this.protectionTerms_ = new List<ProtectionTerms>();
                foreach (XmlNode item in protectionTermsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            protectionTermsIDRef_ = item.Attributes["id"].Value;
                            protectionTerms_.Add(new ProtectionTerms(item));
                            IDManager.SetID(protectionTermsIDRef_, protectionTerms_[protectionTerms_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            protectionTermsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        protectionTerms_.Add(new ProtectionTerms(item));
                        }
                    }
                    else
                    {
                        protectionTerms_.Add(new ProtectionTerms(item));
                    }
                }
            }
            
        
        }
        
    
        #region GeneralTerms_
        private GeneralTerms generalTerms_;
        public GeneralTerms GeneralTerms_
        {
            get
            {
                if (this.generalTerms_ != null)
                {
                    return this.generalTerms_; 
                }
                else if (this.generalTermsIDRef_ != null)
                {
                    generalTerms_ = IDManager.getID(generalTermsIDRef_) as GeneralTerms;
                    return this.generalTerms_; 
                }
                else
                {
                      return this.generalTerms_; 
                }
            }
            set
            {
                if (this.generalTerms_ != value)
                {
                    this.generalTerms_ = value;
                }
            }
        }
        #endregion
        
        public string generalTermsIDRef_ { get; set; }
        #region FeeLeg_
        private FeeLeg feeLeg_;
        public FeeLeg FeeLeg_
        {
            get
            {
                if (this.feeLeg_ != null)
                {
                    return this.feeLeg_; 
                }
                else if (this.feeLegIDRef_ != null)
                {
                    feeLeg_ = IDManager.getID(feeLegIDRef_) as FeeLeg;
                    return this.feeLeg_; 
                }
                else
                {
                      return this.feeLeg_; 
                }
            }
            set
            {
                if (this.feeLeg_ != value)
                {
                    this.feeLeg_ = value;
                }
            }
        }
        #endregion
        
        public string feeLegIDRef_ { get; set; }
        #region ProtectionTerms_
        private List<ProtectionTerms> protectionTerms_;
        public List<ProtectionTerms> ProtectionTerms_
        {
            get
            {
                if (this.protectionTerms_ != null)
                {
                    return this.protectionTerms_; 
                }
                else if (this.protectionTermsIDRef_ != null)
                {
                    return this.protectionTerms_; 
                }
                else
                {
                      return this.protectionTerms_; 
                }
            }
            set
            {
                if (this.protectionTerms_ != value)
                {
                    this.protectionTerms_ = value;
                }
            }
        }
        #endregion
        
        public string protectionTermsIDRef_ { get; set; }
        
    
        
    
    }
    
}

