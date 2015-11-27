using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SubEvent
    {
        public SubEvent(XmlNode xmlNode)
        {
            XmlNodeList refEventIDNodeList = xmlNode.SelectNodes("refEventID");
            if (refEventIDNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in refEventIDNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        refEventIDIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(refEventIDIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        refEventIDIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        refEventID = new XsdTypeToken(item);
                    }
                }
            }
            
        
            XmlNodeList truefalseNodeList = xmlNode.SelectNodes("truefalse");
            if (truefalseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in truefalseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        truefalseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(truefalseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        truefalseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        truefalse = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region RefEventID
        private XsdTypeToken refEventID;
        public XsdTypeToken RefEventID
        {
            get
            {
                if (this.refEventID != null)
                {
                    return this.refEventID; 
                }
                else if (this.refEventIDIDRef != null)
                {
                    refEventID = IDManager.getID(refEventIDIDRef) as XsdTypeToken;
                    return this.refEventID; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.refEventID != value)
                {
                    this.refEventID = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        #region Truefalse
        private XsdTypeBoolean truefalse;
        public XsdTypeBoolean Truefalse
        {
            get
            {
                if (this.truefalse != null)
                {
                    return this.truefalse; 
                }
                else if (this.truefalseIDRef != null)
                {
                    truefalse = IDManager.getID(truefalseIDRef) as XsdTypeBoolean;
                    return this.truefalse; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.truefalse != value)
                {
                    this.truefalse = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

