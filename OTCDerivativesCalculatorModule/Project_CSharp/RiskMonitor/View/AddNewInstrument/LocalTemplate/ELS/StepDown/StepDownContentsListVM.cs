using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class StepDownContentsListVM : ContentsListViewModel
    {
        public StepDownContentsListVM() 
        {
            this.InstrumentTemplateList_.Add(new TemplateStepDownWithKI());
            //this.InstrumentTemplateList_.Add(new TemplateStepDownProtection());
        }


    }
}
