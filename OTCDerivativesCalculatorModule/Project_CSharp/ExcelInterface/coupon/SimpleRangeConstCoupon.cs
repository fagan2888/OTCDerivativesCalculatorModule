using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;
using System.Collections.ObjectModel;
using System.Xml;

namespace ExcelInterface
{
    public class SimpleRangeConstCoupon : EventTriggerXL
    {
        private SimpleEventCouponTriggerViewModel setvm_;

        //private string type_;
        private string eventDate_;
        private string payoffDate_;
        private string lowerTrigger_;
        private string lowerEquality_;
        private string referenceID_;
        private string upperTrigger_;
        private string upperEquality_;
        private string constReturn_;
        private string autoCallable_;
        private string lowerTrigger_autoCall_;
        private string lowerEquality_autoCall_;
        private string referenceID_autoCall_;
        private string upperEquality_autoCall_;
        private string upperTrigger_autoCall_;
        private string autoCallConstReturn_;

        public SimpleRangeConstCoupon(string eventDate,
                                string payoffDate,

                                string lowerTrigger,
                                string lowerEquality,
                                string referenceID,
                                string upperEquality,
                                string upperTrigger,

                                string constReturn,

                                string autoCallable)
        : this(eventDate,payoffDate,lowerTrigger,lowerEquality,referenceID, 
            upperEquality, upperTrigger, constReturn, autoCallable,
            "","","","","","")
        {

        }

        public SimpleRangeConstCoupon(string eventDate,
                                string payoffDate,

                                string lowerTrigger,
                                string lowerEquality,
                                string referenceID,
                                string upperEquality,
                                string upperTrigger,

                                string constReturn,

                                string autoCallable,
                                string lowerTrigger_autoCall,
                                string lowerEquality_autoCall,
                                string referenceID_autoCall,
                                string upperEquality_autoCall,
                                string upperTrigger_autoCall,

                                string autoCallConstReturn)
        {
            this.eventDate_ = eventDate;
            this.payoffDate_ = payoffDate;
            this.referenceID_ = referenceID;
            this.lowerTrigger_ = lowerTrigger;
            this.lowerEquality_ = lowerEquality;
            this.upperTrigger_ = upperTrigger;
            this.upperEquality_ = upperEquality;
            this.constReturn_ = constReturn;
            this.autoCallable_ = autoCallable;

            this.lowerTrigger_autoCall_ = lowerTrigger_autoCall;
            this.lowerEquality_autoCall_ = lowerEquality_autoCall;
            this.referenceID_autoCall_ = referenceID_autoCall;
            this.upperEquality_autoCall_ = upperEquality_autoCall;
            this.upperTrigger_autoCall_ = upperTrigger_autoCall;

            this.autoCallConstReturn_ = autoCallConstReturn;

        }

        private SimpleRangeEventCalViewModel simpleRangeEventCalViewModel(
                                            string lowerTrigger,
                                            string lowerEquality,
                                            string referenceID,
                                            string upperEquality,
                                            string upperTrigger)
        {
            SimpleRangeEventCalViewModel srevm = new SimpleRangeEventCalViewModel();

            #region rangeCal

            Range1DViewModel r1dvm = new Range1DViewModel();
            r1dvm.LowerBound_ = lowerTrigger.ToString();
            r1dvm.LowerBoundEquality_ = lowerEquality.ToString();
            
            r1dvm.UpperBoundEquality_ = upperEquality.ToString();
            r1dvm.UpperBound_ = upperTrigger.ToString();

            srevm.Range1DViewModel_ = r1dvm;

            #endregion

            #region referenceCal

            ReferenceCalculationInfoViewModel rcivm = new ReferenceCalculationInfoViewModel();

            rcivm.ReferenceCalculationViewModel_ = new ObservableCollection<ReferenceCalculationViewModel>();

            ReferenceCalculationViewModel rcvm = this.refCalVM(referenceID, eventDate_);

            rcivm.ReferenceCalculationViewModel_.Add(rcvm);

            srevm.ReferenceCalculationInfoViewModel_ = rcivm;

            #endregion

            return srevm;
        }

        private FixedFixingDateInfoViewModel fixedFixingDate()
        {
            FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();

            ffdivm.AutoCallFlag_ = "false";
            ffdivm.Date_ = this.payoffDate_;

            return ffdivm;
        }

