using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Asian
    {
        public Asian(XmlNode xmlNode)
        {
            XmlNodeList averagingInOutNodeList = xmlNode.SelectNodes("averagingInOut");
            if (averagingInOutNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingInOutNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingInOutIDRef = item.Attributes["id"].Name;
                        AveragingInOutEnum ob = AveragingInOutEnum();
                        IDManager.SetID(averagingInOutIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingInOutIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingInOut = new AveragingInOutEnum(item);
                    }
                }
            }
            
        
            XmlNodeList strikeFactorNodeList = xmlNode.SelectNodes("strikeFactor");
            if (strikeFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikeFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList averagingPeriodInNodeList = xmlNode.SelectNodes("averagingPeriodIn");
            if (averagingPeriodInNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingPeriodInNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingPeriodInIDRef = item.Attributes["id"].Name;
                        AveragingPeriod ob = AveragingPeriod();
                        IDManager.SetID(averagingPeriodInIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingPeriodInIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingPeriodIn = new AveragingPeriod(item);
                    }
                }
            }
            
        
            XmlNodeList averagingPeriodOutNodeList = xmlNode.SelectNodes("averagingPeriodOut");
            if (averagingPeriodOutNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingPeriodOutNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingPeriodOutIDRef = item.Attributes["id"].Name;
                        AveragingPeriod ob = AveragingPeriod();
                        IDManager.SetID(averagingPeriodOutIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingPeriodOutIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingPeriodOut = new AveragingPeriod(item);
                    }
                }
            }
            
        
        }
        
    
        #region AveragingInOut
        private AveragingInOutEnum averagingInOut;
        public AveragingInOutEnum AveragingInOut
        {
            get
            {
                if (this.averagingInOut != null)
                {
                    return this.averagingInOut; 
                }
                else if (this.averagingInOutIDRef != null)
                {
                    averagingInOut = IDManager.getID(averagingInOutIDRef) as AveragingInOutEnum;
                    return this.averagingInOut; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingInOut != value)
                {
                    this.averagingInOut = value;
                }
            }
        }
        #endregion
        
        public string AveragingInOutEnumIDRef { get; set; }
        #region StrikeFactor
        private XsdTypeDecimal strikeFactor;
        public XsdTypeDecimal StrikeFactor
        {
            get
            {
                if (this.strikeFactor != null)
                {
                    return this.strikeFactor; 
                }
                else if (this.strikeFactorIDRef != null)
                {
                    strikeFactor = IDManager.getID(strikeFactorIDRef) as XsdTypeDecimal;
                    return this.strikeFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeFactor != value)
                {
                    this.strikeFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region AveragingPeriodIn
        private AveragingPeriod averagingPeriodIn;
        public AveragingPeriod AveragingPeriodIn
        {
            get
            {
                if (this.averagingPeriodIn != null)
                {
                    return this.averagingPeriodIn; 
                }
                else if (this.averagingPeriodInIDRef != null)
                {
                    averagingPeriodIn = IDManager.getID(averagingPeriodInIDRef) as AveragingPeriod;
                    return this.averagingPeriodIn; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingPeriodIn != value)
                {
                    this.averagingPeriodIn = value;
                }
            }
        }
        #endregion
        
        public string AveragingPeriodIDRef { get; set; }
        #region AveragingPeriodOut
        private AveragingPeriod averagingPeriodOut;
        public AveragingPeriod AveragingPeriodOut
        {
            get
            {
                if (this.averagingPeriodOut != null)
                {
                    return this.averagingPeriodOut; 
                }
                else if (this.averagingPeriodOutIDRef != null)
                {
                    averagingPeriodOut = IDManager.getID(averagingPeriodOutIDRef) as AveragingPeriod;
                    return this.averagingPeriodOut; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingPeriodOut != value)
                {
                    this.averagingPeriodOut = value;
                }
            }
        }
        #endregion
        
        public string AveragingPeriodIDRef { get; set; }
        
    
        
    
    }
    
}

