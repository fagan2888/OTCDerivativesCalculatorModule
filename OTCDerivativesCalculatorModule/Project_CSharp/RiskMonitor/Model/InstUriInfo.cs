using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class InstUriInfo
    {

        public InstUriInfo()
        { 
        }

        public InstUriInfo(string itemCode, string itemType, Uri uri)
        {
            this.itemCode_ = itemCode;
            this.itemType_ = itemType;
            this.Uri_ = uri;
        }

        public Uri Uri_ { get; set; }

        public string itemCode_ { get; set; }
        public string itemType_ { get; set; }

        public bool isExist()
        {
            //check;

            return true;
        }
            
    }
}
