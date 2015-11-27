using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class NCRWrapperViewModel
    {
        

        public double DeltaPosition_ { get; set; }
        public double GammaPosition_ { get; set; }
        public double VegaPosition_ { get; set; }
        public double ThetaPosition_ { get; set; }

        //public static NCRWrapperViewModel CreateNCRVM(InstrumentBaseViewModel instrument)
        //{
        //    NCRWrapperViewModel vm = new NCRWrapperViewModel();
        //    ResultModel resultModel = 

        //    vm.DeltaPosition_ = 

        //    return vm;
        //}

        public NCRWrapperViewModel() { }
    }
}
