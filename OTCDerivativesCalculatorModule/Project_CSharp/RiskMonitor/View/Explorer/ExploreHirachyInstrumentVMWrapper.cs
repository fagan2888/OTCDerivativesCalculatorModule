using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
    public class ExploreHirachyInstrumentVMWrapper : ExploreHirachyVMWrapper 
    {

        public ExploreHirachyInstrumentVMWrapper(InstrumentBaseViewModel instBaseVM)
        : base(instBaseVM)
        {
            //this.InstUri_ = instUri;
            //this.instBaseVM_ = instBaseVM;
            //this.initialize();

        }

        private void initialize()
        {
            this.InstUri_ = this.InstBaseVM_.InstUri_;
            //this.instBaseVM_.loadInstrument();
            
        }

        //public void loadInstBaseVM() 
        //{
        //    //this.instBaseVM_ = InstrumentBaseViewModel.CreateInstBaseVM(this.itemCode_ , this.fileInfo_);
        //    this.instBaseVM_.loadInstrument();
        //}

        public override void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(XmlNode InstNode)
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
            this.productType_ = serial_header.ProductType_.ValueStr;
            this.itemCode_ = serial_header.KrCode_.ValueStr;

            //this.loadInstBaseVM();

            //foreach (var item in serial_hirachy.InstHirachyInfo_)
            //{
            //    this.HirachyInstVMList_ = new ObservableCollection<HirachyInstrumentVM>();
            //    ExploreHirachyInstrumentVMWrapper exploreHirachyInstVMWrapper = new ExploreHirachyInstrumentVMWrapper();
            //    exploreHirachyInstVMWrapper.setFromSerial(serial_hirachy);
            //    this.HirachyInstVMList_.Add(exploreHirachyInstVMWrapper);                    
            //}

        }

        //public Control view()
        //{
        //    this.InstBaseVM_.loadAll();
        //    return this.InstBaseVM_.View_;
        //}


    }
}
