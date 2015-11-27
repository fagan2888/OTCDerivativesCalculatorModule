using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hifiveSwapLeg : ISerialized
    {
        public Excel_hifiveSwapLeg() { }
        public Excel_hifiveSwapLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_swapLegInfoNode = xmlNode.SelectSingleNode("excel_swapLegInfo");
            
            if (excel_swapLegInfoNode != null)
            {
                if (excel_swapLegInfoNode.Attributes["href"] != null || excel_swapLegInfoNode.Attributes["id"] != null) 
                {
                    if (excel_swapLegInfoNode.Attributes["id"] != null) 
                    {
                        excel_swapLegInfoIDRef_ = excel_swapLegInfoNode.Attributes["id"].Value;
                        Excel_swapLegInfo ob = new Excel_swapLegInfo(excel_swapLegInfoNode);
                        IDManager.SetID(excel_swapLegInfoIDRef_, ob);
                    }
                    else if (excel_swapLegInfoNode.Attributes["href"] != null)
                    {
                        excel_swapLegInfoIDRef_ = excel_swapLegInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_swapLegInfo_ = new Excel_swapLegInfo(excel_swapLegInfoNode);
                    }
                }
                else
                {
                    excel_swapLegInfo_ = new Excel_swapLegInfo(excel_swapLegInfoNode);
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
            
        
        }
        
    
        #region Excel_swapLegInfo_
        private Excel_swapLegInfo excel_swapLegInfo_;
        public Excel_swapLegInfo Excel_swapLegInfo_
        {
            get
            {
                if (this.excel_swapLegInfo_ != null)
                {
                    return this.excel_swapLegInfo_; 
                }
                else if (this.excel_swapLegInfoIDRef_ != null)
                {
                    excel_swapLegInfo_ = IDManager.getID(excel_swapLegInfoIDRef_) as Excel_swapLegInfo;
                    return this.excel_swapLegInfo_; 
                }
                else
                {
                    throw new Exception( "excel_swapLegInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapLegInfo_ != value)
                {
                    this.excel_swapLegInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapLegInfoIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

