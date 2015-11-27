using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class JointFunctionEvent
    {
        public JointFunctionEvent(XmlNode xmlNode)
        {
            XmlNodeList jointTypeNodeList = xmlNode.SelectNodes("jointType");
            if (jointTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in jointTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jointTypeIDRef = item.Attributes["id"].Name;
                        JointTypeEnum ob = JointTypeEnum();
                        IDManager.SetID(jointTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jointTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        jointType = new JointTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList functionsNodeList = xmlNode.SelectNodes("functions");
            if (functionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in functionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        functionsIDRef = item.Attributes["id"].Name;
                        Functions ob = Functions();
                        IDManager.SetID(functionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        functionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        functions = new Functions(item);
                    }
                }
            }
            
        
        }
        
    
        #region JointType
        private JointTypeEnum jointType;
        public JointTypeEnum JointType
        {
            get
            {
                if (this.jointType != null)
                {
                    return this.jointType; 
                }
                else if (this.jointTypeIDRef != null)
                {
                    jointType = IDManager.getID(jointTypeIDRef) as JointTypeEnum;
                    return this.jointType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jointType != value)
                {
                    this.jointType = value;
                }
            }
        }
        #endregion
        
        public string JointTypeEnumIDRef { get; set; }
        #region Functions
        private Functions functions;
        public Functions Functions
        {
            get
            {
                if (this.functions != null)
                {
                    return this.functions; 
                }
                else if (this.functionsIDRef != null)
                {
                    functions = IDManager.getID(functionsIDRef) as Functions;
                    return this.functions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.functions != value)
                {
                    this.functions = value;
                }
            }
        }
        #endregion
        
        public string FunctionsIDRef { get; set; }
        
    
        
    
    }
    
}

