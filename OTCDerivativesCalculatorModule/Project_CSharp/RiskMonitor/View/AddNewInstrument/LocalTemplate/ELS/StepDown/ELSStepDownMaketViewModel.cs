using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ELSStepDownMaketViewModel
    {
        #region InstName_
        private string instName_;
        public string InstName_
        {
            get { return this.instName_; }
            set
            {
                if (this.instName_ != value)
                {
                    this.instName_ = value;
                    this.NotifyPropertyChanged("InstName_");
                }
            }
        }
        #endregion

        #region Notional_
        private long notional_;
        public long Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        #region UnderNames_
        private ObservableCollection<string> underNmaes_;
        public ObservableCollection<string> UnderNames_
        {
            get { return this.underNmaes_; }
            set
            {
                if (this.underNmaes_ != value)
                {
                    this.underNmaes_ = value;
                    this.NotifyPropertyChanged("UnderNames_");
                }
            }
        }
        #endregion

        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion

        #region MaturityYear_
        private int maturityYear_;
        public int MaturityYear_
        {
            get { return this.maturityYear_; }
            set
            {
                if (this.maturityYear_ != value)
                {
                    this.maturityYear_ = value;
                    this.NotifyPropertyChanged("MaturityYear_");
                }
            }
        }
        #endregion

        #region RedemptionMonth_
        private int redemptonMonth_;
        public int RedemptionMonth_
        {
            get { return this.redemptonMonth_; }
            set
            {
                if (this.redemptonMonth_ != value)
                {
                    this.redemptonMonth_ = value;
                    this.NotifyPropertyChanged("RedemptionMonth_");
                }
            }
        }
        #endregion

        #region RedemptionTrigger_
        private ObservableCollection<double> redemptionTrigger_;
        public ObservableCollection<double> RedemptionTrigger_
        {
            get { return this.redemptionTrigger_; }
            set
            {
                if (this.redemptionTrigger_ != value)
                {
                    this.redemptionTrigger_ = value;
                    this.NotifyPropertyChanged("RedemptionTrigger_");
                }
            }
        }
        #endregion

        #region KIs_
        private ObservableCollection<double> kis_;
        public ObservableCollection<double> KIs_
        {
            get { return this.kis_; }
            set
            {
                if (this.kis_ != value)
                {
                    this.kis_ = value;
                    this.NotifyPropertyChanged("KIs_");
                }
            }
        }
        #endregion

        #region CpnPerYear_
        private double cpnPerYear_;
        public double CpnPerYear_
        {
            get { return this.cpnPerYear_; }
            set
            {
                if (this.cpnPerYear_ != value)
                {
                    this.cpnPerYear_ = value;
                    this.NotifyPropertyChanged("CpnPerYear_");
                }
            }
        }
        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string fileXml()
        {
            throw new NotImplementedException();
        }
    }
}
