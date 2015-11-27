using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Future
    {
        public Future(XmlNode xmlNode)
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
            
        
            XmlNodeList futureContractReferenceNodeList = xmlNode.SelectNodes("futureContractReference");
            if (futureContractReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in futureContractReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        futureContractReferenceIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(futureContractReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        futureContractReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        futureContractReference = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList maturityNodeList = xmlNode.SelectNodes("maturity");
            if (maturityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maturityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maturityIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(maturityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maturityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maturity = new XsdTypeDate(item);
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
        #region FutureContractReference
        private XsdTypeString futureContractReference;
        public XsdTypeString FutureContractReference
        {
            get
            {
                if (this.futureContractReference != null)
                {
                    return this.futureContractReference; 
                }
                else if (this.futureContractReferenceIDRef != null)
                {
                    futureContractReference = IDManager.getID(futureContractReferenceIDRef) as XsdTypeString;
                    return this.futureContractReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.futureContractReference != value)
                {
                    this.futureContractReference = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region Maturity
        private XsdTypeDate maturity;
        public XsdTypeDate Maturity
        {
            get
            {
                if (this.maturity != null)
                {
                    return this.maturity; 
                }
                else if (this.maturityIDRef != null)
                {
                    maturity = IDManager.getID(maturityIDRef) as XsdTypeDate;
                    return this.maturity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maturity != value)
                {
                    this.maturity = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

