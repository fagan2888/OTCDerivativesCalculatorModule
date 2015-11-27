using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fxForward : ISerialized
    {
        public Excel_fxForward() { }
        public Excel_fxForward(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode excel_issueInfoNode = xmlNode.SelectSingleNode("excel_issueInfo");
            
            if (excel_issueInfoNode != null)
            {
                if (excel_issueInfoNode.Attributes["href"] != null || excel_issueInfoNode.Attributes["id"] != null) 
                {
                    if (excel_issueInfoNode.Attributes["id"] != null) 
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["id"].Value;
                        Excel_issueInfo ob = new Excel_issueInfo(excel_issueInfoNode);
                        IDManager.SetID(excel_issueInfoIDRef_, ob);
                    }
                    else if (excel_issueInfoNode.Attributes["href"] != null)
                    {
                        excel_issueInfoIDRef_ = excel_issueInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                    }
                }
                else
                {
                    excel_issueInfo_ = new Excel_issueInfo(excel_issueInfoNode);
                }
            }
            
        
            XmlNode fx_exchangeLegNode = xmlNode.SelectSingleNode("fx_exchangeLeg");
            
            if (fx_exchangeLegNode != null)
            {
                if (fx_exchangeLegNode.Attributes["href"] != null || fx_exchangeLegNode.Attributes["id"] != null) 
                {
                    if (fx_exchangeLegNode.Attributes["id"] != null) 
                    {
                        fx_exchangeLegIDRef_ = fx_exchangeLegNode.Attributes["id"].Value;
                        Fx_exchangeLeg ob = new Fx_exchangeLeg(fx_exchangeLegNode);
                        IDManager.SetID(fx_exchangeLegIDRef_, ob);
                    }
                    else if (fx_exchangeLegNode.Attributes["href"] != null)
                    {
                        fx_exchangeLegIDRef_ = fx_exchangeLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fx_exchangeLeg_ = new Fx_exchangeLeg(fx_exchangeLegNode);
                    }
                }
                else
                {
                    fx_exchangeLeg_ = new Fx_exchangeLeg(fx_exchangeLegNode);
                }
            }
            
        
        }
        
    
        #region Excel_issueInfo_
        private Excel_issueInfo excel_issueInfo_;
        public Excel_issueInfo Excel_issueInfo_
        {
            get
            {
                if (this.excel_issueInfo_ != null)
                {
                    return this.excel_issueInfo_; 
                }
                else if (this.excel_issueInfoIDRef_ != null)
                {
                    excel_issueInfo_ = IDManager.getID(excel_issueInfoIDRef_) as Excel_issueInfo;
                    return this.excel_issueInfo_; 
                }
                else
                {
                    throw new Exception( "excel_issueInfo_Node no exist!");
                }
            }
            set
            {
                if (this.excel_issueInfo_ != value)
                {
                    this.excel_issueInfo_ = value;
                }
            }
        }
        #endregion
        
        public string excel_issueInfoIDRef_ { get; set; }
        #region Fx_exchangeLeg_
        private Fx_exchangeLeg fx_exchangeLeg_;
        public Fx_exchangeLeg Fx_exchangeLeg_
        {
            get
            {
                if (this.fx_exchangeLeg_ != null)
                {
                    return this.fx_exchangeLeg_; 
                }
                else if (this.fx_exchangeLegIDRef_ != null)
                {
                    fx_exchangeLeg_ = IDManager.getID(fx_exchangeLegIDRef_) as Fx_exchangeLeg;
                    return this.fx_exchangeLeg_; 
                }
                else
                {
                    throw new Exception( "fx_exchangeLeg_Node no exist!");
                }
            }
            set
            {
                if (this.fx_exchangeLeg_ != value)
                {
                    this.fx_exchangeLeg_ = value;
                }
            }
        }
        #endregion
        
        public string fx_exchangeLegIDRef_ { get; set; }
        
    
        
    
    }
    
}

