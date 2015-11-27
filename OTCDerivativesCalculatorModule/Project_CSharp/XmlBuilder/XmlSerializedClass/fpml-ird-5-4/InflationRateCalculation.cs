using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InflationRateCalculation : FloatingRateCalculation
    {
        public InflationRateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode inflationLagNode = xmlNode.SelectSingleNode("inflationLag");
            
            if (inflationLagNode != null)
            {
                if (inflationLagNode.Attributes["href"] != null || inflationLagNode.Attributes["id"] != null) 
                {
                    if (inflationLagNode.Attributes["id"] != null) 
                    {
                        inflationLagIDRef_ = inflationLagNode.Attributes["id"].Value;
                        Offset ob = new Offset(inflationLagNode);
                        IDManager.SetID(inflationLagIDRef_, ob);
                    }
                    else if (inflationLagNode.Attributes["href"] != null)
                    {
                        inflationLagIDRef_ = inflationLagNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inflationLag_ = new Offset(inflationLagNode);
                    }
                }
                else
                {
                    inflationLag_ = new Offset(inflationLagNode);
                }
            }
            
        
            XmlNode indexSourceNode = xmlNode.SelectSingleNode("indexSource");
            
            if (indexSourceNode != null)
            {
                if (indexSourceNode.Attributes["href"] != null || indexSourceNode.Attributes["id"] != null) 
                {
                    if (indexSourceNode.Attributes["id"] != null) 
                    {
                        indexSourceIDRef_ = indexSourceNode.Attributes["id"].Value;
                        RateSourcePage ob = new RateSourcePage(indexSourceNode);
                        IDManager.SetID(indexSourceIDRef_, ob);
                    }
                    else if (indexSourceNode.Attributes["href"] != null)
                    {
                        indexSourceIDRef_ = indexSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexSource_ = new RateSourcePage(indexSourceNode);
                    }
                }
                else
                {
                    indexSource_ = new RateSourcePage(indexSourceNode);
                }
            }
            
        
            XmlNode mainPublicationNode = xmlNode.SelectSingleNode("mainPublication");
            
            if (mainPublicationNode != null)
            {
                if (mainPublicationNode.Attributes["href"] != null || mainPublicationNode.Attributes["id"] != null) 
                {
                    if (mainPublicationNode.Attributes["id"] != null) 
                    {
                        mainPublicationIDRef_ = mainPublicationNode.Attributes["id"].Value;
                        MainPublication ob = new MainPublication(mainPublicationNode);
                        IDManager.SetID(mainPublicationIDRef_, ob);
                    }
                    else if (mainPublicationNode.Attributes["href"] != null)
                    {
                        mainPublicationIDRef_ = mainPublicationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mainPublication_ = new MainPublication(mainPublicationNode);
                    }
                }
                else
                {
                    mainPublication_ = new MainPublication(mainPublicationNode);
                }
            }
            
        
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
            
        
            XmlNode initialIndexLevelNode = xmlNode.SelectSingleNode("initialIndexLevel");
            
            if (initialIndexLevelNode != null)
            {
                if (initialIndexLevelNode.Attributes["href"] != null || initialIndexLevelNode.Attributes["id"] != null) 
                {
                    if (initialIndexLevelNode.Attributes["id"] != null) 
                    {
                        initialIndexLevelIDRef_ = initialIndexLevelNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialIndexLevelNode);
                        IDManager.SetID(initialIndexLevelIDRef_, ob);
                    }
                    else if (initialIndexLevelNode.Attributes["href"] != null)
                    {
                        initialIndexLevelIDRef_ = initialIndexLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialIndexLevel_ = new XsdTypeDecimal(initialIndexLevelNode);
                    }
                }
                else
                {
                    initialIndexLevel_ = new XsdTypeDecimal(initialIndexLevelNode);
                }
            }
            
        
            XmlNode fallbackBondApplicableNode = xmlNode.SelectSingleNode("fallbackBondApplicable");
            
            if (fallbackBondApplicableNode != null)
            {
                if (fallbackBondApplicableNode.Attributes["href"] != null || fallbackBondApplicableNode.Attributes["id"] != null) 
                {
                    if (fallbackBondApplicableNode.Attributes["id"] != null) 
                    {
                        fallbackBondApplicableIDRef_ = fallbackBondApplicableNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fallbackBondApplicableNode);
                        IDManager.SetID(fallbackBondApplicableIDRef_, ob);
                    }
                    else if (fallbackBondApplicableNode.Attributes["href"] != null)
                    {
                        fallbackBondApplicableIDRef_ = fallbackBondApplicableNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallbackBondApplicable_ = new XsdTypeBoolean(fallbackBondApplicableNode);
                    }
                }
                else
                {
                    fallbackBondApplicable_ = new XsdTypeBoolean(fallbackBondApplicableNode);
                }
            }
            
        
        }
        
    
        #region InflationLag_
        private Offset inflationLag_;
        public Offset InflationLag_
        {
            get
            {
                if (this.inflationLag_ != null)
                {
                    return this.inflationLag_; 
                }
                else if (this.inflationLagIDRef_ != null)
                {
                    inflationLag_ = IDManager.getID(inflationLagIDRef_) as Offset;
                    return this.inflationLag_; 
                }
                else
                {
                      return this.inflationLag_; 
                }
            }
            set
            {
                if (this.inflationLag_ != value)
                {
                    this.inflationLag_ = value;
                }
            }
        }
        #endregion
        
        public string inflationLagIDRef_ { get; set; }
        #region IndexSource_
        private RateSourcePage indexSource_;
        public RateSourcePage IndexSource_
        {
            get
            {
                if (this.indexSource_ != null)
                {
                    return this.indexSource_; 
                }
                else if (this.indexSourceIDRef_ != null)
                {
                    indexSource_ = IDManager.getID(indexSourceIDRef_) as RateSourcePage;
                    return this.indexSource_; 
                }
                else
                {
                      return this.indexSource_; 
                }
            }
            set
            {
                if (this.indexSource_ != value)
                {
                    this.indexSource_ = value;
                }
            }
        }
        #endregion
        
        public string indexSourceIDRef_ { get; set; }
        #region MainPublication_
        private MainPublication mainPublication_;
        public MainPublication MainPublication_
        {
            get
            {
                if (this.mainPublication_ != null)
                {
                    return this.mainPublication_; 
                }
                else if (this.mainPublicationIDRef_ != null)
                {
                    mainPublication_ = IDManager.getID(mainPublicationIDRef_) as MainPublication;
                    return this.mainPublication_; 
                }
                else
                {
                      return this.mainPublication_; 
                }
            }
            set
            {
                if (this.mainPublication_ != value)
                {
                    this.mainPublication_ = value;
                }
            }
        }
        #endregion
        
        public string mainPublicationIDRef_ { get; set; }
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
        #region InitialIndexLevel_
        private XsdTypeDecimal initialIndexLevel_;
        public XsdTypeDecimal InitialIndexLevel_
        {
            get
            {
                if (this.initialIndexLevel_ != null)
                {
                    return this.initialIndexLevel_; 
                }
                else if (this.initialIndexLevelIDRef_ != null)
                {
                    initialIndexLevel_ = IDManager.getID(initialIndexLevelIDRef_) as XsdTypeDecimal;
                    return this.initialIndexLevel_; 
                }
                else
                {
                      return this.initialIndexLevel_; 
                }
            }
            set
            {
                if (this.initialIndexLevel_ != value)
                {
                    this.initialIndexLevel_ = value;
                }
            }
        }
        #endregion
        
        public string initialIndexLevelIDRef_ { get; set; }
        #region FallbackBondApplicable_
        private XsdTypeBoolean fallbackBondApplicable_;
        public XsdTypeBoolean FallbackBondApplicable_
        {
            get
            {
                if (this.fallbackBondApplicable_ != null)
                {
                    return this.fallbackBondApplicable_; 
                }
                else if (this.fallbackBondApplicableIDRef_ != null)
                {
                    fallbackBondApplicable_ = IDManager.getID(fallbackBondApplicableIDRef_) as XsdTypeBoolean;
                    return this.fallbackBondApplicable_; 
                }
                else
                {
                      return this.fallbackBondApplicable_; 
                }
            }
            set
            {
                if (this.fallbackBondApplicable_ != value)
                {
                    this.fallbackBondApplicable_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackBondApplicableIDRef_ { get; set; }
        
    
        
    
    }
    
}

