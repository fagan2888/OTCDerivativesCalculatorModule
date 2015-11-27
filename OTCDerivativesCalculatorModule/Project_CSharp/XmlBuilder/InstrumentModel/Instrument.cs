using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.ViewModel;
using System.Xml;

namespace XmlBuilder.InstrumentModel
{
    public class Instrument
    {
        private string fileName_;
        public string Name_ { get; set; }
        public string InstrmentName_ { get; set; }
        public string Notional_ { get; set; }

        // 나중에 없애버릴거
        public Instrument(string name) 
        {
            this.Name_ = name;
        }

        public Instrument(XmlDocument xmlDoc) 
        {
            //hear 정도만 여기서 build함.
            this.buildFromXml(xmlDoc);
        }

        public Instrument(DataSet bookingData) 
        {
            //hear 정도만 여기서 build함.
            this.buildFromDataSet();
            
        }

        private void buildFromDataSet()
        {
            throw new NotImplementedException();
        }

        private void buildFromXml(XmlDocument xmlDoc)
        {
            this.fileName_ = "";
            this.Name_ = "";
            this.Notional_ = "";
        }

        

        
    }

        

}
