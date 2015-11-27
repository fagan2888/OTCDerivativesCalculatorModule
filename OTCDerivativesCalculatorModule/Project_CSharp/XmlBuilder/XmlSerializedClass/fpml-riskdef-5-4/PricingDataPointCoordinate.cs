using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingDataPointCoordinate : ISerialized
    {
        public PricingDataPointCoordinate(XmlNode xmlNode)
        {
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        TimeDimension ob = new TimeDimension(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new TimeDimension(termNode);
                    }
                }
                else
                {
                    term_ = new TimeDimension(termNode);
                }
            }
            
        
            XmlNode expirationNode = xmlNode.SelectSingleNode("expiration");
            
            if (expirationNode != null)
            {
                if (expirationNode.Attributes["href"] != null || expirationNode.Attributes["id"] != null) 
                {
                    if (expirationNode.Attributes["id"] != null) 
                    {
                        expirationIDRef_ = expirationNode.Attributes["id"].Value;
                        TimeDimension ob = new TimeDimension(expirationNode);
                        IDManager.SetID(expirationIDRef_, ob);
                    }
                    else if (expirationNode.Attributes["href"] != null)
                    {
                        expirationIDRef_ = expirationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiration_ = new TimeDimension(expirationNode);
                    }
                }
                else
                {
                    expiration_ = new TimeDimension(expirationNode);
                }
            }
            
        
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new XsdTypeDecimal(strikeNode);
                    }
                }
                else
                {
                    strike_ = new XsdTypeDecimal(strikeNode);
                }
            }
            
        
            XmlNode genericNode = xmlNode.SelectSingleNode("generic");
            
            if (genericNode != null)
            {
                if (genericNode.Attributes["href"] != null || genericNode.Attributes["id"] != null) 
                {
                    if (genericNode.Attributes["id"] != null) 
                    {
                        genericIDRef_ = genericNode.Attributes["id"].Value;
                        GenericDimension ob = new GenericDimension(genericNode);
                        IDManager.SetID(genericIDRef_, ob);
                    }
                    else if (genericNode.Attributes["href"] != null)
                    {
                        genericIDRef_ = genericNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generic_ = new GenericDimension(genericNode);
                    }
                }
                else
                {
                    generic_ = new GenericDimension(genericNode);
                }
            }
            
        
        }
        
    
        #region Term_
        private TimeDimension term_;
        public TimeDimension Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as TimeDimension;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
        #region Expiration_
        private TimeDimension expiration_;
        public TimeDimension Expiration_
        {
            get
            {
                if (this.expiration_ != null)
                {
                    return this.expiration_; 
                }
                else if (this.expirationIDRef_ != null)
                {
                    expiration_ = IDManager.getID(expirationIDRef_) as TimeDimension;
                    return this.expiration_; 
                }
                else
                {
                      return this.expiration_; 
                }
            }
            set
            {
                if (this.expiration_ != value)
                {
                    this.expiration_ = value;
                }
            }
        }
        #endregion
        
        public string expirationIDRef_ { get; set; }
        #region Strike_
        private XsdTypeDecimal strike_;
        public XsdTypeDecimal Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as XsdTypeDecimal;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        #region Generic_
        private GenericDimension generic_;
        public GenericDimension Generic_
        {
            get
            {
                if (this.generic_ != null)
                {
                    return this.generic_; 
                }
                else if (this.genericIDRef_ != null)
                {
                    generic_ = IDManager.getID(genericIDRef_) as GenericDimension;
                    return this.generic_; 
                }
                else
                {
                      return this.generic_; 
                }
            }
            set
            {
                if (this.generic_ != value)
                {
                    this.generic_ = value;
                }
            }
        }
        #endregion
        
        public string genericIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

