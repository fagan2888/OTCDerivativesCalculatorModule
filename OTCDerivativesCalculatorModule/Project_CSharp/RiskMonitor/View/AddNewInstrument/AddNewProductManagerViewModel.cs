using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class AddNewProductManagerViewModel
    {
        public AddNewProductSettings Settings_ { get; set; }

        LocalTemplateViewModel localTemplateVM_ { get; set; }
        OnlineTemplateViewModel onlineTemplateVM_ { get; set; }

    }
}
