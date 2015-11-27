#ifndef quantlib_mc_irproduct_engine_hpp
#define quantlib_mc_irproduct_engine_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

	class VanillaStandardStreamPricer : public MCPricer {
	
		public:
			VanillaStandardStreamPricer(const std::vector<boost::shared_ptr<RateCalculation>>& irCalcList,
										const boost::shared_ptr<YieldTermStructure>& discountCurve);
			
			//interface
			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculate(const MultiPath& paths) const;
			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			void reset();

		//member
		private:
			Size remainEventPosition_;

			std::vector<boost::shared_ptr<RateCalculation>> irCalcList_;
			boost::shared_ptr<YieldTermStructure> discountCurve_;
			Size remainCouponSize_;
			Size pastNum_;
			Size irCalcNum_;
	};

}

#endif