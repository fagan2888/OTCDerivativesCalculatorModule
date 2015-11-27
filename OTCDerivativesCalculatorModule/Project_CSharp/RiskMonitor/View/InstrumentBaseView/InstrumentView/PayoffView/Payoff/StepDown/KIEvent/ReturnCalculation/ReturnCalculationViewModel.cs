using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace RiskMonitor
{
    public abstract class ReturnCalculationViewModel
    {

        #region ReturnCalculationView_
        protected FrameworkElement returnCalculationView_;
        public FrameworkElement ReturnCalculationView_
        {
            get
            {
                return this.returnCalculationView_;
            }
            set
            {
                if (this.returnCalculationView_ != value)
                {
                    
                    this.returnCalculationView_ = value;
                    
                    //this.NotifyPropertyChanged("ReturnCalculationView_");
                }
            }
        }
        #endregion


        public ReturnCalculationViewModel() 
        {
        
        }



        public abstract void setReturnCalcaulation(ReturnCalculation returnCalculation);

    }
}
