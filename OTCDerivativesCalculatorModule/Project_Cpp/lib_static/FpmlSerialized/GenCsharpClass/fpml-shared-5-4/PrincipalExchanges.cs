using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchanges
    {
        public PrincipalExchanges(XmlNode xmlNode)
        {
            XmlNodeList initialExchangeNodeList = xmlNode.SelectNodes("initialExchange");
            if (initialExchangeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialExchangeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialExchangeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(initialExchangeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialExchangeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialExchange = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList finalExchangeNodeList = xmlNode.SelectNodes("finalExchange");
            if (finalExchangeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in finalExchangeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        finalExchangeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(finalExchangeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finalExchangeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finalExchange = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList intermediateExchangeNodeList = xmlNode.SelectNodes("intermediateExchange");
            if (intermediateExchangeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in intermediateExchangeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intermediateExchangeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(intermediateExchangeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intermediateExchangeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        intermediateExchange = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region InitialExchange
        private XsdTypeBoolean initialExchange;
        public XsdTypeBoolean InitialExchange
        {
            get
            {
                if (this.initialExchange != null)
                {
                    return this.initialExchange; 
                }
                else if (this.initialExchangeIDRef != null)
                {
                    initialExchange = IDManager.getID(initialExchangeIDRef) as XsdTypeBoolean;
                    return this.initialExchange; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialExchange != value)
                {
                    this.initialExchange = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FinalExchange
        private XsdTypeBoolean finalExchange;
        public XsdTypeBoolean FinalExchange
        {
            get
            {
                if (this.finalExchange != null)
                {
                    return this.finalExchange; 
                }
                else if (this.finalExchangeIDRef != null)
                {
                    finalExchange = IDManager.getID(finalExchangeIDRef) as XsdTypeBoolean;
                    return this.finalExchange; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.finalExchange != value)
                {
                    this.finalExchange = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region IntermediateExchange
        private XsdTypeBoolean intermediateExchange;
        public XsdTypeBoolean IntermediateExchange
        {
            get
            {
                if (this.intermediateExchange != null)
                {
                    return this.intermediateExchange; 
                }
                else if (this.intermediateExchangeIDRef != null)
                {
                    intermediateExchange = IDManager.getID(intermediateExchangeIDRef) as XsdTypeBoolean;
                    return this.intermediateExchange; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intermediateExchange != value)
                {
                    this.intermediateExchange = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

