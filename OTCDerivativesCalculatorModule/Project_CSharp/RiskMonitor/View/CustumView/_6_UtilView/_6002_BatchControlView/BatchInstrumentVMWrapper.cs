using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    public class BatchInstrumentVMWrapper : InstrumentWrapperVM
    {

        #region ResultFileInfo_
        private FileInfo resultFileInfo_;
        public FileInfo ResultFileInfo_
        {
            get { return this.resultFileInfo_; }
            set
            {
                if (this.resultFileInfo_ != value)
                {
                    this.resultFileInfo_ = value;
                    this.NotifyPropertyChanged("ResultFileInfo_");
                }
            }
        }
        #endregion

        //public string KRCode_ { get; set; }
        //public string InstName_ { get; set; }
        //public string InstCode_ { get; set; }
        //public string CalValue_ { get; set; }
        //public string CalUnitValue_ { get; set; }

        public DateTime ReferenceDate_ { get; set; }

        //public DateTime CalculateDate_ { get; set; }

        //public string FileName_ { get; set; }
        //public string InstType_ { get; set; }
        //public string ResultType_ { get; set; }

        public bool IsCalculateFlag_ { get; set; }
        public bool ParaExistFlag_ { get; set; }

        public InstResultMasterWrapperVM InstResultMasterWrapperVM_ { get; set; }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public BatchInstrumentVMWrapper(InstrumentBaseViewModel instBaseVM)
        {
            this.InstBaseVM_ = instBaseVM;
        }

        public BatchInstrumentVMWrapper(InstResultMasterWrapperVM instRMWrapperVM)
        {
            this.InstBaseVM_ = instRMWrapperVM.InstBaseVM_;
            this.InstResultMasterWrapperVM_ = instRMWrapperVM;

            if (instRMWrapperVM.CalculateDate_ != null) { this.IsCalculateFlag_ = true; }
            else { this.IsCalculateFlag_ = false; }

            this.ParaExistFlag_ = instRMWrapperVM.ParameterExistFlag_;

        }

        //private bool isCalculated()
        //{
        //    if (ParaExistFlag_)
        //    {
        //        FileInfo fileInfo = new FileInfo(this.InstBaseVM_.paraResultPath(this.ReferenceDate_));
        //        XmlDocument resultXml = new XmlDocument();
        //        resultXml.Load(fileInfo.FullName);
        //        FpmlSerializedCSharp.ParaRoot xmlParaRoot = new FpmlSerializedCSharp.ParaRoot(resultXml);

        //        if (xmlParaRoot.Pricing_.PricingResult_ != null)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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
            FpmlSerializedCSharp.InstHirachyInfo serial_hirachy = serial_Class as FpmlSerializedCSharp.InstHirachyInfo;

            //this.itemCode_ = serial_hirachy.Code_.ValueStr;
            //this.productType_ = serial_hirachy.Type_.ValueStr;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.InstUri_.Uri_.LocalPath);

            XmlNode headerNode = xmlDoc.SelectSingleNode("instrument/header");

            FpmlSerializedCSharp.Header serial_header = new FpmlSerializedCSharp.Header(headerNode);

            //this.productName_ = serial_header.ProductName_.ValueStr;

        }

        //public void calculate(DateTime referenceDate)
        //{
        //    this.StartTime_ = DateTime.Now;

        //    //this.instrumentBaseViewModel_.loadProduct();
        //    //this.instrumentBaseViewModel_.loadParaResult();
        //    this.instrumentBaseViewModel_.calculate(referenceDate);

        //    this.Price_ = this.instrumentBaseViewModel_.Price_;
        //    this.UnitPrice_ = this.instrumentBaseViewModel_.UnitPrice_;

        //    this.EndTime_ = DateTime.Now;
        //    this.IsCalculateFlag_ = true;
        //}

        //public void loadParaResult(DateTime referenceDate)
        //{
        //    OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
        //                                       this.krCode_,
        //                                       "Loading From Xml File..."));
        //    //try
        //    //{
        //    //    this.instrumentBaseViewModel_.loadParaResult(referenceDate);
        //    //    this.IsExistFlag_ = true;
        //    //    OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
        //    //                                   this.krCode_,
        //    //                                   "Complete Load From Xml File..."));
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    this.IsExistFlag_ = false;
        //    //    OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
        //    //                                   this.krCode_,
        //    //                                   e.Message));

        //    //}

        //    this.instrumentBaseViewModel_.loadParaResult(referenceDate);
        //    this.IsCalculateFlag_ = this.instrumentBaseViewModel_.InstBase_.IsCalculated_;

        //    this.IsExistFlag_ = true;
        //    this.IsLoadedFlag_ = true;

        //    this.Price_ = this.instrumentBaseViewModel_.Price_;
        //    this.UnitPrice_ = this.instrumentBaseViewModel_.UnitPrice_;

        //    OutputLogViewModel.addResult(new ProcessOutput(this.instName_,
        //                                   this.krCode_,
        //                                   "Complete Load From Xml File..."));


        //}




        
    }
}
