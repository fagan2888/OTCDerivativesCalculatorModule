using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TermCurve
    {
        public TermCurve(XmlNode xmlNode)
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
            
        
            XmlNodeList extrapolationPermittedNodeList = xmlNode.SelectNodes("extrapolationPermitted");
            if (extrapolationPermittedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extrapolationPermittedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extrapolationPermittedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(extrapolationPermittedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extrapolationPermittedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extrapolationPermitted = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList pointNodeList = xmlNode.SelectNodes("point");
            
            foreach (XmlNode item in pointNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pointIDRef = item.Attributes["id"].Name;
                        List<TermPoint> ob = new List<TermPoint>();
                        ob.Add(new TermPoint(item));
                        IDManager.SetID(pointIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pointIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    point.Add(new TermPoint(item));
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
        #region ExtrapolationPermitted
        private XsdTypeBoolean extrapolationPermitted;
        public XsdTypeBoolean ExtrapolationPermitted
        {
            get
            {
                if (this.extrapolationPermitted != null)
                {
                    return this.extrapolationPermitted; 
                }
                else if (this.extrapolationPermittedIDRef != null)
                {
                    extrapolationPermitted = IDManager.getID(extrapolationPermittedIDRef) as XsdTypeBoolean;
                    return this.extrapolationPermitted; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extrapolationPermitted != value)
                {
                    this.extrapolationPermitted = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Point
        private List<TermPoint> point;
        public List<TermPoint> Point
        {
            get
            {
                if (this.point != null)
                {
                    return this.point; 
                }
                else if (this.pointIDRef != null)
                {
                    point = IDManager.getID(pointIDRef) as List<TermPoint>;
                    return this.point; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.point != value)
                {
                    this.point = value;
                }
            }
        }
        #endregion
        
        public string TermPointIDRef { get; set; }
        
    
        
    
    }
    
}

