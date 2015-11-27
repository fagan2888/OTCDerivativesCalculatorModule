using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalendarSpread
    {
        public CalendarSpread(XmlNode xmlNode)
        {
            XmlNodeList expirationDateTwoNodeList = xmlNode.SelectNodes("expirationDateTwo");
            if (expirationDateTwoNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expirationDateTwoNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expirationDateTwoIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(expirationDateTwoIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expirationDateTwoIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expirationDateTwo = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExpirationDateTwo
        private AdjustableOrRelativeDate expirationDateTwo;
        public AdjustableOrRelativeDate ExpirationDateTwo
        {
            get
            {
                if (this.expirationDateTwo != null)
                {
                    return this.expirationDateTwo; 
                }
                else if (this.expirationDateTwoIDRef != null)
                {
                    expirationDateTwo = IDManager.getID(expirationDateTwoIDRef) as AdjustableOrRelativeDate;
                    return this.expirationDateTwo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expirationDateTwo != value)
                {
                    this.expirationDateTwo = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}

