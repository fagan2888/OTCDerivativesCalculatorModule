using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class ELSOptionTemplate : ContentsListViewModel
    {
        public ELSOptionTemplate() 
        {
            this.InstrumentTemplateList_.Add(new TemplateBarrierCallPut());
        }
    }
}
