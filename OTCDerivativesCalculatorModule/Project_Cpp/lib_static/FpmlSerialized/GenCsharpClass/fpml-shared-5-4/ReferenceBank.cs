using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferenceBank
    {
        public ReferenceBank(XmlNode xmlNode)
        {
            XmlNodeList referenceBankIdNodeList = xmlNode.SelectNodes("referenceBankId");
            if (referenceBankIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceBankIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceBankIdIDRef = item.Attributes["id"].Name;
                        ReferenceBankId ob = ReferenceBankId();
                        IDManager.SetID(referenceBankIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceBankIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceBankId = new ReferenceBankId(item);
                    }
                }
            }
            
        
            XmlNodeList referenceBankNameNodeList = xmlNode.SelectNodes("referenceBankName");
            if (referenceBankNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceBankNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceBankNameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(referenceBankNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceBankNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceBankName = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceBankId
        private ReferenceBankId referenceBankId;
        public ReferenceBankId ReferenceBankId
        {
            get
            {
                if (this.referenceBankId != null)
                {
                    return this.referenceBankId; 
                }
                else if (this.referenceBankIdIDRef != null)
                {
                    referenceBankId = IDManager.getID(referenceBankIdIDRef) as ReferenceBankId;
                    return this.referenceBankId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceBankId != value)
                {
                    this.referenceBankId = value;
                }
            }
        }
        #endregion
        
        public string ReferenceBankIdIDRef { get; set; }
        #region ReferenceBankName
        private XsdTypeString referenceBankName;
        public XsdTypeString ReferenceBankName
        {
            get
            {
                if (this.referenceBankName != null)
                {
                    return this.referenceBankName; 
                }
                else if (this.referenceBankNameIDRef != null)
                {
                    referenceBankName = IDManager.getID(referenceBankNameIDRef) as XsdTypeString;
                    return this.referenceBankName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceBankName != value)
                {
                    this.referenceBankName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

