using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_greekResult : ISerialized
    {
        public Excel_greekResult() { }
        public Excel_greekResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList excel_greekUnderlyingNodeList = xmlNode.SelectNodes("excel_greekUnderlying");
            
            if (excel_greekUnderlyingNodeList != null)
            {
                this.excel_greekUnderlying_ = new List<Excel_greekUnderlying>();
                foreach (XmlNode item in excel_greekUnderlyingNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_greekUnderlyingIDRef_ = item.Attributes["id"].Value;
                            excel_greekUnderlying_.Add(new Excel_greekUnderlying(item));
                            IDManager.SetID(excel_greekUnderlyingIDRef_, excel_greekUnderlying_[excel_greekUnderlying_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_greekUnderlyingIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_greekUnderlying_.Add(new Excel_greekUnderlying(item));
                        }
                    }
                    else
                    {
                        excel_greekUnderlying_.Add(new Excel_greekUnderlying(item));
                    }
                }
            }
            
        
            XmlNode thetaNode = xmlNode.SelectSingleNode("theta");
            
            if (thetaNode != null)
            {
                if (thetaNode.Attributes["href"] != null || thetaNode.Attributes["id"] != null) 
                {
                    if (thetaNode.Attributes["id"] != null) 
                    {
                        thetaIDRef_ = thetaNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(thetaNode);
                        IDManager.SetID(thetaIDRef_, ob);
                    }
                    else if (thetaNode.Attributes["href"] != null)
                    {
                        thetaIDRef_ = thetaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        theta_ = new XsdTypeToken(thetaNode);
                    }
                }
                else
                {
                    theta_ = new XsdTypeToken(thetaNode);
                }
            }
            
        
            XmlNode rhoNode = xmlNode.SelectSingleNode("rho");
            
            if (rhoNode != null)
            {
                if (rhoNode.Attributes["href"] != null || rhoNode.Attributes["id"] != null) 
                {
                    if (rhoNode.Attributes["id"] != null) 
                    {
                        rhoIDRef_ = rhoNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(rhoNode);
                        IDManager.SetID(rhoIDRef_, ob);
                    }
                    else if (rhoNode.Attributes["href"] != null)
                    {
                        rhoIDRef_ = rhoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rho_ = new XsdTypeToken(rhoNode);
                    }
                }
                else
                {
                    rho_ = new XsdTypeToken(rhoNode);
                }
            }
            
        
        }
        
    
        #region Excel_greekUnderlying_
        private List<Excel_greekUnderlying> excel_greekUnderlying_;
        public List<Excel_greekUnderlying> Excel_greekUnderlying_
        {
            get
            {
                if (this.excel_greekUnderlying_ != null)
                {
                    return this.excel_greekUnderlying_; 
                }
                else if (this.excel_greekUnderlyingIDRef_ != null)
                {
                    return this.excel_greekUnderlying_; 
                }
                else
                {
                    throw new Exception( "excel_greekUnderlying_Node no exist!");
                }
            }
            set
            {
                if (this.excel_greekUnderlying_ != value)
                {
                    this.excel_greekUnderlying_ = value;
                }
            }
        }
        #endregion
        
        public string excel_greekUnderlyingIDRef_ { get; set; }
        #region Theta_
        private XsdTypeToken theta_;
        public XsdTypeToken Theta_
        {
            get
            {
                if (this.theta_ != null)
                {
                    return this.theta_; 
                }
                else if (this.thetaIDRef_ != null)
                {
                    theta_ = IDManager.getID(thetaIDRef_) as XsdTypeToken;
                    return this.theta_; 
                }
                else
                {
                    throw new Exception( "theta_Node no exist!");
                }
            }
            set
            {
                if (this.theta_ != value)
                {
                    this.theta_ = value;
                }
            }
        }
        #endregion
        
        public string thetaIDRef_ { get; set; }
        #region Rho_
        private XsdTypeToken rho_;
        public XsdTypeToken Rho_
        {
            get
            {
                if (this.rho_ != null)
                {
                    return this.rho_; 
                }
                else if (this.rhoIDRef_ != null)
                {
                    rho_ = IDManager.getID(rhoIDRef_) as XsdTypeToken;
                    return this.rho_; 
                }
                else
                {
                    throw new Exception( "rho_Node no exist!");
                }
            }
            set
            {
                if (this.rho_ != value)
                {
                    this.rho_ = value;
                }
            }
        }
        #endregion
        
        public string rhoIDRef_ { get; set; }
        
    
        
    
    }
    
}

