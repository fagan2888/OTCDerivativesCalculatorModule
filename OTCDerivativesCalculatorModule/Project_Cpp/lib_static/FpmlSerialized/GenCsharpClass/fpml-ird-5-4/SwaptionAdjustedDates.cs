using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SwaptionAdjustedDates
    {
        public SwaptionAdjustedDates(XmlNode xmlNode)
        {
            XmlNodeList exerciseEventNodeList = xmlNode.SelectNodes("exerciseEvent");
            
            foreach (XmlNode item in exerciseEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseEventIDRef = item.Attributes["id"].Name;
                        List<ExerciseEvent> ob = new List<ExerciseEvent>();
                        ob.Add(new ExerciseEvent(item));
                        IDManager.SetID(exerciseEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    exerciseEvent.Add(new ExerciseEvent(item));
                    }
                }
            }
            
        
        }
        
    
        #region ExerciseEvent
        private List<ExerciseEvent> exerciseEvent;
        public List<ExerciseEvent> ExerciseEvent
        {
            get
            {
                if (this.exerciseEvent != null)
                {
                    return this.exerciseEvent; 
                }
                else if (this.exerciseEventIDRef != null)
                {
                    exerciseEvent = IDManager.getID(exerciseEventIDRef) as List<ExerciseEvent>;
                    return this.exerciseEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseEvent != value)
                {
                    this.exerciseEvent = value;
                }
            }
        }
        #endregion
        
        public string ExerciseEventIDRef { get; set; }
        
    
        
    
    }
    
}

