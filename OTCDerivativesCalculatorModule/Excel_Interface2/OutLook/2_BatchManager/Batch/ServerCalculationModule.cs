using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class ServerCalculationModule
    {
        public void calculate(List<Excel_instrumentViewModel> instList, DateTime refDate)
        {
            MessageManager messageManager = new MessageManager();

            messageManager.loadServerInformation();

            foreach (var item in instList)
            {
                item.loadBatchDetailContext();

                item.buildParameterFromInstrument(refDate);

                //item.calculateSavedXml(refDate);

                MessageViewModel mvm = new MessageViewModel();

                mvm.MessageHeaderViewModel_.MessageType_ = "ENQUEUE";

                GridCalculationViewModel gcvm = MessageBodyViewModel.CreateMessageBody("gridCalculation") as GridCalculationViewModel;

                gcvm.Inst_code_ = item.MasterInformationViewModel_.Item_code_;
                gcvm.Inst_name_ = item.MasterInformationViewModel_.Item_name_;
                gcvm.Inst_type_ = item.MasterInformationViewModel_.Booking_type_;
                gcvm.Para_refDate_ = item.Excel_parameterViewModel_.ReferenceDate_;

                gcvm.InnerXml_ = item.calculationXml();

                mvm.TargetCode_ = "gridCalculation";
                mvm.MessageBodyViewModel_ = gcvm;

                messageManager.send(mvm);
            }

            // 다 보냄 우선

            // 글고

            //MessageViewModel calStartMsgVM = new MessageViewModel();

            //calStartMsgVM.MessageHeaderViewModel_.MessageType_ = "GRIDCALCULATIONSTART";

            //GridCalculationStartViewModel gcsvm = new GridCalculationStartViewModel();

            //calStartMsgVM.MessageBodyViewModel_ = gcsvm;

            //calStartMsgVM.TargetCode_ = "gridCalculation";

            //messageManager.send(calStartMsgVM);
        }
    }
}
