//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Excel_Interface
//{
//    public class DiscountCurveParaSetting
//    {
//        public Excel_yieldCurveViewModel discountCurve(CurrencyViewModel currVM)
//        { 
//            Excel_yieldCurveViewModel curve = new Excel_yieldCurveViewModel();

//            curve.Code_ = "testSettingCode";
//            curve.Currency_ = "testSettingCurr";
//            curve.Description_ = "testDescrip";
//            curve.Excel_interpolationViewModel_ = new Excel_interpolationViewModel();
//            curve.Excel_rateDataViewModel_ = new System.Collections.ObjectModel.ObservableCollection<Excel_rateDataViewModel>();

//            Excel_rateDataViewModel e_rDVM = new Excel_rateDataViewModel();

//            curve.Excel_rateDataViewModel_.Add(e_rDVM);
//            curve.Excel_rateDataViewModel_.Add(e_rDVM);
//            curve.Excel_rateDataViewModel_.Add(e_rDVM);
//            curve.Excel_rateDataViewModel_.Add(e_rDVM);
//            curve.Excel_rateDataViewModel_.Add(e_rDVM);

//            return curve;
//        }
//    }
//}
