using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class DataInterfaceManager
    {
        public DataInterfaceManager()
        {

        }

        public void generateParaXml(DateTime refDate)
        {

            // book 상의 inst를 로드함.
            //{
            //    // 로드 전체 code list를 불름

            //    RootBookViewModel rbvm = new RootBookViewModel();

            //    RootBookViewModel.setRootBookReferenceDate(refDate);

            //    rbvm.loadPosition();

            //    //List<string> codeList = rbvm.getWholeItemCode();
            //    List<Excel_instrumentViewModel> e_instVMList =
            //        rbvm.getWholeInstrument();
            //}



            foreach (var item in MasterInformationViewModel.WholeMasterPosition_)
            {
                //Excel_instrumentViewModel instrument =
                //    CodeClassificationGenerator.CreateInstrument(item);

                //instrument.Item_code_ = item;

                //item.loadInterfaceVMFromXml();
                item.loadBatchDetailContext();

                item.buildParameterFromInstrument(refDate);
                //item.loadMarketData(refDate);

                //string result = item.generateParameterXml();

                XMLFileLoader.SaveParameter(item.Excel_parameterViewModel_);

            }


        }
    }
}
