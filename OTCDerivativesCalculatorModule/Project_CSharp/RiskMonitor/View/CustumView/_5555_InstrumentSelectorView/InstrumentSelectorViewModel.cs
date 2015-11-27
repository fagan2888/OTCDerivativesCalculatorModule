using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class InstrumentSelectorViewModel
    {
        public static Uri PrototypeUri_ = new Uri("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\prototype\\");

        #region PrototypeList_
        private Dictionary<string,InstrumentBaseViewModel> prototypeList_;
        public Dictionary<string,InstrumentBaseViewModel> PrototypeList_
        {
            get { return this.prototypeList_; }
            set
            {
                if (this.prototypeList_ != value)
                {
                    this.prototypeList_ = value;
                    //this.NotifyPropertyChanged("PrototypeList_");
                }
            }
        }
        #endregion

        public InstrumentSelectorViewModel()
        {
            this.prototypeList_ = new Dictionary<string,InstrumentBaseViewModel>();
            string typeStr = "";

            typeStr = "stepDownKI";
            this.prototypeList_.Add(typeStr, this.getInstBaseVM("stepDownKI"));

            typeStr = "multiNameCDS";
            this.prototypeList_.Add(typeStr, this.getInstBaseVM("multiNameCDS"));
    

        }

        private InstrumentBaseViewModel getInstBaseVM(string typeStr)
        { 
            InstrumentBaseViewModel instBaseVM;

            Uri instIUri = new Uri(PrototypeUri_.LocalPath + "prototype_" + typeStr + ".xml");
            Uri resultUri = new Uri(PrototypeUri_.LocalPath + "00000000_prototype_" + typeStr + ".xml");

            if (typeStr == "stepDownKI" || typeStr == "multiNameCDS")
            {
                InstUriInfo instUriInfo = new InstUriInfo("", "", instIUri);
                ResultUriInfo resultUriInfo = new ResultUriInfo("", "", resultUri);

                instBaseVM = new StandardInstBaseViewModel(instUriInfo);
                instBaseVM.ReferenceDate_ = PositionSingletonManger.referenceDate();
                instBaseVM.ResultUri_ = resultUriInfo;

                return instBaseVM;
            }
            else
            {
                InstUriInfo instUriInfo = new InstUriInfo("", "", new Uri(""));
                instBaseVM = new NoExistInstrumentBaseViewModel(instUriInfo);
                return instBaseVM;
            }
        }

    }
}
