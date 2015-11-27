using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ISerialized
    {


        public ISerialized()
        { 
        }

        public ISerialized(XmlNode node) 
        {
        
        }

        public string ID_ { get; set; }
        //public string HREF_ { get; set; }
    }
}
