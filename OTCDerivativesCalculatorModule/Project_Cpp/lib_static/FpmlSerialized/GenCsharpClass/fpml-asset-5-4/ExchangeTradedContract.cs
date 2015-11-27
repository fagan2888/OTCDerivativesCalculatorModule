using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedContract
    {
        public ExchangeTradedContract(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList multiplierNodeList = xmlNode.SelectNodes("multiplier");
            if (multiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multiplierIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(multiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multiplier = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList contractReferenceNodeList = xmlNode.SelectNodes("contractReference");
            if (contractReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in contractReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractReferenceIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(contractReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        contractReference = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList expirationDateNodeList = xmlNode.SelectNodes("expirationDate");
            if (expirationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(expirationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region Multiplier
        private XsdTypePositiveInteger multiplier;
        public XsdTypePositiveInteger Multiplier
        {
            get
            {
                if (this.multiplier != null)
                {
                    return this.multiplier; 
                }
                else if (this.multiplierIDRef != null)
                {
                    multiplier = IDManager.getID(multiplierIDRef) as XsdTypePositiveInteger;
                    return this.multiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multiplier != value)
                {
                    this.multiplier = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region ContractReference
        private XsdTypeString contractReference;
        public XsdTypeString ContractReference
        {
            get
            {
                if (this.contractReference != null)
                {
                    return this.contractReference; 
                }
                else if (this.contractReferenceIDRef != null)
                {
                    contractReference = IDManager.getID(contractReferenceIDRef) as XsdTypeString;
                    return this.contractReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractReference != value)
                {
                    this.contractReference = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region ExpirationDate
        private AdjustableOrRelativeDate expirationDate;
        public AdjustableOrRelativeDate ExpirationDate
        {
            get
            {
                if (this.expirationDate != null)
                {
                    return this.expirationDate; 
                }
                else if (this.expirationDateIDRef != null)
                {
                    expirationDate = IDManager.getID(expirationDateIDRef) as AdjustableOrRelativeDate;
                    return this.expirationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDate != value)
                {
                    this.expirationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}

