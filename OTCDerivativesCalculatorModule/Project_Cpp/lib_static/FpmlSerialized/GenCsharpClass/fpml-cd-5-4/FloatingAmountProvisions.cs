using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingAmountProvisions
    {
        public FloatingAmountProvisions(XmlNode xmlNode)
        {
            XmlNodeList WACCapInterestProvisionNodeList = xmlNode.SelectNodes("WACCapInterestProvision");
            if (WACCapInterestProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in WACCapInterestProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        WACCapInterestProvisionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(WACCapInterestProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        WACCapInterestProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        WACCapInterestProvision = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList stepUpProvisionNodeList = xmlNode.SelectNodes("stepUpProvision");
            if (stepUpProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepUpProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepUpProvisionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(stepUpProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepUpProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepUpProvision = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region WACCapInterestProvision
        private XsdTypeBoolean WACCapInterestProvision;
        public XsdTypeBoolean WACCapInterestProvision
        {
            get
            {
                if (this.WACCapInterestProvision != null)
                {
                    return this.WACCapInterestProvision; 
                }
                else if (this.WACCapInterestProvisionIDRef != null)
                {
                    WACCapInterestProvision = IDManager.getID(WACCapInterestProvisionIDRef) as XsdTypeBoolean;
                    return this.WACCapInterestProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.WACCapInterestProvision != value)
                {
                    this.WACCapInterestProvision = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region StepUpProvision
        private XsdTypeBoolean stepUpProvision;
        public XsdTypeBoolean StepUpProvision
        {
            get
            {
                if (this.stepUpProvision != null)
                {
                    return this.stepUpProvision; 
                }
                else if (this.stepUpProvisionIDRef != null)
                {
                    stepUpProvision = IDManager.getID(stepUpProvisionIDRef) as XsdTypeBoolean;
                    return this.stepUpProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stepUpProvision != value)
                {
                    this.stepUpProvision = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

