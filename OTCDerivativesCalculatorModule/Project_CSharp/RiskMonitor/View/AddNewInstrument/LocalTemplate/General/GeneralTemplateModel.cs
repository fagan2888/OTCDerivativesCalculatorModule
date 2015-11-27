using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RiskMonitor
{
    public class GeneralTemplateModel : TemplateHirachyModel
    {
        public GeneralTemplateModel() 
        {
            this.Name_ = "General";
            this.instrumentTemplateList_.Add(new ELSStepDownTemplate());
        }

        //public override ObservableCollection<InstrumentTemplate> contentList()
        //{
        //    ObservableCollection<InstrumentTemplate> result = new ObservableCollection<InstrumentTemplate>();

        //    //result = new ELSStepDownTemplate().contentList();

        //    return result;

        //}
    }
}
