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
            
        
            XmlNode excel_hifiveNode = xmlNode.SelectSingleNode("excel_hifive");
            
            if (excel_hifiveNode != null)
            {
                if (excel_hifiveNode.Attributes["href"] != null || excel_hifiveNode.Attributes["id"] != null) 
                {
                    if (excel_hifiveNode.Attributes["id"] != null) 
                    {
                        excel_hifiveIDRef_ = excel_hifiveNode.Attributes["id"].Value;
                        Excel_hifive ob = new Excel_hifive(excel_hifiveNode);
                        IDManager.SetID(excel_hifiveIDRef_, ob);
                    }
                    else if (excel_hifiveNode.Attributes["href"] != null)
                    {
                        excel_hifiveIDRef_ = excel_hifiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_hifive_ = new Excel_hifive(excel_hifiveNode);
                    }
                }
                else
                {
                    excel_hifive_ = new Excel_hifive(excel_hifiveNode);
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
        #region Excel_hifive_
        private Excel_hifive excel_hifive_;
        public Excel_hifive Excel_hifive_
        {
            get
            {
                if (this.excel_hifive_ != null)
                {
                    return this.excel_hifive_; 
                }
                else if (this.excel_hifiveIDRef_ != null)
                {
                    excel_hifive_ = IDManager.getID(excel_hifiveIDRef_) as Excel_hifive;
                    return this.excel_hifive_; 
                }
                else
                {
                    throw new Exception( "excel_hifive_Node no exist!");
                }
            }
            set
            {
                if (this.excel_hifive_ != value)
                {
                    this.excel_hifive_ = value;
                }
            }
        }
        #endregion
        
        public string excel_hifiveIDRef_ { get; set; }
        
    
        
    
    }
    
}

