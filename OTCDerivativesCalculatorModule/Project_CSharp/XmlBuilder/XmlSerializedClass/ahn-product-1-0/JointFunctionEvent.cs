using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointFunctionEvent : ISerialized
    {
        public JointFunctionEvent(XmlNode xmlNode)
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
            
        
            XmlNode functionsNode = xmlNode.SelectSingleNode("functions");
            
            if (functionsNode != null)
            {
                if (functionsNode.Attributes["href"] != null || functionsNode.Attributes["id"] != null) 
                {
                    if (functionsNode.Attributes["id"] != null) 
                    {
                        functionsIDRef_ = functionsNode.Attributes["id"].Value;
                        Functions ob = new Functions(functionsNode);
                        IDManager.SetID(functionsIDRef_, ob);
                    }
                    else if (functionsNode.Attributes["href"] != null)
                    {
                        functionsIDRef_ = functionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        functions_ = new Functions(functionsNode);
                    }
                }
                else
                {
                    functions_ = new Functions(functionsNode);
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
        #region Functions_
        private Functions functions_;
        public Functions Functions_
        {
            get
            {
                if (this.functions_ != null)
                {
                    return this.functions_; 
                }
                else if (this.functionsIDRef_ != null)
                {
                    functions_ = IDManager.getID(functionsIDRef_) as Functions;
                    return this.functions_; 
                }
                else
                {
                      return this.functions_; 
                }
            }
            set
            {
                if (this.functions_ != value)
                {
                    this.functions_ = value;
                }
            }
        }
        #endregion
        
        public string functionsIDRef_ { get; set; }
        
    
        
    
    }
    
}

