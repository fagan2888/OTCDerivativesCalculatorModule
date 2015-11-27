using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Monthly_ComboBoxItem : I_FrequencyComboBoxItem
    {
        public Monthly_ComboBoxItem()
        {
            this.FrequencyEnum_ = FrequencyEnum.Monthly;
            this.TypeString_ = "Monthly";
        }

        //public override DateTime nextDate(DateTime d,DateAdjustInfo adjust)
        public override DateTime nextDate(DateTime d)
        {
            return d.AddMonths(1);
        }
    }
}
