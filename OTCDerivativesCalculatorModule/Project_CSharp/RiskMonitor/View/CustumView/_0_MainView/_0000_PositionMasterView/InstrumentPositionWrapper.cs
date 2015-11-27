using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class InstPositionWrapperVM : InstrumentWrapperVM
    {
        public DateTime ReferenceDate_ { get; set; }

        public string KRCode_ { get; set; }
        public string InstName_ { get; set; }
        public string InstCode_ { get; set; }
        public string BookedDate_ { get; set; }
        public string UnBookedDate_ { get; set; }
        public string MaturityDate_ { get; set; }
        public string InstType_ { get; set; }
        public string FileName_ { get; set; }
        public string PositionName_ { get; set; }
        public string CounterParty_ { get; set; }
        public string Notional_ { get; set; }
        public string Currency_ { get; set; }
        public string FundCode_ { get; set; }
        public string FundName_ { get; set; }

        public InstPositionWrapperVM(InstPositionInfo instData,InstrumentBaseViewModel instBaseVM)
        {
            this.InstBaseVM_ = instBaseVM;

            this.InstUri_ = instBaseVM.InstUri_;
            this.ResultUri_ = instBaseVM.ResultUri_;
            this.KRCode_= instData.KRCode_ ;
            this.InstName_ = instData.InstName_;
            this.InstCode_ = instData.InstCode_ ;
            this.InstType_ = instData.InstType_ ;
            this.CounterParty_ = instData.CounterParty_;
            this.BookedDate_ = instData.BookedDate_ ;
            this.UnBookedDate_ = instData.UnBookedDate_;
            this.MaturityDate_ = instData.MaturityDate_;
            this.Notional_ = instData.Notional_;
            
        }

        public InstPositionWrapperVM(InstrumentBaseViewModel instBaseVM)
        {
            this.InstUri_ = instBaseVM.InstUri_;
            this.ResultUri_ = instBaseVM.ResultUri_;
            this.InstCode_ = instBaseVM.ItemCode_;
            this.InstType_ = instBaseVM.ItemType_;
            this.InstBaseVM_ = instBaseVM;

        }


        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }
    }
}
