using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TermCurve : ISerialized
    {
        public TermCurve(XmlNode xmlNode)
        {
            XmlNode interpolationMethodNode = xmlNode.SelectSingleNode("interpolationMethod");
            
            if (interpolationMethodNode != null)
            {
                if (interpolationMethodNode.Attributes["href"] != null || interpolationMethodNode.Attributes["id"] != null) 
                {
                    if (interpolationMethodNode.Attributes["id"] != null) 
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["id"].Value;
                        InterpolationMethod ob = new InterpolationMethod(interpolationMethodNode);
                        IDManager.SetID(interpolationMethodIDRef_, ob);
                    }
                    else if (interpolationMethodNode.Attributes["href"] != null)
                    {
                        interpolationMethodIDRef_ = interpolationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                    }
                }
                else
                {
                    interpolationMethod_ = new InterpolationMethod(interpolationMethodNode);
                }
            }
            
        
            XmlNode extrapolationPermittedNode = xmlNode.SelectSingleNode("extrapolationPermitted");
            
            if (extrapolationPermittedNode != null)
            {
                if (extrapolationPermittedNode.Attributes["href"] != null || extrapolationPermittedNode.Attributes["id"] != null) 
                {
                    if (extrapolationPermittedNode.Attributes["id"] != null) 
                    {
                        extrapolationPermittedIDRef_ = extrapolationPermittedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(extrapolationPermittedNode);
                        IDManager.SetID(extrapolationPermittedIDRef_, ob);
                    }
                    else if (extrapolationPermittedNode.Attributes["href"] != null)
                    {
                        extrapolationPermittedIDRef_ = extrapolationPermittedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extrapolationPermitted_ = new XsdTypeBoolean(extrapolationPermittedNode);
                    }
                }
                else
                {
                    extrapolationPermitted_ = new XsdTypeBoolean(extrapolationPermittedNode);
                }
            }
            
        
            XmlNodeList pointNodeList = xmlNode.SelectNodes("point");
            
            if (pointNodeList != null)
            {
                this.point_ = new List<TermPoint>();
                foreach (XmlNode item in pointNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            pointIDRef_ = item.Attributes["id"].Value;
                            point_.Add(new TermPoint(item));
                            IDManager.SetID(pointIDRef_, point_[point_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            pointIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        point_.Add(new TermPoint(item));
                        }
                    }
                    else
                    {
                        point_.Add(new TermPoint(item));
                    }
                }
            }
            
        
        }
        
    
        #region InterpolationMethod_
        private InterpolationMethod interpolationMethod_;
        public InterpolationMethod InterpolationMethod_
        {
            get
            {
                if (this.interpolationMethod_ != null)
                {
                    return this.interpolationMethod_; 
                }
                else if (this.interpolationMethodIDRef_ != null)
                {
                    interpolationMethod_ = IDManager.getID(interpolationMethodIDRef_) as InterpolationMethod;
                    return this.interpolationMethod_; 
                }
                else
                {
                      return this.interpolationMethod_; 
                }
            }
            set
            {
                if (this.interpolationMethod_ != value)
                {
                    this.interpolationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string interpolationMethodIDRef_ { get; set; }
        #region ExtrapolationPermitted_
        private XsdTypeBoolean extrapolationPermitted_;
        public XsdTypeBoolean ExtrapolationPermitted_
        {
            get
            {
                if (this.extrapolationPermitted_ != null)
                {
                    return this.extrapolationPermitted_; 
                }
                else if (this.extrapolationPermittedIDRef_ != null)
                {
                    extrapolationPermitted_ = IDManager.getID(extrapolationPermittedIDRef_) as XsdTypeBoolean;
                    return this.extrapolationPermitted_; 
                }
                else
                {
                      return this.extrapolationPermitted_; 
                }
            }
            set
            {
                if (this.extrapolationPermitted_ != value)
                {
                    this.extrapolationPermitted_ = value;
                }
            }
        }
        #endregion
        
        public string extrapolationPermittedIDRef_ { get; set; }
        #region Point_
        private List<TermPoint> point_;
        public List<TermPoint> Point_
        {
            get
            {
                if (this.point_ != null)
                {
                    return this.point_; 
                }
                else if (this.pointIDRef_ != null)
                {
                    return this.point_; 
                }
                else
                {
                      return this.point_; 
                }
            }
            set
            {
                if (this.point_ != value)
                {
                    this.point_ = value;
                }
            }
        }
        #endregion
        
        public string pointIDRef_ { get; set; }
        
    
        
    
    }
    
}

