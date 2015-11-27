using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace XmlBuilder.DataLoader
{
    public class XmlDataLoader
    {
        public List<InstrumentModel.Instrument> InstrumentList_ {get; set;}
        private string folderPath_ = @".\";

        public string FileName_ { get; set; }
        public string Code_ { get; set; } // key
        

        public XmlDataLoader() 
        {
        
        }

        public InstrumentModel.Instrument loadInstrument(string code)
        {
            string[] filePaths = Directory.GetFiles(folderPath_, "code.xml");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(filePaths[0]);

            return this.productClassification(doc);

        }

        public void loadXml() 
        {
            this.InstrumentList_ = new List<InstrumentModel.Instrument>();
            
            // 우선 전체를 로딩함.

            //string[] filePaths = Directory.GetFiles(@"c:\MyDir\", "*.bmp",
            //                             SearchOption.AllDirectories);

            string[] filePaths = Directory.GetFiles(folderPath_, "*.xml");

            //List<XmlDocument> xmlDocList = new List<XmlDocument>();

            foreach (string item in filePaths)
	        {
		        XmlDocument doc =  new XmlDocument();
                doc.LoadXml(item);
                // type 을 가져옴.

                InstrumentList_.Add(this.productClassification(doc));
	        }

        }

        private InstrumentModel.Instrument productClassification(XmlDocument doc)
        {

            //if(true)
            //{
            
            //}
            //else if (true)
            //{

            //}
            //else 
            //{
            
            //}

            throw new NotImplementedException();
        }

    }
}
