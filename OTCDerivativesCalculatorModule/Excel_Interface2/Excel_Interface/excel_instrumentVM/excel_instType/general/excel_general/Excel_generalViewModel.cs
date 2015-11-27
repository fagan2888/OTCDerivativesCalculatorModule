using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_generalViewModel : Excel_interfaceViewModel
    {
        #region GeneralScheduleInfoViewModel_
        private GeneralScheduleInfoViewModel generalScheduleInfoViewModel_;
        public GeneralScheduleInfoViewModel GeneralScheduleInfoViewModel_
        {
            get { return this.generalScheduleInfoViewModel_; }
            set
            {
                if (this.generalScheduleInfoViewModel_ != value)
                {
                    this.generalScheduleInfoViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleInfoViewModel_");
                }
            }
        }
        #endregion

        #region GeneralTerminationEventInfoViewModel_
        private GeneralTerminationEventInfoViewModel generalTerminationEventInfoViewModel_;
        public GeneralTerminationEventInfoViewModel GeneralTerminationEventInfoViewModel_
        {
            get { return this.generalTerminationEventInfoViewModel_; }
            set
            {
                if (this.generalTerminationEventInfoViewModel_ != value)
                {
                    this.generalTerminationEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralTerminationEventInfoViewModel_");
                }
            }
        }
        #endregion

        public Excel_generalViewModel()
        {
            this.excel_issueInfoViewModel_ = new Excel_noteInfoViewModel();
            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.generalScheduleInfoViewModel_ = new GeneralScheduleInfoViewModel();
            this.generalTerminationEventInfoViewModel_ = new GeneralTerminationEventInfoViewModel();

            //this.view_ = new Excel_generalView();
            //this.view_.DataContext = this;
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            this.excel_issueInfoViewModel_.buildXml(xmlWriter);
            this.excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);

            this.generalScheduleInfoViewModel_.buildXml(xmlWriter);
            this.generalTerminationEventInfoViewModel_.buildXml(xmlWriter);

        }
        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.generalScheduleInfoViewModel_.bookingEvent(masterInformationViewModel);
            this.generalTerminationEventInfoViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override Control view()
        {
            Control v = new Excel_generalView();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying()
        {
            throw new NotImplementedException();
        }

        public override List<CurrencyViewModel> currencyList()
        {
            throw new NotImplementedException();
        }

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
}
