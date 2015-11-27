using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Instrument : ISerialized
    {
        public Instrument() { }
        public Instrument(XmlNode xmlNode)
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
            
        
            XmlNode excel_interfaceNode = xmlNode.SelectSingleNode("excel_interface");
            
            if (excel_interfaceNode != null)
            {
                if (excel_interfaceNode.Attributes["href"] != null || excel_interfaceNode.Attributes["id"] != null) 
                {
                    if (excel_interfaceNode.Attributes["id"] != null) 
                    {
                        excel_interfaceIDRef_ = excel_interfaceNode.Attributes["id"].Value;
                        Excel_interface ob = new Excel_interface(excel_interfaceNode);
                        IDManager.SetID(excel_interfaceIDRef_, ob);
                    }
                    else if (excel_interfaceNode.Attributes["href"] != null)
                    {
                        excel_interfaceIDRef_ = excel_interfaceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_interface_ = new Excel_interface(excel_interfaceNode);
                    }
                }
                else
                {
                    excel_interface_ = new Excel_interface(excel_interfaceNode);
                }
            }
            
        
            XmlNode excel_swapInterfaceNode = xmlNode.SelectSingleNode("excel_swapInterface");
            
            if (excel_swapInterfaceNode != null)
            {
                if (excel_swapInterfaceNode.Attributes["href"] != null || excel_swapInterfaceNode.Attributes["id"] != null) 
                {
                    if (excel_swapInterfaceNode.Attributes["id"] != null) 
                    {
                        excel_swapInterfaceIDRef_ = excel_swapInterfaceNode.Attributes["id"].Value;
                        Excel_swapInterface ob = new Excel_swapInterface(excel_swapInterfaceNode);
                        IDManager.SetID(excel_swapInterfaceIDRef_, ob);
                    }
                    else if (excel_swapInterfaceNode.Attributes["href"] != null)
                    {
                        excel_swapInterfaceIDRef_ = excel_swapInterfaceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_swapInterface_ = new Excel_swapInterface(excel_swapInterfaceNode);
                    }
                }
                else
                {
                    excel_swapInterface_ = new Excel_swapInterface(excel_swapInterfaceNode);
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
        #region Excel_interface_
        private Excel_interface excel_interface_;
        public Excel_interface Excel_interface_
        {
            get
            {
                if (this.excel_interface_ != null)
                {
                    return this.excel_interface_; 
                }
                else if (this.excel_interfaceIDRef_ != null)
                {
                    excel_interface_ = IDManager.getID(excel_interfaceIDRef_) as Excel_interface;
                    return this.excel_interface_; 
                }
                else
                {
                    throw new Exception( "excel_interface_Node no exist!");
                }
            }
            set
            {
                if (this.excel_interface_ != value)
                {
                    this.excel_interface_ = value;
                }
            }
        }
        #endregion
        
        public string excel_interfaceIDRef_ { get; set; }
        #region Excel_swapInterface_
        private Excel_swapInterface excel_swapInterface_;
        public Excel_swapInterface Excel_swapInterface_
        {
            get
            {
                if (this.excel_swapInterface_ != null)
                {
                    return this.excel_swapInterface_; 
                }
                else if (this.excel_swapInterfaceIDRef_ != null)
                {
                    excel_swapInterface_ = IDManager.getID(excel_swapInterfaceIDRef_) as Excel_swapInterface;
                    return this.excel_swapInterface_; 
                }
                else
                {
                    throw new Exception( "excel_swapInterface_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapInterface_ != value)
                {
                    this.excel_swapInterface_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapInterfaceIDRef_ { get; set; }
        
    
        
    
    }
    
}

