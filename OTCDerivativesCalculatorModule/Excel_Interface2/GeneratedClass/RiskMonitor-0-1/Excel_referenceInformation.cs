using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceInformation : ISerialized
    {
        public Excel_referenceInformation() { }
        public Excel_referenceInformation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode entityNameNode = xmlNode.SelectSingleNode("entityName");
            
            if (entityNameNode != null)
            {
                if (entityNameNode.Attributes["href"] != null || entityNameNode.Attributes["id"] != null) 
                {
                    if (entityNameNode.Attributes["id"] != null) 
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(entityNameNode);
                        IDManager.SetID(entityNameIDRef_, ob);
                    }
                    else if (entityNameNode.Attributes["href"] != null)
                    {
                        entityNameIDRef_ = entityNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityName_ = new XsdTypeToken(entityNameNode);
                    }
                }
                else
                {
                    entityName_ = new XsdTypeToken(entityNameNode);
                }
            }
            
        
            XmlNode entityIdNode = xmlNode.SelectSingleNode("entityId");
            
            if (entityIdNode != null)
            {
                if (entityIdNode.Attributes["href"] != null || entityIdNode.Attributes["id"] != null) 
                {
                    if (entityIdNode.Attributes["id"] != null) 
                    {
                        entityIdIDRef_ = entityIdNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(entityIdNode);
                        IDManager.SetID(entityIdIDRef_, ob);
                    }
                    else if (entityIdNode.Attributes["href"] != null)
                    {
                        entityIdIDRef_ = entityIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entityId_ = new XsdTypeToken(entityIdNode);
                    }
                }
                else
                {
                    entityId_ = new XsdTypeToken(entityIdNode);
                }
            }
            
        
            XmlNode excel_referenceObligationNode = xmlNode.SelectSingleNode("excel_referenceObligation");
            
            if (excel_referenceObligationNode != null)
            {
                if (excel_referenceObligationNode.Attributes["href"] != null || excel_referenceObligationNode.Attributes["id"] != null) 
                {
                    if (excel_referenceObligationNode.Attributes["id"] != null) 
                    {
                        excel_referenceObligationIDRef_ = excel_referenceObligationNode.Attributes["id"].Value;
                        Excel_referenceObligation ob = new Excel_referenceObligation(excel_referenceObligationNode);
                        IDManager.SetID(excel_referenceObligationIDRef_, ob);
                    }
                    else if (excel_referenceObligationNode.Attributes["href"] != null)
                    {
                        excel_referenceObligationIDRef_ = excel_referenceObligationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_referenceObligation_ = new Excel_referenceObligation(excel_referenceObligationNode);
                    }
                }
                else
                {
                    excel_referenceObligation_ = new Excel_referenceObligation(excel_referenceObligationNode);
                }
            }
            
        
        }
        
    
        #region EntityName_
        private XsdTypeToken entityName_;
        public XsdTypeToken EntityName_
        {
            get
            {
                if (this.entityName_ != null)
                {
                    return this.entityName_; 
                }
                else if (this.entityNameIDRef_ != null)
                {
                    entityName_ = IDManager.getID(entityNameIDRef_) as XsdTypeToken;
                    return this.entityName_; 
                }
                else
                {
                    throw new Exception( "entityName_Node no exist!");
                }
            }
            set
            {
                if (this.entityName_ != value)
                {
                    this.entityName_ = value;
                }
            }
        }
        #endregion
        
        public string entityNameIDRef_ { get; set; }
        #region EntityId_
        private XsdTypeToken entityId_;
        public XsdTypeToken EntityId_
        {
            get
            {
                if (this.entityId_ != null)
                {
                    return this.entityId_; 
                }
                else if (this.entityIdIDRef_ != null)
                {
                    entityId_ = IDManager.getID(entityIdIDRef_) as XsdTypeToken;
                    return this.entityId_; 
                }
                else
                {
                    throw new Exception( "entityId_Node no exist!");
                }
            }
            set
            {
                if (this.entityId_ != value)
                {
                    this.entityId_ = value;
                }
            }
        }
        #endregion
        
        public string entityIdIDRef_ { get; set; }
        #region Excel_referenceObligation_
        private Excel_referenceObligation excel_referenceObligation_;
        public Excel_referenceObligation Excel_referenceObligation_
        {
            get
            {
                if (this.excel_referenceObligation_ != null)
                {
                    return this.excel_referenceObligation_; 
                }
                else if (this.excel_referenceObligationIDRef_ != null)
                {
                    excel_referenceObligation_ = IDManager.getID(excel_referenceObligationIDRef_) as Excel_referenceObligation;
                    return this.excel_referenceObligation_; 
                }
                else
                {
                    throw new Exception( "excel_referenceObligation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_referenceObligation_ != value)
                {
                    this.excel_referenceObligation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_referenceObligationIDRef_ { get; set; }
        
    
        
    
    }
    
}

