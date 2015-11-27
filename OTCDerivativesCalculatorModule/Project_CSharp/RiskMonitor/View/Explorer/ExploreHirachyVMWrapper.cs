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
    public abstract class ExploreHirachyVMWrapper : HirachyInstrumentVM 
    {

        public ExploreHirachyVMWrapper(InstrumentBaseViewModel instBaseVM)
        : base(instBaseVM) 
        {
            this.initialize();
        }

        private void initialize()
        {
            //this.InstUri_ = this.instBaseVM_.InstUri_;
            //this.instBaseVM_.loadInstrument();
        }

        //public void loadInstBaseVM() 
        //{
        //    //this.instBaseVM_ = InstrumentBaseViewModel.CreateInstBaseVM(this.itemCode_ , this.fileInfo_);
        //    this.instBaseVM_.loadInstrument();
        //}

        //public abstract void buildXml(XmlWriter xmlWriter);
        //public abstract void setFromXml(XmlNode InstNode);
        //public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public static ExploreHirachyVMWrapper CreateExploreHirachyWrapper(InstrumentBaseViewModel instBaseVM)
        {
            if (instBaseVM.InstUri_.itemType_ == "Group")
            {
                return new ExploreHirachyGroupVMWrapper(instBaseVM);
            }
            else
            {
                return new ExploreHirachyInstrumentVMWrapper(instBaseVM);
            }
        }
    }
}
