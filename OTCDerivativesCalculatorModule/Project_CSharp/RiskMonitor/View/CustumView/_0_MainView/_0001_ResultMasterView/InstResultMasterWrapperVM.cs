using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class InstResultMasterWrapperVM : InstrumentWrapperVM
    {
        public string KRCode_ { get; set; }
        public string InstName_ { get; set; }
        public string InstCode_ { get; set; }
        public string CalValue_ { get; set; }
        public string CalUnitValue_ { get; set; }
        public string ReferenceDate_ { get; set; }
        public string CalculateDate_ { get; set; }
        public string FileName_ { get; set; }
        public string InstType_ { get; set; }
        public string ResultType_ { get; set; }

        public ResultMasterInfo ResultMasterInfo_ { get; set; }

        public bool ParameterExistFlag_ { get; set; }

        public InstResultMasterWrapperVM(InstrumentBaseViewModel instBaseVM)
        {
            this.InstBaseVM_ = instBaseVM;
            this.ParameterExistFlag_ = false;
        }

        public InstResultMasterWrapperVM(InstrumentBaseViewModel instBaseVM,ResultMasterInfo resultMasterInfo)
        {
            this.InstBaseVM_ = instBaseVM;
            this.ParameterExistFlag_ = true;

            this.ResultMasterInfo_ = resultMasterInfo;

            this.KRCode_ = resultMasterInfo.KRCode_;
            this.InstName_ = resultMasterInfo.InstName_;
            this.InstCode_ = resultMasterInfo.InstCode_;
            this.CalValue_ = resultMasterInfo.CalValue_;
            this.CalUnitValue_ = resultMasterInfo.CalUnitValue_;
            this.ReferenceDate_ = resultMasterInfo.ReferenceDate_;
            this.FileName_ = resultMasterInfo.FileName_;
            this.InstType_ = resultMasterInfo.InstType_;
            this.ResultType_ = resultMasterInfo.ResultType_;

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
