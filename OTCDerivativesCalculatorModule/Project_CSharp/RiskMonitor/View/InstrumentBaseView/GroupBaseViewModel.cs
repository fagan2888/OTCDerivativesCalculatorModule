using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RiskMonitor
{
    public class GroupBaseViewModel : InstrumentBaseViewModel
    {

        public List<InstrumentViewModel> InstrumentViewModelList_ { get; set; }
        public List<PricingParameterViewModel> PricingParameterViewModelList_ { get; set; }
        public List<ResultViewModel> ResultViewModelList_ { get; set; }

        public GroupBaseViewModel(InstUriInfo instUri)
        : base(instUri)
        {
        }

        protected override string calculateImpl()
        {
            throw new NotImplementedException();
        }

        protected override void buildInstrumentXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        protected override void buildParaResultXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        protected override void loadInstrumentFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        protected override void loadParaResultFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }


        public override void loadSampleParaResult()
        {
            throw new NotImplementedException();
        }

        protected override void buildParaXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
