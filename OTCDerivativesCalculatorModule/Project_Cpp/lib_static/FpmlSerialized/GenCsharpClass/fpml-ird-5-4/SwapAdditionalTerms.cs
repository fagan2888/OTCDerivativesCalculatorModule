using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SwapAdditionalTerms
    {
        public SwapAdditionalTerms(XmlNode xmlNode)
        {
            XmlNodeList bondReferenceNodeList = xmlNode.SelectNodes("bondReference");
            if (bondReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bondReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bondReferenceIDRef = item.Attributes["id"].Name;
                        BondReference ob = BondReference();
                        IDManager.SetID(bondReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bondReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bondReference = new BondReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region BondReference
        private BondReference bondReference;
        public BondReference BondReference
        {
            get
            {
                if (this.bondReference != null)
                {
                    return this.bondReference; 
                }
                else if (this.bondReferenceIDRef != null)
                {
                    bondReference = IDManager.getID(bondReferenceIDRef) as BondReference;
                    return this.bondReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bondReference != value)
                {
                    this.bondReference = value;
                }
            }
        }
        #endregion
        
        public string BondReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

