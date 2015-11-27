#ifndef quantlib_mc_stoplosscalculation_hpp
#define quantlib_mc_stoplosscalculation_hpp

namespace QuantLib {
	class StopLossCalculation : public IReturnCalculation {
		public:
			virtual void initialize(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0; 

			virtual void returnCalculate(const MultiPath& multiPath) = 0;
	};

}

#endif