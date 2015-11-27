using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class CorrelationParaSetting
    {
        protected ParameterSettingManager owner_parameterSettingManager_;

        public CorrelationParaSetting(ParameterSettingManager parameterSettingManager)
        {
            this.owner_parameterSettingManager_ = parameterSettingManager;
        }

        public ObservableCollection<Excel_correlation_paraViewModel> corrInfo(Excel_underlyingCalcInfoViewModel excel_ucivm)
        {
            DateTime refDate = this.owner_parameterSettingManager_.ReferenceDate_;

            ObservableCollection<Excel_correlation_paraViewModel> corrParaList = new ObservableCollection<Excel_correlation_paraViewModel>();
            ObservableCollection<Excel_underlyingInfoViewModel> underInfoVMList = excel_ucivm.Excel_underlyingInfoViewModel_;

            int underNum = excel_ucivm.Excel_underlyingInfoViewModel_.Count;

            Excel_correlation_paraViewModel corr = new Excel_correlation_paraViewModel();

            corr.First_ = underInfoVMList[0].KrCode_;
            corr.Second_ = underInfoVMList[0].KrCode_;
            corr.Value_ = "1.0";

            corrParaList.Add(corr);

            for (int under_i = 1; under_i < underInfoVMList.Count; under_i++)
            {
                int preUnderNum = under_i;

                Excel_correlation_paraViewModel diagCorrVM = new Excel_correlation_paraViewModel();

                diagCorrVM.First_ = underInfoVMList[under_i].KrCode_;
                diagCorrVM.Second_ = underInfoVMList[under_i].KrCode_;
                diagCorrVM.Value_ = "1.0";

                corrParaList.Add(diagCorrVM);

                for (int i = 0; i < preUnderNum; i++)
                {
                    //Excel_correlation_paraViewModel e_corr = new Excel_correlation_paraViewModel();

                    //// 새롭게 추가된 underlying을 넣음
                    //e_corr.First_ = addedUnderInfoVM.KrCode_;

                    //// 기존꺼를 넣음
                    //e_corr.Second_ = preCorrParaList[i];

                    //// value는 default 0 이 드감.

                    //e_corr.value_ = "0.0";

                    //this.correlationDataList_.Add(e_corr);

                    Excel_correlation_paraViewModel e_corrVM_1 = new Excel_correlation_paraViewModel();

                    e_corrVM_1.First_ = underInfoVMList[under_i].KrCode_;
                    e_corrVM_1.Second_ = underInfoVMList[i].KrCode_;

                    // data load
                    e_corrVM_1.Value_ = this.value(refDate, e_corrVM_1.First_, e_corrVM_1.Second_);

                    corrParaList.Add(e_corrVM_1);

                    Excel_correlation_paraViewModel e_corrVM_2 = new Excel_correlation_paraViewModel();

                    e_corrVM_2.First_ = underInfoVMList[i].KrCode_;
                    e_corrVM_2.Second_ = underInfoVMList[under_i].KrCode_;

                    e_corrVM_2.Value_ = this.value(refDate, e_corrVM_2.First_, e_corrVM_2.Second_); ;

                    corrParaList.Add(e_corrVM_2);

                }
            }


            return corrParaList;

        }

        public abstract string value(DateTime refDate, string code, string other_code);
    }
}
