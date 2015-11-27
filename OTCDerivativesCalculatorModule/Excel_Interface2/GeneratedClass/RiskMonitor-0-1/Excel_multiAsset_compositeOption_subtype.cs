using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_multiAsset_compositeOption_subtype : ISerialized
    {
        public Excel_multiAsset_compositeOption_subtype() { }
        public Excel_multiAsset_compositeOption_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_multiAsset_vanillaCallPutNode = xmlNode.SelectSingleNode("excel_multiAsset_vanillaCallPut");
            
            if (excel_multiAsset_vanillaCallPutNode != null)
            {
                if (excel_multiAsset_vanillaCallPutNode.Attributes["href"] != null || excel_multiAsset_vanillaCallPutNode.Attributes["id"] != null) 
                {
                    if (excel_multiAsset_vanillaCallPutNode.Attributes["id"] != null) 
                    {
                        excel_multiAsset_vanillaCallPutIDRef_ = excel_multiAsset_vanillaCallPutNode.Attributes["id"].Value;
                        Excel_multiAsset_vanillaCallPut ob = new Excel_multiAsset_vanillaCallPut(excel_multiAsset_vanillaCallPutNode);
                        IDManager.SetID(excel_multiAsset_vanillaCallPutIDRef_, ob);
                    }
                    else if (excel_multiAsset_vanillaCallPutNode.Attributes["href"] != null)
                    {
                        excel_multiAsset_vanillaCallPutIDRef_ = excel_multiAsset_vanillaCallPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiAsset_vanillaCallPut_ = new Excel_multiAsset_vanillaCallPut(excel_multiAsset_vanillaCallPutNode);
                    }
                }
                else
                {
                    excel_multiAsset_vanillaCallPut_ = new Excel_multiAsset_vanillaCallPut(excel_multiAsset_vanillaCallPutNode);
                }
            }
            
        
            XmlNode excel_multiAsset_upInOutCallNode = xmlNode.SelectSingleNode("excel_multiAsset_upInOutCall");
            
            if (excel_multiAsset_upInOutCallNode != null)
            {
                if (excel_multiAsset_upInOutCallNode.Attributes["href"] != null || excel_multiAsset_upInOutCallNode.Attributes["id"] != null) 
                {
                    if (excel_multiAsset_upInOutCallNode.Attributes["id"] != null) 
                    {
                        excel_multiAsset_upInOutCallIDRef_ = excel_multiAsset_upInOutCallNode.Attributes["id"].Value;
                        Excel_multiAsset_upInOutCall ob = new Excel_multiAsset_upInOutCall(excel_multiAsset_upInOutCallNode);
                        IDManager.SetID(excel_multiAsset_upInOutCallIDRef_, ob);
                    }
                    else if (excel_multiAsset_upInOutCallNode.Attributes["href"] != null)
                    {
                        excel_multiAsset_upInOutCallIDRef_ = excel_multiAsset_upInOutCallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiAsset_upInOutCall_ = new Excel_multiAsset_upInOutCall(excel_multiAsset_upInOutCallNode);
                    }
                }
                else
                {
                    excel_multiAsset_upInOutCall_ = new Excel_multiAsset_upInOutCall(excel_multiAsset_upInOutCallNode);
                }
            }
            
        
            XmlNode excel_multiAsset_downInOutPutNode = xmlNode.SelectSingleNode("excel_multiAsset_downInOutPut");
            
            if (excel_multiAsset_downInOutPutNode != null)
            {
                if (excel_multiAsset_downInOutPutNode.Attributes["href"] != null || excel_multiAsset_downInOutPutNode.Attributes["id"] != null) 
                {
                    if (excel_multiAsset_downInOutPutNode.Attributes["id"] != null) 
                    {
                        excel_multiAsset_downInOutPutIDRef_ = excel_multiAsset_downInOutPutNode.Attributes["id"].Value;
                        Excel_multiAsset_downInOutPut ob = new Excel_multiAsset_downInOutPut(excel_multiAsset_downInOutPutNode);
                        IDManager.SetID(excel_multiAsset_downInOutPutIDRef_, ob);
                    }
                    else if (excel_multiAsset_downInOutPutNode.Attributes["href"] != null)
                    {
                        excel_multiAsset_downInOutPutIDRef_ = excel_multiAsset_downInOutPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiAsset_downInOutPut_ = new Excel_multiAsset_downInOutPut(excel_multiAsset_downInOutPutNode);
                    }
                }
                else
                {
                    excel_multiAsset_downInOutPut_ = new Excel_multiAsset_downInOutPut(excel_multiAsset_downInOutPutNode);
                }
            }
            
        
            XmlNode excel_multiAsset_digitalCallPutNode = xmlNode.SelectSingleNode("excel_multiAsset_digitalCallPut");
            
            if (excel_multiAsset_digitalCallPutNode != null)
            {
                if (excel_multiAsset_digitalCallPutNode.Attributes["href"] != null || excel_multiAsset_digitalCallPutNode.Attributes["id"] != null) 
                {
                    if (excel_multiAsset_digitalCallPutNode.Attributes["id"] != null) 
                    {
                        excel_multiAsset_digitalCallPutIDRef_ = excel_multiAsset_digitalCallPutNode.Attributes["id"].Value;
                        Excel_multiAsset_digitalCallPut ob = new Excel_multiAsset_digitalCallPut(excel_multiAsset_digitalCallPutNode);
                        IDManager.SetID(excel_multiAsset_digitalCallPutIDRef_, ob);
                    }
                    else if (excel_multiAsset_digitalCallPutNode.Attributes["href"] != null)
                    {
                        excel_multiAsset_digitalCallPutIDRef_ = excel_multiAsset_digitalCallPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_multiAsset_digitalCallPut_ = new Excel_multiAsset_digitalCallPut(excel_multiAsset_digitalCallPutNode);
                    }
                }
                else
                {
                    excel_multiAsset_digitalCallPut_ = new Excel_multiAsset_digitalCallPut(excel_multiAsset_digitalCallPutNode);
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
        #region Excel_multiAsset_vanillaCallPut_
        private Excel_multiAsset_vanillaCallPut excel_multiAsset_vanillaCallPut_;
        public Excel_multiAsset_vanillaCallPut Excel_multiAsset_vanillaCallPut_
        {
            get
            {
                if (this.excel_multiAsset_vanillaCallPut_ != null)
                {
                    return this.excel_multiAsset_vanillaCallPut_; 
                }
                else if (this.excel_multiAsset_vanillaCallPutIDRef_ != null)
                {
                    excel_multiAsset_vanillaCallPut_ = IDManager.getID(excel_multiAsset_vanillaCallPutIDRef_) as Excel_multiAsset_vanillaCallPut;
                    return this.excel_multiAsset_vanillaCallPut_; 
                }
                else
                {
                    throw new Exception( "excel_multiAsset_vanillaCallPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAsset_vanillaCallPut_ != value)
                {
                    this.excel_multiAsset_vanillaCallPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAsset_vanillaCallPutIDRef_ { get; set; }
        #region Excel_multiAsset_upInOutCall_
        private Excel_multiAsset_upInOutCall excel_multiAsset_upInOutCall_;
        public Excel_multiAsset_upInOutCall Excel_multiAsset_upInOutCall_
        {
            get
            {
                if (this.excel_multiAsset_upInOutCall_ != null)
                {
                    return this.excel_multiAsset_upInOutCall_; 
                }
                else if (this.excel_multiAsset_upInOutCallIDRef_ != null)
                {
                    excel_multiAsset_upInOutCall_ = IDManager.getID(excel_multiAsset_upInOutCallIDRef_) as Excel_multiAsset_upInOutCall;
                    return this.excel_multiAsset_upInOutCall_; 
                }
                else
                {
                    throw new Exception( "excel_multiAsset_upInOutCall_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAsset_upInOutCall_ != value)
                {
                    this.excel_multiAsset_upInOutCall_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAsset_upInOutCallIDRef_ { get; set; }
        #region Excel_multiAsset_downInOutPut_
        private Excel_multiAsset_downInOutPut excel_multiAsset_downInOutPut_;
        public Excel_multiAsset_downInOutPut Excel_multiAsset_downInOutPut_
        {
            get
            {
                if (this.excel_multiAsset_downInOutPut_ != null)
                {
                    return this.excel_multiAsset_downInOutPut_; 
                }
                else if (this.excel_multiAsset_downInOutPutIDRef_ != null)
                {
                    excel_multiAsset_downInOutPut_ = IDManager.getID(excel_multiAsset_downInOutPutIDRef_) as Excel_multiAsset_downInOutPut;
                    return this.excel_multiAsset_downInOutPut_; 
                }
                else
                {
                    throw new Exception( "excel_multiAsset_downInOutPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAsset_downInOutPut_ != value)
                {
                    this.excel_multiAsset_downInOutPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAsset_downInOutPutIDRef_ { get; set; }
        #region Excel_multiAsset_digitalCallPut_
        private Excel_multiAsset_digitalCallPut excel_multiAsset_digitalCallPut_;
        public Excel_multiAsset_digitalCallPut Excel_multiAsset_digitalCallPut_
        {
            get
            {
                if (this.excel_multiAsset_digitalCallPut_ != null)
                {
                    return this.excel_multiAsset_digitalCallPut_; 
                }
                else if (this.excel_multiAsset_digitalCallPutIDRef_ != null)
                {
                    excel_multiAsset_digitalCallPut_ = IDManager.getID(excel_multiAsset_digitalCallPutIDRef_) as Excel_multiAsset_digitalCallPut;
                    return this.excel_multiAsset_digitalCallPut_; 
                }
                else
                {
                    throw new Exception( "excel_multiAsset_digitalCallPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_multiAsset_digitalCallPut_ != value)
                {
                    this.excel_multiAsset_digitalCallPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_multiAsset_digitalCallPutIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

