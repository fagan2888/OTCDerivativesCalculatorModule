using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class GreekPositionViewModel_Backup
    {

        public string ItemCode_ { get; set; }
        public string ItemName_ { get; set; }

        public double DeltaPosition_ { get; set; }
        public double GammaPosition_ { get; set; }
        public double VegaPosition_ { get; set; }
        public double ThetaPosition_ { get; set; }

        //public List<NCRWrapperViewModel> NCRWrapperVMList_ { get; set; }

        //public static List<GreekPositionViewModel> CreateUnderGreekPositionVM(InstrumentHierarchyViewModel instrumentHierarchyVM, DateTime referenceDate)
        //{
        //    List<GreekPositionViewModel> vmList_ = new List<GreekPositionViewModel>();

        //    instrumentHierarchyVM.loadParaResult(referenceDate);

        //    InstrumentBase instBase = instrumentHierarchyVM.InstrumentBaseViewModel_.InstBase_;

        //    ResultModel resultModel = instBase.Result_;

        //    GreekResultInfo greekResultInfo = resultModel.GreekResultInfo_;

        //    int underCount = greekResultInfo.UnderCount_;

        //    for (int i = 0; i < underCount; i++)
        //    {
        //        GreekPositionViewModel gpVM = new GreekPositionViewModel();

        //        gpVM.ItemCode_ = greekResultInfo.GreekResultList_[i].ItemCode_;
        //        gpVM.ItemCode_ = greekResultInfo.GreekResultList_[i].ItemName_;
        //        gpVM.DeltaPosition_ = greekResultInfo.GreekResultList_[i].DeltaPosition_;
        //        gpVM.GammaPosition_ = greekResultInfo.GreekResultList_[i].GammaPosition_;
        //        gpVM.VegaPosition_ = greekResultInfo.GreekResultList_[i].VegaPosition_;

        //        vmList_.Add(gpVM);
        //    }

        //    return vmList_;
        //}

        //public static List<GreekPositionViewModel> CreateInstGreekPositionVM(InstrumentBaseViewModel instrumentBaseVM, DateTime referenceDate)
        //{ 
        
        //}

        //calculation 담당
        public GreekPositionViewModel_Backup()
        { 
        }

        public void add(GreekPositionViewModel_Backup vm)
        {
            this.DeltaPosition_ += vm.DeltaPosition_;
            this.GammaPosition_ += vm.GammaPosition_;
            this.VegaPosition_ += vm.VegaPosition_;
            this.ThetaPosition_ += vm.ThetaPosition_;
        }
        


    }
}
