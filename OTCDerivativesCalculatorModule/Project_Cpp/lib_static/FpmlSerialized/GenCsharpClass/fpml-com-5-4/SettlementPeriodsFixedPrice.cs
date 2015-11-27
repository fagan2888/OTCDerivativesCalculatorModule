using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementPeriodsFixedPrice
    {
        public SettlementPeriodsFixedPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList settlementPeriodsReferenceNodeList = xmlNode.SelectNodes("settlementPeriodsReference");
            
            foreach (XmlNode item in settlementPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriodsReference> ob = new List<SettlementPeriodsReference>();
                        ob.Add(new SettlementPeriodsReference(item));
                        IDManager.SetID(settlementPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsReference.Add(new SettlementPeriodsReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementPeriodsReference
        private List<SettlementPeriodsReference> settlementPeriodsReference;
        public List<SettlementPeriodsReference> SettlementPeriodsReference
        {
            get
            {
                if (this.settlementPeriodsReference != null)
                {
                    return this.settlementPeriodsReference; 
                }
                else if (this.settlementPeriodsReferenceIDRef != null)
                {
                    settlementPeriodsReference = IDManager.getID(settlementPeriodsReferenceIDRef) as List<SettlementPeriodsReference>;
                    return this.settlementPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsReference != value)
                {
                    this.settlementPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

