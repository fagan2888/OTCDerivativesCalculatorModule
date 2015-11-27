using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxLinkedNotionalAmount
    {
        public FxLinkedNotionalAmount(XmlNode xmlNode)
        {
            XmlNodeList resetDateNodeList = xmlNode.SelectNodes("resetDate");
            if (resetDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(resetDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedFxSpotFixingDateNodeList = xmlNode.SelectNodes("adjustedFxSpotFixingDate");
            if (adjustedFxSpotFixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedFxSpotFixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedFxSpotFixingDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedFxSpotFixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedFxSpotFixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedFxSpotFixingDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList observedFxSpotRateNodeList = xmlNode.SelectNodes("observedFxSpotRate");
            if (observedFxSpotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observedFxSpotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observedFxSpotRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(observedFxSpotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observedFxSpotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observedFxSpotRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region ResetDate
        private XsdTypeDate resetDate;
        public XsdTypeDate ResetDate
        {
            get
            {
                if (this.resetDate != null)
                {
                    return this.resetDate; 
                }
                else if (this.resetDateIDRef != null)
                {
                    resetDate = IDManager.getID(resetDateIDRef) as XsdTypeDate;
                    return this.resetDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetDate != value)
                {
                    this.resetDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedFxSpotFixingDate
        private XsdTypeDate adjustedFxSpotFixingDate;
        public XsdTypeDate AdjustedFxSpotFixingDate
        {
            get
            {
                if (this.adjustedFxSpotFixingDate != null)
                {
                    return this.adjustedFxSpotFixingDate; 
                }
                else if (this.adjustedFxSpotFixingDateIDRef != null)
                {
                    adjustedFxSpotFixingDate = IDManager.getID(adjustedFxSpotFixingDateIDRef) as XsdTypeDate;
                    return this.adjustedFxSpotFixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedFxSpotFixingDate != value)
                {
                    this.adjustedFxSpotFixingDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ObservedFxSpotRate
        private XsdTypeDecimal observedFxSpotRate;
        public XsdTypeDecimal ObservedFxSpotRate
        {
            get
            {
                if (this.observedFxSpotRate != null)
                {
                    return this.observedFxSpotRate; 
                }
                else if (this.observedFxSpotRateIDRef != null)
                {
                    observedFxSpotRate = IDManager.getID(observedFxSpotRateIDRef) as XsdTypeDecimal;
                    return this.observedFxSpotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observedFxSpotRate != value)
                {
                    this.observedFxSpotRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region NotionalAmount
        private XsdTypeDecimal notionalAmount;
        public XsdTypeDecimal NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as XsdTypeDecimal;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

