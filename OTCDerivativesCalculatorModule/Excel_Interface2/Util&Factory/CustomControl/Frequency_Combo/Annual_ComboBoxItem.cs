using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Annual_ComboBoxItem : I_FrequencyComboBoxItem
    {

        public Annual_ComboBoxItem()
        {
            this.FrequencyEnum_ = FrequencyEnum.Annual;
            this.TypeString_ = "Annual";
        }

        public override DateTime nextDate(DateTime d)
        {
            return d.AddMonths(12);
        }
    }
}
