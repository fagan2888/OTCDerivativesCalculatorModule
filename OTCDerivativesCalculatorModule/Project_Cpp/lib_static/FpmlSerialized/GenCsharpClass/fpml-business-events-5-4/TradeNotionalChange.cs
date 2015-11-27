using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeNotionalChange
    {
        public TradeNotionalChange(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList changeInNotionalAmountNodeList = xmlNode.SelectNodes("changeInNotionalAmount");
            
            foreach (XmlNode item in changeInNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeInNotionalAmountIDRef = item.Attributes["id"].Name;
                        List<NonNegativeMoney> ob = new List<NonNegativeMoney>();
                        ob.Add(new NonNegativeMoney(item));
                        IDManager.SetID(changeInNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeInNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    changeInNotionalAmount.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNodeList outstandingNotionalAmountNodeList = xmlNode.SelectNodes("outstandingNotionalAmount");
            
            foreach (XmlNode item in outstandingNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNotionalAmountIDRef = item.Attributes["id"].Name;
                        List<NonNegativeMoney> ob = new List<NonNegativeMoney>();
                        ob.Add(new NonNegativeMoney(item));
                        IDManager.SetID(outstandingNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    outstandingNotionalAmount.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNodeList changeInNumberOfOptionsNodeList = xmlNode.SelectNodes("changeInNumberOfOptions");
            if (changeInNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in changeInNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeInNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(changeInNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeInNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        changeInNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList outstandingNumberOfOptionsNodeList = xmlNode.SelectNodes("outstandingNumberOfOptions");
            if (outstandingNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in outstandingNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(outstandingNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        outstandingNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList changeInNumberOfUnitsNodeList = xmlNode.SelectNodes("changeInNumberOfUnits");
            if (changeInNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in changeInNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeInNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(changeInNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeInNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        changeInNumberOfUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList outstandingNumberOfUnitsNodeList = xmlNode.SelectNodes("outstandingNumberOfUnits");
            if (outstandingNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in outstandingNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(outstandingNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        outstandingNumberOfUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region ChangeInNotionalAmount
        private List<NonNegativeMoney> changeInNotionalAmount;
        public List<NonNegativeMoney> ChangeInNotionalAmount
        {
            get
            {
                if (this.changeInNotionalAmount != null)
                {
                    return this.changeInNotionalAmount; 
                }
                else if (this.changeInNotionalAmountIDRef != null)
                {
                    changeInNotionalAmount = IDManager.getID(changeInNotionalAmountIDRef) as List<NonNegativeMoney>;
                    return this.changeInNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.changeInNotionalAmount != value)
                {
                    this.changeInNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region OutstandingNotionalAmount
        private List<NonNegativeMoney> outstandingNotionalAmount;
        public List<NonNegativeMoney> OutstandingNotionalAmount
        {
            get
            {
                if (this.outstandingNotionalAmount != null)
                {
                    return this.outstandingNotionalAmount; 
                }
                else if (this.outstandingNotionalAmountIDRef != null)
                {
                    outstandingNotionalAmount = IDManager.getID(outstandingNotionalAmountIDRef) as List<NonNegativeMoney>;
                    return this.outstandingNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNotionalAmount != value)
                {
                    this.outstandingNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region ChangeInNumberOfOptions
        private XsdTypeDecimal changeInNumberOfOptions;
        public XsdTypeDecimal ChangeInNumberOfOptions
        {
            get
            {
                if (this.changeInNumberOfOptions != null)
                {
                    return this.changeInNumberOfOptions; 
                }
                else if (this.changeInNumberOfOptionsIDRef != null)
                {
                    changeInNumberOfOptions = IDManager.getID(changeInNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.changeInNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.changeInNumberOfOptions != value)
                {
                    this.changeInNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region OutstandingNumberOfOptions
        private XsdTypeDecimal outstandingNumberOfOptions;
        public XsdTypeDecimal OutstandingNumberOfOptions
        {
            get
            {
                if (this.outstandingNumberOfOptions != null)
                {
                    return this.outstandingNumberOfOptions; 
                }
                else if (this.outstandingNumberOfOptionsIDRef != null)
                {
                    outstandingNumberOfOptions = IDManager.getID(outstandingNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.outstandingNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNumberOfOptions != value)
                {
                    this.outstandingNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ChangeInNumberOfUnits
        private XsdTypeDecimal changeInNumberOfUnits;
        public XsdTypeDecimal ChangeInNumberOfUnits
        {
            get
            {
                if (this.changeInNumberOfUnits != null)
                {
                    return this.changeInNumberOfUnits; 
                }
                else if (this.changeInNumberOfUnitsIDRef != null)
                {
                    changeInNumberOfUnits = IDManager.getID(changeInNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.changeInNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.changeInNumberOfUnits != value)
                {
                    this.changeInNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region OutstandingNumberOfUnits
        private XsdTypeDecimal outstandingNumberOfUnits;
        public XsdTypeDecimal OutstandingNumberOfUnits
        {
            get
            {
                if (this.outstandingNumberOfUnits != null)
                {
                    return this.outstandingNumberOfUnits; 
                }
                else if (this.outstandingNumberOfUnitsIDRef != null)
                {
                    outstandingNumberOfUnits = IDManager.getID(outstandingNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.outstandingNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNumberOfUnits != value)
                {
                    this.outstandingNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

