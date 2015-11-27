using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingDataPointCoordinate
    {
        public PricingDataPointCoordinate(XmlNode xmlNode)
        {
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        TimeDimension ob = TimeDimension();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new TimeDimension(item);
                    }
                }
            }
            
        
            XmlNodeList expirationNodeList = xmlNode.SelectNodes("expiration");
            if (expirationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationIDRef = item.Attributes["id"].Name;
                        TimeDimension ob = TimeDimension();
                        IDManager.SetID(expirationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiration = new TimeDimension(item);
                    }
                }
            }
            
        
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList genericNodeList = xmlNode.SelectNodes("generic");
            if (genericNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in genericNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        genericIDRef = item.Attributes["id"].Name;
                        GenericDimension ob = GenericDimension();
                        IDManager.SetID(genericIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        genericIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        generic = new GenericDimension(item);
                    }
                }
            }
            
        
        }
        
    
        #region Term
        private TimeDimension term;
        public TimeDimension Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as TimeDimension;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string TimeDimensionIDRef { get; set; }
        #region Expiration
        private TimeDimension expiration;
        public TimeDimension Expiration
        {
            get
            {
                if (this.expiration != null)
                {
                    return this.expiration; 
                }
                else if (this.expirationIDRef != null)
                {
                    expiration = IDManager.getID(expirationIDRef) as TimeDimension;
                    return this.expiration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiration != value)
                {
                    this.expiration = value;
                }
            }
        }
        #endregion
        
        public string TimeDimensionIDRef { get; set; }
        #region Strike
        private XsdTypeDecimal strike;
        public XsdTypeDecimal Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as XsdTypeDecimal;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Generic
        private GenericDimension generic;
        public GenericDimension Generic
        {
            get
            {
                if (this.generic != null)
                {
                    return this.generic; 
                }
                else if (this.genericIDRef != null)
                {
                    generic = IDManager.getID(genericIDRef) as GenericDimension;
                    return this.generic; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.generic != value)
                {
                    this.generic = value;
                }
            }
        }
        #endregion
        
        public string GenericDimensionIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

