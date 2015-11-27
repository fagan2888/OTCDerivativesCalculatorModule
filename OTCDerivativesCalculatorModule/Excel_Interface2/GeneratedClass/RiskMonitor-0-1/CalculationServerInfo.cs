using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationServerInfo : ISerialized
    {
        public CalculationServerInfo() { }
        public CalculationServerInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode server_nameNode = xmlNode.SelectSingleNode("server_name");
            
            if (server_nameNode != null)
            {
                if (server_nameNode.Attributes["href"] != null || server_nameNode.Attributes["id"] != null) 
                {
                    if (server_nameNode.Attributes["id"] != null) 
                    {
                        server_nameIDRef_ = server_nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_nameNode);
                        IDManager.SetID(server_nameIDRef_, ob);
                    }
                    else if (server_nameNode.Attributes["href"] != null)
                    {
                        server_nameIDRef_ = server_nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_name_ = new XsdTypeToken(server_nameNode);
                    }
                }
                else
                {
                    server_name_ = new XsdTypeToken(server_nameNode);
                }
            }
            
        
            XmlNode server_ipNode = xmlNode.SelectSingleNode("server_ip");
            
            if (server_ipNode != null)
            {
                if (server_ipNode.Attributes["href"] != null || server_ipNode.Attributes["id"] != null) 
                {
                    if (server_ipNode.Attributes["id"] != null) 
                    {
                        server_ipIDRef_ = server_ipNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_ipNode);
                        IDManager.SetID(server_ipIDRef_, ob);
                    }
                    else if (server_ipNode.Attributes["href"] != null)
                    {
                        server_ipIDRef_ = server_ipNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_ip_ = new XsdTypeToken(server_ipNode);
                    }
                }
                else
                {
                    server_ip_ = new XsdTypeToken(server_ipNode);
                }
            }
            
        
            XmlNode server_portNode = xmlNode.SelectSingleNode("server_port");
            
            if (server_portNode != null)
            {
                if (server_portNode.Attributes["href"] != null || server_portNode.Attributes["id"] != null) 
                {
                    if (server_portNode.Attributes["id"] != null) 
                    {
                        server_portIDRef_ = server_portNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_portNode);
                        IDManager.SetID(server_portIDRef_, ob);
                    }
                    else if (server_portNode.Attributes["href"] != null)
                    {
                        server_portIDRef_ = server_portNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_port_ = new XsdTypeToken(server_portNode);
                    }
                }
                else
                {
                    server_port_ = new XsdTypeToken(server_portNode);
                }
            }
            
        
            XmlNode server_statusNode = xmlNode.SelectSingleNode("server_status");
            
            if (server_statusNode != null)
            {
                if (server_statusNode.Attributes["href"] != null || server_statusNode.Attributes["id"] != null) 
                {
                    if (server_statusNode.Attributes["id"] != null) 
                    {
                        server_statusIDRef_ = server_statusNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_statusNode);
                        IDManager.SetID(server_statusIDRef_, ob);
                    }
                    else if (server_statusNode.Attributes["href"] != null)
                    {
                        server_statusIDRef_ = server_statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_status_ = new XsdTypeToken(server_statusNode);
                    }
                }
                else
                {
                    server_status_ = new XsdTypeToken(server_statusNode);
                }
            }
            
        
            XmlNode server_coreNumNode = xmlNode.SelectSingleNode("server_coreNum");
            
            if (server_coreNumNode != null)
            {
                if (server_coreNumNode.Attributes["href"] != null || server_coreNumNode.Attributes["id"] != null) 
                {
                    if (server_coreNumNode.Attributes["id"] != null) 
                    {
                        server_coreNumIDRef_ = server_coreNumNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_coreNumNode);
                        IDManager.SetID(server_coreNumIDRef_, ob);
                    }
                    else if (server_coreNumNode.Attributes["href"] != null)
                    {
                        server_coreNumIDRef_ = server_coreNumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_coreNum_ = new XsdTypeToken(server_coreNumNode);
                    }
                }
                else
                {
                    server_coreNum_ = new XsdTypeToken(server_coreNumNode);
                }
            }
            
        
            XmlNode server_useNode = xmlNode.SelectSingleNode("server_use");
            
            if (server_useNode != null)
            {
                if (server_useNode.Attributes["href"] != null || server_useNode.Attributes["id"] != null) 
                {
                    if (server_useNode.Attributes["id"] != null) 
                    {
                        server_useIDRef_ = server_useNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_useNode);
                        IDManager.SetID(server_useIDRef_, ob);
                    }
                    else if (server_useNode.Attributes["href"] != null)
                    {
                        server_useIDRef_ = server_useNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_use_ = new XsdTypeToken(server_useNode);
                    }
                }
                else
                {
                    server_use_ = new XsdTypeToken(server_useNode);
                }
            }
            
        
            XmlNode server_aliveTimeNode = xmlNode.SelectSingleNode("server_aliveTime");
            
            if (server_aliveTimeNode != null)
            {
                if (server_aliveTimeNode.Attributes["href"] != null || server_aliveTimeNode.Attributes["id"] != null) 
                {
                    if (server_aliveTimeNode.Attributes["id"] != null) 
                    {
                        server_aliveTimeIDRef_ = server_aliveTimeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_aliveTimeNode);
                        IDManager.SetID(server_aliveTimeIDRef_, ob);
                    }
                    else if (server_aliveTimeNode.Attributes["href"] != null)
                    {
                        server_aliveTimeIDRef_ = server_aliveTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_aliveTime_ = new XsdTypeToken(server_aliveTimeNode);
                    }
                }
                else
                {
                    server_aliveTime_ = new XsdTypeToken(server_aliveTimeNode);
                }
            }
            
        
            XmlNode server_descriptionNode = xmlNode.SelectSingleNode("server_description");
            
            if (server_descriptionNode != null)
            {
                if (server_descriptionNode.Attributes["href"] != null || server_descriptionNode.Attributes["id"] != null) 
                {
                    if (server_descriptionNode.Attributes["id"] != null) 
                    {
                        server_descriptionIDRef_ = server_descriptionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(server_descriptionNode);
                        IDManager.SetID(server_descriptionIDRef_, ob);
                    }
                    else if (server_descriptionNode.Attributes["href"] != null)
                    {
                        server_descriptionIDRef_ = server_descriptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        server_description_ = new XsdTypeToken(server_descriptionNode);
                    }
                }
                else
                {
                    server_description_ = new XsdTypeToken(server_descriptionNode);
                }
            }
            
        
        }
        
    
        #region Server_name_
        private XsdTypeToken server_name_;
        public XsdTypeToken Server_name_
        {
            get
            {
                if (this.server_name_ != null)
                {
                    return this.server_name_; 
                }
                else if (this.server_nameIDRef_ != null)
                {
                    server_name_ = IDManager.getID(server_nameIDRef_) as XsdTypeToken;
                    return this.server_name_; 
                }
                else
                {
                    throw new Exception( "server_name_Node no exist!");
                }
            }
            set
            {
                if (this.server_name_ != value)
                {
                    this.server_name_ = value;
                }
            }
        }
        #endregion
        
        public string server_nameIDRef_ { get; set; }
        #region Server_ip_
        private XsdTypeToken server_ip_;
        public XsdTypeToken Server_ip_
        {
            get
            {
                if (this.server_ip_ != null)
                {
                    return this.server_ip_; 
                }
                else if (this.server_ipIDRef_ != null)
                {
                    server_ip_ = IDManager.getID(server_ipIDRef_) as XsdTypeToken;
                    return this.server_ip_; 
                }
                else
                {
                    throw new Exception( "server_ip_Node no exist!");
                }
            }
            set
            {
                if (this.server_ip_ != value)
                {
                    this.server_ip_ = value;
                }
            }
        }
        #endregion
        
        public string server_ipIDRef_ { get; set; }
        #region Server_port_
        private XsdTypeToken server_port_;
        public XsdTypeToken Server_port_
        {
            get
            {
                if (this.server_port_ != null)
                {
                    return this.server_port_; 
                }
                else if (this.server_portIDRef_ != null)
                {
                    server_port_ = IDManager.getID(server_portIDRef_) as XsdTypeToken;
                    return this.server_port_; 
                }
                else
                {
                    throw new Exception( "server_port_Node no exist!");
                }
            }
            set
            {
                if (this.server_port_ != value)
                {
                    this.server_port_ = value;
                }
            }
        }
        #endregion
        
        public string server_portIDRef_ { get; set; }
        #region Server_status_
        private XsdTypeToken server_status_;
        public XsdTypeToken Server_status_
        {
            get
            {
                if (this.server_status_ != null)
                {
                    return this.server_status_; 
                }
                else if (this.server_statusIDRef_ != null)
                {
                    server_status_ = IDManager.getID(server_statusIDRef_) as XsdTypeToken;
                    return this.server_status_; 
                }
                else
                {
                    throw new Exception( "server_status_Node no exist!");
                }
            }
            set
            {
                if (this.server_status_ != value)
                {
                    this.server_status_ = value;
                }
            }
        }
        #endregion
        
        public string server_statusIDRef_ { get; set; }
        #region Server_coreNum_
        private XsdTypeToken server_coreNum_;
        public XsdTypeToken Server_coreNum_
        {
            get
            {
                if (this.server_coreNum_ != null)
                {
                    return this.server_coreNum_; 
                }
                else if (this.server_coreNumIDRef_ != null)
                {
                    server_coreNum_ = IDManager.getID(server_coreNumIDRef_) as XsdTypeToken;
                    return this.server_coreNum_; 
                }
                else
                {
                    throw new Exception( "server_coreNum_Node no exist!");
                }
            }
            set
            {
                if (this.server_coreNum_ != value)
                {
                    this.server_coreNum_ = value;
                }
            }
        }
        #endregion
        
        public string server_coreNumIDRef_ { get; set; }
        #region Server_use_
        private XsdTypeToken server_use_;
        public XsdTypeToken Server_use_
        {
            get
            {
                if (this.server_use_ != null)
                {
                    return this.server_use_; 
                }
                else if (this.server_useIDRef_ != null)
                {
                    server_use_ = IDManager.getID(server_useIDRef_) as XsdTypeToken;
                    return this.server_use_; 
                }
                else
                {
                    throw new Exception( "server_use_Node no exist!");
                }
            }
            set
            {
                if (this.server_use_ != value)
                {
                    this.server_use_ = value;
                }
            }
        }
        #endregion
        
        public string server_useIDRef_ { get; set; }
        #region Server_aliveTime_
        private XsdTypeToken server_aliveTime_;
        public XsdTypeToken Server_aliveTime_
        {
            get
            {
                if (this.server_aliveTime_ != null)
                {
                    return this.server_aliveTime_; 
                }
                else if (this.server_aliveTimeIDRef_ != null)
                {
                    server_aliveTime_ = IDManager.getID(server_aliveTimeIDRef_) as XsdTypeToken;
                    return this.server_aliveTime_; 
                }
                else
                {
                    throw new Exception( "server_aliveTime_Node no exist!");
                }
            }
            set
            {
                if (this.server_aliveTime_ != value)
                {
                    this.server_aliveTime_ = value;
                }
            }
        }
        #endregion
        
        public string server_aliveTimeIDRef_ { get; set; }
        #region Server_description_
        private XsdTypeToken server_description_;
        public XsdTypeToken Server_description_
        {
            get
            {
                if (this.server_description_ != null)
                {
                    return this.server_description_; 
                }
                else if (this.server_descriptionIDRef_ != null)
                {
                    server_description_ = IDManager.getID(server_descriptionIDRef_) as XsdTypeToken;
                    return this.server_description_; 
                }
                else
                {
                    throw new Exception( "server_description_Node no exist!");
                }
            }
            set
            {
                if (this.server_description_ != value)
                {
                    this.server_description_ = value;
                }
            }
        }
        #endregion
        
        public string server_descriptionIDRef_ { get; set; }
        
    
        
    
    }
    
}

