using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MakeWholeAmount
    {
        public MakeWholeAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList interpolationMethodNodeList = xmlNode.SelectNodes("interpolationMethod");
            if (interpolationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interpolationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef = item.Attributes["id"].Name;
                        InterpolationMethod ob = InterpolationMethod();
                        IDManager.SetID(interpolationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interpolationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interpolationMethod = new InterpolationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList earlyCallDateNodeList = xmlNode.SelectNodes("earlyCallDate");
            if (earlyCallDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in earlyCallDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        earlyCallDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(earlyCallDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        earlyCallDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        earlyCallDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region InterpolationMethod
        private InterpolationMethod interpolationMethod;
        public InterpolationMethod InterpolationMethod
        {
            get
            {
                if (this.interpolationMethod != null)
                {
                    return this.interpolationMethod; 
                }
                else if (this.interpolationMethodIDRef != null)
                {
                    interpolationMethod = IDManager.getID(interpolationMethodIDRef) as InterpolationMethod;
                    return this.interpolationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interpolationMethod != value)
                {
                    this.interpolationMethod = value;
                }
            }
        }
        #endregion
        
        public string InterpolationMethodIDRef { get; set; }
        #region EarlyCallDate
        private IdentifiedDate earlyCallDate;
        public IdentifiedDate EarlyCallDate
        {
            get
            {
                if (this.earlyCallDate != null)
                {
                    return this.earlyCallDate; 
                }
                else if (this.earlyCallDateIDRef != null)
                {
                    earlyCallDate = IDManager.getID(earlyCallDateIDRef) as IdentifiedDate;
                    return this.earlyCallDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.earlyCallDate != value)
                {
                    this.earlyCallDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}

