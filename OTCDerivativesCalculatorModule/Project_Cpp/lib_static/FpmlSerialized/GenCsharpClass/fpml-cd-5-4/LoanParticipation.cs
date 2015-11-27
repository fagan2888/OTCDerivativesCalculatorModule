using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class LoanParticipation
    {
        public LoanParticipation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList qualifyingParticipationSellerNodeList = xmlNode.SelectNodes("qualifyingParticipationSeller");
            if (qualifyingParticipationSellerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in qualifyingParticipationSellerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        qualifyingParticipationSellerIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(qualifyingParticipationSellerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        qualifyingParticipationSellerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        qualifyingParticipationSeller = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region QualifyingParticipationSeller
        private XsdTypeString qualifyingParticipationSeller;
        public XsdTypeString QualifyingParticipationSeller
        {
            get
            {
                if (this.qualifyingParticipationSeller != null)
                {
                    return this.qualifyingParticipationSeller; 
                }
                else if (this.qualifyingParticipationSellerIDRef != null)
                {
                    qualifyingParticipationSeller = IDManager.getID(qualifyingParticipationSellerIDRef) as XsdTypeString;
                    return this.qualifyingParticipationSeller; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.qualifyingParticipationSeller != value)
                {
                    this.qualifyingParticipationSeller = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

