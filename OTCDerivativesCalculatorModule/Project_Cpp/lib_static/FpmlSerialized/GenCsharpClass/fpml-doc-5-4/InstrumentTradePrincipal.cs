using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradePrincipal
    {
        public InstrumentTradePrincipal(XmlNode xmlNode)
        {
            XmlNodeList principalAmountNodeList = xmlNode.SelectNodes("principalAmount");
            if (principalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalAmountIDRef = item.Attributes["id"].Name;
                        NetAndGross ob = NetAndGross();
                        IDManager.SetID(principalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalAmount = new NetAndGross(item);
                    }
                }
            }
            
        
        }
        
    
        #region PrincipalAmount
        private NetAndGross principalAmount;
        public NetAndGross PrincipalAmount
        {
            get
            {
                if (this.principalAmount != null)
                {
                    return this.principalAmount; 
                }
                else if (this.principalAmountIDRef != null)
                {
                    principalAmount = IDManager.getID(principalAmountIDRef) as NetAndGross;
                    return this.principalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalAmount != value)
                {
                    this.principalAmount = value;
                }
            }
        }
        #endregion
        
        public string NetAndGrossIDRef { get; set; }
        
    
        
    
    }
    
}

