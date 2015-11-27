using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExerciseProcedure : ISerialized
    {
        public ExerciseProcedure(XmlNode xmlNode)
        {
            XmlNode manualExerciseNode = xmlNode.SelectSingleNode("manualExercise");
            
            if (manualExerciseNode != null)
            {
                if (manualExerciseNode.Attributes["href"] != null || manualExerciseNode.Attributes["id"] != null) 
                {
                    if (manualExerciseNode.Attributes["id"] != null) 
                    {
                        manualExerciseIDRef_ = manualExerciseNode.Attributes["id"].Value;
                        ManualExercise ob = new ManualExercise(manualExerciseNode);
                        IDManager.SetID(manualExerciseIDRef_, ob);
                    }
                    else if (manualExerciseNode.Attributes["href"] != null)
                    {
                        manualExerciseIDRef_ = manualExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        manualExercise_ = new ManualExercise(manualExerciseNode);
                    }
                }
                else
                {
                    manualExercise_ = new ManualExercise(manualExerciseNode);
                }
            }
            
        
            XmlNode automaticExerciseNode = xmlNode.SelectSingleNode("automaticExercise");
            
            if (automaticExerciseNode != null)
            {
                if (automaticExerciseNode.Attributes["href"] != null || automaticExerciseNode.Attributes["id"] != null) 
                {
                    if (automaticExerciseNode.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["id"].Value;
                        AutomaticExercise ob = new AutomaticExercise(automaticExerciseNode);
                        IDManager.SetID(automaticExerciseIDRef_, ob);
                    }
                    else if (automaticExerciseNode.Attributes["href"] != null)
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        automaticExercise_ = new AutomaticExercise(automaticExerciseNode);
                    }
                }
                else
                {
                    automaticExercise_ = new AutomaticExercise(automaticExerciseNode);
                }
            }
            
        
            XmlNode followUpConfirmationNode = xmlNode.SelectSingleNode("followUpConfirmation");
            
            if (followUpConfirmationNode != null)
            {
                if (followUpConfirmationNode.Attributes["href"] != null || followUpConfirmationNode.Attributes["id"] != null) 
                {
                    if (followUpConfirmationNode.Attributes["id"] != null) 
                    {
                        followUpConfirmationIDRef_ = followUpConfirmationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(followUpConfirmationNode);
                        IDManager.SetID(followUpConfirmationIDRef_, ob);
                    }
                    else if (followUpConfirmationNode.Attributes["href"] != null)
                    {
                        followUpConfirmationIDRef_ = followUpConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        followUpConfirmation_ = new XsdTypeBoolean(followUpConfirmationNode);
                    }
                }
                else
                {
                    followUpConfirmation_ = new XsdTypeBoolean(followUpConfirmationNode);
                }
            }
            
        
            XmlNode limitedRightToConfirmNode = xmlNode.SelectSingleNode("limitedRightToConfirm");
            
            if (limitedRightToConfirmNode != null)
            {
                if (limitedRightToConfirmNode.Attributes["href"] != null || limitedRightToConfirmNode.Attributes["id"] != null) 
                {
                    if (limitedRightToConfirmNode.Attributes["id"] != null) 
                    {
                        limitedRightToConfirmIDRef_ = limitedRightToConfirmNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(limitedRightToConfirmNode);
                        IDManager.SetID(limitedRightToConfirmIDRef_, ob);
                    }
                    else if (limitedRightToConfirmNode.Attributes["href"] != null)
                    {
                        limitedRightToConfirmIDRef_ = limitedRightToConfirmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        limitedRightToConfirm_ = new XsdTypeBoolean(limitedRightToConfirmNode);
                    }
                }
                else
                {
                    limitedRightToConfirm_ = new XsdTypeBoolean(limitedRightToConfirmNode);
                }
            }
            
        
            XmlNode splitTicketNode = xmlNode.SelectSingleNode("splitTicket");
            
            if (splitTicketNode != null)
            {
                if (splitTicketNode.Attributes["href"] != null || splitTicketNode.Attributes["id"] != null) 
                {
                    if (splitTicketNode.Attributes["id"] != null) 
                    {
                        splitTicketIDRef_ = splitTicketNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(splitTicketNode);
                        IDManager.SetID(splitTicketIDRef_, ob);
                    }
                    else if (splitTicketNode.Attributes["href"] != null)
                    {
                        splitTicketIDRef_ = splitTicketNode.Attributes["href"].Value;
                    }
                    else
                    {
                        splitTicket_ = new XsdTypeBoolean(splitTicketNode);
                    }
                }
                else
                {
                    splitTicket_ = new XsdTypeBoolean(splitTicketNode);
                }
            }
            
        
        }
        
    
        #region ManualExercise_
        private ManualExercise manualExercise_;
        public ManualExercise ManualExercise_
        {
            get
            {
                if (this.manualExercise_ != null)
                {
                    return this.manualExercise_; 
                }
                else if (this.manualExerciseIDRef_ != null)
                {
                    manualExercise_ = IDManager.getID(manualExerciseIDRef_) as ManualExercise;
                    return this.manualExercise_; 
                }
                else
                {
                      return this.manualExercise_; 
                }
            }
            set
            {
                if (this.manualExercise_ != value)
                {
                    this.manualExercise_ = value;
                }
            }
        }
        #endregion
        
        public string manualExerciseIDRef_ { get; set; }
        #region AutomaticExercise_
        private AutomaticExercise automaticExercise_;
        public AutomaticExercise AutomaticExercise_
        {
            get
            {
                if (this.automaticExercise_ != null)
                {
                    return this.automaticExercise_; 
                }
                else if (this.automaticExerciseIDRef_ != null)
                {
                    automaticExercise_ = IDManager.getID(automaticExerciseIDRef_) as AutomaticExercise;
                    return this.automaticExercise_; 
                }
                else
                {
                      return this.automaticExercise_; 
                }
            }
            set
            {
                if (this.automaticExercise_ != value)
                {
                    this.automaticExercise_ = value;
                }
            }
        }
        #endregion
        
        public string automaticExerciseIDRef_ { get; set; }
        #region FollowUpConfirmation_
        private XsdTypeBoolean followUpConfirmation_;
        public XsdTypeBoolean FollowUpConfirmation_
        {
            get
            {
                if (this.followUpConfirmation_ != null)
                {
                    return this.followUpConfirmation_; 
                }
                else if (this.followUpConfirmationIDRef_ != null)
                {
                    followUpConfirmation_ = IDManager.getID(followUpConfirmationIDRef_) as XsdTypeBoolean;
                    return this.followUpConfirmation_; 
                }
                else
                {
                      return this.followUpConfirmation_; 
                }
            }
            set
            {
                if (this.followUpConfirmation_ != value)
                {
                    this.followUpConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string followUpConfirmationIDRef_ { get; set; }
        #region LimitedRightToConfirm_
        private XsdTypeBoolean limitedRightToConfirm_;
        public XsdTypeBoolean LimitedRightToConfirm_
        {
            get
            {
                if (this.limitedRightToConfirm_ != null)
                {
                    return this.limitedRightToConfirm_; 
                }
                else if (this.limitedRightToConfirmIDRef_ != null)
                {
                    limitedRightToConfirm_ = IDManager.getID(limitedRightToConfirmIDRef_) as XsdTypeBoolean;
                    return this.limitedRightToConfirm_; 
                }
                else
                {
                      return this.limitedRightToConfirm_; 
                }
            }
            set
            {
                if (this.limitedRightToConfirm_ != value)
                {
                    this.limitedRightToConfirm_ = value;
                }
            }
        }
        #endregion
        
        public string limitedRightToConfirmIDRef_ { get; set; }
        #region SplitTicket_
        private XsdTypeBoolean splitTicket_;
        public XsdTypeBoolean SplitTicket_
        {
            get
            {
                if (this.splitTicket_ != null)
                {
                    return this.splitTicket_; 
                }
                else if (this.splitTicketIDRef_ != null)
                {
                    splitTicket_ = IDManager.getID(splitTicketIDRef_) as XsdTypeBoolean;
                    return this.splitTicket_; 
                }
                else
                {
                      return this.splitTicket_; 
                }
            }
            set
            {
                if (this.splitTicket_ != value)
                {
                    this.splitTicket_ = value;
                }
            }
        }
        #endregion
        
        public string splitTicketIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

