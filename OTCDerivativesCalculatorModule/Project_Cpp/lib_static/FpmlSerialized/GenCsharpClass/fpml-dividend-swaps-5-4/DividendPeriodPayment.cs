using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendPeriodPayment
    {
        public DividendPeriodPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList fixedStrikeNodeList = xmlNode.SelectNodes("fixedStrike");
            if (fixedStrikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedStrikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedStrikeIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(fixedStrikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedStrikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedStrike = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateNodeList = xmlNode.SelectNodes("paymentDate");
            if (paymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList valuationDateNodeList = xmlNode.SelectNodes("valuationDate");
            if (valuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(valuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region FixedStrike
        private PositiveDecimal fixedStrike;
        public PositiveDecimal FixedStrike
        {
            get
            {
                if (this.fixedStrike != null)
                {
                    return this.fixedStrike; 
                }
                else if (this.fixedStrikeIDRef != null)
                {
                    fixedStrike = IDManager.getID(fixedStrikeIDRef) as PositiveDecimal;
                    return this.fixedStrike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedStrike != value)
                {
                    this.fixedStrike = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region PaymentDate
        private AdjustableOrRelativeDate paymentDate;
        public AdjustableOrRelativeDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as AdjustableOrRelativeDate;
                    return this.paymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDate != value)
                {
                    this.paymentDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region ValuationDate
        private AdjustableOrRelativeDate valuationDate;
        public AdjustableOrRelativeDate ValuationDate
        {
            get
            {
                if (this.valuationDate != null)
                {
                    return this.valuationDate; 
                }
                else if (this.valuationDateIDRef != null)
                {
                    valuationDate = IDManager.getID(valuationDateIDRef) as AdjustableOrRelativeDate;
                    return this.valuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDate != value)
                {
                    this.valuationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}

