using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelInterface
{
    public class ReferenceCalFactory : BuilderXL
    {
        #region VMList_
        private Dictionary<string,string[]> vmList_;
        public Dictionary<string,string[]> VMList_
        {
            get { return this.vmList_; }
            set
            {
                if (this.vmList_ != value)
                {
                    this.vmList_ = value;
                }
            }
        }
        #endregion

        #region UnderlyingSet_
        private Dictionary<string,ObservableCollection<string>> underlyingSet_;
        public Dictionary<string,ObservableCollection<string>> UnderlyingSet_
        {
            get { return this.underlyingSet_; }
            set
            {
                if (this.underlyingSet_ != value)
                {
                    this.underlyingSet_ = value;
                }
            }
        }
        #endregion

        public ReferenceCalFactory() 
        {
            this.vmList_ = new Dictionary<string, string[]>();
            this.underlyingSet_ = new Dictionary<string, ObservableCollection<string>>();

        }

        public ReferenceCalculationViewModel getReferCalVM(string referCal_ID)
        {

            string[] array = this.vmList_[referCal_ID];

            string id = array[0];
            string type = array[1];
            string referenceType = array[2];
            string referenceSet = array[3];
            string nth = array[4];
            //string averageD

            ReferenceCalculationViewModel rcvm;

            try
            {
                if (referenceType.ToUpper() == "CHOICEREFERENCECAL" || referenceType.ToUpper() == "CHOICE")
                {
                    rcvm = new ChoiceReferenceCalViewModel();
                }
                else if (referenceType.ToUpper() == "IDENTITYREFERENCECAL" || referenceType.ToUpper() == "IDENTITY")
                {
                    rcvm = new IdentityReferenceCalViewModel();
                }
                else if (referenceType.ToUpper() == "MAXIMUMREFERENCECAL" || referenceType.ToUpper() == "MAXIMUM")
                {
                    MaximumReferenceCalViewModel vm = new MaximumReferenceCalViewModel();
                    vm.Nth_ = nth;
                    vm.SelectedUnderName_ = this.underlyingSet_[referenceSet];
                    vm.Type_ = "maximumReferenceCal";

                    rcvm = vm;
                }
                else if (referenceType.ToUpper() == "MINIMUMREFERENCECAL" || referenceType.ToUpper() == "MINIMUM")
                {
                    MinimumReferenceCalViewModel vm = new MinimumReferenceCalViewModel();
                    vm.Nth_ = nth;
                    vm.SelectedUnderName_ = this.underlyingSet_[referenceSet];
                    vm.Type_ = "minimumReferenceCal";

                    rcvm = vm;

                }
                else if (referenceType.ToUpper() == "REFVARIABLEREFERENCECAL" || referenceType.ToUpper() == "REFVARIABLE")
                {
                    rcvm = new RefVariableReferenceCalViewModel();
                }
                else if (referenceType.ToUpper() == "DAILYRETURNREFERENCECAL" || referenceType.ToUpper() == "DAILYRETURN")
                {
                    rcvm = new DailyReturnReferenceCalViewModel();
                }
                else
                {
                    rcvm = new DailyReturnReferenceCalViewModel();
                    throw new Exception("unknown reference type : " + type);
                }

                return rcvm;

            }
            catch (Exception e)
            {
                
                // dummy 용... complie이 안됨..
                rcvm = new ChoiceReferenceCalViewModel();

                errStr_ += e.Message + "\n";
                this.errNum_ += 1;

                if (e is KeyNotFoundException)
                {
                    errStr_ += "referenceSetID : " + referenceSet + "\n";
                }
                
            }
            
            return rcvm;

        }

        public string addReferenceID(string refCalType,string[] array)
        {
            try
            {
                string id = array[1];
                //calculation
                this.vmList_.Add(id,array);

            }
            catch (Exception e)
            {
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return errStr_; 
        }

        private int simpleCalculationNum_ = 5;
        //private void addSimpleCalculation(string[] array)
        //{
        //    string type = array[0];
        //    string id = array[1];
        //    string referenceType = array[2];
        //    string referenceSet = array[3];
        //    string nth = array[4];
        //    //string averageD

        //    ReferenceCalculationViewModel rcvm;

        //    try
        //    {
        //        if (referenceType.ToUpper() == "CHOICEREFERENCECAL" || referenceType.ToUpper() == "CHOICE")
        //        {
        //            rcvm = new ChoiceReferenceCalViewModel();
        //        }
        //        else if (referenceType.ToUpper() == "IDENTITYREFERENCECAL" || referenceType.ToUpper() == "IDENTITY")
        //        {
        //            rcvm = new IdentityReferenceCalViewModel();
        //        }
        //        else if (referenceType.ToUpper() == "MAXIMUMREFERENCECAL" || referenceType.ToUpper() == "MAXIMUM")
        //        {
        //            MaximumReferenceCalViewModel vm = new MaximumReferenceCalViewModel();
        //            vm.Nth_ = nth;
        //            vm.SelectedUnderName_ = this.underlyingSet_[referenceSet];
        //            vm.Type_ = "maximumReferenceCal";

        //            rcvm = vm;
        //        }
        //        else if (referenceType.ToUpper() == "MINIMUMREFERENCECAL" || referenceType.ToUpper() == "MINIMUM")
        //        {
        //            MinimumReferenceCalViewModel vm = new MinimumReferenceCalViewModel();
        //            vm.Nth_ = nth;
        //            vm.SelectedUnderName_ = this.underlyingSet_[referenceSet];
        //            vm.Type_ = "minimumReferenceCal";

        //            rcvm = vm;

        //        }
        //        else if (referenceType.ToUpper() == "REFVARIABLEREFERENCECAL" || referenceType.ToUpper() == "REFVARIABLE")
        //        {
        //            rcvm = new RefVariableReferenceCalViewModel();
        //        }
        //        else if (referenceType.ToUpper() == "DAILYRETURNREFERENCECAL" || referenceType.ToUpper() == "DAILYRETURN")
        //        {
        //            rcvm = new DailyReturnReferenceCalViewModel();
        //        }
        //        else
        //        {
        //            throw new Exception("unknown reference type : " + type);
        //        }

        //        this.vmList_.Add(id, rcvm);

        //    }
        //    catch (Exception e)
        //    {
                
        //        errStr_ += e.Message + "\n";
        //        this.errNum_ += 1;

        //        if (e is KeyNotFoundException)
        //        {
        //            errStr_ += "referenceSetID : " + referenceSet + "\n";
        //        }
                
        //    }
        //}

        public int referenceCalDataNum(string referenceCalTypeStr)
        {
            int num = 0;

            try
            {
                //referenceType
                if (referenceCalTypeStr.ToUpper() == "SIMPLECALCULATION")
                {
                    num = this.simpleCalculationNum_;
                }
                else
                {
                    throw new Exception("unknown referenceID type : " + referenceCalTypeStr);

                }
            }
            catch (Exception e)
            {
                errStr_ += e.Message + "\n";
                this.errNum_ += 1;
            }

            return num; 
            
        }
    }



}
