//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using System.IO;

//namespace RiskMonitor
//{
//    public class StepDownKIBaseViewModel : InstrumentBaseViewModel
//    {
//        public StepDownKIBaseViewModel(string itemCode, FileInfo fileInfo)
//            : base(itemCode,fileInfo)
//        {
//            this.instBase_ = new StepDownInstBase(itemCode);

//        }

//        protected override void setInstrumentVM(string instType) 
//        {
//            //여기서 inst는 이미 로드가 끝나있음.
//            if (true)
//            {
//                this.InstrumentViewModel_ = new StandardInstViewModel();
                
//            }
//        }

//        protected override void setParameterVM(string parameterType)
//        {
//            if (true)
//            {
//                this.ParameterViewModel_ = new StepDownKIParameterViewModel();
                
//            }

//        }

//        protected override void setResultVM(string resultType)
//        {
//            if (true)
//            {
//                this.ResultViewModel_ = new StepDownKIResultViewModel();
//            }
//        }



//        public override void calculate(DateTime referenceDate)
//        {
//            this.loadProductFile();
//            this.loadParaResultFile(referenceDate);

//            this.instBase_.calculate();

//            this.saveParaResultFile(referenceDate);
//        }
//    }
//}
