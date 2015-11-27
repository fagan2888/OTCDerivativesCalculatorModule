using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointSubEvent : ISerialized
    {
        public JointSubEvent(XmlNode xmlNode)
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
            
        
            XmlNodeList subEventNodeList = xmlNode.SelectNodes("subEvent");
            
            if (subEventNodeList != null)
            {
                this.subEvent_ = new List<SubEvent>();
                foreach (XmlNode item in subEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            subEventIDRef_ = item.Attributes["id"].Value;
                            subEvent_.Add(new SubEvent(item));
                            IDManager.SetID(subEventIDRef_, subEvent_[subEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            subEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        subEvent_.Add(new SubEvent(item));
                        }
                    }
                    else
                    {
                        subEvent_.Add(new SubEvent(item));
                    }
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
        #region SubEvent_
        private List<SubEvent> subEvent_;
        public List<SubEvent> SubEvent_
        {
            get
            {
                if (this.subEvent_ != null)
                {
                    return this.subEvent_; 
                }
                else if (this.subEventIDRef_ != null)
                {
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

