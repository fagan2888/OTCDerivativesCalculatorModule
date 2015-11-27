using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Notional
    {
        public Notional(XmlNode xmlNode)
        {
            XmlNodeList notionalStepScheduleNodeList = xmlNode.SelectNodes("notionalStepSchedule");
            if (notionalStepScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalStepScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalStepScheduleIDRef = item.Attributes["id"].Name;
                        NonNegativeAmountSchedule ob = NonNegativeAmountSchedule();
                        IDManager.SetID(notionalStepScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalStepScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalStepSchedule = new NonNegativeAmountSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList notionalStepParametersNodeList = xmlNode.SelectNodes("notionalStepParameters");
            if (notionalStepParametersNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalStepParametersNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalStepParametersIDRef = item.Attributes["id"].Name;
                        NotionalStepRule ob = NotionalStepRule();
                        IDManager.SetID(notionalStepParametersIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalStepParametersIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalStepParameters = new NotionalStepRule(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotionalStepSchedule
        private NonNegativeAmountSchedule notionalStepSchedule;
        public NonNegativeAmountSchedule NotionalStepSchedule
        {
            get
            {
                if (this.notionalStepSchedule != null)
                {
                    return this.notionalStepSchedule; 
                }
                else if (this.notionalStepScheduleIDRef != null)
                {
                    notionalStepSchedule = IDManager.getID(notionalStepScheduleIDRef) as NonNegativeAmountSchedule;
                    return this.notionalStepSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalStepSchedule != value)
                {
                    this.notionalStepSchedule = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeAmountScheduleIDRef { get; set; }
        #region NotionalStepParameters
        private NotionalStepRule notionalStepParameters;
        public NotionalStepRule NotionalStepParameters
        {
            get
            {
                if (this.notionalStepParameters != null)
                {
                    return this.notionalStepParameters; 
                }
                else if (this.notionalStepParametersIDRef != null)
                {
                    notionalStepParameters = IDManager.getID(notionalStepParametersIDRef) as NotionalStepRule;
                    return this.notionalStepParameters; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalStepParameters != value)
                {
                    this.notionalStepParameters = value;
                }
            }
        }
        #endregion
        
        public string NotionalStepRuleIDRef { get; set; }
        
    
        
    
    }
    
}

