using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class CalculationManagerViewModel
    {
        public BookViewModel BookViewModel_ { get; set; }
        public CalculationSetting CalculationSetting_ { get; set; }

        public CalculationManagerViewModel()
        { 
        
        }

        public void setBook(BookViewModel bvm)
        {
            this.BookViewModel_ = bvm;

        }

        public void calculate(DateTime refDate)
        { 
            List<Excel_instrumentViewModel> instList = new List<Excel_instrumentViewModel>();

            //this.BookViewModel_.loadInstrument();

            BookViewModel_.getInstrument(instList);

            if (this.CalculationSetting_.CalculateTypeEnum_ == CalculationSetting.CalculateTypeEnum.Local)
            {
                LocalCalculationModule lcm = new LocalCalculationModule();

                lcm.calculate(instList, refDate);
            }
            else if (this.CalculationSetting_.CalculateTypeEnum_ == CalculationSetting.CalculateTypeEnum.Parellel)
            {
                ServerCalculationModule scm = new ServerCalculationModule();

                scm.calculate(instList, refDate);
            }
            else
            { 
                
            }

            // 
        }

        
    }
}
