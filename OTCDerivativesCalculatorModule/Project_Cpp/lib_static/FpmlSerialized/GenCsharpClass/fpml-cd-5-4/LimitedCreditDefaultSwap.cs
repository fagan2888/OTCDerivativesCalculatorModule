using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LimitedCreditDefaultSwap
    {
        public LimitedCreditDefaultSwap(XmlNode xmlNode)
        {
            XmlNodeList generalTermsNodeList = xmlNode.SelectNodes("generalTerms");
            if (generalTermsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in generalTermsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        generalTermsIDRef = item.Attributes["id"].Name;
                        GeneralTerms ob = GeneralTerms();
                        IDManager.SetID(generalTermsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        generalTermsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        generalTerms = new GeneralTerms(item);
                    }
                }
            }
            
        
            XmlNodeList feeLegNodeList = xmlNode.SelectNodes("feeLeg");
            if (feeLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feeLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feeLegIDRef = item.Attributes["id"].Name;
                        FeeLeg ob = FeeLeg();
                        IDManager.SetID(feeLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feeLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feeLeg = new FeeLeg(item);
                    }
                }
            }
            
        
            XmlNodeList protectionTermsNodeList = xmlNode.SelectNodes("protectionTerms");
            
            foreach (XmlNode item in protectionTermsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        protectionTermsIDRef = item.Attributes["id"].Name;
                        List<ProtectionTerms> ob = new List<ProtectionTerms>();
                        ob.Add(new ProtectionTerms(item));
                        IDManager.SetID(protectionTermsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        protectionTermsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    protectionTerms.Add(new ProtectionTerms(item));
                    }
                }
            }
            
        
        }
        
    
        #region GeneralTerms
        private GeneralTerms generalTerms;
        public GeneralTerms GeneralTerms
        {
            get
            {
                if (this.generalTerms != null)
                {
                    return this.generalTerms; 
                }
                else if (this.generalTermsIDRef != null)
                {
                    generalTerms = IDManager.getID(generalTermsIDRef) as GeneralTerms;
                    return this.generalTerms; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.generalTerms != value)
                {
                    this.generalTerms = value;
                }
            }
        }
        #endregion
        
        public string GeneralTermsIDRef { get; set; }
        #region FeeLeg
        private FeeLeg feeLeg;
        public FeeLeg FeeLeg
        {
            get
            {
                if (this.feeLeg != null)
                {
                    return this.feeLeg; 
                }
                else if (this.feeLegIDRef != null)
                {
                    feeLeg = IDManager.getID(feeLegIDRef) as FeeLeg;
                    return this.feeLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feeLeg != value)
                {
                    this.feeLeg = value;
                }
            }
        }
        #endregion
        
        public string FeeLegIDRef { get; set; }
        #region ProtectionTerms
        private List<ProtectionTerms> protectionTerms;
        public List<ProtectionTerms> ProtectionTerms
        {
            get
            {
                if (this.protectionTerms != null)
                {
                    return this.protectionTerms; 
                }
                else if (this.protectionTermsIDRef != null)
                {
                    protectionTerms = IDManager.getID(protectionTermsIDRef) as List<ProtectionTerms>;
                    return this.protectionTerms; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.protectionTerms != value)
                {
                    this.protectionTerms = value;
                }
            }
        }
        #endregion
        
        public string ProtectionTermsIDRef { get; set; }
        
    
        
    
    }
    
}

