using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class ResultUriInfo
    {
        
        public ResultUriInfo(string itemCode, string itemType, Uri uri)
        {
            this.itemCode_ = itemCode;
            this.itemType_ = itemType;
            this.Uri_ = uri;
        }

        public Uri Uri_ { get; set; }

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    //this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        public string itemCode_ { get; set; }
        public string itemType_ { get; set; }

        public string IsExist_ { get; set; }

        public bool isExist()
        {
            //check;

            return true;
        }

        public void setReferenceDate(DateTime ReferenceDate_)
        {
            throw new NotImplementedException();
        }
    }
}
