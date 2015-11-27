using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SwaptionPhysicalSettlement
    {
        public SwaptionPhysicalSettlement(XmlNode xmlNode)
        {
            XmlNodeList clearedPhysicalSettlementNodeList = xmlNode.SelectNodes("clearedPhysicalSettlement");
            if (clearedPhysicalSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearedPhysicalSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearedPhysicalSettlementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(clearedPhysicalSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearedPhysicalSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearedPhysicalSettlement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ClearedPhysicalSettlement
        private XsdTypeBoolean clearedPhysicalSettlement;
        public XsdTypeBoolean ClearedPhysicalSettlement
        {
            get
            {
                if (this.clearedPhysicalSettlement != null)
                {
                    return this.clearedPhysicalSettlement; 
                }
                else if (this.clearedPhysicalSettlementIDRef != null)
                {
                    clearedPhysicalSettlement = IDManager.getID(clearedPhysicalSettlementIDRef) as XsdTypeBoolean;
                    return this.clearedPhysicalSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearedPhysicalSettlement != value)
                {
                    this.clearedPhysicalSettlement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

