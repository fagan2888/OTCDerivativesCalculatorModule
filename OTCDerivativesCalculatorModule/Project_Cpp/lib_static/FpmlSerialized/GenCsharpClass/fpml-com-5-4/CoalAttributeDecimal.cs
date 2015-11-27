using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalAttributeDecimal
    {
        public CoalAttributeDecimal(XmlNode xmlNode)
        {
            XmlNodeList standardContentNodeList = xmlNode.SelectNodes("standardContent");
            if (standardContentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardContentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardContentIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(standardContentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardContentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardContent = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList rejectionLimitNodeList = xmlNode.SelectNodes("rejectionLimit");
            if (rejectionLimitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rejectionLimitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rejectionLimitIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(rejectionLimitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rejectionLimitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rejectionLimit = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardContent
        private XsdTypeDecimal standardContent;
        public XsdTypeDecimal StandardContent
        {
            get
            {
                if (this.standardContent != null)
                {
                    return this.standardContent; 
                }
                else if (this.standardContentIDRef != null)
                {
                    standardContent = IDManager.getID(standardContentIDRef) as XsdTypeDecimal;
                    return this.standardContent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardContent != value)
                {
                    this.standardContent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RejectionLimit
        private XsdTypeDecimal rejectionLimit;
        public XsdTypeDecimal RejectionLimit
        {
            get
            {
                if (this.rejectionLimit != null)
                {
                    return this.rejectionLimit; 
                }
                else if (this.rejectionLimitIDRef != null)
                {
                    rejectionLimit = IDManager.getID(rejectionLimitIDRef) as XsdTypeDecimal;
                    return this.rejectionLimit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rejectionLimit != value)
                {
                    this.rejectionLimit = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

