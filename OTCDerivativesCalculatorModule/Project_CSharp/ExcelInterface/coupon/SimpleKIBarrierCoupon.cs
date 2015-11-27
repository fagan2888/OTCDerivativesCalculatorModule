using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelInterface
{
    public class SimpleKIBarrierCoupon : EventTriggerXL
    {
        private SimpleEventCouponTriggerViewModel setvm_;

        private string eventDate_;
        private string payoffDate_;
        private string observationStartDate_;
        private string observationEndDate_;
        private string barrierType_;
        private string downBarrierTrigger_;
        private string referenceCal_downID_;
        private string referenceCal_upperID_;
        private string upBarrierTrigger_;
        private string referenceCal_ID_returnCal_;
        private string gearing_returnCal_;
        private string spread_returnCal_;
        private string constReturn_complement_;

        public SimpleKIBarrierCoupon(string eventDate, 
                                    string payoffDate, 
                                    string observationStartDate, 
                                    string observationEndDate, 
                                    string barrierType,
                                    string downBarrierTrigger, 
                                    string referenceCal_downID,
                                    string referenceCal_upperID, 
                                    string upBarrierTrigger, 
                                    string referenceCal_ID_returnCal, 
                                    string gearing_returnCal, 
                                    string spread_returnCal, 
                                    string constReturn_complement)
        {
            // TODO: Complete member initialization
            this.eventDate_ = eventDate;
            this.payoffDate_ = payoffDate;
            this.observationStartDate_ = observationStartDate;
            this.observationEndDate_ = observationEndDate;
            this.barrierType_ = barrierType;
            this.downBarrierTrigger_ = downBarrierTrigger;
            this.referenceCal_downID_ = referenceCal_downID;
            this.referenceCal_upperID_ = referenceCal_upperID;
            this.upBarrierTrigger_ = upBarrierTrigger;
            this.referenceCal_ID_returnCal_ = referenceCal_ID_returnCal;
            this.gearing_returnCal_ = gearing_returnCal;
            this.spread_returnCal_ = spread_returnCal;
            this.constReturn_complement_ = constReturn_complement;
        }

        private DateInformationViewModel dateInfoVM()
        {
            DailyIntervalViewModel divm = new DailyIntervalViewModel();
            
            divm.ObservationStartDate_ = this.observationStartDate_;
            divm.ObservationEndDate_ = this.observationEndDate_;

            return divm;
        }

        private EventCalculationViewModel eventCalViewModel()
        {
            EventCalculationViewModel ecvm;
            EventCalculationFactory ecf = new EventCalculationFactory();

            #region barrierEventCal

            if (this.barrierType_.ToUpper() == "LOWER" || this.barrierType_.ToUpper() == "LOWERBARRIER")
            {
                LowerBarrierEventCalViewModel lbecvm = new LowerBarrierEventCalViewModel();

                lbecvm.DateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
                lbecvm.LowerTrigger_ = new ObservableCollection<string>();

                lbecvm.DateInformationViewModel_.Add(this.dateInfoVM());
                lbecvm.LowerTrigger_.Add(this.downBarrierTrigger_.ToString());

                lbecvm.ReferenceCalculationInfoViewModel_.ReferenceCalculationViewModel_.Add(
                    this.referenceCalFactory_.getReferCalVM(referenceCal_downID_));

                ecvm = lbecvm;
                
            }
            else if (this.barrierType_.ToUpper() == "UPPER" || this.barrierType_.ToUpper() == "UPPERBARRIER")
            {
                UpperBarrierEventCalViewModel ubecvm = new UpperBarrierEventCalViewModel();

                ubecvm.DateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
                ubecvm.UpperTrigger_ = new ObservableCollection<string>();

                ubecvm.DateInformationViewModel_.Add(this.dateInfoVM());
                ubecvm.UpperTrigger_.Add(this.upBarrierTrigger_.ToString());

                ubecvm.ReferenceCalculationInfoViewModel_.ReferenceCalculationViewModel_.Add(
                    this.referenceCalFactory_.getReferCalVM(referenceCal_downID_));

                ecvm = ubecvm;

            }
            else if (this.barrierType_.ToUpper() == "DUAL" || this.barrierType_.ToUpper() == "DUALBARRIER")
            {
                DualBarrierEventCalViewModel dbecvm = new DualBarrierEventCalViewModel();

                dbecvm.DateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
                dbecvm.DateInformationViewModel_.Add(this.dateInfoVM());

                dbecvm.LowerTrigger_ = new ObservableCollection<string>();
                dbecvm.LowerTrigger_.Add(this.downBarrierTrigger_.ToString());

                dbecvm.UpperTrigger_ = new ObservableCollection<string>();
                dbecvm.UpperTrigger_.Add(this.downBarrierTrigger_.ToString());

                //upperPart
                ReferenceCalculationInfoViewModel u_rcivm = new ReferenceCalculationInfoViewModel();
                u_rcivm.ReferenceCalculationViewModel_.Add(this.referenceCalFactory_.getReferCalVM(referenceCal_downID_));
                dbecvm.ReferenceCalculationInfoViewModel_.Add(u_rcivm);

                //lowerPart
                ReferenceCalculationInfoViewModel l_rcivm = new ReferenceCalculationInfoViewModel();
                l_rcivm.ReferenceCalculationViewModel_.Add(this.referenceCalFactory_.getReferCalVM(referenceCal_downID_));
                dbecvm.ReferenceCalculationInfoViewModel_.Add(l_rcivm);

                ecvm = dbecvm;
            }
            else 
            {
                throw new Exception("unknown barrierType : " + this.barrierType_);
            }

            #endregion

            return ecvm;
        }

        private ReferenceCalculationInfoViewModel refInfoCalVM(string refID)
        {
            ReferenceCalculationInfoViewModel rcivm = new ReferenceCalculationInfoViewModel();

            rcivm.ReferenceCalculationViewModel_ = new ObservableCollection<ReferenceCalculationViewModel>();

            ReferenceCalculationViewModel rcvm = this.referenceCalFactory_.getReferCalVM(refID);

            rcivm.ReferenceCalculationViewModel_.Add(rcvm);

            return rcivm;
        }

        public override void buildVM()
        {
            this.setvm_ = new SimpleEventCouponTriggerViewModel();

            setvm_.EventDate_ = eventDate_.ToString();

            #region eventCal

            EventCalculationInfoViewModel ecivm = new EventCalculationInfoViewModel();
            ecivm.EventCalculationViewModel_ = new ObservableCollection<EventCalculationViewModel>();

            ecivm.EventCalculationViewModel_.Add(this.eventCalViewModel());

            this.setvm_.EventCalculationInfoViewModel_ = ecivm;

            #endregion

            #region returnCal

            setvm_.ReturnCalculationInfoViewModel_ = new ReturnCalculationInfoViewModel();
            setvm_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_ = new ObservableCollection<ReturnCalculationViewModel>();
            setvm_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_.Add(this.vanillaReturnCalVM());

            #endregion

            #region complementReturnCal

            setvm_.ComplementReturnCalculationViewModel_ = new ComplementReturnCalculationViewModel();
            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_ = new ReturnCalculationInfoViewModel();
            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                = new ObservableCollection<ReturnCalculationViewModel>();

            setvm_.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_.ReturnCalculationViewModel_
                .Add(this.constReturnCalVM(this.constReturn_complement_));

            #endregion

            #region payoffDate

            setvm_.PayoffDateInfoViewModel_ = new PayoffDateInfoViewModel();
            setvm_.PayoffDateInfoViewModel_.FixingDateInfoViewModel_ =
                this.fixedFixingDate();

            #endregion

        }

        private FixingDateInfoViewModel fixedFixingDate()
        {
            FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();

            ffdivm.AutoCallFlag_ = "false";
            ffdivm.Date_ = this.payoffDate_;

            return ffdivm;
        }

        private ReturnCalculationViewModel constReturnCalVM(string constReturnValue)
        {
            ReturnCalculationViewModel rcvm;

            ConstReturnCalViewModel vm = new ConstReturnCalViewModel();
            vm.ConstReturn_ = constReturnValue;
            rcvm = vm;

            return rcvm;
        }

        private ReturnCalculationViewModel vanillaReturnCalVM()
        {
            VanillaReturnCalViewModel vrcvm = new VanillaReturnCalViewModel();
            vrcvm.Gearing_ = this.gearing_returnCal_;
            vrcvm.Spread_ = this.spread_returnCal_;

            ReferenceCalculationViewModel rcvm = this.referenceCalFactory_.getReferCalVM(this.referenceCal_ID_returnCal_);

            FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();
            ffdivm.Date_ = this.eventDate_;
            ffdivm.AutoCallFlag_ = "false";
            rcvm.FixingDateInfoViewModel_ = ffdivm;

            vrcvm.ReferenceCalculationInfoViewModel_.ReferenceCalculationViewModel_.Add(rcvm);

            return vrcvm;
        }


        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            this.setvm_.buildXml(xmlWriter);
        }
    }
}
