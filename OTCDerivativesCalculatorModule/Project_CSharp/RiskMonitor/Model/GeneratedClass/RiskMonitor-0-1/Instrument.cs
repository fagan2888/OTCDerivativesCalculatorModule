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
            XmlNode headerNode = xmlNode.SelectSingleNode("header");
            
            if (headerNode != null)
            {
                if (headerNode.Attributes["href"] != null || headerNode.Attributes["id"] != null) 
                {
                    if (headerNode.Attributes["id"] != null) 
                    {
                        headerIDRef_ = headerNode.Attributes["id"].Value;
                        Header ob = new Header(headerNode);
                        IDManager.SetID(headerIDRef_, ob);
                    }
                    else if (headerNode.Attributes["href"] != null)
                    {
                        headerIDRef_ = headerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        header_ = new Header(headerNode);
                    }
                }
                else
                {
                    header_ = new Header(headerNode);
                }
            }
            
        
            XmlNode instPositionInfoNode = xmlNode.SelectSingleNode("instPositionInfo");
            
            if (instPositionInfoNode != null)
            {
                if (instPositionInfoNode.Attributes["href"] != null || instPositionInfoNode.Attributes["id"] != null) 
                {
                    if (instPositionInfoNode.Attributes["id"] != null) 
                    {
                        instPositionInfoIDRef_ = instPositionInfoNode.Attributes["id"].Value;
                        InstPositionInfo ob = new InstPositionInfo(instPositionInfoNode);
                        IDManager.SetID(instPositionInfoIDRef_, ob);
                    }
                    else if (instPositionInfoNode.Attributes["href"] != null)
                    {
                        instPositionInfoIDRef_ = instPositionInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instPositionInfo_ = new InstPositionInfo(instPositionInfoNode);
                    }
                }
                else
                {
                    instPositionInfo_ = new InstPositionInfo(instPositionInfoNode);
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
            
        
            XmlNode instrumentInfoNode = xmlNode.SelectSingleNode("instrumentInfo");
            
            if (instrumentInfoNode != null)
            {
                if (instrumentInfoNode.Attributes["href"] != null || instrumentInfoNode.Attributes["id"] != null) 
                {
                    if (instrumentInfoNode.Attributes["id"] != null) 
                    {
                        instrumentInfoIDRef_ = instrumentInfoNode.Attributes["id"].Value;
                        InstrumentInfo ob = new InstrumentInfo(instrumentInfoNode);
                        IDManager.SetID(instrumentInfoIDRef_, ob);
                    }
                    else if (instrumentInfoNode.Attributes["href"] != null)
                    {
                        instrumentInfoIDRef_ = instrumentInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrumentInfo_ = new InstrumentInfo(instrumentInfoNode);
                    }
                }
                else
                {
                    instrumentInfo_ = new InstrumentInfo(instrumentInfoNode);
                }
            }
            
        
        }
        
    
        #region Header_
        private Header header_;
        public Header Header_
        {
            get
            {
                if (this.header_ != null)
                {
                    return this.header_; 
                }
                else if (this.headerIDRef_ != null)
                {
                    header_ = IDManager.getID(headerIDRef_) as Header;
                    return this.header_; 
                }
                else
                {
                    throw new Exception( "header_Node no exist!");
                }
            }
            set
            {
                if (this.header_ != value)
                {
                    this.header_ = value;
                }
            }
        }
        #endregion
        
        public string headerIDRef_ { get; set; }
        #region InstPositionInfo_
        private InstPositionInfo instPositionInfo_;
        public InstPositionInfo InstPositionInfo_
        {
            get
            {
                if (this.instPositionInfo_ != null)
                {
                    return this.instPositionInfo_; 
                }
                else if (this.instPositionInfoIDRef_ != null)
                {
                    instPositionInfo_ = IDManager.getID(instPositionInfoIDRef_) as InstPositionInfo;
                    return this.instPositionInfo_; 
                }
                else
                {
                    throw new Exception( "instPositionInfo_Node no exist!");
                }
            }
            set
            {
                if (this.instPositionInfo_ != value)
                {
                    this.instPositionInfo_ = value;
                }
            }
        }
        #endregion
        
        public string instPositionInfoIDRef_ { get; set; }
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
        #region InstrumentInfo_
        private InstrumentInfo instrumentInfo_;
        public InstrumentInfo InstrumentInfo_
        {
            get
            {
                if (this.instrumentInfo_ != null)
                {
                    return this.instrumentInfo_; 
                }
                else if (this.instrumentInfoIDRef_ != null)
                {
                    instrumentInfo_ = IDManager.getID(instrumentInfoIDRef_) as InstrumentInfo;
                    return this.instrumentInfo_; 
                }
                else
                {
                    throw new Exception( "instrumentInfo_Node no exist!");
                }
            }
            set
            {
                if (this.instrumentInfo_ != value)
                {
                    this.instrumentInfo_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

