//#ifndef quantlib_mc_barrierEventPricer_engine_hpp
//#define quantlib_mc_barrierEventPricer_engine_hpp
//
//#include <boost/shared_ptr.hpp>
//
//#include <src/Engine/MonteCarlo/MCPricer.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/eventInfo.hpp>
//#include <src/Engine/MonteCarlo/pricer/payoff/payoffInfo.hpp>
//
////-----------------------------	Pricer -----------------------------------------
//
//namespace QuantLib {
//
//    class BarrierEventPricer : public MCPricer {
//      public:
//        BarrierEventPricer(const boost::shared_ptr<EventInfo>& barrierInfo,
//						   const boost::shared_ptr<PayoffInfo>& occBarrierPayoffInfo,
//						   const boost::shared_ptr<PayoffInfo>& nonOccBarrierPayoffInfo)
//		: barrierInfo_(barrierInfo), occBarrierPayoffInfo_(occBarrierPayoffInfo),
//		  nonOccBarrierPayoffInfo_(nonOccBarrierPayoffInfo)
//		{
//			pastEventOcc_ = barrierInfo_->pastEventOcc();
//		}
//
//		void initialize(const TimeGrid& timeGrid,
//						const boost::shared_ptr<YieldTermStructure>& discountCurve,
//						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) const
//		{
//			this->barrierInfo_->initialize(timeGrid);
//			this->occBarrierPayoffInfo_->initialize(timeGrid);
//			this->nonOccBarrierPayoffInfo_->initialize(timeGrid);
//		}
//
//		Real calculate(const MultiPath& path) const
//		{
//			Real value = 0.0;
//			bool eventOcc = pastEventOcc_;
//
//			barrierInfo_->checkEvent(path);
//
//			if(eventOcc)
//			{
//				occBarrierPayoffInfo_->payoff(path);
//			}else
//			{
//				nonOccBarrierPayoffInfo_->payoff(path);
//			}
//
//			return value;
//		}
//
//      private:
//		  bool pastEventOcc_;
//
//		  boost::shared_ptr<EventInfo> barrierInfo_;
//		  boost::shared_ptr<PayoffInfo> occBarrierPayoffInfo_;
//		  boost::shared_ptr<PayoffInfo> nonOccBarrierPayoffInfo_;
//        //DiscountFactor discount_;
//	};
//}
//
//#endif