using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_defaultCurve : ISerialized
    {
        public Excel_defaultCurve() { }
        public Excel_defaultCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode codeNode = xmlNode.SelectSingleNode("code");
            
            if (codeNode != null)
            {
                if (codeNode.Attributes["href"] != null || codeNode.Attributes["id"] != null) 
                {
                    if (codeNode.Attributes["id"] != null) 
                    {
                        codeIDRef_ = codeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(codeNode);
                        IDManager.SetID(codeIDRef_, ob);
                    }
                    else if (codeNode.Attributes["href"] != null)
                    {
                        codeIDRef_ = codeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        code_ = new XsdTypeToken(codeNode);
                    }
                }
                else
                {
                    code_ = new XsdTypeToken(codeNode);
                }
            }
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode recoveryNode = xmlNode.SelectSingleNode("recovery");
            
            if (recoveryNode != null)
            {
                if (recoveryNode.Attributes["href"] != null || recoveryNode.Attributes["id"] != null) 
                {
                    if (recoveryNode.Attributes["id"] != null) 
                    {
                        recoveryIDRef_ = recoveryNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(recoveryNode);
                        IDManager.SetID(recoveryIDRef_, ob);
                    }
                    else if (recoveryNode.Attributes["href"] != null)
                    {
                        recoveryIDRef_ = recoveryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recovery_ = new XsdTypeToken(recoveryNode);
                    }
                }
                else
                {
                    recovery_ = new XsdTypeToken(recoveryNode);
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
            
        
            XmlNode excel_interpolationNode = xmlNode.SelectSingleNode("excel_interpolation");
            
            if (excel_interpolationNode != null)
            {
                if (excel_interpolationNode.Attributes["href"] != null || excel_interpolationNode.Attributes["id"] != null) 
                {
                    if (excel_interpolationNode.Attributes["id"] != null) 
                    {
                        excel_interpolationIDRef_ = excel_interpolationNode.Attributes["id"].Value;
                        Excel_interpolation ob = new Excel_interpolation(excel_interpolationNode);
                        IDManager.SetID(excel_interpolationIDRef_, ob);
                    }
                    else if (excel_interpolationNode.Attributes["href"] != null)
                    {
                        excel_interpolationIDRef_ = excel_interpolationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_interpolation_ = new Excel_interpolation(excel_interpolationNode);
                    }
                }
                else
                {
                    excel_interpolation_ = new Excel_interpolation(excel_interpolationNode);
                }
            }
            
        
            XmlNodeList excel_rateDataNodeList = xmlNode.SelectNodes("excel_rateData");
            
            if (excel_rateDataNodeList != null)
            {
                this.excel_rateData_ = new List<Excel_rateData>();
                foreach (XmlNode item in excel_rateDataNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_rateDataIDRef_ = item.Attributes["id"].Value;
                            excel_rateData_.Add(new Excel_rateData(item));
                            IDManager.SetID(excel_rateDataIDRef_, excel_rateData_[excel_rateData_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_rateDataIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_rateData_.Add(new Excel_rateData(item));
                        }
                    }
                    else
                    {
                        excel_rateData_.Add(new Excel_rateData(item));
                    }
                }
            }
            
        
        }
        
    
        #region Code_
        private XsdTypeToken code_;
        public XsdTypeToken Code_
        {
            get
            {
                if (this.code_ != null)
                {
                    return this.code_; 
                }
                else if (this.codeIDRef_ != null)
                {
                    code_ = IDManager.getID(codeIDRef_) as XsdTypeToken;
                    return this.code_; 
                }
                else
                {
                    throw new Exception( "code_Node no exist!");
                }
            }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                }
            }
        }
        #endregion
        
        public string codeIDRef_ { get; set; }
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                    throw new Exception( "name_Node no exist!");
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region Recovery_
        private XsdTypeToken recovery_;
        public XsdTypeToken Recovery_
        {
            get
            {
                if (this.recovery_ != null)
                {
                    return this.recovery_; 
                }
                else if (this.recoveryIDRef_ != null)
                {
                    recovery_ = IDManager.getID(recoveryIDRef_) as XsdTypeToken;
                    return this.recovery_; 
                }
                else
                {
                    throw new Exception( "recovery_Node no exist!");
                }
            }
            set
            {
                if (this.recovery_ != value)
                {
                    this.recovery_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryIDRef_ { get; set; }
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
        #region Excel_interpolation_
        private Excel_interpolation excel_interpolation_;
        public Excel_interpolation Excel_interpolation_
        {
            get
            {
                if (this.excel_interpolation_ != null)
                {
                    return this.excel_interpolation_; 
                }
                else if (this.excel_interpolationIDRef_ != null)
                {
                    excel_interpolation_ = IDManager.getID(excel_interpolationIDRef_) as Excel_interpolation;
                    return this.excel_interpolation_; 
                }
                else
                {
                    throw new Exception( "excel_interpolation_Node no exist!");
                }
            }
            set
            {
                if (this.excel_interpolation_ != value)
                {
                    this.excel_interpolation_ = value;
                }
            }
        }
        #endregion
        
        public string excel_interpolationIDRef_ { get; set; }
        #region Excel_rateData_
        private List<Excel_rateData> excel_rateData_;
        public List<Excel_rateData> Excel_rateData_
        {
            get
            {
                if (this.excel_rateData_ != null)
                {
                    return this.excel_rateData_; 
                }
                else if (this.excel_rateDataIDRef_ != null)
                {
                    return this.excel_rateData_; 
                }
                else
                {
                    throw new Exception( "excel_rateData_Node no exist!");
                }
            }
            set
            {
                if (this.excel_rateData_ != value)
                {
                    this.excel_rateData_ = value;
                }
            }
        }
        #endregion
        
        public string excel_rateDataIDRef_ { get; set; }
        
    
        
    
    }
    
}

