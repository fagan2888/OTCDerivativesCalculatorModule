using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class JointFSubEvent
    {
        public JointFSubEvent(XmlNode xmlNode)
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
            
        
            XmlNodeList mainEventNodeList = xmlNode.SelectNodes("mainEvent");
            if (mainEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mainEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mainEventIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(mainEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mainEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mainEvent = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList subEventNodeList = xmlNode.SelectNodes("subEvent");
            if (subEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in subEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        subEventIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(subEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        subEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        subEvent = new XsdTypeBoolean(item);
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
        #region MainEvent
        private XsdTypeBoolean mainEvent;
        public XsdTypeBoolean MainEvent
        {
            get
            {
                if (this.mainEvent != null)
                {
                    return this.mainEvent; 
                }
                else if (this.mainEventIDRef != null)
                {
                    mainEvent = IDManager.getID(mainEventIDRef) as XsdTypeBoolean;
                    return this.mainEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mainEvent != value)
                {
                    this.mainEvent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SubEvent
        private XsdTypeBoolean subEvent;
        public XsdTypeBoolean SubEvent
        {
            get
            {
                if (this.subEvent != null)
                {
                    return this.subEvent; 
                }
                else if (this.subEventIDRef != null)
                {
                    subEvent = IDManager.getID(subEventIDRef) as XsdTypeBoolean;
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
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

