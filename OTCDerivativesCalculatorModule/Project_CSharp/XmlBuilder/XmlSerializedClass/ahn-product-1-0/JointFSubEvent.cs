using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointFSubEvent : ISerialized
    {
        public JointFSubEvent(XmlNode xmlNode)
        {
            XmlNode jointTypeNode = xmlNode.SelectSingleNode("jointType");
            
            if (jointTypeNode != null)
            {
                if (jointTypeNode.Attributes["href"] != null || jointTypeNode.Attributes["id"] != null) 
                {
                    if (jointTypeNode.Attributes["id"] != null) 
                    {
                        jointTypeIDRef_ = jointTypeNode.Attributes["id"].Value;
                        JointTypeEnum ob = new JointTypeEnum(jointTypeNode);
                        IDManager.SetID(jointTypeIDRef_, ob);
                    }
                    else if (jointTypeNode.Attributes["href"] != null)
                    {
                        jointTypeIDRef_ = jointTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointType_ = new JointTypeEnum(jointTypeNode);
                    }
                }
                else
                {
                    jointType_ = new JointTypeEnum(jointTypeNode);
                }
            }
            
        
            XmlNode mainEventNode = xmlNode.SelectSingleNode("mainEvent");
            
            if (mainEventNode != null)
            {
                if (mainEventNode.Attributes["href"] != null || mainEventNode.Attributes["id"] != null) 
                {
                    if (mainEventNode.Attributes["id"] != null) 
                    {
                        mainEventIDRef_ = mainEventNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(mainEventNode);
                        IDManager.SetID(mainEventIDRef_, ob);
                    }
                    else if (mainEventNode.Attributes["href"] != null)
                    {
                        mainEventIDRef_ = mainEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mainEvent_ = new XsdTypeBoolean(mainEventNode);
                    }
                }
                else
                {
                    mainEvent_ = new XsdTypeBoolean(mainEventNode);
                }
            }
            
        
            XmlNode subEventNode = xmlNode.SelectSingleNode("subEvent");
            
            if (subEventNode != null)
            {
                if (subEventNode.Attributes["href"] != null || subEventNode.Attributes["id"] != null) 
                {
                    if (subEventNode.Attributes["id"] != null) 
                    {
                        subEventIDRef_ = subEventNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(subEventNode);
                        IDManager.SetID(subEventIDRef_, ob);
                    }
                    else if (subEventNode.Attributes["href"] != null)
                    {
                        subEventIDRef_ = subEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        subEvent_ = new XsdTypeBoolean(subEventNode);
                    }
                }
                else
                {
                    subEvent_ = new XsdTypeBoolean(subEventNode);
                }
            }
            
        
        }
        
    
        #region JointType_
        private JointTypeEnum jointType_;
        public JointTypeEnum JointType_
        {
            get
            {
                if (this.jointType_ != null)
                {
                    return this.jointType_; 
                }
                else if (this.jointTypeIDRef_ != null)
                {
                    jointType_ = IDManager.getID(jointTypeIDRef_) as JointTypeEnum;
                    return this.jointType_; 
                }
                else
                {
                      return this.jointType_; 
                }
            }
            set
            {
                if (this.jointType_ != value)
                {
                    this.jointType_ = value;
                }
            }
        }
        #endregion
        
        public string jointTypeIDRef_ { get; set; }
        #region MainEvent_
        private XsdTypeBoolean mainEvent_;
        public XsdTypeBoolean MainEvent_
        {
            get
            {
                if (this.mainEvent_ != null)
                {
                    return this.mainEvent_; 
                }
                else if (this.mainEventIDRef_ != null)
                {
                    mainEvent_ = IDManager.getID(mainEventIDRef_) as XsdTypeBoolean;
                    return this.mainEvent_; 
                }
                else
                {
                      return this.mainEvent_; 
                }
            }
            set
            {
                if (this.mainEvent_ != value)
                {
                    this.mainEvent_ = value;
                }
            }
        }
        #endregion
        
        public string mainEventIDRef_ { get; set; }
        #region SubEvent_
        private XsdTypeBoolean subEvent_;
        public XsdTypeBoolean SubEvent_
        {
            get
            {
                if (this.subEvent_ != null)
                {
                    return this.subEvent_; 
                }
                else if (this.subEventIDRef_ != null)
                {
                    subEvent_ = IDManager.getID(subEventIDRef_) as XsdTypeBoolean;
                    return this.subEvent_; 
                }
                else
                {
                      return this.subEvent_; 
                }
            }
            set
            {
                if (this.subEvent_ != value)
                {
                    this.subEvent_ = value;
                }
            }
        }
        #endregion
        
        public string subEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

