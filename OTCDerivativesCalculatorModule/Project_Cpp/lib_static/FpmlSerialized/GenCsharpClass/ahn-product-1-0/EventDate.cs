using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventDate
    {
        public EventDate(XmlNode xmlNode)
        {
            XmlNodeList dateSingleNodeList = xmlNode.SelectNodes("dateSingle");
            if (dateSingleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateSingleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateSingleIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(dateSingleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateSingleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateSingle = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region DateSingle
        private XsdTypeDate dateSingle;
        public XsdTypeDate DateSingle
        {
            get
            {
                if (this.dateSingle != null)
                {
                    return this.dateSingle; 
                }
                else if (this.dateSingleIDRef != null)
                {
                    dateSingle = IDManager.getID(dateSingleIDRef) as XsdTypeDate;
                    return this.dateSingle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateSingle != value)
                {
                    this.dateSingle = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

