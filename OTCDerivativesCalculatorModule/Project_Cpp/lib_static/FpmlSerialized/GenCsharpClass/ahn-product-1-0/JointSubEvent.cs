using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class JointSubEvent
    {
        public JointSubEvent(XmlNode xmlNode)
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
            
        
            XmlNodeList subEventNodeList = xmlNode.SelectNodes("subEvent");
            
            foreach (XmlNode item in subEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        subEventIDRef = item.Attributes["id"].Name;
                        List<SubEvent> ob = new List<SubEvent>();
                        ob.Add(new SubEvent(item));
                        IDManager.SetID(subEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        subEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    subEvent.Add(new SubEvent(item));
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
        #region SubEvent
        private List<SubEvent> subEvent;
        public List<SubEvent> SubEvent
        {
            get
            {
                if (this.subEvent != null)
                {
                    return this.subEvent; 
                }
                else if (this.subEventIDRef != null)
                {
                    subEvent = IDManager.getID(subEventIDRef) as List<SubEvent>;
                    return this.subEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.subEvent != value)
                {
                    this.subEvent = value;
                }
            }
        }
        #endregion
        
        public string SubEventIDRef { get; set; }
        
    
        
    
    }
    
}

