using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class SemiAnnual_ComboBoxItem : I_FrequencyComboBoxItem
    {
        public SemiAnnual_ComboBoxItem()
        {
            this.FrequencyEnum_ = FrequencyEnum.SemiAnnual;
            this.TypeString_ = "SemiAnnual";
        }

        public override DateTime nextDate(DateTime d)
        {
            return d.AddMonths(6);
        }
    }
}
