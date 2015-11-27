using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GracePeriodExtension
    {
        public GracePeriodExtension(XmlNode xmlNode)
        {
            XmlNodeList applicableNodeList = xmlNode.SelectNodes("applicable");
            if (applicableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in applicableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        applicableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(applicableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        applicableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        applicable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList gracePeriodNodeList = xmlNode.SelectNodes("gracePeriod");
            if (gracePeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in gracePeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gracePeriodIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(gracePeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gracePeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        gracePeriod = new Offset(item);
                    }
                }
            }
            
        
        }
        
    
        #region Applicable
        private XsdTypeBoolean applicable;
        public XsdTypeBoolean Applicable
        {
            get
            {
                if (this.applicable != null)
                {
                    return this.applicable; 
                }
                else if (this.applicableIDRef != null)
                {
                    applicable = IDManager.getID(applicableIDRef) as XsdTypeBoolean;
                    return this.applicable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.applicable != value)
                {
                    this.applicable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region GracePeriod
        private Offset gracePeriod;
        public Offset GracePeriod
        {
            get
            {
                if (this.gracePeriod != null)
                {
                    return this.gracePeriod; 
                }
                else if (this.gracePeriodIDRef != null)
                {
                    gracePeriod = IDManager.getID(gracePeriodIDRef) as Offset;
                    return this.gracePeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.gracePeriod != value)
                {
                    this.gracePeriod = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        
    
        
    
    }
    
}

