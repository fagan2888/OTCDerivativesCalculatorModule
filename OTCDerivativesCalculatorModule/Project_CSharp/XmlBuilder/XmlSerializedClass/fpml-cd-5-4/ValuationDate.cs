using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ValuationDate : ISerialized
    {
        public ValuationDate(XmlNode xmlNode)
        {
            XmlNode singleValuationDateNode = xmlNode.SelectSingleNode("singleValuationDate");
            
            if (singleValuationDateNode != null)
            {
                if (singleValuationDateNode.Attributes["href"] != null || singleValuationDateNode.Attributes["id"] != null) 
                {
                    if (singleValuationDateNode.Attributes["id"] != null) 
                    {
                        singleValuationDateIDRef_ = singleValuationDateNode.Attributes["id"].Value;
                        SingleValuationDate ob = new SingleValuationDate(singleValuationDateNode);
                        IDManager.SetID(singleValuationDateIDRef_, ob);
                    }
                    else if (singleValuationDateNode.Attributes["href"] != null)
                    {
                        singleValuationDateIDRef_ = singleValuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        singleValuationDate_ = new SingleValuationDate(singleValuationDateNode);
                    }
                }
                else
                {
                    singleValuationDate_ = new SingleValuationDate(singleValuationDateNode);
                }
            }
            
        
            XmlNode multipleValuationDatesNode = xmlNode.SelectSingleNode("multipleValuationDates");
            
            if (multipleValuationDatesNode != null)
            {
                if (multipleValuationDatesNode.Attributes["href"] != null || multipleValuationDatesNode.Attributes["id"] != null) 
                {
                    if (multipleValuationDatesNode.Attributes["id"] != null) 
                    {
                        multipleValuationDatesIDRef_ = multipleValuationDatesNode.Attributes["id"].Value;
                        MultipleValuationDates ob = new MultipleValuationDates(multipleValuationDatesNode);
                        IDManager.SetID(multipleValuationDatesIDRef_, ob);
                    }
                    else if (multipleValuationDatesNode.Attributes["href"] != null)
                    {
                        multipleValuationDatesIDRef_ = multipleValuationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multipleValuationDates_ = new MultipleValuationDates(multipleValuationDatesNode);
                    }
                }
                else
                {
                    multipleValuationDates_ = new MultipleValuationDates(multipleValuationDatesNode);
                }
            }
            
        
        }
        
    
        #region SingleValuationDate_
        private SingleValuationDate singleValuationDate_;
        public SingleValuationDate SingleValuationDate_
        {
            get
            {
                if (this.singleValuationDate_ != null)
                {
                    return this.singleValuationDate_; 
                }
                else if (this.singleValuationDateIDRef_ != null)
                {
                    singleValuationDate_ = IDManager.getID(singleValuationDateIDRef_) as SingleValuationDate;
                    return this.singleValuationDate_; 
                }
                else
                {
                      return this.singleValuationDate_; 
                }
            }
            set
            {
                if (this.singleValuationDate_ != value)
                {
                    this.singleValuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string singleValuationDateIDRef_ { get; set; }
        #region MultipleValuationDates_
        private MultipleValuationDates multipleValuationDates_;
        public MultipleValuationDates MultipleValuationDates_
        {
            get
            {
                if (this.multipleValuationDates_ != null)
                {
                    return this.multipleValuationDates_; 
                }
                else if (this.multipleValuationDatesIDRef_ != null)
                {
                    multipleValuationDates_ = IDManager.getID(multipleValuationDatesIDRef_) as MultipleValuationDates;
                    return this.multipleValuationDates_; 
                }
                else
                {
                      return this.multipleValuationDates_; 
                }
            }
            set
            {
                if (this.multipleValuationDates_ != value)
                {
                    this.multipleValuationDates_ = value;
                }
            }
        }
        #endregion
        
        public string multipleValuationDatesIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

