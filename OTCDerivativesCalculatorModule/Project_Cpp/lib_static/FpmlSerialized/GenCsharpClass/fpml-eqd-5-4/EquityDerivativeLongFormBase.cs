using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityDerivativeLongFormBase
    {
        public EquityDerivativeLongFormBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dividendConditionsNodeList = xmlNode.SelectNodes("dividendConditions");
            if (dividendConditionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendConditionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendConditionsIDRef = item.Attributes["id"].Name;
                        DividendConditions ob = DividendConditions();
                        IDManager.SetID(dividendConditionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendConditionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendConditions = new DividendConditions(item);
                    }
                }
            }
            
        
            XmlNodeList methodOfAdjustmentNodeList = xmlNode.SelectNodes("methodOfAdjustment");
            if (methodOfAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in methodOfAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef = item.Attributes["id"].Name;
                        MethodOfAdjustmentEnum ob = MethodOfAdjustmentEnum();
                        IDManager.SetID(methodOfAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        methodOfAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        methodOfAdjustment = new MethodOfAdjustmentEnum(item);
                    }
                }
            }
            
        
            XmlNodeList extraordinaryEventsNodeList = xmlNode.SelectNodes("extraordinaryEvents");
            if (extraordinaryEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extraordinaryEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extraordinaryEventsIDRef = item.Attributes["id"].Name;
                        ExtraordinaryEvents ob = ExtraordinaryEvents();
                        IDManager.SetID(extraordinaryEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extraordinaryEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extraordinaryEvents = new ExtraordinaryEvents(item);
                    }
                }
            }
            
        
        }
        
    
        #region DividendConditions
        private DividendConditions dividendConditions;
        public DividendConditions DividendConditions
        {
            get
            {
                if (this.dividendConditions != null)
                {
                    return this.dividendConditions; 
                }
                else if (this.dividendConditionsIDRef != null)
                {
                    dividendConditions = IDManager.getID(dividendConditionsIDRef) as DividendConditions;
                    return this.dividendConditions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendConditions != value)
                {
                    this.dividendConditions = value;
                }
            }
        }
        #endregion
        
        public string DividendConditionsIDRef { get; set; }
        #region MethodOfAdjustment
        private MethodOfAdjustmentEnum methodOfAdjustment;
        public MethodOfAdjustmentEnum MethodOfAdjustment
        {
            get
            {
                if (this.methodOfAdjustment != null)
                {
                    return this.methodOfAdjustment; 
                }
                else if (this.methodOfAdjustmentIDRef != null)
                {
                    methodOfAdjustment = IDManager.getID(methodOfAdjustmentIDRef) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.methodOfAdjustment != value)
                {
                    this.methodOfAdjustment = value;
                }
            }
        }
        #endregion
        
        public string MethodOfAdjustmentEnumIDRef { get; set; }
        #region ExtraordinaryEvents
        private ExtraordinaryEvents extraordinaryEvents;
        public ExtraordinaryEvents ExtraordinaryEvents
        {
            get
            {
                if (this.extraordinaryEvents != null)
                {
                    return this.extraordinaryEvents; 
                }
                else if (this.extraordinaryEventsIDRef != null)
                {
                    extraordinaryEvents = IDManager.getID(extraordinaryEventsIDRef) as ExtraordinaryEvents;
                    return this.extraordinaryEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extraordinaryEvents != value)
                {
                    this.extraordinaryEvents = value;
                }
            }
        }
        #endregion
        
        public string ExtraordinaryEventsIDRef { get; set; }
        
    
        
    
    }
    
}

