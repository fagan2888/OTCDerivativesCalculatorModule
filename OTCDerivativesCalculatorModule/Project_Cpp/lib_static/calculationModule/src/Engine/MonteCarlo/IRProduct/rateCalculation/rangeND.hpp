#ifndef quantlib_rangeND_hpp
#define quantlib_rangeND_hpp

#include <valarray>
#include <vector>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculationInfo.hpp>

namespace QuantLib {

	class RangeND
	{
		public:
			RangeND(std::string jointType,
					const std::vector<boost::shared_ptr<QuantLib::Range1D>>& range1DList,
					const std::vector<boost::shared_ptr<ReferenceCalculation>>& refCalcList);
						  
			bool eventOcc(std::vector<Real> value) const;

			bool eventOccSlice(const MultiPath& path,Size position) const; 

			void initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		protected:

			Size rangeNum_;
			bool checkTF_;

			std::string jointType_;
			std::vector<boost::shared_ptr<QuantLib::Range1D>> range1DList_;
			std::vector<boost::shared_ptr<ReferenceCalculation>> refCalcList_;
	};
}

#endif