using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExerciseProcedure
    {
        public ExerciseProcedure(XmlNode xmlNode)
        {
            XmlNodeList manualExerciseNodeList = xmlNode.SelectNodes("manualExercise");
            if (manualExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in manualExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        manualExerciseIDRef = item.Attributes["id"].Name;
                        ManualExercise ob = ManualExercise();
                        IDManager.SetID(manualExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        manualExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        manualExercise = new ManualExercise(item);
                    }
                }
            }
            
        
            XmlNodeList automaticExerciseNodeList = xmlNode.SelectNodes("automaticExercise");
            if (automaticExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in automaticExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef = item.Attributes["id"].Name;
                        AutomaticExercise ob = AutomaticExercise();
                        IDManager.SetID(automaticExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        automaticExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        automaticExercise = new AutomaticExercise(item);
                    }
                }
            }
            
        
            XmlNodeList followUpConfirmationNodeList = xmlNode.SelectNodes("followUpConfirmation");
            if (followUpConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in followUpConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        followUpConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(followUpConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        followUpConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        followUpConfirmation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList limitedRightToConfirmNodeList = xmlNode.SelectNodes("limitedRightToConfirm");
            if (limitedRightToConfirmNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in limitedRightToConfirmNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        limitedRightToConfirmIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(limitedRightToConfirmIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        limitedRightToConfirmIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        limitedRightToConfirm = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList splitTicketNodeList = xmlNode.SelectNodes("splitTicket");
            if (splitTicketNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in splitTicketNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        splitTicketIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(splitTicketIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        splitTicketIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        splitTicket = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ManualExercise
        private ManualExercise manualExercise;
        public ManualExercise ManualExercise
        {
            get
            {
                if (this.manualExercise != null)
                {
                    return this.manualExercise; 
                }
                else if (this.manualExerciseIDRef != null)
                {
                    manualExercise = IDManager.getID(manualExerciseIDRef) as ManualExercise;
                    return this.manualExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.manualExercise != value)
                {
                    this.manualExercise = value;
                }
            }
        }
        #endregion
        
        public string ManualExerciseIDRef { get; set; }
        #region AutomaticExercise
        private AutomaticExercise automaticExercise;
        public AutomaticExercise AutomaticExercise
        {
            get
            {
                if (this.automaticExercise != null)
                {
                    return this.automaticExercise; 
                }
                else if (this.automaticExerciseIDRef != null)
                {
                    automaticExercise = IDManager.getID(automaticExerciseIDRef) as AutomaticExercise;
                    return this.automaticExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.automaticExercise != value)
                {
                    this.automaticExercise = value;
                }
            }
        }
        #endregion
        
        public string AutomaticExerciseIDRef { get; set; }
        #region FollowUpConfirmation
        private XsdTypeBoolean followUpConfirmation;
        public XsdTypeBoolean FollowUpConfirmation
        {
            get
            {
                if (this.followUpConfirmation != null)
                {
                    return this.followUpConfirmation; 
                }
                else if (this.followUpConfirmationIDRef != null)
                {
                    followUpConfirmation = IDManager.getID(followUpConfirmationIDRef) as XsdTypeBoolean;
                    return this.followUpConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.followUpConfirmation != value)
                {
                    this.followUpConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region LimitedRightToConfirm
        private XsdTypeBoolean limitedRightToConfirm;
        public XsdTypeBoolean LimitedRightToConfirm
        {
            get
            {
                if (this.limitedRightToConfirm != null)
                {
                    return this.limitedRightToConfirm; 
                }
                else if (this.limitedRightToConfirmIDRef != null)
                {
                    limitedRightToConfirm = IDManager.getID(limitedRightToConfirmIDRef) as XsdTypeBoolean;
                    return this.limitedRightToConfirm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.limitedRightToConfirm != value)
                {
                    this.limitedRightToConfirm = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SplitTicket
        private XsdTypeBoolean splitTicket;
        public XsdTypeBoolean SplitTicket
        {
            get
            {
                if (this.splitTicket != null)
                {
                    return this.splitTicket; 
                }
                else if (this.splitTicketIDRef != null)
                {
                    splitTicket = IDManager.getID(splitTicketIDRef) as XsdTypeBoolean;
                    return this.splitTicket; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.splitTicket != value)
                {
                    this.splitTicket = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

