////-----------------------------	Pricer -----------------------------------------
//
//    class StandardInstrumentPricer {
//      public:
//        StandardInstrumentPricer(//const boost::shared_ptr<BarrierEventInfo>& BarrierInfo,
//								 const boost::shared_ptr<EventInfo>& BarrierInfo,
//							     const boost::shared_ptr<PayoffInfo>& occBarrierPayoffInfo,
//								 const boost::shared_ptr<PayoffInfo>& nonOccBarrierPayoffInfo)
//		: payoffInfo_(payoffInfo) 
//		{
//			pastEventOcc_ = BarrierInfo->pastEventOcc();
//		}
//
//		Real calculate(const MultiPath& path) const
//		{
//			Real value = 0.0;
//			bool eventOcc = pastEventOcc_;
//
//			BarrierInfo_->checkEvent(path);
//
//			if(eventOcc)
//			{
//				occBarrierPayoffInfo_->payoff(path);
//			}else
//			{
//				nonOccBarrierPayoffInfo->payoff(path);
//			}
//
//			return value;
//		}
//
//      private:
//		  bool pastEventOcc_;
//		  const boost::shared_ptr<EventInfo>& BarrierInfo_;
//		  const boost::shared_ptr<PayoffInfo>& occBarrierPayoffInfo_;
//		  const boost::shared_ptr<PayoffInfo>& nonOccBarrierPayoffInfo_;
//        //DiscountFactor discount_;
