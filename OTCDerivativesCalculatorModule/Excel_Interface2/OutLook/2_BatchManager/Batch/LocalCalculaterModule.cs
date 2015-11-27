using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class LocalCalculationModule
    {
        public List<BatchItemViewModel> WholeBatchItemViewModel_;
        //public List<BatchItemViewModel> BindingBatchItemViewModel_;

        public void calculate(List<Excel_instrumentViewModel> instList, DateTime refDate)
        {
            foreach (var item in instList)
            {
                item.loadBatchDetailContext();

                item.buildParameterFromInstrument(refDate);
                
                item.calculateSavedXml(refDate);
            }
        }
    }
}
