#ifndef quantlib_VariableCalculation_hpp
#define quantlib_VariableCalculation_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>
#include <src/Engine/MonteCarlo/operator/condition/conditionOperator.hpp>

namespace QuantLib {

	class VariableCalculation : public IRefVariable
	{
		public:

			VariableCalculation(const boost::shared_ptr<ReferenceCalculation>& referCal,
								const std::vector<boost::shared_ptr<Operator1D>>& operator1DList,
								const boost::shared_ptr<ConditionOperator>& conditionOperCal,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculate(const MultiPath& path,Size endPosition);

		protected:
			std::vector<Date> fixingDates_;
			std::valarray<Size> fixingDatePositions_;

			boost::shared_ptr<ReferenceCalculation> referCal_;
			std::vector<boost::shared_ptr<Operator1D>> operator1DList_;
			boost::shared_ptr<ConditionOperator> conditionOperCal_;
	};

}

#endif