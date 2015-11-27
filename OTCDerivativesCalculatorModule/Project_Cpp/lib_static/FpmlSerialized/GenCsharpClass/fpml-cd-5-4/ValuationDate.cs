using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ValuationDate
    {
        public ValuationDate(XmlNode xmlNode)
        {
            XmlNodeList singleValuationDateNodeList = xmlNode.SelectNodes("singleValuationDate");
            if (singleValuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in singleValuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        singleValuationDateIDRef = item.Attributes["id"].Name;
                        SingleValuationDate ob = SingleValuationDate();
                        IDManager.SetID(singleValuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        singleValuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        singleValuationDate = new SingleValuationDate(item);
                    }
                }
            }
            
        
            XmlNodeList multipleValuationDatesNodeList = xmlNode.SelectNodes("multipleValuationDates");
            if (multipleValuationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multipleValuationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multipleValuationDatesIDRef = item.Attributes["id"].Name;
                        MultipleValuationDates ob = MultipleValuationDates();
                        IDManager.SetID(multipleValuationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multipleValuationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multipleValuationDates = new MultipleValuationDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region SingleValuationDate
        private SingleValuationDate singleValuationDate;
        public SingleValuationDate SingleValuationDate
        {
            get
            {
                if (this.singleValuationDate != null)
                {
                    return this.singleValuationDate; 
                }
                else if (this.singleValuationDateIDRef != null)
                {
                    singleValuationDate = IDManager.getID(singleValuationDateIDRef) as SingleValuationDate;
                    return this.singleValuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.singleValuationDate != value)
                {
                    this.singleValuationDate = value;
                }
            }
        }
        #endregion
        
        public string SingleValuationDateIDRef { get; set; }
        #region MultipleValuationDates
        private MultipleValuationDates multipleValuationDates;
        public MultipleValuationDates MultipleValuationDates
        {
            get
            {
                if (this.multipleValuationDates != null)
                {
                    return this.multipleValuationDates; 
                }
                else if (this.multipleValuationDatesIDRef != null)
                {
                    multipleValuationDates = IDManager.getID(multipleValuationDatesIDRef) as MultipleValuationDates;
                    return this.multipleValuationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multipleValuationDates != value)
                {
                    this.multipleValuationDates = value;
                }
            }
        }
        #endregion
        
        public string MultipleValuationDatesIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

