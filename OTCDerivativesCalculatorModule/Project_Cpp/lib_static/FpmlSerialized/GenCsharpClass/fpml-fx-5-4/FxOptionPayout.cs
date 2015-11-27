using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxOptionPayout
    {
        public FxOptionPayout(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList payoutStyleNodeList = xmlNode.SelectNodes("payoutStyle");
            if (payoutStyleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payoutStyleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payoutStyleIDRef = item.Attributes["id"].Name;
                        PayoutEnum ob = PayoutEnum();
                        IDManager.SetID(payoutStyleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payoutStyleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payoutStyle = new PayoutEnum(item);
                    }
                }
            }
            
        
            XmlNodeList settlementInformationNodeList = xmlNode.SelectNodes("settlementInformation");
            if (settlementInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef = item.Attributes["id"].Name;
                        SettlementInformation ob = SettlementInformation();
                        IDManager.SetID(settlementInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementInformation = new SettlementInformation(item);
                    }
                }
            }
            
        
        }
        
    
        #region PayoutStyle
        private PayoutEnum payoutStyle;
        public PayoutEnum PayoutStyle
        {
            get
            {
                if (this.payoutStyle != null)
                {
                    return this.payoutStyle; 
                }
                else if (this.payoutStyleIDRef != null)
                {
                    payoutStyle = IDManager.getID(payoutStyleIDRef) as PayoutEnum;
                    return this.payoutStyle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payoutStyle != value)
                {
                    this.payoutStyle = value;
                }
            }
        }
        #endregion
        
        public string PayoutEnumIDRef { get; set; }
        #region SettlementInformation
        private SettlementInformation settlementInformation;
        public SettlementInformation SettlementInformation
        {
            get
            {
                if (this.settlementInformation != null)
                {
                    return this.settlementInformation; 
                }
                else if (this.settlementInformationIDRef != null)
                {
                    settlementInformation = IDManager.getID(settlementInformationIDRef) as SettlementInformation;
                    return this.settlementInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementInformation != value)
                {
                    this.settlementInformation = value;
                }
            }
        }
        #endregion
        
        public string SettlementInformationIDRef { get; set; }
        
    
        
    
    }
    
}

