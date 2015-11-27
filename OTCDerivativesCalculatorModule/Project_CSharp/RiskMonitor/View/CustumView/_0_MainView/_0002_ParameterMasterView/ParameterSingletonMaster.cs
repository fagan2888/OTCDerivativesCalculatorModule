using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ParameterSingletonMaster
    {

        public Underlying_paraViewModel stockIndex_underlying_paraViewModel_ { get; set; }
        public Underlying_paraViewModel _underlying_paraViewModel_ { get; set; }

        public UnderlyingInfo_paraViewModel makeParameterInfoVM(FpmlSerializedCSharp.UnderlyingInformation xml_underInfo)
        {

            UnderlyingInfo_paraViewModel underInfoParaVM = new UnderlyingInfo_paraViewModel();

            ObservableCollection<Underlying_paraViewModel> underParaVMList = new ObservableCollection<Underlying_paraViewModel>();

            List<FpmlSerializedCSharp.Index> xml_indexList = xml_underInfo.IndexUnderInfo_.Index_;

            foreach (var item in xml_indexList)
	        {
		        underParaVMList.Add(this.makeIndexPara(item));
	        }

            // correlation 
            CorrelationInfo_paraViewModel corr_paraVM = this.makeCorrPara(xml_indexList);

            return underInfoParaVM;
        }

        public CorrelationInfo_paraViewModel makeCorrPara(List<FpmlSerializedCSharp.Index> xml_indexList)
        {
            CorrelationInfo_paraViewModel vm = new CorrelationInfo_paraViewModel();

            vm.Dimension_ = xml_indexList.Count.ToString();

            for (int i = 0; i < xml_indexList.Count; i++)
            {
                Correlation_paraViewModel corrParaVM = new Correlation_paraViewModel();
                
                corrParaVM.First_ = "KR7012330007";
                corrParaVM.Second_ = "KR7011170008";
                corrParaVM.Value_ = "0.3328";

                vm.Correlation_paraViewModel_.Add(corrParaVM);
            }

            return vm;
        }

        public Underlying_paraViewModel makeIndexPara(FpmlSerializedCSharp.Index xml_index)
        {
            Underlying_paraViewModel vm;

            string processType = "";

            if (xml_index.Type_.ValueStr == "stockIndex")
            {
                processType = "geometricBM";
                vm = Underlying_paraViewModel.CreateUnderlying_para(processType);
            }
            else if (xml_index.Type_.ValueStr == "stockIndex")
            {
                processType = "geometricBM";
                vm = Underlying_paraViewModel.CreateUnderlying_para(processType);
            }
            else 
            {
                processType = "geometricBM";
                vm = Underlying_paraViewModel.CreateUnderlying_para(processType);
            }

            return vm;
        
        }

        //fundCode 며 , book 이며 , 상품 code 며 이런거 받아야함
        //아.. 이게 따로 댈라나.... ㅡ.ㅡ;;
        
        public void loadData(UnderlyingInfo_paraViewModel underInfoParaVM)
        {
            //underInfoParaVM.
        }
    }
}
