using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Factory_ELSGreekPosition
    {
        private DataSet dataSet_;

        public Factory_ELSGreekPosition() 
        {
            dataSet_ = this.loadDataSet();
        }

        public GreekPositionAnalyzerViewModel viewModel()
        {
            GreekPositionAnalyzerViewModel viewModel = new GreekPositionAnalyzerViewModel();
            
            //// StockList를 뜸

            //DataLoader_ELSUnderlyingStock loader = new DataLoader_ELSUnderlyingStock();

            //List<ELSUnderlyingStock> stockList = loader.ELSUnderlyingStockListLoad();

            //foreach (ELSUnderlyingStock stock in stockList)
            //{

            //    ObservableCollection<ELSStepDownGreekPositionViewModel> instList = this.getELS(stock);

            //    ELSUnderlyingViewModel underViewModel = new ELSUnderlyingViewModel(stock, instList);
                                
            //    viewModel.UnderlyingViewModelList_.Add(underViewModel);
                
            //}
            
            return viewModel;

        }

        //private ObservableCollection<ELSStepDownGreekPositionViewModel> getELS(ELSUnderlyingStock stock)
        //{
        //    ObservableCollection<ELSStepDownGreekPositionViewModel> instVMList = new ObservableCollection<ELSStepDownGreekPositionViewModel>();

        //    DataLoader_StepDownELSInformation loader = new DataLoader_StepDownELSInformation();

        //    List<StepDownELSInformation> instList = loader.ELSDeltaHedgePositionLoad();

        //    foreach (StepDownELSInformation inst in instList)
        //    {
        //        if (inst.hasUnderlying(stock))
        //        {
        //            ELSStepDownGreekPositionViewModel viewModel = new ELSStepDownGreekPositionViewModel(stock, inst);
        //            instVMList.Add(viewModel);
        //        }

        //    }

        //    return instVMList;
        //}

        private DataSet loadDataSet()
        {
            throw new NotImplementedException();
        }

    }
}
