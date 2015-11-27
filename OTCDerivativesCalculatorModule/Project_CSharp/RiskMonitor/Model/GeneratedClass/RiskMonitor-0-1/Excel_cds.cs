using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_cds : ISerialized
    {
        public Excel_cds() { }
        public Excel_cds(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_swapLegNode = xmlNode.SelectSingleNode("excel_swapLeg");
            
            if (excel_swapLegNode != null)
            {
                if (excel_swapLegNode.Attributes["href"] != null || excel_swapLegNode.Attributes["id"] != null) 
                {
                    if (excel_swapLegNode.Attributes["id"] != null) 
                    {
                        excel_swapLegIDRef_ = excel_swapLegNode.Attributes["id"].Value;
                        Excel_swapLeg ob = new Excel_swapLeg(excel_swapLegNode);
                        IDManager.SetID(excel_swapLegIDRef_, ob);
                    }
                    else if (excel_swapLegNode.Attributes["href"] != null)
                    {
                        excel_swapLegIDRef_ = excel_swapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_swapLeg_ = new Excel_swapLeg(excel_swapLegNode);
                    }
                }
                else
                {
                    excel_swapLeg_ = new Excel_swapLeg(excel_swapLegNode);
                }
            }
            
        
            XmlNode excel_creditEventSwapLegNode = xmlNode.SelectSingleNode("excel_creditEventSwapLeg");
            
            if (excel_creditEventSwapLegNode != null)
            {
                if (excel_creditEventSwapLegNode.Attributes["href"] != null || excel_creditEventSwapLegNode.Attributes["id"] != null) 
                {
                    if (excel_creditEventSwapLegNode.Attributes["id"] != null) 
                    {
                        excel_creditEventSwapLegIDRef_ = excel_creditEventSwapLegNode.Attributes["id"].Value;
                        Excel_creditEventSwapLeg ob = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                        IDManager.SetID(excel_creditEventSwapLegIDRef_, ob);
                    }
                    else if (excel_creditEventSwapLegNode.Attributes["href"] != null)
                    {
                        excel_creditEventSwapLegIDRef_ = excel_creditEventSwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_creditEventSwapLeg_ = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                    }
                }
                else
                {
                    excel_creditEventSwapLeg_ = new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode);
                }
            }
            
        
        }
        
    
        #region Excel_swapLeg_
        private Excel_swapLeg excel_swapLeg_;
        public Excel_swapLeg Excel_swapLeg_
        {
            get
            {
                if (this.excel_swapLeg_ != null)
                {
                    return this.excel_swapLeg_; 
                }
                else if (this.excel_swapLegIDRef_ != null)
                {
                    excel_swapLeg_ = IDManager.getID(excel_swapLegIDRef_) as Excel_swapLeg;
                    return this.excel_swapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_swapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_swapLeg_ != value)
                {
                    this.excel_swapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_swapLegIDRef_ { get; set; }
        #region Excel_creditEventSwapLeg_
        private Excel_creditEventSwapLeg excel_creditEventSwapLeg_;
        public Excel_creditEventSwapLeg Excel_creditEventSwapLeg_
        {
            get
            {
                if (this.excel_creditEventSwapLeg_ != null)
                {
                    return this.excel_creditEventSwapLeg_; 
                }
                else if (this.excel_creditEventSwapLegIDRef_ != null)
                {
                    excel_creditEventSwapLeg_ = IDManager.getID(excel_creditEventSwapLegIDRef_) as Excel_creditEventSwapLeg;
                    return this.excel_creditEventSwapLeg_; 
                }
                else
                {
                    throw new Exception( "excel_creditEventSwapLeg_Node no exist!");
                }
            }
            set
            {
                if (this.excel_creditEventSwapLeg_ != value)
                {
                    this.excel_creditEventSwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string excel_creditEventSwapLegIDRef_ { get; set; }
        
    
        
    
    }
    
}

