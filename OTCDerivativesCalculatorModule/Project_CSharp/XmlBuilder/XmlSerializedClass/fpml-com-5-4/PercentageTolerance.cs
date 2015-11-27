using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PercentageTolerance : ISerialized
    {
        public PercentageTolerance(XmlNode xmlNode)
        {
            XmlNode postitiveNode = xmlNode.SelectSingleNode("postitive");
            
            if (postitiveNode != null)
            {
                if (postitiveNode.Attributes["href"] != null || postitiveNode.Attributes["id"] != null) 
                {
                    if (postitiveNode.Attributes["id"] != null) 
                    {
                        postitiveIDRef_ = postitiveNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(postitiveNode);
                        IDManager.SetID(postitiveIDRef_, ob);
                    }
                    else if (postitiveNode.Attributes["href"] != null)
                    {
                        postitiveIDRef_ = postitiveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        postitive_ = new RestrictedPercentage(postitiveNode);
                    }
                }
                else
                {
                    postitive_ = new RestrictedPercentage(postitiveNode);
                }
            }
            
        
            XmlNode negativeNode = xmlNode.SelectSingleNode("negative");
            
            if (negativeNode != null)
            {
                if (negativeNode.Attributes["href"] != null || negativeNode.Attributes["id"] != null) 
                {
                    if (negativeNode.Attributes["id"] != null) 
                    {
                        negativeIDRef_ = negativeNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(negativeNode);
                        IDManager.SetID(negativeIDRef_, ob);
                    }
                    else if (negativeNode.Attributes["href"] != null)
                    {
                        negativeIDRef_ = negativeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        negative_ = new RestrictedPercentage(negativeNode);
                    }
                }
                else
                {
                    negative_ = new RestrictedPercentage(negativeNode);
                }
            }
            
        
            XmlNode optionNode = xmlNode.SelectSingleNode("option");
            
            if (optionNode != null)
            {
                if (optionNode.Attributes["href"] != null || optionNode.Attributes["id"] != null) 
                {
                    if (optionNode.Attributes["id"] != null) 
                    {
                        optionIDRef_ = optionNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(optionNode);
                        IDManager.SetID(optionIDRef_, ob);
                    }
                    else if (optionNode.Attributes["href"] != null)
                    {
                        optionIDRef_ = optionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        option_ = new PartyReference(optionNode);
                    }
                }
                else
                {
                    option_ = new PartyReference(optionNode);
                }
            }
            
        
        }
        
    
        #region Postitive_
        private RestrictedPercentage postitive_;
        public RestrictedPercentage Postitive_
        {
            get
            {
                if (this.postitive_ != null)
                {
                    return this.postitive_; 
                }
                else if (this.postitiveIDRef_ != null)
                {
                    postitive_ = IDManager.getID(postitiveIDRef_) as RestrictedPercentage;
                    return this.postitive_; 
                }
                else
                {
                      return this.postitive_; 
                }
            }
            set
            {
                if (this.postitive_ != value)
                {
                    this.postitive_ = value;
                }
            }
        }
        #endregion
        
        public string postitiveIDRef_ { get; set; }
        #region Negative_
        private RestrictedPercentage negative_;
        public RestrictedPercentage Negative_
        {
            get
            {
                if (this.negative_ != null)
                {
                    return this.negative_; 
                }
                else if (this.negativeIDRef_ != null)
                {
                    negative_ = IDManager.getID(negativeIDRef_) as RestrictedPercentage;
                    return this.negative_; 
                }
                else
                {
                      return this.negative_; 
                }
            }
            set
            {
                if (this.negative_ != value)
                {
                    this.negative_ = value;
                }
            }
        }
        #endregion
        
        public string negativeIDRef_ { get; set; }
        #region Option_
        private PartyReference option_;
        public PartyReference Option_
        {
            get
            {
                if (this.option_ != null)
                {
                    return this.option_; 
                }
                else if (this.optionIDRef_ != null)
                {
                    option_ = IDManager.getID(optionIDRef_) as PartyReference;
                    return this.option_; 
                }
                else
                {
                      return this.option_; 
                }
            }
            set
            {
                if (this.option_ != value)
                {
                    this.option_ = value;
                }
            }
        }
        #endregion
        
        public string optionIDRef_ { get; set; }
        
    
        
    
    }
    
}

