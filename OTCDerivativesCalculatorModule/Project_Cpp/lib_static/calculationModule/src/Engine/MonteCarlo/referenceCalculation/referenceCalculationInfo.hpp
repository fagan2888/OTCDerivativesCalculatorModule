#ifndef quantlib_ReferenceCalculationInfo_hpp
#define quantlib_ReferenceCalculationInfo_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class ReferenceCalculationInfo : public ReferenceCalculation
	{
		public:

			ReferenceCalculationInfo(const std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>>& referenceCalList,
									const boost::shared_ptr<QuantLib::OperatorND>& operatorND,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			Real calSlice(const MultiPath& path,Size position); 

			Real calSlice(const std::valarray<Real>& val); 

			std::vector<Date> fixingDates() const;

		protected:
			Real calculateImpl(const MultiPath& path,Size endPosition);

			void initializeImpl(const TimeGrid& timeGrid,
										const boost::shared_ptr<YieldTermStructure>& discountCurve,
										const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		private:
			std::valarray<Real> arr_;
			Size refCalNum_;
			std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>> referenceCalList_;
			boost::shared_ptr<QuantLib::OperatorND> operatorND_;

	};

}

#endif