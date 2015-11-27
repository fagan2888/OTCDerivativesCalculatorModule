using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_referenceInfo_para : ISerialized
    {
        public Excel_referenceInfo_para() { }
        public Excel_referenceInfo_para(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_typeNode = xmlNode.SelectSingleNode("excel_type");
            
            if (excel_typeNode != null)
            {
                if (excel_typeNode.Attributes["href"] != null || excel_typeNode.Attributes["id"] != null) 
                {
                    if (excel_typeNode.Attributes["id"] != null) 
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(excel_typeNode);
                        IDManager.SetID(excel_typeIDRef_, ob);
                    }
                    else if (excel_typeNode.Attributes["href"] != null)
                    {
                        excel_typeIDRef_ = excel_typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_type_ = new XsdTypeToken(excel_typeNode);
                    }
                }
                else
                {
                    excel_type_ = new XsdTypeToken(excel_typeNode);
                }
            }
            
        
            XmlNode krCodeNode = xmlNode.SelectSingleNode("krCode");
            
            if (krCodeNode != null)
            {
                if (krCodeNode.Attributes["href"] != null || krCodeNode.Attributes["id"] != null) 
                {
                    if (krCodeNode.Attributes["id"] != null) 
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(krCodeNode);
                        IDManager.SetID(krCodeIDRef_, ob);
                    }
                    else if (krCodeNode.Attributes["href"] != null)
                    {
                        krCodeIDRef_ = krCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        krCode_ = new XsdTypeToken(krCodeNode);
                    }
                }
                else
                {
                    krCode_ = new XsdTypeToken(krCodeNode);
                }
            }
            
        
            XmlNode referenceNameNode = xmlNode.SelectSingleNode("referenceName");
            
            if (referenceNameNode != null)
            {
                if (referenceNameNode.Attributes["href"] != null || referenceNameNode.Attributes["id"] != null) 
                {
                    if (referenceNameNode.Attributes["id"] != null) 
                    {
                        referenceNameIDRef_ = referenceNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(referenceNameNode);
                        IDManager.SetID(referenceNameIDRef_, ob);
                    }
                    else if (referenceNameNode.Attributes["href"] != null)
                    {
                        referenceNameIDRef_ = referenceNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceName_ = new XsdTypeToken(referenceNameNode);
                    }
                }
                else
                {
                    referenceName_ = new XsdTypeToken(referenceNameNode);
                }
            }
            
        
            XmlNode modelNode = xmlNode.SelectSingleNode("model");
            
            if (modelNode != null)
            {
                if (modelNode.Attributes["href"] != null || modelNode.Attributes["id"] != null) 
                {
                    if (modelNode.Attributes["id"] != null) 
                    {
                        modelIDRef_ = modelNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(modelNode);
                        IDManager.SetID(modelIDRef_, ob);
                    }
                    else if (modelNode.Attributes["href"] != null)
                    {
                        modelIDRef_ = modelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        model_ = new XsdTypeToken(modelNode);
                    }
                }
                else
                {
                    model_ = new XsdTypeToken(modelNode);
                }
            }
            
        
            XmlNode excel_defaultCurveNode = xmlNode.SelectSingleNode("excel_defaultCurve");
            
            if (excel_defaultCurveNode != null)
            {
                if (excel_defaultCurveNode.Attributes["href"] != null || excel_defaultCurveNode.Attributes["id"] != null) 
                {
                    if (excel_defaultCurveNode.Attributes["id"] != null) 
                    {
                        excel_defaultCurveIDRef_ = excel_defaultCurveNode.Attributes["id"].Value;
                        Excel_defaultCurve ob = new Excel_defaultCurve(excel_defaultCurveNode);
                        IDManager.SetID(excel_defaultCurveIDRef_, ob);
                    }
                    else if (excel_defaultCurveNode.Attributes["href"] != null)
                    {
                        excel_defaultCurveIDRef_ = excel_defaultCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_defaultCurve_ = new Excel_defaultCurve(excel_defaultCurveNode);
                    }
                }
                else
                {
                    excel_defaultCurve_ = new Excel_defaultCurve(excel_defaultCurveNode);
                }
            }
            
        
            XmlNode descriptionNode = xmlNode.SelectSingleNode("description");
            
            if (descriptionNode != null)
            {
                if (descriptionNode.Attributes["href"] != null || descriptionNode.Attributes["id"] != null) 
                {
                    if (descriptionNode.Attributes["id"] != null) 
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(descriptionNode);
                        IDManager.SetID(descriptionIDRef_, ob);
                    }
                    else if (descriptionNode.Attributes["href"] != null)
                    {
                        descriptionIDRef_ = descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        description_ = new XsdTypeToken(descriptionNode);
                    }
                }
                else
                {
                    description_ = new XsdTypeToken(descriptionNode);
                }
            }
            
        
        }
        
    
        #region Excel_type_
        private XsdTypeToken excel_type_;
        public XsdTypeToken Excel_type_
        {
            get
            {
                if (this.excel_type_ != null)
                {
                    return this.excel_type_; 
                }
                else if (this.excel_typeIDRef_ != null)
                {
                    excel_type_ = IDManager.getID(excel_typeIDRef_) as XsdTypeToken;
                    return this.excel_type_; 
                }
                else
                {
                    throw new Exception( "excel_type_Node no exist!");
                }
            }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                }
            }
        }
        #endregion
        
        public string excel_typeIDRef_ { get; set; }
        #region KrCode_
        private XsdTypeToken krCode_;
        public XsdTypeToken KrCode_
        {
            get
            {
                if (this.krCode_ != null)
                {
                    return this.krCode_; 
                }
                else if (this.krCodeIDRef_ != null)
                {
                    krCode_ = IDManager.getID(krCodeIDRef_) as XsdTypeToken;
                    return this.krCode_; 
                }
                else
                {
                    throw new Exception( "krCode_Node no exist!");
                }
            }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                }
            }
        }
        #endregion
        
        public string krCodeIDRef_ { get; set; }
        #region ReferenceName_
        private XsdTypeToken referenceName_;
        public XsdTypeToken ReferenceName_
        {
            get
            {
                if (this.referenceName_ != null)
                {
                    return this.referenceName_; 
                }
                else if (this.referenceNameIDRef_ != null)
                {
                    referenceName_ = IDManager.getID(referenceNameIDRef_) as XsdTypeToken;
                    return this.referenceName_; 
                }
                else
                {
                    throw new Exception( "referenceName_Node no exist!");
                }
            }
            set
            {
                if (this.referenceName_ != value)
                {
                    this.referenceName_ = value;
                }
            }
        }
        #endregion
        
        public string referenceNameIDRef_ { get; set; }
        #region Model_
        private XsdTypeToken model_;
        public XsdTypeToken Model_
        {
            get
            {
                if (this.model_ != null)
                {
                    return this.model_; 
                }
                else if (this.modelIDRef_ != null)
                {
                    model_ = IDManager.getID(modelIDRef_) as XsdTypeToken;
                    return this.model_; 
                }
                else
                {
                    throw new Exception( "model_Node no exist!");
                }
            }
            set
            {
                if (this.model_ != value)
                {
                    this.model_ = value;
                }
            }
        }
        #endregion
        
        public string modelIDRef_ { get; set; }
        #region Excel_defaultCurve_
        private Excel_defaultCurve excel_defaultCurve_;
        public Excel_defaultCurve Excel_defaultCurve_
        {
            get
            {
                if (this.excel_defaultCurve_ != null)
                {
                    return this.excel_defaultCurve_; 
                }
                else if (this.excel_defaultCurveIDRef_ != null)
                {
                    excel_defaultCurve_ = IDManager.getID(excel_defaultCurveIDRef_) as Excel_defaultCurve;
                    return this.excel_defaultCurve_; 
                }
                else
                {
                    throw new Exception( "excel_defaultCurve_Node no exist!");
                }
            }
            set
            {
                if (this.excel_defaultCurve_ != value)
                {
                    this.excel_defaultCurve_ = value;
                }
            }
        }
        #endregion
        
        public string excel_defaultCurveIDRef_ { get; set; }
        #region Description_
        private XsdTypeToken description_;
        public XsdTypeToken Description_
        {
            get
            {
                if (this.description_ != null)
                {
                    return this.description_; 
                }
                else if (this.descriptionIDRef_ != null)
                {
                    description_ = IDManager.getID(descriptionIDRef_) as XsdTypeToken;
                    return this.description_; 
                }
                else
                {
                    throw new Exception( "description_Node no exist!");
                }
            }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                }
            }
        }
        #endregion
        
        public string descriptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

