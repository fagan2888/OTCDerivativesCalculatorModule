using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Monte : ISerialized
    {
        public Monte() { }
        public Monte(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode simulationNumNode = xmlNode.SelectSingleNode("simulationNum");
            
            if (simulationNumNode != null)
            {
                if (simulationNumNode.Attributes["href"] != null || simulationNumNode.Attributes["id"] != null) 
                {
                    if (simulationNumNode.Attributes["id"] != null) 
                    {
                        simulationNumIDRef_ = simulationNumNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(simulationNumNode);
                        IDManager.SetID(simulationNumIDRef_, ob);
                    }
                    else if (simulationNumNode.Attributes["href"] != null)
                    {
                        simulationNumIDRef_ = simulationNumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simulationNum_ = new XsdTypeInteger(simulationNumNode);
                    }
                }
                else
                {
                    simulationNum_ = new XsdTypeInteger(simulationNumNode);
                }
            }
            
        
        }
        
    
        #region SimulationNum_
        private XsdTypeInteger simulationNum_;
        public XsdTypeInteger SimulationNum_
        {
            get
            {
                if (this.simulationNum_ != null)
                {
                    return this.simulationNum_; 
                }
                else if (this.simulationNumIDRef_ != null)
                {
                    simulationNum_ = IDManager.getID(simulationNumIDRef_) as XsdTypeInteger;
                    return this.simulationNum_; 
                }
                else
                {
                    throw new Exception( "simulationNum_Node no exist!");
                }
            }
            set
            {
                if (this.simulationNum_ != value)
                {
                    this.simulationNum_ = value;
                }
            }
        }
        #endregion
        
        public string simulationNumIDRef_ { get; set; }
        
    
        
    
    }
    
}

