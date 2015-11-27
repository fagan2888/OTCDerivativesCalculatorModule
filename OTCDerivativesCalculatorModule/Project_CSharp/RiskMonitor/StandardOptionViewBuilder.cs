//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RiskMonitor
//{
//    public class StandardOptionViewBuilder : InstrumentViewBuilder
//    {
//        public StandardOptionViewBuilder() { }

//        void setView(InstrumentViewModel instVM)
//        {
//            InstrumentPropertyViewCtrl view = new InstrumentPropertyViewCtrl();
//            StandardOption inst = instVM.Instrument_ as StandardOption;

//            view.ProductType_ = inst.instInfo_.ProductType_;
//            view.ProductName_ = inst.instInfo_.ProductName_;
//            view.ProductKRCode_ = inst.instInfo_.KRCode_;
//            view.Notional_ = inst.instInfo_.Notional_;

//            instVM.PropertyView_ = view;
            
//        }
//    }
//}
