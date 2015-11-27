using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using AvalonDock.Layout;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
    public class TemplateStepDownWithKI : InstrumentTemplate
    {
        //public LayoutDocument LayoutDoc_ { get; set; }


        public ELSStepDownMaketViewModel MaketVM_ { get; set; }

        public TemplateStepDownWithKI() 
        {
            this.Type_ = "ELSStepDownWithKI";
        }


        public override LayoutDocument documentView()
        {
            LayoutDocument layoutDoc = new LayoutDocument();
            //layoutDoc.Content = StepDownInstViewModel.stepDownInstView();

            return layoutDoc;
        }

        public override InstrumentBaseViewModel instrumentBaseVM()
        {
            StepDownKIBaseViewModel vm = new StepDownKIBaseViewModel(ItemCode_, FileInfo_);

            return vm;
        }

        public override void saveFile()
        {
            XmlDocument doc = new XmlDocument();

            string InstName = "ELS999";
            long notional = 10000;
            List<string> unders = new List<string>();
            unders.Add("SK"); unders.Add("LG");
            DateTime effectiveDate = new DateTime();
            int maturityYear = 3;
            int redemTenorMonth = 6;
            List<double> redemptionTrigger = new List<double>();
            redemptionTrigger.Add(0.95);
            redemptionTrigger.Add(0.95);
            redemptionTrigger.Add(0.90);
            redemptionTrigger.Add(0.90);
            redemptionTrigger.Add(0.85);
            redemptionTrigger.Add(0.85);

            int averageDays  = 1;
            List<double> KIs = new List<double>();
            KIs.Add(0.55);KIs.Add(0.55);
            double cpnYear = 0.09;

            
            //string xmlText = InstrumentMakerTool.ELSStepDown(InstName,
            //                                               notional,
            //                                              unders,
            //                                              effectiveDate,
            //                                              maturityYear,
            //                                              redemTenorMonth,
            //                                              redemptionTrigger,
            //                                              averageDays,
            //                                              KIs,
            //                                              cpnYear);

            string xmlText = "";
            doc.LoadXml(xmlText);

            //doc.InnerText = MaketVM_.fileXml();

            //doc.Save(Path_ + this.FileName_ + ".xml");
            doc.Save(this.FileInfo_.FullName);
        }

    }
}
