using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class TradeEventViewModel
    {
        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region TradeType_
        protected string tradeType;
        public string TradeType_
        {
            get { return this.tradeType; }
            set
            {
                if (this.tradeType != value)
                {
                    this.tradeType = value;
                    this.NotifyPropertyChanged("TradeType_");
                }
            }
        }
        #endregion


    }
}
