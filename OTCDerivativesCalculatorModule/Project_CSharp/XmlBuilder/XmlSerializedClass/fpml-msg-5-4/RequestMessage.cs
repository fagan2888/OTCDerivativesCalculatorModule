using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RequestMessage : Message
    {
        public RequestMessage(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode headerNode = xmlNode.SelectSingleNode("header");
            
            if (headerNode != null)
            {
                if (headerNode.Attributes["href"] != null || headerNode.Attributes["id"] != null) 
                {
                    if (headerNode.Attributes["id"] != null) 
                    {
                        headerIDRef_ = headerNode.Attributes["id"].Value;
                        RequestMessageHeader ob = new RequestMessageHeader(headerNode);
                        IDManager.SetID(headerIDRef_, ob);
                    }
                    else if (headerNode.Attributes["href"] != null)
                    {
                        headerIDRef_ = headerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        header_ = new RequestMessageHeader(headerNode);
                    }
                }
                else
                {
                    header_ = new RequestMessageHeader(headerNode);
                }
            }
            
        
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            if (validationNodeList != null)
            {
                this.validation_ = new List<Validation>();
                foreach (XmlNode item in validationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            validationIDRef_ = item.Attributes["id"].Value;
                            validation_.Add(new Validation(item));
                            IDManager.SetID(validationIDRef_, validation_[validation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            validationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        validation_.Add(new Validation(item));
                        }
                    }
                    else
                    {
                        validation_.Add(new Validation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Header_
        private RequestMessageHeader header_;
        public RequestMessageHeader Header_
        {
            get
            {
                if (this.header_ != null)
                {
                    return this.header_; 
                }
                else if (this.headerIDRef_ != null)
                {
                    header_ = IDManager.getID(headerIDRef_) as RequestMessageHeader;
                    return this.header_; 
                }
                else
                {
                      return this.header_; 
                }
            }
            set
            {
                if (this.header_ != value)
                {
                    this.header_ = value;
                }
            }
        }
        #endregion
        
        public string headerIDRef_ { get; set; }
        #region Validation_
        private List<Validation> validation_;
        public List<Validation> Validation_
        {
            get
            {
                if (this.validation_ != null)
                {
                    return this.validation_; 
                }
                else if (this.validationIDRef_ != null)
                {
                    return this.validation_; 
                }
                else
                {
                      return this.validation_; 
                }
            }
            set
            {
                if (this.validation_ != value)
                {
                    this.validation_ = value;
                }
            }
        }
        #endregion
        
        public string validationIDRef_ { get; set; }
        
    
        
    
    }
    
}

