using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Tranche
    {
        public Tranche(XmlNode xmlNode)
        {
            XmlNodeList attachmentPointNodeList = xmlNode.SelectNodes("attachmentPoint");
            if (attachmentPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in attachmentPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        attachmentPointIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(attachmentPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        attachmentPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        attachmentPoint = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList exhaustionPointNodeList = xmlNode.SelectNodes("exhaustionPoint");
            if (exhaustionPointNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exhaustionPointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exhaustionPointIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(exhaustionPointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exhaustionPointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exhaustionPoint = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList incurredRecoveryApplicableNodeList = xmlNode.SelectNodes("incurredRecoveryApplicable");
            if (incurredRecoveryApplicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in incurredRecoveryApplicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        incurredRecoveryApplicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(incurredRecoveryApplicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        incurredRecoveryApplicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        incurredRecoveryApplicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region AttachmentPoint
        private XsdTypeDecimal attachmentPoint;
        public XsdTypeDecimal AttachmentPoint
        {
            get
            {
                if (this.attachmentPoint != null)
                {
                    return this.attachmentPoint; 
                }
                else if (this.attachmentPointIDRef != null)
                {
                    attachmentPoint = IDManager.getID(attachmentPointIDRef) as XsdTypeDecimal;
                    return this.attachmentPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.attachmentPoint != value)
                {
                    this.attachmentPoint = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ExhaustionPoint
        private XsdTypeDecimal exhaustionPoint;
        public XsdTypeDecimal ExhaustionPoint
        {
            get
            {
                if (this.exhaustionPoint != null)
                {
                    return this.exhaustionPoint; 
                }
                else if (this.exhaustionPointIDRef != null)
                {
                    exhaustionPoint = IDManager.getID(exhaustionPointIDRef) as XsdTypeDecimal;
                    return this.exhaustionPoint; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exhaustionPoint != value)
                {
                    this.exhaustionPoint = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region IncurredRecoveryApplicable
        private XsdTypeBoolean incurredRecoveryApplicable;
        public XsdTypeBoolean IncurredRecoveryApplicable
        {
            get
            {
                if (this.incurredRecoveryApplicable != null)
                {
                    return this.incurredRecoveryApplicable; 
                }
                else if (this.incurredRecoveryApplicableIDRef != null)
                {
                    incurredRecoveryApplicable = IDManager.getID(incurredRecoveryApplicableIDRef) as XsdTypeBoolean;
                    return this.incurredRecoveryApplicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.incurredRecoveryApplicable != value)
                {
                    this.incurredRecoveryApplicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

