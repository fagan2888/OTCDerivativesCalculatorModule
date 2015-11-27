using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionExpiry : AbstractEvent
    {
        public OptionExpiry(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            if (tradeIdentifierNodeList != null)
            {
                this.tradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in tradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(tradeIdentifierIDRef_, tradeIdentifier_[tradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode dateNode = xmlNode.SelectSingleNode("date");
            
            if (dateNode != null)
            {
                if (dateNode.Attributes["href"] != null || dateNode.Attributes["id"] != null) 
                {
                    if (dateNode.Attributes["id"] != null) 
                    {
                        dateIDRef_ = dateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(dateNode);
                        IDManager.SetID(dateIDRef_, ob);
                    }
                    else if (dateNode.Attributes["href"] != null)
                    {
                        dateIDRef_ = dateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        date_ = new XsdTypeDate(dateNode);
                    }
                }
                else
                {
                    date_ = new XsdTypeDate(dateNode);
                }
            }
            
        
            XmlNode timeNode = xmlNode.SelectSingleNode("time");
            
            if (timeNode != null)
            {
                if (timeNode.Attributes["href"] != null || timeNode.Attributes["id"] != null) 
                {
                    if (timeNode.Attributes["id"] != null) 
                    {
                        timeIDRef_ = timeNode.Attributes["id"].Value;
                        XsdTypeTime ob = new XsdTypeTime(timeNode);
                        IDManager.SetID(timeIDRef_, ob);
                    }
                    else if (timeNode.Attributes["href"] != null)
                    {
                        timeIDRef_ = timeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        time_ = new XsdTypeTime(timeNode);
                    }
                }
                else
                {
                    time_ = new XsdTypeTime(timeNode);
                }
            }
            
        
            XmlNode exerciseProcedureNode = xmlNode.SelectSingleNode("exerciseProcedure");
            
            if (exerciseProcedureNode != null)
            {
                if (exerciseProcedureNode.Attributes["href"] != null || exerciseProcedureNode.Attributes["id"] != null) 
                {
                    if (exerciseProcedureNode.Attributes["id"] != null) 
                    {
                        exerciseProcedureIDRef_ = exerciseProcedureNode.Attributes["id"].Value;
                        ExerciseProcedureOption ob = new ExerciseProcedureOption(exerciseProcedureNode);
                        IDManager.SetID(exerciseProcedureIDRef_, ob);
                    }
                    else if (exerciseProcedureNode.Attributes["href"] != null)
                    {
                        exerciseProcedureIDRef_ = exerciseProcedureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseProcedure_ = new ExerciseProcedureOption(exerciseProcedureNode);
                    }
                }
                else
                {
                    exerciseProcedure_ = new ExerciseProcedureOption(exerciseProcedureNode);
                }
            }
            
        
        }
        
    
        #region TradeIdentifier_
        private List<PartyTradeIdentifier> tradeIdentifier_;
        public List<PartyTradeIdentifier> TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        #region Date_
        private XsdTypeDate date_;
        public XsdTypeDate Date_
        {
            get
            {
                if (this.date_ != null)
                {
                    return this.date_; 
                }
                else if (this.dateIDRef_ != null)
                {
                    date_ = IDManager.getID(dateIDRef_) as XsdTypeDate;
                    return this.date_; 
                }
                else
                {
                      return this.date_; 
                }
            }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                }
            }
        }
        #endregion
        
        public string dateIDRef_ { get; set; }
        #region Time_
        private XsdTypeTime time_;
        public XsdTypeTime Time_
        {
            get
            {
                if (this.time_ != null)
                {
                    return this.time_; 
                }
                else if (this.timeIDRef_ != null)
                {
                    time_ = IDManager.getID(timeIDRef_) as XsdTypeTime;
                    return this.time_; 
                }
                else
                {
                      return this.time_; 
                }
            }
            set
            {
                if (this.time_ != value)
                {
                    this.time_ = value;
                }
            }
        }
        #endregion
        
        public string timeIDRef_ { get; set; }
        #region ExerciseProcedure_
        private ExerciseProcedureOption exerciseProcedure_;
        public ExerciseProcedureOption ExerciseProcedure_
        {
            get
            {
                if (this.exerciseProcedure_ != null)
                {
                    return this.exerciseProcedure_; 
                }
                else if (this.exerciseProcedureIDRef_ != null)
                {
                    exerciseProcedure_ = IDManager.getID(exerciseProcedureIDRef_) as ExerciseProcedureOption;
                    return this.exerciseProcedure_; 
                }
                else
                {
                      return this.exerciseProcedure_; 
                }
            }
            set
            {
                if (this.exerciseProcedure_ != value)
                {
                    this.exerciseProcedure_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseProcedureIDRef_ { get; set; }
        
    
        
    
    }
    
}

