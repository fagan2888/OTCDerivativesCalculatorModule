using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_compositeOption_subtype : ISerialized
    {
        public Excel_compositeOption_subtype() { }
        public Excel_compositeOption_subtype(XmlNode xmlNode)
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
            
        
            XmlNode excel_vanillaCallPutNode = xmlNode.SelectSingleNode("excel_vanillaCallPut");
            
            if (excel_vanillaCallPutNode != null)
            {
                if (excel_vanillaCallPutNode.Attributes["href"] != null || excel_vanillaCallPutNode.Attributes["id"] != null) 
                {
                    if (excel_vanillaCallPutNode.Attributes["id"] != null) 
                    {
                        excel_vanillaCallPutIDRef_ = excel_vanillaCallPutNode.Attributes["id"].Value;
                        Excel_vanillaCallPut ob = new Excel_vanillaCallPut(excel_vanillaCallPutNode);
                        IDManager.SetID(excel_vanillaCallPutIDRef_, ob);
                    }
                    else if (excel_vanillaCallPutNode.Attributes["href"] != null)
                    {
                        excel_vanillaCallPutIDRef_ = excel_vanillaCallPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_vanillaCallPut_ = new Excel_vanillaCallPut(excel_vanillaCallPutNode);
                    }
                }
                else
                {
                    excel_vanillaCallPut_ = new Excel_vanillaCallPut(excel_vanillaCallPutNode);
                }
            }
            
        
            XmlNode excel_upInOutCallNode = xmlNode.SelectSingleNode("excel_upInOutCall");
            
            if (excel_upInOutCallNode != null)
            {
                if (excel_upInOutCallNode.Attributes["href"] != null || excel_upInOutCallNode.Attributes["id"] != null) 
                {
                    if (excel_upInOutCallNode.Attributes["id"] != null) 
                    {
                        excel_upInOutCallIDRef_ = excel_upInOutCallNode.Attributes["id"].Value;
                        Excel_upInOutCall ob = new Excel_upInOutCall(excel_upInOutCallNode);
                        IDManager.SetID(excel_upInOutCallIDRef_, ob);
                    }
                    else if (excel_upInOutCallNode.Attributes["href"] != null)
                    {
                        excel_upInOutCallIDRef_ = excel_upInOutCallNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_upInOutCall_ = new Excel_upInOutCall(excel_upInOutCallNode);
                    }
                }
                else
                {
                    excel_upInOutCall_ = new Excel_upInOutCall(excel_upInOutCallNode);
                }
            }
            
        
            XmlNode excel_downInOutPutNode = xmlNode.SelectSingleNode("excel_downInOutPut");
            
            if (excel_downInOutPutNode != null)
            {
                if (excel_downInOutPutNode.Attributes["href"] != null || excel_downInOutPutNode.Attributes["id"] != null) 
                {
                    if (excel_downInOutPutNode.Attributes["id"] != null) 
                    {
                        excel_downInOutPutIDRef_ = excel_downInOutPutNode.Attributes["id"].Value;
                        Excel_downInOutPut ob = new Excel_downInOutPut(excel_downInOutPutNode);
                        IDManager.SetID(excel_downInOutPutIDRef_, ob);
                    }
                    else if (excel_downInOutPutNode.Attributes["href"] != null)
                    {
                        excel_downInOutPutIDRef_ = excel_downInOutPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_downInOutPut_ = new Excel_downInOutPut(excel_downInOutPutNode);
                    }
                }
                else
                {
                    excel_downInOutPut_ = new Excel_downInOutPut(excel_downInOutPutNode);
                }
            }
            
        
            XmlNode excel_digitalCallPutNode = xmlNode.SelectSingleNode("excel_digitalCallPut");
            
            if (excel_digitalCallPutNode != null)
            {
                if (excel_digitalCallPutNode.Attributes["href"] != null || excel_digitalCallPutNode.Attributes["id"] != null) 
                {
                    if (excel_digitalCallPutNode.Attributes["id"] != null) 
                    {
                        excel_digitalCallPutIDRef_ = excel_digitalCallPutNode.Attributes["id"].Value;
                        Excel_digitalCallPut ob = new Excel_digitalCallPut(excel_digitalCallPutNode);
                        IDManager.SetID(excel_digitalCallPutIDRef_, ob);
                    }
                    else if (excel_digitalCallPutNode.Attributes["href"] != null)
                    {
                        excel_digitalCallPutIDRef_ = excel_digitalCallPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_digitalCallPut_ = new Excel_digitalCallPut(excel_digitalCallPutNode);
                    }
                }
                else
                {
                    excel_digitalCallPut_ = new Excel_digitalCallPut(excel_digitalCallPutNode);
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
        #region Excel_vanillaCallPut_
        private Excel_vanillaCallPut excel_vanillaCallPut_;
        public Excel_vanillaCallPut Excel_vanillaCallPut_
        {
            get
            {
                if (this.excel_vanillaCallPut_ != null)
                {
                    return this.excel_vanillaCallPut_; 
                }
                else if (this.excel_vanillaCallPutIDRef_ != null)
                {
                    excel_vanillaCallPut_ = IDManager.getID(excel_vanillaCallPutIDRef_) as Excel_vanillaCallPut;
                    return this.excel_vanillaCallPut_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaCallPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaCallPut_ != value)
                {
                    this.excel_vanillaCallPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaCallPutIDRef_ { get; set; }
        #region Excel_upInOutCall_
        private Excel_upInOutCall excel_upInOutCall_;
        public Excel_upInOutCall Excel_upInOutCall_
        {
            get
            {
                if (this.excel_upInOutCall_ != null)
                {
                    return this.excel_upInOutCall_; 
                }
                else if (this.excel_upInOutCallIDRef_ != null)
                {
                    excel_upInOutCall_ = IDManager.getID(excel_upInOutCallIDRef_) as Excel_upInOutCall;
                    return this.excel_upInOutCall_; 
                }
                else
                {
                    throw new Exception( "excel_upInOutCall_Node no exist!");
                }
            }
            set
            {
                if (this.excel_upInOutCall_ != value)
                {
                    this.excel_upInOutCall_ = value;
                }
            }
        }
        #endregion
        
        public string excel_upInOutCallIDRef_ { get; set; }
        #region Excel_downInOutPut_
        private Excel_downInOutPut excel_downInOutPut_;
        public Excel_downInOutPut Excel_downInOutPut_
        {
            get
            {
                if (this.excel_downInOutPut_ != null)
                {
                    return this.excel_downInOutPut_; 
                }
                else if (this.excel_downInOutPutIDRef_ != null)
                {
                    excel_downInOutPut_ = IDManager.getID(excel_downInOutPutIDRef_) as Excel_downInOutPut;
                    return this.excel_downInOutPut_; 
                }
                else
                {
                    throw new Exception( "excel_downInOutPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_downInOutPut_ != value)
                {
                    this.excel_downInOutPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_downInOutPutIDRef_ { get; set; }
        #region Excel_digitalCallPut_
        private Excel_digitalCallPut excel_digitalCallPut_;
        public Excel_digitalCallPut Excel_digitalCallPut_
        {
            get
            {
                if (this.excel_digitalCallPut_ != null)
                {
                    return this.excel_digitalCallPut_; 
                }
                else if (this.excel_digitalCallPutIDRef_ != null)
                {
                    excel_digitalCallPut_ = IDManager.getID(excel_digitalCallPutIDRef_) as Excel_digitalCallPut;
                    return this.excel_digitalCallPut_; 
                }
                else
                {
                    throw new Exception( "excel_digitalCallPut_Node no exist!");
                }
            }
            set
            {
                if (this.excel_digitalCallPut_ != value)
                {
                    this.excel_digitalCallPut_ = value;
                }
            }
        }
        #endregion
        
        public string excel_digitalCallPutIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

