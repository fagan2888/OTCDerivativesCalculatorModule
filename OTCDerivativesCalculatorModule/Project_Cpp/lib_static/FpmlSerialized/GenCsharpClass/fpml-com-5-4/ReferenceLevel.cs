using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferenceLevel
    {
        public ReferenceLevel(XmlNode xmlNode)
        {
            XmlNodeList amountNodeList = xmlNode.SelectNodes("amount");
            if (amountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList referenceLevelUnitNodeList = xmlNode.SelectNodes("referenceLevelUnit");
            if (referenceLevelUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceLevelUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceLevelUnitIDRef = item.Attributes["id"].Name;
                        ReferenceLevelUnit ob = ReferenceLevelUnit();
                        IDManager.SetID(referenceLevelUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceLevelUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceLevelUnit = new ReferenceLevelUnit(item);
                    }
                }
            }
            
        
        }
        
    
        #region Amount
        private XsdTypeDecimal amount;
        public XsdTypeDecimal Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as XsdTypeDecimal;
                    return this.amount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ReferenceLevelUnit
        private ReferenceLevelUnit referenceLevelUnit;
        public ReferenceLevelUnit ReferenceLevelUnit
        {
            get
            {
                if (this.referenceLevelUnit != null)
                {
                    return this.referenceLevelUnit; 
                }
                else if (this.referenceLevelUnitIDRef != null)
                {
                    referenceLevelUnit = IDManager.getID(referenceLevelUnitIDRef) as ReferenceLevelUnit;
                    return this.referenceLevelUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceLevelUnit != value)
                {
                    this.referenceLevelUnit = value;
                }
            }
        }
        #endregion
        
        public string ReferenceLevelUnitIDRef { get; set; }
        
    
        
    
    }
    
}

