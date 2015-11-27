using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ValuationPostponement : ISerialized
    {
        public ValuationPostponement(XmlNode xmlNode)
        {
            XmlNode maximumDaysOfPostponementNode = xmlNode.SelectSingleNode("maximumDaysOfPostponement");
            
            if (maximumDaysOfPostponementNode != null)
            {
                if (maximumDaysOfPostponementNode.Attributes["href"] != null || maximumDaysOfPostponementNode.Attributes["id"] != null) 
                {
                    if (maximumDaysOfPostponementNode.Attributes["id"] != null) 
                    {
                        maximumDaysOfPostponementIDRef_ = maximumDaysOfPostponementNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(maximumDaysOfPostponementNode);
                        IDManager.SetID(maximumDaysOfPostponementIDRef_, ob);
                    }
                    else if (maximumDaysOfPostponementNode.Attributes["href"] != null)
                    {
                        maximumDaysOfPostponementIDRef_ = maximumDaysOfPostponementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumDaysOfPostponement_ = new XsdTypePositiveInteger(maximumDaysOfPostponementNode);
                    }
                }
                else
                {
                    maximumDaysOfPostponement_ = new XsdTypePositiveInteger(maximumDaysOfPostponementNode);
                }
            }
            
        
        }
        
    
        #region MaximumDaysOfPostponement_
        private XsdTypePositiveInteger maximumDaysOfPostponement_;
        public XsdTypePositiveInteger MaximumDaysOfPostponement_
        {
            get
            {
                if (this.maximumDaysOfPostponement_ != null)
                {
                    return this.maximumDaysOfPostponement_; 
                }
                else if (this.maximumDaysOfPostponementIDRef_ != null)
                {
                    maximumDaysOfPostponement_ = IDManager.getID(maximumDaysOfPostponementIDRef_) as XsdTypePositiveInteger;
                    return this.maximumDaysOfPostponement_; 
                }
                else
                {
                      return this.maximumDaysOfPostponement_; 
                }
            }
            set
            {
                if (this.maximumDaysOfPostponement_ != value)
                {
                    this.maximumDaysOfPostponement_ = value;
                }
            }
        }
        #endregion
        
        public string maximumDaysOfPostponementIDRef_ { get; set; }
        
    
        
    
    }
    
}

