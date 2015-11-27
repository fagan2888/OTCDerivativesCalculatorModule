using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExerciseProcedureOption
    {
        public ExerciseProcedureOption(XmlNode xmlNode)
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
                        Empty ob = Empty();
                        IDManager.SetID(manualExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        manualExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        manualExercise = new Empty(item);
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
                        Empty ob = Empty();
                        IDManager.SetID(automaticExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        automaticExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        automaticExercise = new Empty(item);
                    }
                }
            }
            
        
        }
        
    
        #region ManualExercise
        private Empty manualExercise;
        public Empty ManualExercise
        {
            get
            {
                if (this.manualExercise != null)
                {
                    return this.manualExercise; 
                }
                else if (this.manualExerciseIDRef != null)
                {
                    manualExercise = IDManager.getID(manualExerciseIDRef) as Empty;
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
        
        public string EmptyIDRef { get; set; }
        #region AutomaticExercise
        private Empty automaticExercise;
        public Empty AutomaticExercise
        {
            get
            {
                if (this.automaticExercise != null)
                {
                    return this.automaticExercise; 
                }
                else if (this.automaticExerciseIDRef != null)
                {
                    automaticExercise = IDManager.getID(automaticExerciseIDRef) as Empty;
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
        
        public string EmptyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

