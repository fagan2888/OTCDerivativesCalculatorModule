using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Once_ComboBoxItem : I_FrequencyComboBoxItem
    {
        public int SelectedIndex_ = 0;

        public Once_ComboBoxItem()
        {
            this.FrequencyEnum_ = I_FrequencyComboBoxItem.FrequencyEnum.Once;
            this.TypeString_ = "Once";
        }

        public override DateTime nextDate(DateTime d)
        {
            return d.AddMonths(1);
        }
    }
}
