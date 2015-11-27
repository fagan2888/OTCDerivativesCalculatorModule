using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestMessage
    {
        public RequestMessage(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList headerNodeList = xmlNode.SelectNodes("header");
            if (headerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in headerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        headerIDRef = item.Attributes["id"].Name;
                        RequestMessageHeader ob = RequestMessageHeader();
                        IDManager.SetID(headerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        headerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        header = new RequestMessageHeader(item);
                    }
                }
            }
            
        
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            foreach (XmlNode item in validationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        validationIDRef = item.Attributes["id"].Name;
                        List<Validation> ob = new List<Validation>();
                        ob.Add(new Validation(item));
                        IDManager.SetID(validationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        validationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    validation.Add(new Validation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Header
        private RequestMessageHeader header;
        public RequestMessageHeader Header
        {
            get
            {
                if (this.header != null)
                {
                    return this.header; 
                }
                else if (this.headerIDRef != null)
                {
                    header = IDManager.getID(headerIDRef) as RequestMessageHeader;
                    return this.header; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.header != value)
                {
                    this.header = value;
                }
            }
        }
        #endregion
        
        public string RequestMessageHeaderIDRef { get; set; }
        #region Validation
        private List<Validation> validation;
        public List<Validation> Validation
        {
            get
            {
                if (this.validation != null)
                {
                    return this.validation; 
                }
                else if (this.validationIDRef != null)
                {
                    validation = IDManager.getID(validationIDRef) as List<Validation>;
                    return this.validation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.validation != value)
                {
                    this.validation = value;
                }
            }
        }
        #endregion
        
        public string ValidationIDRef { get; set; }
        
    
        
    
    }
    
}

