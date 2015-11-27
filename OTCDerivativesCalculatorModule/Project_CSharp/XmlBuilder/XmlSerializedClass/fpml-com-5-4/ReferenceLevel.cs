using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceLevel : ISerialized
    {
        public ReferenceLevel(XmlNode xmlNode)
        {
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new XsdTypeDecimal(amountNode);
                    }
                }
                else
                {
                    amount_ = new XsdTypeDecimal(amountNode);
                }
            }
            
        
            XmlNode referenceLevelUnitNode = xmlNode.SelectSingleNode("referenceLevelUnit");
            
            if (referenceLevelUnitNode != null)
            {
                if (referenceLevelUnitNode.Attributes["href"] != null || referenceLevelUnitNode.Attributes["id"] != null) 
                {
                    if (referenceLevelUnitNode.Attributes["id"] != null) 
                    {
                        referenceLevelUnitIDRef_ = referenceLevelUnitNode.Attributes["id"].Value;
                        ReferenceLevelUnit ob = new ReferenceLevelUnit(referenceLevelUnitNode);
                        IDManager.SetID(referenceLevelUnitIDRef_, ob);
                    }
                    else if (referenceLevelUnitNode.Attributes["href"] != null)
                    {
                        referenceLevelUnitIDRef_ = referenceLevelUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceLevelUnit_ = new ReferenceLevelUnit(referenceLevelUnitNode);
                    }
                }
                else
                {
                    referenceLevelUnit_ = new ReferenceLevelUnit(referenceLevelUnitNode);
                }
            }
            
        
        }
        
    
        #region Amount_
        private XsdTypeDecimal amount_;
        public XsdTypeDecimal Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as XsdTypeDecimal;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        #region ReferenceLevelUnit_
        private ReferenceLevelUnit referenceLevelUnit_;
        public ReferenceLevelUnit ReferenceLevelUnit_
        {
            get
            {
                if (this.referenceLevelUnit_ != null)
                {
                    return this.referenceLevelUnit_; 
                }
                else if (this.referenceLevelUnitIDRef_ != null)
                {
                    referenceLevelUnit_ = IDManager.getID(referenceLevelUnitIDRef_) as ReferenceLevelUnit;
                    return this.referenceLevelUnit_; 
                }
                else
                {
                      return this.referenceLevelUnit_; 
                }
            }
            set
            {
                if (this.referenceLevelUnit_ != value)
                {
                    this.referenceLevelUnit_ = value;
                }
            }
        }
        #endregion
        
        public string referenceLevelUnitIDRef_ { get; set; }
        
    
        
    
    }
    
}

