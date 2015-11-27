using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdditionalFixedPayments
    {
        public AdditionalFixedPayments(XmlNode xmlNode)
        {
            XmlNodeList interestShortfallReimbursementNodeList = xmlNode.SelectNodes("interestShortfallReimbursement");
            if (interestShortfallReimbursementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestShortfallReimbursementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestShortfallReimbursementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(interestShortfallReimbursementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestShortfallReimbursementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestShortfallReimbursement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList principalShortfallReimbursementNodeList = xmlNode.SelectNodes("principalShortfallReimbursement");
            if (principalShortfallReimbursementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalShortfallReimbursementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalShortfallReimbursementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(principalShortfallReimbursementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalShortfallReimbursementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalShortfallReimbursement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList writedownReimbursementNodeList = xmlNode.SelectNodes("writedownReimbursement");
            if (writedownReimbursementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in writedownReimbursementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        writedownReimbursementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(writedownReimbursementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        writedownReimbursementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        writedownReimbursement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region InterestShortfallReimbursement
        private XsdTypeBoolean interestShortfallReimbursement;
        public XsdTypeBoolean InterestShortfallReimbursement
        {
            get
            {
                if (this.interestShortfallReimbursement != null)
                {
                    return this.interestShortfallReimbursement; 
                }
                else if (this.interestShortfallReimbursementIDRef != null)
                {
                    interestShortfallReimbursement = IDManager.getID(interestShortfallReimbursementIDRef) as XsdTypeBoolean;
                    return this.interestShortfallReimbursement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestShortfallReimbursement != value)
                {
                    this.interestShortfallReimbursement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PrincipalShortfallReimbursement
        private XsdTypeBoolean principalShortfallReimbursement;
        public XsdTypeBoolean PrincipalShortfallReimbursement
        {
            get
            {
                if (this.principalShortfallReimbursement != null)
                {
                    return this.principalShortfallReimbursement; 
                }
                else if (this.principalShortfallReimbursementIDRef != null)
                {
                    principalShortfallReimbursement = IDManager.getID(principalShortfallReimbursementIDRef) as XsdTypeBoolean;
                    return this.principalShortfallReimbursement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalShortfallReimbursement != value)
                {
                    this.principalShortfallReimbursement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region WritedownReimbursement
        private XsdTypeBoolean writedownReimbursement;
        public XsdTypeBoolean WritedownReimbursement
        {
            get
            {
                if (this.writedownReimbursement != null)
                {
                    return this.writedownReimbursement; 
                }
                else if (this.writedownReimbursementIDRef != null)
                {
                    writedownReimbursement = IDManager.getID(writedownReimbursementIDRef) as XsdTypeBoolean;
                    return this.writedownReimbursement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.writedownReimbursement != value)
                {
                    this.writedownReimbursement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