        private ReferenceCalculationViewModel refCalVM(string refID, string fixingDate)
        {
            ReferenceCalculationViewModel rcvm = this.referenceCalFactory_.getReferCalVM(refID);

            FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();
            ffdivm.AutoCallFlag_ = "false";
            ffdivm.Date_ = fixingDate;

            rcvm.FixingDateInfoViewModel_ = ffdivm;

            return rcvm;
        }

        private ReturnCalculationViewModel constReturnCalVM(string constReturnValue)
        {
            ReturnCalculationViewModel rcvm;

            ConstReturnCalViewModel vm = new ConstReturnCalViewModel();
            vm.ConstReturn_ = constReturnValue;
            rcvm = vm;

            return rcvm;
        }

        void setUnderlyingInfo(ExcelUnderlyingInfo underInfo)
        {
            this.underInfo_ = underInfo;
        }

        public override void buildXml(XmlWriter xmlWriter)
        {
            this.setvm_.buildXml(xmlWriter);
        }

        public override void buildVM() 
        {
            this.setvm_ = new SimpleEventCouponTriggerViewModel();

            setvm_.EventDate_ = eventDate_.ToString();

            #region eventCal

            EventCalculationInfoViewModel ecivm = new EventCalculationInfoViewModel();
            ecivm.EventCalculationViewModel_ = new ObservableCollection<EventCalculationViewModel>();

            ecivm.EventCalculationViewModel_.Add(
                this.simpleRangeEventCalViewModel(lowerTrigger_,
                                                  lowerEquality_,
                                                  referenceID_,
                                                  upperEquality_,
                                                  upperTrigger_));

            this.setvm_.EventCalculationInfoViewModel_ = ecivm;

            #endregion

            #region returnCal

            setvm_.ReturnCalculationInfoViewModel_ = new ReturnCalculationInfoViewModel();
            setvm_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_ = new ObservableCollection<ReturnCalculationViewModel>();
            setvm_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_.Add(this.constReturnCalVM(this.constReturn_));

            #endregion

            #region complementReturnCal

            setvm_.ComplementReturnCalculationViewModel_ = new ComplementReturnCalculationViewModel();
            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_ = new ReturnCalculationInfoViewModel();
            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                = new ObservableCollection<ReturnCalculationViewModel>();

            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                .Add(this.constReturnCalVM("0.0"));

            #endregion

            #region payoffDate

            setvm_.PayoffDateInfoViewModel_ = new PayoffDateInfoViewModel();
            setvm_.PayoffDateInfoViewModel_.FixingDateInfoViewModel_ =
                this.fixedFixingDate();

            #endregion

            #region autoCallable

            if (this.autoCallable_.ToUpper() == "TRUE" || this.autoCallable_.ToUpper() == "T")
            {
                setvm_.AutoTerminationTriggerViewModel_ = new AutoTerminationTriggerViewModel();

                setvm_.AutoTerminationTriggerViewModel_.EventCalculationInfoViewModel_.EventCalculationViewModel_
                    = new ObservableCollection<EventCalculationViewModel>();

                setvm_.AutoTerminationTriggerViewModel_.EventCalculationInfoViewModel_.EventCalculationViewModel_
                    .Add(this.simpleRangeEventCalViewModel(this.lowerTrigger_autoCall_,
                                                            this.lowerEquality_autoCall_,
                                                            this.referenceID_autoCall_,
                                                            this.upperEquality_autoCall_,
                                                            this.upperTrigger_autoCall_));

                setvm_.AutoTerminationTriggerViewModel_.PayoffDateInfoViewModel_
                    = setvm_.PayoffDateInfoViewModel_;

                setvm_.AutoTerminationTriggerViewModel_.ReturnCalculationInfoViewModel_ = new ReturnCalculationInfoViewModel();

                setvm_.AutoTerminationTriggerViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                    = new ObservableCollection<ReturnCalculationViewModel>();
                setvm_.AutoTerminationTriggerViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                    .Add(this.constReturnCalVM(this.autoCallConstReturn_));
            }

            #endregion
        }

        #region UnderInfo
        private ExcelUnderlyingInfo underInfo_;
        public ExcelUnderlyingInfo UnderInfo
        {
            get { return this.underInfo_; }
            set
            {
                if (this.underInfo_ != value)
                {
                    this.underInfo_ = value;
                   // this.NotifyPropertyChanged("UnderInfo");
                }
            }
        }
        #endregion



    }
}
