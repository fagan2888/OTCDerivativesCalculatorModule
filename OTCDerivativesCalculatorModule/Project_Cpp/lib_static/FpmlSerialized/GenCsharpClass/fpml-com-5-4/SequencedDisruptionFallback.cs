using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SequencedDisruptionFallback
    {
        public SequencedDisruptionFallback(XmlNode xmlNode)
        {
            XmlNodeList fallbackNodeList = xmlNode.SelectNodes("fallback");
            if (fallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackIDRef = item.Attributes["id"].Name;
                        DisruptionFallback ob = DisruptionFallback();
                        IDManager.SetID(fallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallback = new DisruptionFallback(item);
                    }
                }
            }
            
        
            XmlNodeList sequenceNodeList = xmlNode.SelectNodes("sequence");
            if (sequenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sequenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sequenceIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(sequenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sequenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sequence = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region Fallback
        private DisruptionFallback fallback;
        public DisruptionFallback Fallback
        {
            get
            {
                if (this.fallback != null)
                {
                    return this.fallback; 
                }
                else if (this.fallbackIDRef != null)
                {
                    fallback = IDManager.getID(fallbackIDRef) as DisruptionFallback;
                    return this.fallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallback != value)
                {
                    this.fallback = value;
                }
            }
        }
        #endregion
        
        public string DisruptionFallbackIDRef { get; set; }
        #region Sequence
        private XsdTypePositiveInteger sequence;
        public XsdTypePositiveInteger Sequence
        {
            get
            {
                if (this.sequence != null)
                {
                    return this.sequence; 
                }
                else if (this.sequenceIDRef != null)
                {
                    sequence = IDManager.getID(sequenceIDRef) as XsdTypePositiveInteger;
                    return this.sequence; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sequence != value)
                {
                    this.sequence = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

