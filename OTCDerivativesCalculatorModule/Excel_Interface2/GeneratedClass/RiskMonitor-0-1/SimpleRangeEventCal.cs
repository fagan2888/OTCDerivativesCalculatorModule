using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeEventCal : ISerialized
    {
        public SimpleRangeEventCal() { }
        public SimpleRangeEventCal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode range1DNode = xmlNode.SelectSingleNode("range1D");
            
            if (range1DNode != null)
            {
                if (range1DNode.Attributes["href"] != null || range1DNode.Attributes["id"] != null) 
                {
                    if (range1DNode.Attributes["id"] != null) 
                    {
                        range1DIDRef_ = range1DNode.Attributes["id"].Value;
                        Range1D ob = new Range1D(range1DNode);
                        IDManager.SetID(range1DIDRef_, ob);
                    }
                    else if (range1DNode.Attributes["href"] != null)
                    {
                        range1DIDRef_ = range1DNode.Attributes["href"].Value;
                    }
                    else
                    {
                        range1D_ = new Range1D(range1DNode);
                    }
                }
                else
                {
                    range1D_ = new Range1D(range1DNode);
                }
            }
            
        
            XmlNode referenceCalculationInfoNode = xmlNode.SelectSingleNode("referenceCalculationInfo");
            
            if (referenceCalculationInfoNode != null)
            {
                if (referenceCalculationInfoNode.Attributes["href"] != null || referenceCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (referenceCalculationInfoNode.Attributes["id"] != null) 
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["id"].Value;
                        ReferenceCalculationInfo ob = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                        IDManager.SetID(referenceCalculationInfoIDRef_, ob);
                    }
                    else if (referenceCalculationInfoNode.Attributes["href"] != null)
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                    }
                }
                else
                {
                    referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                }
            }
            
        
            XmlNode dateInformationNode = xmlNode.SelectSingleNode("dateInformation");
            
            if (dateInformationNode != null)
            {
                if (dateInformationNode.Attributes["href"] != null || dateInformationNode.Attributes["id"] != null) 
                {
                    if (dateInformationNode.Attributes["id"] != null) 
                    {
                        dateInformationIDRef_ = dateInformationNode.Attributes["id"].Value;
                        DateInformation ob = new DateInformation(dateInformationNode);
                        IDManager.SetID(dateInformationIDRef_, ob);
                    }
                    else if (dateInformationNode.Attributes["href"] != null)
                    {
                        dateInformationIDRef_ = dateInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateInformation_ = new DateInformation(dateInformationNode);
                    }
                }
                else
                {
                    dateInformation_ = new DateInformation(dateInformationNode);
                }
            }
            
        
            XmlNode jointSimpleCalculationNode = xmlNode.SelectSingleNode("jointSimpleCalculation");
            
            if (jointSimpleCalculationNode != null)
            {
                if (jointSimpleCalculationNode.Attributes["href"] != null || jointSimpleCalculationNode.Attributes["id"] != null) 
                {
                    if (jointSimpleCalculationNode.Attributes["id"] != null) 
                    {
                        jointSimpleCalculationIDRef_ = jointSimpleCalculationNode.Attributes["id"].Value;
                        JointSimpleCalculation ob = new JointSimpleCalculation(jointSimpleCalculationNode);
                        IDManager.SetID(jointSimpleCalculationIDRef_, ob);
                    }
                    else if (jointSimpleCalculationNode.Attributes["href"] != null)
                    {
                        jointSimpleCalculationIDRef_ = jointSimpleCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointSimpleCalculation_ = new JointSimpleCalculation(jointSimpleCalculationNode);
                    }
                }
                else
                {
                    jointSimpleCalculation_ = new JointSimpleCalculation(jointSimpleCalculationNode);
                }
            }
            
        
        }
        
    
        #region Range1D_
        private Range1D range1D_;
        public Range1D Range1D_
        {
            get
            {
                if (this.range1D_ != null)
                {
                    return this.range1D_; 
                }
                else if (this.range1DIDRef_ != null)
                {
                    range1D_ = IDManager.getID(range1DIDRef_) as Range1D;
                    return this.range1D_; 
                }
                else
                {
                    throw new Exception( "range1D_Node no exist!");
                }
            }
            set
            {
                if (this.range1D_ != value)
                {
                    this.range1D_ = value;
                }
            }
        }
        #endregion
        
        public string range1DIDRef_ { get; set; }
        #region ReferenceCalculationInfo_
        private ReferenceCalculationInfo referenceCalculationInfo_;
        public ReferenceCalculationInfo ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
                    referenceCalculationInfo_ = IDManager.getID(referenceCalculationInfoIDRef_) as ReferenceCalculationInfo;
                    return this.referenceCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "referenceCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculationInfo_ != value)
                {
                    this.referenceCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationInfoIDRef_ { get; set; }
        #region DateInformation_
        private DateInformation dateInformation_;
        public DateInformation DateInformation_
        {
            get
            {
                if (this.dateInformation_ != null)
                {
                    return this.dateInformation_; 
                }
                else if (this.dateInformationIDRef_ != null)
                {
                    dateInformation_ = IDManager.getID(dateInformationIDRef_) as DateInformation;
                    return this.dateInformation_; 
                }
                else
                {
                    throw new Exception( "dateInformation_Node no exist!");
                }
            }
            set
            {
                if (this.dateInformation_ != value)
                {
                    this.dateInformation_ = value;
                }
            }
        }
        #endregion
        
        public string dateInformationIDRef_ { get; set; }
        #region JointSimpleCalculation_
        private JointSimpleCalculation jointSimpleCalculation_;
        public JointSimpleCalculation JointSimpleCalculation_
        {
            get
            {
                if (this.jointSimpleCalculation_ != null)
                {
                    return this.jointSimpleCalculation_; 
                }
                else if (this.jointSimpleCalculationIDRef_ != null)
                {
                    jointSimpleCalculation_ = IDManager.getID(jointSimpleCalculationIDRef_) as JointSimpleCalculation;
                    return this.jointSimpleCalculation_; 
                }
                else
                {
                    throw new Exception( "jointSimpleCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.jointSimpleCalculation_ != value)
                {
                    this.jointSimpleCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string jointSimpleCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

