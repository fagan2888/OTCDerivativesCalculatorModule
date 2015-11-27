#ifndef quantlib_preCalculation_hpp
#define quantlib_preCalculation_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/variableCalculation.hpp>

namespace QuantLib {

	class PreCalculation : public IRefVariable
	{
		public:

			PreCalculation(const std::vector<boost::shared_ptr<VariableCalculation>>& variableCalList,
						   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			//std::vector<Date> fixingDates() const;

			void calculate(const MultiPath& path,Size endPosition);
			//void calculateEarlyEx(const MultiPath& path,Size endPosition);

		protected:
			std::vector<Date> fixingDates_;
			std::valarray<Size> fixingDatePositions_;

			std::vector<boost::shared_ptr<VariableCalculation>> variableCalList_;
			
	};

}

#endif