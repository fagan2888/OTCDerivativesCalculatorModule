using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RefVariable_eventOcc : ISerialized
    {
        public RefVariable_eventOcc() { }
        public RefVariable_eventOcc(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode variableEventInfoNode = xmlNode.SelectSingleNode("variableEventInfo");
            
            if (variableEventInfoNode != null)
            {
                if (variableEventInfoNode.Attributes["href"] != null || variableEventInfoNode.Attributes["id"] != null) 
                {
                    if (variableEventInfoNode.Attributes["id"] != null) 
                    {
                        variableEventInfoIDRef_ = variableEventInfoNode.Attributes["id"].Value;
                        VariableEventInfo ob = new VariableEventInfo(variableEventInfoNode);
                        IDManager.SetID(variableEventInfoIDRef_, ob);
                    }
                    else if (variableEventInfoNode.Attributes["href"] != null)
                    {
                        variableEventInfoIDRef_ = variableEventInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        variableEventInfo_ = new VariableEventInfo(variableEventInfoNode);
                    }
                }
                else
                {
                    variableEventInfo_ = new VariableEventInfo(variableEventInfoNode);
                }
            }
            
        
        }
        
    
        #region VariableEventInfo_
        private VariableEventInfo variableEventInfo_;
        public VariableEventInfo VariableEventInfo_
        {
            get
            {
                if (this.variableEventInfo_ != null)
                {
                    return this.variableEventInfo_; 
                }
                else if (this.variableEventInfoIDRef_ != null)
                {
                    variableEventInfo_ = IDManager.getID(variableEventInfoIDRef_) as VariableEventInfo;
                    return this.variableEventInfo_; 
                }
                else
                {
                    throw new Exception( "variableEventInfo_Node no exist!");
                }
            }
            set
            {
                if (this.variableEventInfo_ != value)
                {
                    this.variableEventInfo_ = value;
                }
            }
        }
        #endregion
        
        public string variableEventInfoIDRef_ { get; set; }
        
    
        
    
    }
    
}

