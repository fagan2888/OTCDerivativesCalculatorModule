using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ManualExercise
    {
        public ManualExercise(XmlNode xmlNode)
        {
            XmlNodeList exerciseNoticeNodeList = xmlNode.SelectNodes("exerciseNotice");
            if (exerciseNoticeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseNoticeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseNoticeIDRef = item.Attributes["id"].Name;
                        ExerciseNotice ob = ExerciseNotice();
                        IDManager.SetID(exerciseNoticeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseNoticeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseNotice = new ExerciseNotice(item);
                    }
                }
            }
            
        
            XmlNodeList fallbackExerciseNodeList = xmlNode.SelectNodes("fallbackExercise");
            if (fallbackExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackExerciseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fallbackExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallbackExercise = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ExerciseNotice
        private ExerciseNotice exerciseNotice;
        public ExerciseNotice ExerciseNotice
        {
            get
            {
                if (this.exerciseNotice != null)
                {
                    return this.exerciseNotice; 
                }
                else if (this.exerciseNoticeIDRef != null)
                {
                    exerciseNotice = IDManager.getID(exerciseNoticeIDRef) as ExerciseNotice;
                    return this.exerciseNotice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseNotice != value)
                {
                    this.exerciseNotice = value;
                }
            }
        }
        #endregion
        
        public string ExerciseNoticeIDRef { get; set; }
        #region FallbackExercise
        private XsdTypeBoolean fallbackExercise;
        public XsdTypeBoolean FallbackExercise
        {
            get
            {
                if (this.fallbackExercise != null)
                {
                    return this.fallbackExercise; 
                }
                else if (this.fallbackExerciseIDRef != null)
                {
                    fallbackExercise = IDManager.getID(fallbackExerciseIDRef) as XsdTypeBoolean;
                    return this.fallbackExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackExercise != value)
                {
                    this.fallbackExercise = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

