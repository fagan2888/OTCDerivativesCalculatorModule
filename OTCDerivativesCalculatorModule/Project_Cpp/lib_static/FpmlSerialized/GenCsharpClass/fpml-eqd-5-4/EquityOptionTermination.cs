using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityOptionTermination
    {
        public EquityOptionTermination(XmlNode xmlNode)
        {
            XmlNodeList settlementAmountPaymentDateNodeList = xmlNode.SelectNodes("settlementAmountPaymentDate");
            if (settlementAmountPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementAmountPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementAmountPaymentDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(settlementAmountPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementAmountPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementAmountPaymentDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList settlementAmountNodeList = xmlNode.SelectNodes("settlementAmount");
            if (settlementAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(settlementAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementAmountPaymentDate
        private AdjustableDate settlementAmountPaymentDate;
        public AdjustableDate SettlementAmountPaymentDate
        {
            get
            {
                if (this.settlementAmountPaymentDate != null)
                {
                    return this.settlementAmountPaymentDate; 
                }
                else if (this.settlementAmountPaymentDateIDRef != null)
                {
                    settlementAmountPaymentDate = IDManager.getID(settlementAmountPaymentDateIDRef) as AdjustableDate;
                    return this.settlementAmountPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementAmountPaymentDate != value)
                {
                    this.settlementAmountPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region SettlementAmount
        private NonNegativeMoney settlementAmount;
        public NonNegativeMoney SettlementAmount
        {
            get
            {
                if (this.settlementAmount != null)
                {
                    return this.settlementAmount; 
                }
                else if (this.settlementAmountIDRef != null)
                {
                    settlementAmount = IDManager.getID(settlementAmountIDRef) as NonNegativeMoney;
                    return this.settlementAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementAmount != value)
                {
                    this.settlementAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        
    
        
    
    }
    
}

